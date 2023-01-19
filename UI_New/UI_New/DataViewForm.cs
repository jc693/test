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
using System.IO;
using System.Data.SqlClient;

namespace UI_New
{
    public partial class DataViewForm : Form
    {
        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        //Constructor
        public DataViewForm()
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

        public DataViewForm(DataTable dt)
        {
            InitializeComponent();
            dataGridView.DataSource = dt;
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

        
    }
}
