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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace UI_New
{
    public partial class NewClientForm : Form
    {
        private void NewClientForm_Load(object sender, EventArgs e)
        {

        }
        //fields
        //private IconButton currentBtn;
        private Panel leftBorderBtn;

        //Constructor
        public NewClientForm()
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

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void EnterClient_txt_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //minimize, maximize, close
        private void minimize_button_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximize_button_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void close_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //enter new client
        private void enterClient_button_Click(object sender, EventArgs e)
        {
           
            try
            {
                //Connection String
                string MyConnection = "server=localhost;userid=my.morrisc6;password=team2;database=my_morrisc6_template1;persistsecurityinfo=True";
                
                //Open MySQL connection
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                MyConn2.Open();
                MySqlCommand comm = MyConn2.CreateCommand();

                //Insert query
                comm.CommandText = "INSERT into CLIENT_DEMOGRAPHICS(ClientID, LastName, FirstName, Address) VALUES(@ClientID, @LastName, @FirstName, @Address)";
                comm.Parameters.AddWithValue("@ClientID", enterClientIdTxt.Text);
                comm.Parameters.AddWithValue("@LastName", enterLastTxt.Text);
                comm.Parameters.AddWithValue("@FirstName", enterFirstTxt.Text);
                comm.Parameters.AddWithValue("@Address", enterAddressTxt.Text);
                //test 2

                comm.ExecuteNonQuery();

                //close MySQL connection
                MyConn2.Close();

                MessageBox.Show("Data Saved");

            }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
            

        }
    }
}
