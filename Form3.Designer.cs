namespace Projekt_TK_biblioteka
{
    partial class BookAddingWindow
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
            bookTypeBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bookTitleBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            bookEditionTextBox = new TextBox();
            authorsListBox = new ListBox();
            label5 = new Label();
            authorTextBox = new TextBox();
            inButton = new Button();
            outButton = new Button();
            label6 = new Label();
            filePathTextBox = new TextBox();
            addBookButton = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            isbnTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bookTypeBox
            // 
            bookTypeBox.Location = new Point(97, 67);
            bookTypeBox.Margin = new Padding(2, 1, 2, 1);
            bookTypeBox.Name = "bookTypeBox";
            bookTypeBox.Size = new Size(209, 23);
            bookTypeBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "Typ literacki";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Tytuł";
            label2.Click += label2_Click;
            // 
            // bookTitleBox
            // 
            bookTitleBox.Location = new Point(97, 111);
            bookTitleBox.Margin = new Padding(2, 1, 2, 1);
            bookTitleBox.Name = "bookTitleBox";
            bookTitleBox.Size = new Size(209, 23);
            bookTitleBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(382, 88);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 13);
            label3.TabIndex = 4;
            label3.Text = "Autorzy:\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 140);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "Wydanie";
            label4.Click += label4_Click;
            // 
            // bookEditionTextBox
            // 
            bookEditionTextBox.Location = new Point(97, 157);
            bookEditionTextBox.Margin = new Padding(2, 1, 2, 1);
            bookEditionTextBox.Name = "bookEditionTextBox";
            bookEditionTextBox.Size = new Size(209, 23);
            bookEditionTextBox.TabIndex = 6;
            // 
            // authorsListBox
            // 
            authorsListBox.FormattingEnabled = true;
            authorsListBox.ImeMode = ImeMode.On;
            authorsListBox.ItemHeight = 15;
            authorsListBox.Location = new Point(382, 102);
            authorsListBox.Margin = new Padding(2, 1, 2, 1);
            authorsListBox.Name = "authorsListBox";
            authorsListBox.ScrollAlwaysVisible = true;
            authorsListBox.Size = new Size(280, 94);
            authorsListBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(382, 52);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 11;
            label5.Text = "Autor:";
            label5.Click += label5_Click;
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(382, 68);
            authorTextBox.Margin = new Padding(2, 1, 2, 1);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(280, 23);
            authorTextBox.TabIndex = 10;
            // 
            // inButton
            // 
            inButton.ForeColor = Color.FromArgb(0, 192, 0);
            inButton.Location = new Point(678, 95);
            inButton.Margin = new Padding(2, 1, 2, 1);
            inButton.Name = "inButton";
            inButton.Size = new Size(72, 25);
            inButton.TabIndex = 12;
            inButton.Text = "Dodaj";
            inButton.UseVisualStyleBackColor = true;
            inButton.Click += inButton_Click;
            // 
            // outButton
            // 
            outButton.BackgroundImageLayout = ImageLayout.Center;
            outButton.Cursor = Cursors.No;
            outButton.ForeColor = Color.Red;
            outButton.Location = new Point(678, 130);
            outButton.Margin = new Padding(2, 1, 2, 1);
            outButton.Name = "outButton";
            outButton.Size = new Size(72, 25);
            outButton.TabIndex = 13;
            outButton.Text = "Usuń";
            outButton.UseVisualStyleBackColor = true;
            outButton.Click += outButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 228);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 15;
            label6.Text = "URL";
            label6.Click += label6_Click;
            // 
            // filePathTextBox
            // 
            filePathTextBox.Location = new Point(87, 244);
            filePathTextBox.Margin = new Padding(2, 1, 2, 1);
            filePathTextBox.Name = "filePathTextBox";
            filePathTextBox.Size = new Size(574, 23);
            filePathTextBox.TabIndex = 14;
            filePathTextBox.Text = "Wprowadź URL do zdjęcia";
            filePathTextBox.TextChanged += filePathTextBox_TextChanged;
            // 
            // addBookButton
            // 
            addBookButton.Location = new Point(89, 404);
            addBookButton.Margin = new Padding(2, 1, 2, 1);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(572, 28);
            addBookButton.TabIndex = 17;
            addBookButton.Text = "Dodaj pozycję literatury";
            addBookButton.UseVisualStyleBackColor = true;
            addBookButton.Click += addBookButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(248, 286);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 268);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 19;
            label7.Text = "Wybrane zdjęcie";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(97, 187);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 21;
            label8.Text = "ISBN:";
            label8.Click += label8_Click;
            // 
            // isbnTextBox
            // 
            isbnTextBox.Location = new Point(97, 204);
            isbnTextBox.Margin = new Padding(2, 1, 2, 1);
            isbnTextBox.Name = "isbnTextBox";
            isbnTextBox.Size = new Size(209, 23);
            isbnTextBox.TabIndex = 20;
            isbnTextBox.TextChanged += textBox1_TextChanged;
            // 
            // BookAddingWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 466);
            Controls.Add(label8);
            Controls.Add(isbnTextBox);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(addBookButton);
            Controls.Add(label6);
            Controls.Add(filePathTextBox);
            Controls.Add(outButton);
            Controls.Add(inButton);
            Controls.Add(label5);
            Controls.Add(authorTextBox);
            Controls.Add(authorsListBox);
            Controls.Add(label4);
            Controls.Add(bookEditionTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bookTitleBox);
            Controls.Add(label1);
            Controls.Add(bookTypeBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "BookAddingWindow";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bookTypeBox;
        private Label label1;
        private Label label2;
        private TextBox bookTitleBox;
        private Label label3;
        private Label label4;
        private TextBox bookEditionTextBox;
        private ListBox authorsListBox;
        private Label label5;
        private TextBox authorTextBox;
        private Button inButton;
        private Button outButton;
        private Label label6;
        private TextBox filePathTextBox;
        private Button selectImageButton;
        private Button addBookButton;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
        private TextBox isbnTextBox;
    }
}