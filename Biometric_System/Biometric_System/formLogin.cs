using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Biometric_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUsername1.Text.Equals("Username"))

            {
                txtUsername1.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername1.Text.Equals(""))

            {
                txtUsername1.Text = "Username";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if(txtPassword1.Text.Equals("Password"))
            {
                txtPassword1.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword1.Text.Equals(""))
            {
                txtPassword1.Text = "Password";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername1.Text;
            string pass = txtPassword1.Text;
            MySqlConnection conn = new MySqlConnection(connectionString: "server=localhost;user id=root; password=kisumen@1; persistsecurityinfo=True;database=biometric_system");
            MySqlDataAdapter sda = new MySqlDataAdapter("select username from login where username = '" +txtUsername1.Text+ "' and password = '" +txtPassword1.Text+ "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                //MessageBox.Show("username and password are matched", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Dashboard dd = new Dashboard(dt.Rows[0][0].ToString()); 
                dd.Show();

            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Unimaid Biometric System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
