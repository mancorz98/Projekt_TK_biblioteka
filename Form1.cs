using System.Xml.Linq;
using System.Linq;
using MySql.Data.MySqlClient;



namespace Projekt_TK_biblioteka
{
    public partial class Form1 : Form
    {
        private string cs = @"server=mysql.agh.edu.pl;userid=kbednarz;password=dkeF99Vb8tWr2kVh;database=kbednarz";
        private MySqlConnection con;
        private string ISBN;
        public Form1()
        {
            InitializeComponent();
            con = new MySqlConnection(cs);
            starRating1.Enabled = false;
            starRating1.onValueChanged += new EventHandler(ratingChanged);

        }


        private void updateRanking()
        {
            var stm = "INSERT INTO RATING(ISBNnumber, rating) VALUES (@tmpISBN, @tmpRating)";
            con.Open();
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@tmpRating", starRating1.Value);
            cmd.Parameters.AddWithValue("@tmpISBN", ISBN);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        private string getAverageRating() {
            var stm = "SELECT AVG(rating) from RATING where ISBNnumber = @tmpISBN";
            con.Open();
            using var cmd = new MySqlCommand(stm, con);
   
            cmd.Parameters.AddWithValue("@tmpISBN", ISBN);
         

            var rating = cmd.ExecuteScalar().ToString();
            con.Close();

            return rating;

        }

        protected void ratingChanged(object sender, EventArgs e)
        {
            updateRanking();
            MessageBox.Show($"Dziêkujemy za opiniê \n Œrednia ocen dla pozycji wynosi {getAverageRating()}");
            starRating1.Enabled = false;
        }


        public void load_books()
        {
            bookTypesList.Items.Clear();
            //foreach (Book book in books)
            //{

            //    if (!bookTypesList.Items.Contains(book.type))
            //    {
            //        bookTypesList.Items.Add(book.type);
            //    }

            //}

            var stm = "select distinct Type from BOOK;";
            con.Open();
            var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                bookTypesList.Items.Add(rdr.GetString(0));
            }
            con.Close();
        }



        private Book selected_book;
        private void Form1_Load(object sender, EventArgs e)
        {
            load_books();
        }

        private void updateAuthors()
        {
            var stm = "select Author1, Author2, Author3 from BOOK WHERE Type = @tempType;";
            con.Open();
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@tempType", (string)bookTypesList.SelectedItem);

            selectedAuthorList.Items.Clear();

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                for (int i = 0; i < 3; i++)
                    if (!rdr.IsDBNull(i))
                        if (rdr.GetString(i) != "" && !selectedAuthorList.Items.Contains(rdr.GetString(i)))
                            selectedAuthorList.Items.Add(rdr.GetString(i));
            }
            con.Close();
            selectedAuthorList.Enabled = true;
        }

        private void bookTypesList_SelectedIndexChanged(object sender, EventArgs e)
        {

            updateAuthors();

        }


        private void selectedAuthorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBooks.Items.Clear();
            var stm = "select Title, Edition from BOOK WHERE Type = @tempType and (Author1 = @tempAuthor or " +
                "Author2 = @tempAuthor or Author3 = @tempAuthor);";
            con.Open();
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@tempType", (string)bookTypesList.SelectedItem);
            cmd.Parameters.AddWithValue("@tempAuthor", (string)selectedAuthorList.SelectedItem);


            //selectedAuthorList.Items.Clear();

            using MySqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {

                selectedBooks.Items.Add($"{rdr.GetString(0)},  Wydanie {rdr.GetString(1)}");
            }
            con.Close();

            selectedAuthorList.Enabled = true;
            selectedBooks.Enabled = true;

        }


        private string getISBNFromDb()
        {
            try
            {
                var stm = "select ISBNNumber from BOOK WHERE Type = @tempType and (Author1 = @tempAuthor or " +
           "Author2 = @tempAuthor or Author3 = @tempAuthor) and " +
           "Title = @tempTitle and Edition = @tempEdition;";
                con.Open();
                using var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@tempType", (string)bookTypesList.SelectedItem);
                cmd.Parameters.AddWithValue("@tempAuthor", (string)selectedAuthorList.SelectedItem);

                var bookContent = ((string)selectedBooks.SelectedItem).Split(",  Wydanie ");
                cmd.Parameters.AddWithValue("@tempTitle", bookContent[0]);
                cmd.Parameters.AddWithValue("@tempEdition", bookContent[1]);

                var IsbnNumber = cmd.ExecuteScalar().ToString();
                con.Close();
                return IsbnNumber;
            }
            catch (Exception e)
            {
                con.Close();
                return null;
            }




        }

        private string getUrl(string ISBN)
        {
            var stm = "select ImageUrl from Image where ImageId = (SELECT ImageID FROM BOOK WHERE ISBNNumber = @tempISBN);";
            con.Open();
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@tempISBN", ISBN);
            var URL = cmd.ExecuteScalar().ToString();
            con.Close();
            return URL;
        }




        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (selectedBooks.Items != null && selectedBooks.Items.Count > 0)
                {
                    var IsbnNumber = getISBNFromDb();
                    var URL = getUrl(IsbnNumber);
                    ISBN = IsbnNumber;
                    Book.showPicture(bookPictureBox, URL);
                    starRating1.Enabled = true;
                }
            }
            catch (Exception e2)
            {

            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            var loginWindow = new Form2();
            loginWindow.ShowDialog();
        }

        private void deleteRecord()
        {

            var stm = "DELETE FROM BOOK where ISBNNumber = @tempISBN;";
            con.Open();
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@tempISBN", ISBN);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void removeBookButton_Click(object sender, EventArgs e)
        {
            var loginWindow = new Form2(isRemoving: true);
            loginWindow.ShowDialog();

            if (loginWindow.get_isValid())
            {
                deleteRecord();
                MessageBox.Show("Usuniêto pozycjê");
            }

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void starRating1_Load(object sender, EventArgs e)
        {

        }
    }
}
