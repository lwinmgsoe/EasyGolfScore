using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyGolfScore.Controls
{
    public partial class HomePage : UserControl
    {
        private static HomePage _instance;
        public static HomePage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HomePage();
                }
                return _instance;
            }
        }
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnSystem36_Click(object sender, EventArgs e)
        {
            var control = System36.Instance;
            CallParentLoadControl(control);
        }
        private void CallParentLoadControl(UserControl control)
        {
            var parent = (MainForm)this.Parent.Parent;
            parent.LoadControl(control);
        }

        private void btnHandicup_Click(object sender, EventArgs e)
        {
            var control = Handicap.Instance;
            CallParentLoadControl(control);
        }

        private void btnOldPeoria_Click(object sender, EventArgs e)
        {
            var control = OldPeoria.Instance;
            CallParentLoadControl(control);
        }

        private void btnNewPeoria_Click(object sender, EventArgs e)
        {
            var control = Peoria.Instance;
            CallParentLoadControl(control);
        }
    }
}
