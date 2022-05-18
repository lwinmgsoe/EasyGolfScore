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
    public partial class ScroeTable : UserControl
    {
        public ScroeTable()
        {
            InitializeComponent();
        }
        public void DrawTable(int col, int row)
        {
            //dgStroke.Rows.Clear();
            //dgStroke.Refresh();
            dgStroke.ColumnCount = col + 5 + 1 + 1;
            dgStroke.RowCount = row;
            for (int i = 0; i < col + 5 + 1 + 1; i++)
            {
                if (i == 0)
                {
                    dgStroke.Columns[i].HeaderText = "No.";
                    dgStroke.Columns[i].Width = 50;
                }
                else if (i == 1)
                {
                    dgStroke.Columns[i].HeaderText = "Name";
                    dgStroke.Columns[i].Width = 150;
                    dgStroke.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else if (i == col + 2)
                {
                    dgStroke.Columns[i].HeaderText = "T. Score";
                    //dgStroke.Columns[i].Width = 50;
                }
                else if (i == col + 3)
                {
                    dgStroke.Columns[i].HeaderText = "T.Marks";
                    //dgStroke.Columns[i].Width = 50;
                }
                else if (i == col + 4)
                {
                    dgStroke.Columns[i].HeaderText = "H/S";
                    //dgStroke.Columns[i].Width = 50;
                }
                else if (i == col + 5)
                {
                    dgStroke.Columns[i].HeaderText = "N. Score";
                    //dgStroke.Columns[i].Width = 50;
                }
                else if (i == col + 6)
                {
                    dgStroke.Columns[i].HeaderText = "+/-";
                }
                else
                {
                    dgStroke.Columns[i].HeaderText = (i - 1).ToString();
                    dgStroke.Columns[i].Width = 50;
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
