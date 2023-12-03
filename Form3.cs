using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Projekt_TK_biblioteka
{
    public partial class BookAddingWindow : Form
    {
        private string cs = @"server=mysql.agh.edu.pl;userid=kbednarz;password=dkeF99Vb8tWr2kVh;database=kbednarz";
        private MySqlConnection con;


        public BookAddingWindow()
        {
            InitializeComponent();
            con = new MySqlConnection(cs);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void inButton_Click(object sender, EventArgs e)
        {
            if (!authorsListBox.Items.Contains(authorTextBox.Text))
                authorsListBox.Items.Add(authorTextBox.Text);
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            if (authorsListBox.Items.Count > 0)
            {
                authorsListBox.Items.Remove(authorsListBox.SelectedItem);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private static string GetImageFilter()
        {
            return
                "All Files (*.*)|*.*" +
                "|All Pictures (*.emf;*.wmf;*.jpg;*.jpeg;*.jfif;*.jpe;*.png;*.bmp;*.dib;*.rle;*.gif;*.emz;*.wmz;*.tif;*.tiff;*.svg;*.ico)" +
                    "|*.emf;*.wmf;*.jpg;*.jpeg;*.jfif;*.jpe;*.png;*.bmp;*.dib;*.rle;*.gif;*.emz;*.wmz;*.tif;*.tiff;*.svg;*.ico" +
                "|Windows Enhanced Metafile (*.emf)|*.emf" +
                "|Windows Metafile (*.wmf)|*.wmf" +
                "|JPEG File Interchange Format (*.jpg;*.jpeg;*.jfif;*.jpe)|*.jpg;*.jpeg;*.jfif;*.jpe" +
                "|Portable Network Graphics (*.png)|*.png" +
                "|Bitmap Image File (*.bmp;*.dib;*.rle)|*.bmp;*.dib;*.rle" +
                "|Compressed Windows Enhanced Metafile (*.emz)|*.emz" +
                "|Compressed Windows MetaFile (*.wmz)|*.wmz" +
                "|Tag Image File Format (*.tif;*.tiff)|*.tif;*.tiff" +
                "|Scalable Vector Graphics (*.svg)|*.svg" +
                "|Icon (*.ico)|*.ico";
        }

        private void addImageToDb(string ImageURL)
        {
            var stm = "INSERT INTO Image(ImageId, ImageUrl) SELECT (SELECT MAX(im1.ImageId)+1 FROM Image im1), @tmpImageUrl FROM Image im2 WHERE NOT EXISTS (SELECT * FROM Image im3 WHERE im3.ImageUrl = @tmpImageUrl) LIMIT 1";
            con.Open();
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@tmpImageUrl", ImageURL);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private int getID(string ImageURL)
        {
            var stm = "SELECT ImageId FROM Image where ImageUrl = @tmpImageUrl";
            con.Open();
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@tmpImageUrl", ImageURL);

            var returning_int = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();
            return returning_int;
        }

        private void addBookToDB(string isbn, List<string> authors, string title,string type ,int edition, int imageId)
        {
            try
            {
                var stm = "INSERT INTO BOOK(ISBNnumber, Type, Edition, Author1, Author2, Author3, ImageId, Title) VALUES (@tmpISBN, @tmpType, @tmpEdition, @tmpAuthor1, @tmpAuthor2, @tmpAuthor3, @tmpImageId, @tmpTitle );";
                con.Open();
                using var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@tmpISBN", isbn);
                cmd.Parameters.AddWithValue("@tmpType", type);
                cmd.Parameters.AddWithValue("@tmpEdition", edition);
                cmd.Parameters.AddWithValue("@tmpAuthor1", authors[0]);
                cmd.Parameters.AddWithValue("@tmpAuthor2", authors.Count() > 1 ? authors[1] : (string?)null);
                cmd.Parameters.AddWithValue("@tmpAuthor3", authors.Count() > 2 ? authors[2] : (string?)null);
                cmd.Parameters.AddWithValue("@tmpImageId", imageId);
                cmd.Parameters.AddWithValue("@tmpTitle", title);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch { }


        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                int edition = Convert.ToInt32(bookEditionTextBox.Text);
                addImageToDb(filePathTextBox.Text);
                var imageID = getID(filePathTextBox.Text);


                addBookToDB(isbnTextBox.Text, authorsListBox.Items.Cast<String>().ToList(), bookTitleBox.Text, bookTypeBox.Text, edition, imageID);

                MessageBox.Show($"Dodano pozycję: {bookTitleBox.Text}");
            }
            catch
            {
                bookEditionTextBox.Text = "";
                MessageBox.Show("Zły format wydania. Należy podać wartość liczbową");
            }
        }

        private void filePathTextBox_TextChanged(object sender, EventArgs e)
        {
            Book.showPicture(pictureBox1, filePathTextBox.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
