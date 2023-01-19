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
using System.IO;

namespace UI_New
{
    public partial class ReportForm : Form
    {
        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        //Constructor
        public ReportForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
           // Logo_panel.Controls.Add(leftBorderBtn);
            //Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void EnterClient_txt_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //minimize, maximize, close
        private void minimize_button_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximize_button_MouseClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void close_button_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        //search database
        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("server=localhost;user id=my.morrisc6;database=my_morrisc6_template1;persistsecurityinfo=True"))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    using (DataTable dt = new DataTable("table2"))
                    {
                        using (SqlCommand cd = new SqlCommand("select *from table2 where firstName like @firstName or lastName like @lastName or address like @address", con))
                        {
                            cd.Parameters.AddWithValue("@firstName",  firstTxt.Text );
                            cd.Parameters.AddWithValue("@lastName",  lastTxt.Text );
                            cd.Parameters.AddWithValue("@address", addressTxt.Text );

                            SqlDataAdapter apt = new SqlDataAdapter(cd);
                            apt.Fill(dt);

                            DataViewForm dataForm = new DataViewForm(dt);
                            dataForm.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        


    }
    }

