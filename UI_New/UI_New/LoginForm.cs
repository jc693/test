using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace UI_New
{
    public partial class LoginForm : Form
    {
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        //fields
        //private IconButton currentBtn;
        private Panel leftBorderBtn;

        //Constructor
        public LoginForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            //Logo_panel.Controls.Add(leftBorderBtn);
            //Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void UserIcon_pbox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //close button
        private void close_button_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "")//checks to make sure the user name and the password are not blank
            {
                //message prompts the user letting them know that the field is empty
                MessageBox.Show("Username and password fields are empty. Please enter a username and password to login", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsername.Text == "")//checks to make sure the username is not blank
            {
                //message prompts the user letting them know that the field is empty
                MessageBox.Show("Username field is empty. Please enter Username to continue", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")//checks to make sure the password is not blank
            {
                //message prompts the user letting them know that the field is empty
                MessageBox.Show("Password field is empty. Please enter Password to continue", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                //mysql connection stuff
                //MAKE SURE YOU CHANGE THE QUERY FORM TO BE SAFE AGAINST SQL INJECTION (SEE DONNIES CODE FOR MORE DETAILS NEWCLIENT FORM)
                string Myconn ="server = localhost; user id = my.morrisc6; password = team2; persistsecurityinfo = True; database = my_morrisc6_template1";
                MySqlConnection conn = new MySqlConnection(Myconn);
                MySqlCommand cmd = new MySqlCommand("select * from login where username=@Username and password =@Password", conn);//mysql query command
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd); 
                DataTable dt = new DataTable();
                sda.Fill(dt);//actually runs the query
                if (dt.Rows.Count > 0)//looks through table for the requested credentials 
                {
                    MainMenu f2 = new MainMenu();//if credentials are found move them to the next page
                    f2.ShowDialog();
                }
                else {// if credentials not found display this message
                    MessageBox.Show("credentials not found. please try again.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
