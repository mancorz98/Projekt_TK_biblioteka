namespace Projekt_TK_biblioteka
{
    public partial class Form2 : Form
    {
        private bool isValid = false;
        private bool isRemoving = false;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(bool isRemoving)
        {
            this.isRemoving = isRemoving;
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (!isRemoving)
            {
                Login.login(new BookAddingWindow(), this, paswordCell ,loginTextBox);
            }
            else
            {
                this.isValid = (Login.loginForRemoving(this, paswordCell, loginTextBox));
            }
        }

        public bool get_isValid()
        {
            return isValid;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
