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


namespace UI_New
{
    public partial class EnterNewUserForm : Form
    {
        private void EnterNewUserForm_Load(object sender, EventArgs e)
        {

        }
        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public EnterNewUserForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            option_panel.Controls.Add(leftBorderBtn);
            //Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(244, 122, 96);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(49, 104, 121);
                //currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(49, 104, 121);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

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

        private void input_button_Click(object sender, EventArgs e)
        {
            //change color of button when selected
            ActivateButton(sender, RGBColors.color7);

        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            //change color of button when selected
            ActivateButton(sender, RGBColors.color7);

        }

        private void report_button_Click(object sender, EventArgs e)
        {
            //change color of button when selected
            ActivateButton(sender, RGBColors.color7);

        }

        private void newUser_button_Click(object sender, EventArgs e)
        {
            //change color of button when selected
            ActivateButton(sender, RGBColors.color7);

        }

        private void editUser_button_Click(object sender, EventArgs e)
        {
            //change color of button when selected
            ActivateButton(sender, RGBColors.color7);

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (currentBtn == input_button)
            {
                if (perm_listbox.Items.Contains("Input New Clients"))
                {
                    MessageBox.Show("User already has this permission");
                }
                else
                perm_listbox.Items.Add("Input New Clients");
            }
            else if (currentBtn == edit_button)
            {
                if (perm_listbox.Items.Contains("Edit Clients"))
                {
                    MessageBox.Show("User already has this permission");
                }
                else
                    perm_listbox.Items.Add("Edit Clients");
            }
            else if (currentBtn == report_button)
            {
                if (perm_listbox.Items.Contains("Generate Reports"))
                {
                    MessageBox.Show("User already has this permission");
                }
                else
                    perm_listbox.Items.Add("Generate Reports");
            }
            else if (currentBtn == newUser_button)
            {
                if (perm_listbox.Items.Contains("Add New User"))
                {
                    MessageBox.Show("User already has this permission");
                }
                else
                    perm_listbox.Items.Add("Add New User");
            }
            else if (currentBtn == editUser_button)
            {
                if (perm_listbox.Items.Contains("Edit User"))
                {
                    MessageBox.Show("User already has this permission");
                }
                else
                    perm_listbox.Items.Add("Edit User");
            }
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            if (currentBtn == input_button)
            {
                perm_listbox.Items.Remove("Input New Clients");
            }
            else if (currentBtn == edit_button)
            {
                perm_listbox.Items.Remove("Edit Clients");
            }
            else if (currentBtn == report_button)
            {
                perm_listbox.Items.Remove("Generate Reports");
            }
            else if (currentBtn == newUser_button)
            {
                perm_listbox.Items.Remove("Add New User");
            }
            else if (currentBtn == editUser_button)
            {
                perm_listbox.Items.Remove("Edit User");
            }

        }
    }
}
