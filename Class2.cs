using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Projekt_TK_biblioteka
{
    internal class Login
    {
   
        private static string cs = @"server=mysql.agh.edu.pl;userid=kbednarz;password=dkeF99Vb8tWr2kVh;database=kbednarz";
        private static MySqlConnection con;
        private static MySqlConnection get_con()
        {
            return new MySqlConnection(cs);
        }

        private static bool handle_login(string login, string password)
        {   
            con = get_con();
            con.Open(); 
            var stm = "SELECT COUNT(*) FROM Login WHERE login = @tmpLogin and password = PASSWORD(@tmpPassword)";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@tmpLogin", login);
            cmd.Parameters.AddWithValue("@tmpPassword", password);
            int UserExist = Convert.ToInt32( cmd.ExecuteScalar().ToString());
            con.Close();
            if (UserExist > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void login( Form addBookForm, Form loginForm, MaskedTextBox passwordTextBox, TextBox loginTextBox )   
        {   


            if (handle_login(loginTextBox.Text, passwordTextBox.Text))
            {
                loginForm.Hide();
                addBookForm.ShowDialog();
                
            }
            else
            {
                passwordTextBox.Text = "";
                loginTextBox.Text = "";
                MessageBox.Show("Złe login/hasło!");
            }
        }

        public static bool loginForRemoving(Form loginForm, MaskedTextBox passwordTextBox, TextBox loginTextBox)
        {
            
            if (handle_login(loginTextBox.Text, passwordTextBox.Text))
            {
                loginForm.Hide();
                return true;

            }
            else
            {
                MessageBox.Show("Złe hasło!");
                loginForm.Hide();
                return false;
            }
        }
    }
}
