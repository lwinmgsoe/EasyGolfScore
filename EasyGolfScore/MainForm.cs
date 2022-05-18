using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyGolfScore.Controls;
namespace EasyGolfScore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BySystem36Menu_Click(object sender, EventArgs e)
        {
            var control = System36.Instance;
            LoadControl(control);
        }
        public void LoadControl(UserControl control)
        {
            if (MainPanel.Controls.Contains(control))
            {
                control.BringToFront();
            }
            else
            {
                MainPanel.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                control.BringToFront();
            }
            //if (MainPanel.Controls.Count > 0)
            //{
            //    MainPanel.Controls.Clear();
            //}
            //MainPanel.Controls.Add(control);
            //control.Dock = DockStyle.Fill;
        }

        private void ByHandicapMenu_Click(object sender, EventArgs e)
        {
            var control = Handicap.Instance;
            LoadControl(control);
        }

        private void ByPeoriaMenu_Click(object sender, EventArgs e)
        {
            var control = Peoria.Instance;
            LoadControl(control);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var control = OldPeoria.Instance;
            LoadControl(control);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var control = HomePage.Instance;
            LoadControl(control);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                var control = HomePage.Instance;
                LoadControl(control);
            }
        }
    }
}
