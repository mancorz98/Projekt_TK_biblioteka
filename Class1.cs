using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;



namespace Projekt_TK_biblioteka
{
    public class Book
    {
        private const string LOCAL_FILE_PATH = "\\\\Mac\\Home\\Desktop\\projekt_TK_obrazy\\pobrane.jpeg";

        public string type;
        public string title;
        public List<string> authors;

        public string ISBNNumber;
        public int edition;
        public string localFilePath;

        public Book(string type, string title, List<string> authors, string ISBNNumber, int edition, string localFilePath = "\\\\Mac\\Home\\Desktop\\projekt_TK_obrazy\\pobrane.jpeg")
        {
            this.type = type;
            this.title = title;
            this.authors = authors;
            this.ISBNNumber = ISBNNumber;
            this.edition = edition;
            set_localFilePath(localFilePath);

        }

        private static List<string> create_list_from_string(string s)
        {
            var tmp_list = new List<string>
            {
                s
            };
            return tmp_list;

        }

        public static List<Book> BuildList()
        {
            return new List<Book> {
                new Book("powieść", "W pustyni i w puszczy", create_list_from_string("Henryk Sienkiewicz"), "gdkejgfej", 1),
                new Book("ballada", "Antygona", create_list_from_string("Sofokles"), "blandjwls", 1),
                new Book("poemat", "Monachomachia", create_list_from_string("Ignacy Krasicki"), "gdkejgfej", 1),
                new Book("bajka", "Czerwony kapturek",create_list_from_string("Charles Perrault"), "sdafsdfg", 1)
            };
        }

        private string authorsToString()
        {
            string returning_string = "";
            foreach (string author in authors)
            {
                returning_string += (author + ", ");
            }
            return returning_string;
        }
        public override string ToString()
        {
            return title + " Wydanie: " + this.edition.ToString();
        }
        public string toFilename()
        {
            return title + "Wydanie" + this.edition.ToString();
        }
        public void generatePicture(PictureBox pb)
        {
            pb.ImageLocation = this.localFilePath;
            pb.SizeMode = PictureBoxSizeMode.Zoom;

        }

        public void set_localFilePath(string path)
        {
            string starup_directory = Application.StartupPath;
            FileInfo fi = new FileInfo(path);
            if (!fi.Exists)
            {
                path = LOCAL_FILE_PATH;
            }

            /// string startupPath = Application.StartupPath;
            string folder = "data";
            DirectoryInfo dir = new DirectoryInfo(folder);

            var destPath = Path.Join(starup_directory, folder, $"{this.toFilename()}{fi.Extension}");
            if (!dir.Exists)
            {
                dir.Create();
            }
            File.Copy(path, destPath, true);
            this.localFilePath = destPath;

        }
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Book p = (Book)obj;
                return (type == p.type) && (authors == p.authors) && (p.title == title) && (p.edition == edition);
            }
        }
        public static void showPicture(PictureBox pb, string url)
        {
            try
            {
                var request = WebRequest.Create(url);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pb.Image = Bitmap.FromStream(stream);
                }

            }
            catch
            {
                MessageBox.Show($"Nie znaleziono obrazka pod adresem: {url}");
                var request = WebRequest.Create("https://www.shutterstock.com/image-vector/open-book-red-cover-white-260nw-1384829126.jpg");

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pb.Image = Bitmap.FromStream(stream);
                }
            }


        }
    }
}
