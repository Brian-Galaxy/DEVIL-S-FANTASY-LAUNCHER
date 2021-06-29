using AutoUpdaterDotNET;
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
        public selectForm()
        {
            InitializeComponent();
            AutoUpdater.Start("https://pastebin.com/raw/WRR00DxV");


        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
