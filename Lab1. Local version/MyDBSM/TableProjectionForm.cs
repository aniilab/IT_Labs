using MyDBSM.Controllers;
using MyDBSM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyDBSM
{
    public partial class TableProjectionForm : Form
    {
        private int tableId = -1;
        public TableProjectionForm(int selectedTableId)
        {
            InitializeComponent();
            columnPickPanel.Visible = true;
            projectionPanel.Visible = false;
            columnsListBox.Items.Clear();
            tableId = selectedTableId;
            foreach (var c in DBController.db.Tables[tableId].Columns)
            {
                columnsListBox.Items.Add(c.Name);
            }
        }

        private void confirmProjectButton_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            Dictionary<int, string> columnNamesIndexes = new Dictionary<int, string>();
            foreach(var name in columnsListBox.SelectedItems)
            {
                names.Add(name.ToString());
            }
            for (int i = 0; i< DBController.db.Tables[tableId].Columns.Count; i++)
            {
                    if (names.Contains(DBController.db.Tables[tableId].Columns[i].Name))
                    {
                    columnNamesIndexes[i] = DBController.db.Tables[tableId].Columns[i].Name;
                    }
                
            }
            columnPickPanel.Visible = false;
            projectionPanel.Visible = true;
            projectionGrid.Columns.Clear();


            DataGridViewColumn firstColumn = new DataGridViewTextBoxColumn();
            firstColumn.ReadOnly = true;
            firstColumn.Name = "Id";
            firstColumn.HeaderText = "Id";
            projectionGrid.Columns.Add(firstColumn);

            var projectedTable = DBController.ProjectTable(tableId, columnNamesIndexes);

            foreach (var col in projectedTable.Columns)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                column.HeaderText = col.Name;
                column.Name = col.Name;

                projectionGrid.Columns.Add(column);
            }

            projectionGrid.Rows.Clear();

            if (projectedTable.Rows.Count != 0)
            {
                projectionGrid.RowCount = projectedTable.Rows.Count;
            }

            for (int i = 0; i < projectedTable.Rows.Count; i++)
            {
                projectionGrid.Rows[i].Cells["Id"].Value = DBController.db.Tables[tableId].Rows[i].Id;
                for (int j = 1; j <= projectedTable.Columns.Count; j++)
                {
                    if (projectedTable.Rows[i].Values[j - 1] != null)
                    {
                        projectionGrid[j, i].Value = projectedTable.Rows[i].Values[j - 1].ToString();
                    }
                    else
                    {
                        projectionGrid[j, i].Value = null;
                    }
                   
                }
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            projectionPanel.Visible = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
