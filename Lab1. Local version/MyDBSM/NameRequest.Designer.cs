namespace MyDBSM
{
    partial class NameRequest
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
            okButton = new Button();
            nameTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Cursor = Cursors.Hand;
            okButton.Font = new Font("Tw Cen MT Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            okButton.Location = new Point(263, 91);
            okButton.Name = "okButton";
            okButton.Size = new Size(88, 33);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Tw Cen MT", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            nameTextBox.Location = new Point(33, 55);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(318, 30);
            nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 24);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 2;
            label1.Text = "Enter a name:";
            // 
            // NameRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(384, 141);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(okButton);
            Name = "NameRequest";
            Text = "Enter a name";
            Load += NameRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private TextBox nameTextBox;
        private Label label1;
    }
}