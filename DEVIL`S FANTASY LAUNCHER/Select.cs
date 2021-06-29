using AutoUpdaterDotNET;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVIL_S_FANTASY_LAUNCHER
{
    public partial class selectForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public selectForm()
        {
            InitializeComponent();
            AutoUpdater.Start("https://pastebin.com/raw/WRR00DxV");


        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void authPnl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void inBtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = nameBox.Text;
            String passUser = passBox.Text;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`= @_login AND `pass`= @_pass", db.getConnection());

            command.Parameters.Add("@_login", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@_pass", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (inCheck.Checked == true)
            {
                Properties.Settings.Default.username = loginUser;
                Properties.Settings.Default.password = passUser;
            }
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Auth Complete");
            }
            else
            {
                MessageBox.Show("Failure");
            }
        }

        private void inCheck_CheckStateChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.check = inCheck.Checked;
        }
    }
}
