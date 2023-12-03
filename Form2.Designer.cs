namespace Projekt_TK_biblioteka
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            paswordCell = new MaskedTextBox();
            button1 = new Button();
            label100 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label2 = new Label();
            loginTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(380, 33);
            label1.TabIndex = 0;
            label1.Text = "Akcja wymaga zalogowania";
            label1.Click += label1_Click;
            // 
            // paswordCell
            // 
            paswordCell.CutCopyMaskFormat = MaskFormat.IncludePromptAndLiterals;
            paswordCell.HidePromptOnLeave = true;
            paswordCell.Location = new Point(66, 125);
            paswordCell.Margin = new Padding(2, 1, 2, 1);
            paswordCell.Name = "paswordCell";
            paswordCell.PasswordChar = '*';
            paswordCell.Size = new Size(285, 23);
            paswordCell.TabIndex = 1;

            // 
            // button1
            // 
            button1.Location = new Point(157, 160);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label100
            // 
            label100.AutoSize = true;
            label100.Location = new Point(66, 109);
            label100.Name = "label100";
            label100.Size = new Size(37, 15);
            label100.TabIndex = 3;
            label100.Text = "Hasło";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 65);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 5;
            label2.Text = "Login";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(66, 83);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(285, 23);
            loginTextBox.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 211);
            Controls.Add(loginTextBox);
            Controls.Add(label2);
            Controls.Add(label100);
            Controls.Add(button1);
            Controls.Add(paswordCell);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form2";
            Text = "Logowanie ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox paswordCell;
        private Button button1;
        private Label label100;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
        private TextBox loginTextBox;
    }
}