using EasyGolfScore.Helpers;
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
    public partial class StandardHoleAndStrokes : UserControl
    {
        public StandardHoleAndStrokes()
        {
            InitializeComponent();
        }
        public string GetTitle()
        {
            return "Standard Holes and Strokes";
        }
        public List<MarkRule> GetStandardMarks()
        {
            return MarkRules();
        }
        private List<MarkRule> MarkRules()
        {
            List<MarkRule> markRules = new List<MarkRule>();
            for(int i=1; i< dgRecord.ColumnCount-1; i++)
            {
                markRules.Add(new MarkRule()
                {
                    HoleNo = i.ToString(),
                    Stroke = int.Parse(dgRecord[i, 1].Value.ToString())
                });
            }
            return markRules;
        }
        public int GetStandardScroe()
        {
            int NofHoles = int.Parse(txtHoleNumber.Text);
            return int.Parse(dgRecord[NofHoles+1,1].Value.ToString());
        }
        public int GetHoleCount()
        {
            return string.IsNullOrEmpty(txtHoleNumber.Text) ? 0 : int.Parse(txtHoleNumber.Text);
        }
        //helper methods
        void DrawTable(int col, bool isInitial = false)
        {
            dgRecord.RowCount = 2;
            dgRecord.ColumnCount = col + 2;
            //dgRes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //gridView1.s
            var pars = GolfStandard.getHoleAndStroke();
            var totalStroke = 0;
            for (int i = 0; i < col + 1; i++)
            {
                if (i == 0)
                {
                    dgRecord.Columns[i].Width = 150;
                    dgRecord[i, 0].Value = "ကျင်းအမှတ်";
                    dgRecord[i, 1].Value = "သတ်မှတ်ရိုက်ချက်";
                    //dgRecord[i, 2].Value = "ရိုက်ချက်";
                    continue;
                }
                else
                {
                    dgRecord.Columns[i].Width = 50;
                    dgRecord[i, 0].ReadOnly = true;
                    dgRecord[i, 0].Value = i;
                    if (isInitial && col <= 18)
                    {
                        if (pars[i - 1].HoleNo == i.ToString())
                        {
                            dgRecord[i, 1].Value = pars[i - 1].Stroke;
                            totalStroke = totalStroke + pars[i - 1].Stroke;
                        }
                    }
                }

            }
            dgRecord[col + 1, 0].Value = "စုစုပေါင်းရိုက်ချက်";
            dgRecord[col + 1, 0].ReadOnly = true;
            dgRecord[col + 1, 1].Value = totalStroke;
            dgRecord.Columns[col + 1].MinimumWidth = 150;
            dgRecord.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgRecord.CurrentCell = dgRecord.Rows[1].Cells[col + 1];
        }
        //
        public List<MarkRule> GetSelectedCells()
        {
            List<MarkRule> selected = new List<MarkRule>();
            var selectedCellCount = dgRecord.GetCellCount(DataGridViewElementStates.Selected);
            if(selectedCellCount > 0)
            {
                for(int i = 0; i < selectedCellCount; i++)
                {
                    var selectedCell = dgRecord.SelectedCells[i];
                    if(selectedCell.RowIndex == 0 && selectedCell.ColumnIndex < dgRecord.ColumnCount - 1)
                    {
                        selected.Add(new MarkRule()
                        {
                            HoleNo = selectedCell.Value.ToString(),
                            Stroke = int.Parse(dgRecord[selectedCell.ColumnIndex, 1].Value.ToString())
                        });
                    }
                }
            }
            return selected;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void StandardHoleAndStrokes_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                int col = int.Parse(txtHoleNumber.Text);
                DrawTable(col, true);
            }
            
        }
        private void dgRecord_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var col = e.ColumnIndex;
            var row = e.RowIndex;
            var colcount = dgRecord.ColumnCount;
            var total_column = colcount - 1;
            if (col < total_column && col >= 1)
            {
                var total = 0;
                for (int i = 1; i < total_column; i++)
                {
                    int stroke = 0;
                    if (dgRecord[i, row].Value == null) continue;
                    var tmp = dgRecord[i, row].Value.ToString();
                    if (!int.TryParse(tmp, out stroke)) continue;
                    var val = dgRecord[i, row].Value == null ? 0 : int.Parse(dgRecord[i, row].Value.ToString());
                    total = total + val;
                }
                dgRecord[total_column, row].Value = total;
            }
        }

        private void txtHoleNumber_TextChanged(object sender, EventArgs e)
        {
            var holes = int.Parse(txtHoleNumber.Text);
            DrawTable(holes, true);
        }
    }
}
