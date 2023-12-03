using System.Xml.Linq;

namespace Projekt_TK_biblioteka
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
        /// 


        private void InitializeComponent()
        {
            titleLabel = new Label();
            bookTypesList = new ComboBox();
            selectedAuthorList = new ListBox();
            selectedBooks = new ListBox();
            bookPictureBox = new PictureBox();
            button1 = new Button();
            removeBookButton = new Button();
            starRating1 = new StarRating();
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(90, 4);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(476, 37);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "System wypożyczania książek";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // bookTypesList
            // 
            bookTypesList.FormattingEnabled = true;
            bookTypesList.Items.AddRange(new object[] { "dds" });
            bookTypesList.Location = new Point(26, 90);
            bookTypesList.Margin = new Padding(2, 1, 2, 1);
            bookTypesList.Name = "bookTypesList";
            bookTypesList.Size = new Size(166, 23);
            bookTypesList.TabIndex = 2;
            bookTypesList.SelectedIndexChanged += bookTypesList_SelectedIndexChanged;
            // 
            // selectedAuthorList
            // 
            selectedAuthorList.Enabled = false;
            selectedAuthorList.FormattingEnabled = true;
            selectedAuthorList.ItemHeight = 15;
            selectedAuthorList.Location = new Point(212, 90);
            selectedAuthorList.Margin = new Padding(2, 1, 2, 1);
            selectedAuthorList.Name = "selectedAuthorList";
            selectedAuthorList.Size = new Size(175, 79);
            selectedAuthorList.TabIndex = 3;
            selectedAuthorList.SelectedIndexChanged += selectedAuthorList_SelectedIndexChanged;
            // 
            // selectedBooks
            // 
            selectedBooks.Enabled = false;
            selectedBooks.FormattingEnabled = true;
            selectedBooks.HorizontalExtent = 30;
            selectedBooks.ItemHeight = 15;
            selectedBooks.Location = new Point(407, 90);
            selectedBooks.Margin = new Padding(2, 1, 2, 1);
            selectedBooks.Name = "selectedBooks";
            selectedBooks.Size = new Size(286, 79);
            selectedBooks.Sorted = true;
            selectedBooks.TabIndex = 4;
            selectedBooks.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // bookPictureBox
            // 
            bookPictureBox.Location = new Point(144, 172);
            bookPictureBox.Margin = new Padding(2, 1, 2, 1);
            bookPictureBox.Name = "bookPictureBox";
            bookPictureBox.Size = new Size(422, 236);
            bookPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            bookPictureBox.TabIndex = 5;
            bookPictureBox.TabStop = false;
            // 
            // button1
            // 
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(559, 457);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(160, 26);
            button1.TabIndex = 6;
            button1.Text = "Dodaj pozycję";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // removeBookButton
            // 
            removeBookButton.ForeColor = Color.Red;
            removeBookButton.Location = new Point(382, 457);
            removeBookButton.Margin = new Padding(2, 1, 2, 1);
            removeBookButton.Name = "removeBookButton";
            removeBookButton.Size = new Size(160, 26);
            removeBookButton.TabIndex = 7;
            removeBookButton.Text = "Usuń pozycję";
            removeBookButton.UseVisualStyleBackColor = true;
            removeBookButton.Click += removeBookButton_Click;
            // 
            // starRating1
            // 
            starRating1.Location = new Point(-5, 423);
            starRating1.Name = "starRating1";
            starRating1.Size = new Size(316, 118);
            starRating1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 542);
            Controls.Add(starRating1);
            Controls.Add(removeBookButton);
            Controls.Add(button1);
            Controls.Add(bookPictureBox);
            Controls.Add(selectedBooks);
            Controls.Add(selectedAuthorList);
            Controls.Add(bookTypesList);
            Controls.Add(titleLabel);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        public static List<Book> books = Book.BuildList();
        private ComboBox bookTypesList;
        private ListBox selectedAuthorList;
        private ListBox selectedBooks;
        private PictureBox bookPictureBox;
        private Button button1;
        private Button removeBookButton;
        private StarRating starRating1;



    }
}