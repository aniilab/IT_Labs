namespace MyDBSM
{
    partial class TableProjectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            columnPickPanel = new Panel();
            confirmProjectButton = new Button();
            columnsListBox = new ListBox();
            label1 = new Label();
            projectionPanel = new Panel();
            projectionGrid = new DataGridView();
            doneButton = new Button();
            columnPickPanel.SuspendLayout();
            projectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectionGrid).BeginInit();
            SuspendLayout();
            // 
            // columnPickPanel
            // 
            columnPickPanel.BackColor = Color.SlateGray;
            columnPickPanel.Controls.Add(confirmProjectButton);
            columnPickPanel.Controls.Add(columnsListBox);
            columnPickPanel.Controls.Add(label1);
            columnPickPanel.Dock = DockStyle.Fill;
            columnPickPanel.Location = new Point(0, 0);
            columnPickPanel.Name = "columnPickPanel";
            columnPickPanel.Size = new Size(800, 450);
            columnPickPanel.TabIndex = 0;
            // 
            // confirmProjectButton
            // 
            confirmProjectButton.BackColor = Color.AliceBlue;
            confirmProjectButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            confirmProjectButton.Location = new Point(633, 405);
            confirmProjectButton.Name = "confirmProjectButton";
            confirmProjectButton.Size = new Size(142, 39);
            confirmProjectButton.TabIndex = 2;
            confirmProjectButton.Text = "Project";
            confirmProjectButton.UseVisualStyleBackColor = false;
            confirmProjectButton.Click += confirmProjectButton_Click;
            // 
            // columnsListBox
            // 
            columnsListBox.FormattingEnabled = true;
            columnsListBox.ItemHeight = 25;
            columnsListBox.Location = new Point(12, 50);
            columnsListBox.Name = "columnsListBox";
            columnsListBox.SelectionMode = SelectionMode.MultiSimple;
            columnsListBox.Size = new Size(776, 354);
            columnsListBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(135, 9);
            label1.Name = "label1";
            label1.Size = new Size(488, 38);
            label1.TabIndex = 0;
            label1.Text = "Choose which columns you want to project";
            // 
            // projectionPanel
            // 
            projectionPanel.BackColor = Color.Azure;
            projectionPanel.Controls.Add(doneButton);
            projectionPanel.Controls.Add(projectionGrid);
            projectionPanel.Dock = DockStyle.Fill;
            projectionPanel.Location = new Point(0, 0);
            projectionPanel.Name = "projectionPanel";
            projectionPanel.Size = new Size(800, 450);
            projectionPanel.TabIndex = 3;
            // 
            // projectionGrid
            // 
            projectionGrid.BackgroundColor = SystemColors.ButtonHighlight;
            projectionGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectionGrid.Location = new Point(7, 6);
            projectionGrid.Name = "projectionGrid";
            projectionGrid.ReadOnly = true;
            projectionGrid.RowHeadersWidth = 62;
            projectionGrid.RowTemplate.Height = 33;
            projectionGrid.Size = new Size(781, 365);
            projectionGrid.TabIndex = 0;
            // 
            // doneButton
            // 
            doneButton.BackColor = Color.DarkSlateGray;
            doneButton.Font = new Font("Tw Cen MT", 14F, FontStyle.Bold, GraphicsUnit.Point);
            doneButton.ForeColor = Color.White;
            doneButton.Location = new Point(328, 392);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(162, 46);
            doneButton.TabIndex = 1;
            doneButton.Text = "Done";
            doneButton.UseVisualStyleBackColor = false;
            doneButton.Click += doneButton_Click;
            // 
            // TableProjectionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(projectionPanel);
            Controls.Add(columnPickPanel);
            Name = "TableProjectionForm";
            Text = "TableProjectionForm";
            columnPickPanel.ResumeLayout(false);
            columnPickPanel.PerformLayout();
            projectionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)projectionGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel columnPickPanel;
        private ListBox columnsListBox;
        private Label label1;
        private Button confirmProjectButton;
        private Panel projectionPanel;
        private DataGridView projectionGrid;
        private Button doneButton;
    }
}