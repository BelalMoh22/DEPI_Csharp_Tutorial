namespace MyFirstWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "Belal" && txtPassword.Text.Trim() == "123")
            {
                //Form2 
                MainFrm mainFrm = new MainFrm();
                mainFrm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Userame Or Password....", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
