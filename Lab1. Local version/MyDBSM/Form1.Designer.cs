namespace MyDBSM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startPanel = new Panel();
            label1 = new Label();
            dbCreateButton = new Button();
            importButton = new Button();
            dbInfoPanel = new Panel();
            exportButton = new Button();
            button3 = new Button();
            columnsTableButton = new Button();
            dataTableButton = new Button();
            tableListBox = new ListBox();
            addTableButton = new Button();
            label3 = new Label();
            dbRenameButton = new Button();
            dbDeleteButton = new Button();
            label2 = new Label();
            splitter1 = new Splitter();
            name_label = new Label();
            tableColumnsPanel = new Panel();
            addNewColumnButton = new Button();
            deleteColumnButton = new Button();
            saveChangesColumnsButton = new Button();
            backFromColumnsButton = new Button();
            dataGridView1 = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            DataType = new DataGridViewComboBoxColumn();
            IsNullable = new DataGridViewCheckBoxColumn();
            valuesPanel = new Panel();
            projectTableButton = new Button();
            deleteRowButton = new Button();
            newRowButton = new Button();
            saveValuesButton = new Button();
            backFromValuesButton = new Button();
            valuesGrid = new DataGridView();
            startPanel.SuspendLayout();
            dbInfoPanel.SuspendLayout();
            tableColumnsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            valuesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)valuesGrid).BeginInit();
            SuspendLayout();
            // 
            // startPanel
            // 
            startPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            startPanel.BackColor = Color.Gainsboro;
            startPanel.Controls.Add(label1);
            startPanel.Controls.Add(dbCreateButton);
            startPanel.Controls.Add(importButton);
            startPanel.Location = new Point(0, 0);
            startPanel.Name = "startPanel";
            startPanel.Size = new Size(1654, 1607);
            startPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(787, 435);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(528, 57);
            label1.TabIndex = 3;
            label1.Text = "Choose one of these options";
            // 
            // dbCreateButton
            // 
            dbCreateButton.BackColor = Color.White;
            dbCreateButton.Cursor = Cursors.Hand;
            dbCreateButton.FlatAppearance.BorderColor = Color.Gray;
            dbCreateButton.FlatAppearance.BorderSize = 3;
            dbCreateButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            dbCreateButton.FlatAppearance.MouseOverBackColor = Color.MintCream;
            dbCreateButton.FlatStyle = FlatStyle.Flat;
            dbCreateButton.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dbCreateButton.ForeColor = Color.Black;
            dbCreateButton.Location = new Point(856, 140);
            dbCreateButton.Name = "dbCreateButton";
            dbCreateButton.Size = new Size(349, 115);
            dbCreateButton.TabIndex = 2;
            dbCreateButton.Text = "Create new database";
            dbCreateButton.UseVisualStyleBackColor = false;
            dbCreateButton.Click += dbCreateButton_Click;
            // 
            // importButton
            // 
            importButton.BackColor = Color.White;
            importButton.Cursor = Cursors.Hand;
            importButton.FlatAppearance.BorderColor = Color.Gray;
            importButton.FlatAppearance.BorderSize = 3;
            importButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            importButton.FlatAppearance.MouseOverBackColor = Color.MintCream;
            importButton.FlatStyle = FlatStyle.Flat;
            importButton.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            importButton.ForeColor = Color.Black;
            importButton.Location = new Point(856, 682);
            importButton.Name = "importButton";
            importButton.Size = new Size(349, 115);
            importButton.TabIndex = 1;
            importButton.Text = "Import existing database";
            importButton.UseVisualStyleBackColor = false;
            importButton.Click += importButton_Click;
            // 
            // dbInfoPanel
            // 
            dbInfoPanel.BackColor = Color.AliceBlue;
            dbInfoPanel.Controls.Add(exportButton);
            dbInfoPanel.Controls.Add(button3);
            dbInfoPanel.Controls.Add(columnsTableButton);
            dbInfoPanel.Controls.Add(dataTableButton);
            dbInfoPanel.Controls.Add(tableListBox);
            dbInfoPanel.Controls.Add(addTableButton);
            dbInfoPanel.Controls.Add(label3);
            dbInfoPanel.Controls.Add(dbRenameButton);
            dbInfoPanel.Controls.Add(dbDeleteButton);
            dbInfoPanel.Controls.Add(label2);
            dbInfoPanel.Controls.Add(splitter1);
            dbInfoPanel.Controls.Add(name_label);
            dbInfoPanel.Dock = DockStyle.Fill;
            dbInfoPanel.Location = new Point(0, 0);
            dbInfoPanel.Name = "dbInfoPanel";
            dbInfoPanel.Size = new Size(1284, 702);
            dbInfoPanel.TabIndex = 4;
            dbInfoPanel.Paint += dbInfoPanel_Paint;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.FromArgb(0, 64, 64);
            exportButton.Cursor = Cursors.Hand;
            exportButton.Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            exportButton.ForeColor = SystemColors.ControlLightLight;
            exportButton.Location = new Point(30, 913);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(306, 53);
            exportButton.TabIndex = 11;
            exportButton.Text = "Export database";
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += exportButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 64, 64);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(906, 740);
            button3.Name = "button3";
            button3.Size = new Size(226, 57);
            button3.TabIndex = 10;
            button3.Text = "Delete table";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // columnsTableButton
            // 
            columnsTableButton.BackColor = Color.FromArgb(0, 64, 64);
            columnsTableButton.Cursor = Cursors.Hand;
            columnsTableButton.Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            columnsTableButton.ForeColor = SystemColors.ControlLightLight;
            columnsTableButton.Location = new Point(674, 742);
            columnsTableButton.Name = "columnsTableButton";
            columnsTableButton.Size = new Size(226, 57);
            columnsTableButton.TabIndex = 9;
            columnsTableButton.Text = "View columns";
            columnsTableButton.UseVisualStyleBackColor = false;
            columnsTableButton.Click += columnsTableButton_Click;
            // 
            // dataTableButton
            // 
            dataTableButton.BackColor = Color.FromArgb(0, 64, 64);
            dataTableButton.Cursor = Cursors.Hand;
            dataTableButton.Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            dataTableButton.ForeColor = Color.White;
            dataTableButton.Location = new Point(443, 742);
            dataTableButton.Name = "dataTableButton";
            dataTableButton.Size = new Size(226, 57);
            dataTableButton.TabIndex = 8;
            dataTableButton.Text = "View data";
            dataTableButton.UseVisualStyleBackColor = false;
            dataTableButton.Click += dataTableButton_Click;
            // 
            // tableListBox
            // 
            tableListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableListBox.Cursor = Cursors.Help;
            tableListBox.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableListBox.FormattingEnabled = true;
            tableListBox.ItemHeight = 42;
            tableListBox.Location = new Point(443, 165);
            tableListBox.Name = "tableListBox";
            tableListBox.Size = new Size(830, 424);
            tableListBox.TabIndex = 7;
            // 
            // addTableButton
            // 
            addTableButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addTableButton.BackColor = Color.FromArgb(0, 64, 64);
            addTableButton.Cursor = Cursors.Hand;
            addTableButton.Font = new Font("Tw Cen MT Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addTableButton.ForeColor = SystemColors.ControlLightLight;
            addTableButton.Location = new Point(1097, 110);
            addTableButton.Name = "addTableButton";
            addTableButton.Size = new Size(171, 52);
            addTableButton.TabIndex = 6;
            addTableButton.Text = "Add table";
            addTableButton.UseVisualStyleBackColor = false;
            addTableButton.Click += addTableButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(434, 110);
            label3.Name = "label3";
            label3.Size = new Size(168, 42);
            label3.TabIndex = 5;
            label3.Text = "Tables list:";
            // 
            // dbRenameButton
            // 
            dbRenameButton.BackColor = Color.DimGray;
            dbRenameButton.Cursor = Cursors.Hand;
            dbRenameButton.Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            dbRenameButton.ForeColor = SystemColors.ControlLightLight;
            dbRenameButton.Location = new Point(30, 172);
            dbRenameButton.Name = "dbRenameButton";
            dbRenameButton.Size = new Size(306, 53);
            dbRenameButton.TabIndex = 4;
            dbRenameButton.Text = "Rename database";
            dbRenameButton.UseVisualStyleBackColor = false;
            dbRenameButton.Click += dbRenameButton_Click;
            // 
            // dbDeleteButton
            // 
            dbDeleteButton.BackColor = Color.DimGray;
            dbDeleteButton.Cursor = Cursors.Hand;
            dbDeleteButton.Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            dbDeleteButton.ForeColor = SystemColors.ControlLightLight;
            dbDeleteButton.Location = new Point(30, 83);
            dbDeleteButton.Name = "dbDeleteButton";
            dbDeleteButton.Size = new Size(306, 53);
            dbDeleteButton.TabIndex = 3;
            dbDeleteButton.Text = "Delete database";
            dbDeleteButton.UseVisualStyleBackColor = false;
            dbDeleteButton.Click += dbDeleteButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Tw Cen MT", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 22);
            label2.Name = "label2";
            label2.Size = new Size(324, 47);
            label2.TabIndex = 1;
            label2.Text = "Database settings: ";
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.White;
            splitter1.BorderStyle = BorderStyle.FixedSingle;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(399, 702);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Tw Cen MT Condensed Extra Bold", 28F, FontStyle.Regular, GraphicsUnit.Point);
            name_label.Location = new Point(846, 22);
            name_label.Name = "name_label";
            name_label.Size = new Size(253, 65);
            name_label.TabIndex = 0;
            name_label.Text = "Database: ";
            // 
            // tableColumnsPanel
            // 
            tableColumnsPanel.BackColor = Color.MintCream;
            tableColumnsPanel.Controls.Add(addNewColumnButton);
            tableColumnsPanel.Controls.Add(deleteColumnButton);
            tableColumnsPanel.Controls.Add(saveChangesColumnsButton);
            tableColumnsPanel.Controls.Add(backFromColumnsButton);
            tableColumnsPanel.Controls.Add(dataGridView1);
            tableColumnsPanel.Dock = DockStyle.Fill;
            tableColumnsPanel.Location = new Point(0, 0);
            tableColumnsPanel.Margin = new Padding(4, 5, 4, 5);
            tableColumnsPanel.Name = "tableColumnsPanel";
            tableColumnsPanel.Size = new Size(1284, 702);
            tableColumnsPanel.TabIndex = 12;
            tableColumnsPanel.Visible = false;
            // 
            // addNewColumnButton
            // 
            addNewColumnButton.BackColor = Color.FromArgb(0, 64, 64);
            addNewColumnButton.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addNewColumnButton.ForeColor = Color.White;
            addNewColumnButton.Location = new Point(804, 20);
            addNewColumnButton.Margin = new Padding(4, 5, 4, 5);
            addNewColumnButton.Name = "addNewColumnButton";
            addNewColumnButton.Size = new Size(341, 52);
            addNewColumnButton.TabIndex = 4;
            addNewColumnButton.Text = "Add new column";
            addNewColumnButton.UseVisualStyleBackColor = false;
            addNewColumnButton.Click += addNewColumnButton_Click;
            // 
            // deleteColumnButton
            // 
            deleteColumnButton.BackColor = Color.FromArgb(0, 64, 64);
            deleteColumnButton.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteColumnButton.ForeColor = Color.White;
            deleteColumnButton.Location = new Point(1154, 20);
            deleteColumnButton.Margin = new Padding(4, 5, 4, 5);
            deleteColumnButton.Name = "deleteColumnButton";
            deleteColumnButton.Size = new Size(341, 52);
            deleteColumnButton.TabIndex = 3;
            deleteColumnButton.Text = "Delete selected column";
            deleteColumnButton.UseVisualStyleBackColor = false;
            deleteColumnButton.Click += deleteColumnButton_Click;
            // 
            // saveChangesColumnsButton
            // 
            saveChangesColumnsButton.BackColor = Color.FromArgb(0, 64, 64);
            saveChangesColumnsButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            saveChangesColumnsButton.ForeColor = Color.White;
            saveChangesColumnsButton.Location = new Point(114, 23);
            saveChangesColumnsButton.Margin = new Padding(4, 5, 4, 5);
            saveChangesColumnsButton.Name = "saveChangesColumnsButton";
            saveChangesColumnsButton.Size = new Size(210, 52);
            saveChangesColumnsButton.TabIndex = 2;
            saveChangesColumnsButton.Text = "Save changes";
            saveChangesColumnsButton.UseVisualStyleBackColor = false;
            saveChangesColumnsButton.Click += saveChangesColumnsButton_Click;
            // 
            // backFromColumnsButton
            // 
            backFromColumnsButton.BackColor = Color.FromArgb(0, 64, 64);
            backFromColumnsButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            backFromColumnsButton.ForeColor = Color.White;
            backFromColumnsButton.Location = new Point(31, 23);
            backFromColumnsButton.Margin = new Padding(4, 5, 4, 5);
            backFromColumnsButton.Name = "backFromColumnsButton";
            backFromColumnsButton.Size = new Size(67, 52);
            backFromColumnsButton.TabIndex = 1;
            backFromColumnsButton.Text = "<< ";
            backFromColumnsButton.UseVisualStyleBackColor = false;
            backFromColumnsButton.Click += backFromColumnsButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnName, DataType, IsNullable });
            dataGridView1.Location = new Point(0, 78);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1284, 623);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Column name";
            ColumnName.MinimumWidth = 8;
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 150;
            // 
            // DataType
            // 
            DataType.HeaderText = "Data type";
            DataType.Items.AddRange(new object[] { "Integer", "Real", "Char", "String", "Color", "Color interval" });
            DataType.MinimumWidth = 8;
            DataType.Name = "DataType";
            DataType.Width = 150;
            // 
            // IsNullable
            // 
            IsNullable.HeaderText = "Is nullable";
            IsNullable.MinimumWidth = 8;
            IsNullable.Name = "IsNullable";
            IsNullable.Width = 150;
            // 
            // valuesPanel
            // 
            valuesPanel.BackColor = Color.Silver;
            valuesPanel.Controls.Add(projectTableButton);
            valuesPanel.Controls.Add(deleteRowButton);
            valuesPanel.Controls.Add(newRowButton);
            valuesPanel.Controls.Add(saveValuesButton);
            valuesPanel.Controls.Add(backFromValuesButton);
            valuesPanel.Controls.Add(valuesGrid);
            valuesPanel.Dock = DockStyle.Fill;
            valuesPanel.Location = new Point(0, 0);
            valuesPanel.Margin = new Padding(4, 5, 4, 5);
            valuesPanel.Name = "valuesPanel";
            valuesPanel.Size = new Size(1284, 702);
            valuesPanel.TabIndex = 5;
            // 
            // projectTableButton
            // 
            projectTableButton.BackColor = Color.Black;
            projectTableButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            projectTableButton.ForeColor = Color.White;
            projectTableButton.Location = new Point(1070, 10);
            projectTableButton.Name = "projectTableButton";
            projectTableButton.Size = new Size(198, 65);
            projectTableButton.TabIndex = 5;
            projectTableButton.Text = "Project this table";
            projectTableButton.UseVisualStyleBackColor = false;
            projectTableButton.Click += projectTableButton_Click;
            // 
            // deleteRowButton
            // 
            deleteRowButton.BackColor = Color.Black;
            deleteRowButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteRowButton.ForeColor = Color.White;
            deleteRowButton.Location = new Point(443, 10);
            deleteRowButton.Name = "deleteRowButton";
            deleteRowButton.Size = new Size(230, 65);
            deleteRowButton.TabIndex = 4;
            deleteRowButton.Text = "Delete selected row";
            deleteRowButton.UseVisualStyleBackColor = false;
            deleteRowButton.Click += deleteRowButton_Click;
            // 
            // newRowButton
            // 
            newRowButton.BackColor = Color.Black;
            newRowButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newRowButton.ForeColor = Color.White;
            newRowButton.Location = new Point(266, 12);
            newRowButton.Name = "newRowButton";
            newRowButton.Size = new Size(171, 65);
            newRowButton.TabIndex = 3;
            newRowButton.Text = "Add new row";
            newRowButton.UseVisualStyleBackColor = false;
            newRowButton.Click += newRowButton_Click;
            // 
            // saveValuesButton
            // 
            saveValuesButton.BackColor = Color.Black;
            saveValuesButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveValuesButton.ForeColor = Color.White;
            saveValuesButton.Location = new Point(89, 12);
            saveValuesButton.Name = "saveValuesButton";
            saveValuesButton.Size = new Size(171, 65);
            saveValuesButton.TabIndex = 2;
            saveValuesButton.Text = "Save changes";
            saveValuesButton.UseVisualStyleBackColor = false;
            saveValuesButton.Click += saveValuesButton_Click;
            // 
            // backFromValuesButton
            // 
            backFromValuesButton.BackColor = Color.Black;
            backFromValuesButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backFromValuesButton.ForeColor = Color.White;
            backFromValuesButton.Location = new Point(11, 12);
            backFromValuesButton.Name = "backFromValuesButton";
            backFromValuesButton.Size = new Size(71, 65);
            backFromValuesButton.TabIndex = 1;
            backFromValuesButton.Text = "<<";
            backFromValuesButton.UseVisualStyleBackColor = false;
            backFromValuesButton.Click += backFromValuesButton_Click;
            // 
            // valuesGrid
            // 
            valuesGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            valuesGrid.BackgroundColor = Color.White;
            valuesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            valuesGrid.Location = new Point(0, 82);
            valuesGrid.Margin = new Padding(4, 5, 4, 5);
            valuesGrid.Name = "valuesGrid";
            valuesGrid.RowHeadersWidth = 62;
            valuesGrid.RowTemplate.Height = 25;
            valuesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            valuesGrid.Size = new Size(1284, 845);
            valuesGrid.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1284, 702);
            Controls.Add(startPanel);
            Controls.Add(valuesPanel);
            Controls.Add(tableColumnsPanel);
            Controls.Add(dbInfoPanel);
            Name = "Form1";
            Text = "MyDBSM";
            Load += Form1_Load;
            startPanel.ResumeLayout(false);
            startPanel.PerformLayout();
            dbInfoPanel.ResumeLayout(false);
            dbInfoPanel.PerformLayout();
            tableColumnsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            valuesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)valuesGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel startPanel;
        private Button importButton;
        private Button dbCreateButton;
        private Label label1;
        private Panel dbInfoPanel;
        private Label name_label;
        private Button dbDeleteButton;
        private Label label2;
        private Splitter splitter1;
        private Button dbRenameButton;
        private Button addTableButton;
        private Label label3;
        private ListBox tableListBox;
        private Button button3;
        private Button columnsTableButton;
        private Button dataTableButton;
        private Button exportButton;
        private Panel tableColumnsPanel;
        private DataGridView dataGridView1;
        private Button backFromColumnsButton;
        private Button saveChangesColumnsButton;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewComboBoxColumn DataType;
        private DataGridViewCheckBoxColumn IsNullable;
        private Button deleteColumnButton;
        private Button addNewColumnButton;
        private Panel valuesPanel;
        private DataGridView valuesGrid;
        private Button backFromValuesButton;
        private Button saveValuesButton;
        private Button newRowButton;
        private Button deleteRowButton;
        private Button projectTableButton;
    }
}