using EasyGolfScore.Helpers;
using OfficeOpenXml;
using OfficeOpenXml.Style;
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
    public partial class Handicap : UserControl
    {
        private static Handicap _instance;
        public static Handicap Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Handicap();
                }
                return _instance;
            }
        }
        public Handicap()
        {
            InitializeComponent();
            
        }
        void fillName(int row)
        {
            for (int i = 0; i < row; i++)
            {
                dgStroke[1, i].Value = RandomString(10);
            }
        }
        public string RandomString(int size, bool lowerCase = false)
        {
            var _random = new Random();
            var builder = new StringBuilder(size);

            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.  

            // char is a single Unicode character  
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }
        void testData(int col, int row)
        {
            var random = new Random();

            for (int i = 0; i < row; i++)
            {
                var total = 0;
                dgStroke[0, i].Value = i + 1;
                for (int j = 1; j <= col; j++)
                {
                    var stroke = random.Next(2, 9);
                    dgStroke[j + 1, i].Value = stroke;
                    total = total + stroke;

                }
                dgStroke[col + 2, i].Value = total;
                dgStroke[col + 3, i].Value = random.Next(2,24);
            }
        }
        private void DrawTable(int col, int row)
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
                    dgStroke.Columns[i].HeaderText = "H/S";
                    //dgStroke.Columns[i].Width = 50;
                }
                else if (i == col + 4)
                {
                    dgStroke.Columns[i].HeaderText = "T.Marks";
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
        void clearBackGround()
        {
            for (int i = 0; i < dgStroke.Rows.Count; i++)
            {
                for (int j = 0; j < dgStroke.Columns.Count; j++)
                {
                    dgStroke.Rows[i].Cells[j].Style.BackColor = Color.White;
                    dgStroke.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                }
            }
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            var row = int.Parse(txtPlayerNo.Text);
            var col = standardHoleAndStrokes.GetHoleCount();
            clearBackGround();
            testData(col, row);
            fillName(row);
        }

        private void Hanicap_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                var holeNo = standardHoleAndStrokes.GetHoleCount();
                var playerNo = int.Parse(txtPlayerNo.Text);
                DrawTable(holeNo, playerNo);
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calculateMark();
        }
        private CellColor getCellColor(string name)
        {
            var morepar = "Birdie,Hole-in-One,Eagle,Albatross".Split(',').ToList();
            if (name == "Par")
            {
                return new CellColor()
                {
                    Back = Color.Green,
                    Fore = Color.White
                };
            }
            if (name == "Bogey")
            {
                return new CellColor()
                {
                    Back = Color.SkyBlue,
                    Fore = Color.White
                };
            }

            if (morepar.Contains(name))
            {
                return new CellColor()
                {
                    Back = Color.Yellow,
                    Fore = Color.Black
                };
            }


            return new CellColor()
            {
                Back = Color.White,
                Fore = Color.Black
            };
        }
        
        private void calculateMark()
        {
            var standards = standardHoleAndStrokes.GetStandardMarks();
            var lst = new List<myGolfMark>();
            var gm = new myGolfMark();
            var colcount = dgStroke.ColumnCount;
            var rowcount = dgStroke.RowCount;
            var numOfHoles = standardHoleAndStrokes.GetHoleCount();
            var stdStroke = standardHoleAndStrokes.GetStandardScroe();
            for (int j = 0; j < rowcount; j++)
            {
                var um = new UserAndMark();
                var mTotal = 0;
                var sTotal = 0;
                for (int i = 2; i < numOfHoles + 2; i++)
                {
                    dgStroke.Rows[j].Cells[i].Style.BackColor = Color.White;
                    dgStroke.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                    //var _std = dgRecord.Columns[i]
                    var std = standards[i - 2].Stroke;
                    var val = dgStroke[i, j].Value == null ? 0 : int.Parse(dgStroke[i, j].Value.ToString());
                    var res = gm.getMark(std, val);
                    //MessageBox.Show(res.Mark.ToString() + " N= " + res.StrokeName);
                    var cellcolor = getCellColor(res.StrokeName);

                    dgStroke.Rows[j].Cells[i].Style.BackColor = cellcolor.Back;
                    dgStroke.Rows[j].Cells[i].Style.ForeColor = cellcolor.Fore;
                    sTotal = sTotal + val;
                    mTotal = res.Mark + mTotal;
                    um.Marks.Add(res);
                }
                um.Name = dgStroke[0, j].Value.ToString();
                um.TotalMark = mTotal;


                var Handi = int.Parse(dgStroke[colcount -4, j].Value.ToString());
                var Net = sTotal - Handi;
                dgStroke[colcount - 3, j].Value = um.TotalMark;
                //dgStroke[colcount - 3, j].Value = Handi;
                dgStroke[colcount - 2, j].Value = Net;
                var diff = (Net - stdStroke);
                var strDiff = "0";
                if (diff > 0)
                {
                    strDiff = string.Format("+{0}", diff);
                }
                else if (diff < 0)
                {
                    strDiff = string.Format("{0}", diff);
                }
                else
                {
                    strDiff = "0";
                }
                dgStroke[colcount - 1, j].Value = strDiff;
                var str = string.Format("Name={3}, Total Mark={0}, Handi={1}, Net={2}", um.TotalMark, um.Handi, um.Net, um.Name);
                //MessageBox.Show(str);
            }

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            calculateMarkSort();
        }
        private void calculateMarkSort()
        {
            var standards = standardHoleAndStrokes.GetStandardMarks();
            var lstSortMarks = new List<SortMarks>();
            var column = dgStroke.Columns.Count;
            var row = dgStroke.Rows.Count;
            var numOfHoles = standardHoleAndStrokes.GetHoleCount();
            for (int i = 0; i < row; i++)
            {
                var sm = new SortMarks();
                sm.Name = dgStroke[1, i].Value.ToString();
                sm.TotalScore = int.Parse(dgStroke[column - 5, i].Value.ToString());
                sm.TotalMark = int.Parse(dgStroke[column - 3, i].Value.ToString());
                sm.HS = int.Parse(dgStroke[column - 4, i].Value.ToString());
                sm.NetMark = int.Parse(dgStroke[column - 2, i].Value.ToString());
                sm.Diff = dgStroke[column - 1, i].Value.ToString();
                for (int j = 2; j < numOfHoles + 2; j++)
                {
                    var ss = int.Parse(dgStroke[j, i].Value.ToString());
                    sm.Strokes.Add(ss);
                }
                lstSortMarks.Add(sm);
            }
            lstSortMarks = lstSortMarks.OrderBy(x => x.NetMark).ThenBy(x => x.HS).ToList();
            var gm = new myGolfMark();
            for (int i = 0; i < row; i++)
            {
                dgStroke[1, i].Value = lstSortMarks[i].Name;
                dgStroke[column - 1, i].Value = lstSortMarks[i].Diff;
                dgStroke[column - 2, i].Value = lstSortMarks[i].NetMark;
                dgStroke[column - 4, i].Value = lstSortMarks[i].HS;
                dgStroke[column - 3, i].Value = lstSortMarks[i].TotalMark;
                dgStroke[column - 5, i].Value = lstSortMarks[i].TotalScore;
                for (int j = 2; j < numOfHoles + 2; j++)
                {
                    dgStroke[j, i].Value = lstSortMarks[i].Strokes[j - 2];
                    //cell color
                    dgStroke.Rows[i].Cells[j].Style.BackColor = Color.White;
                    dgStroke.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    //var _std = dgRecord.Columns[i]
                    var std = standards[j - 2].Stroke;
                    var val = dgStroke[j, i].Value == null ? 0 : int.Parse(dgStroke[j, i].Value.ToString());
                    var res = gm.getMark(std, val);
                    //MessageBox.Show(res.Mark.ToString() + " N= " + res.StrokeName);
                    var cellcolor = getCellColor(res.StrokeName);

                    dgStroke.Rows[i].Cells[j].Style.BackColor = cellcolor.Back;
                    dgStroke.Rows[i].Cells[j].Style.ForeColor = cellcolor.Fore;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var pk = new ExcelPackage())
            {
                var holes = standardHoleAndStrokes.GetHoleCount();
                var sheet = pk.Workbook.Worksheets.Add("Golf Mark");
                sheet.Row(1).Height = 20;
                var col = dgStroke.ColumnCount;
                sheet.Cells[1, 1, 1, col].Merge = true;
                sheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                sheet.Cells[1, 1].Value = "Golf Marks by Handicap";
                sheet.Cells[2, 1].Value = "No.";
                sheet.Cells[2, 2].Value = "Name";
                for (int i = 3; i < holes + 3; i++)
                {
                    sheet.Cells[2, i].Value = i - 2;
                }
                sheet.Cells[2, holes + 3].Value = "Total Scores";
                sheet.Cells[2, holes + 4].Value = "H/S";
                sheet.Cells[2, holes + 5].Value = "Total Marks";                
                sheet.Cells[2, holes + 6].Value = "Net Score";
                sheet.Cells[2, holes + 7].Value = "+/-";
                var dlg = new SaveFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var file = new FileInfo(dlg.FileName + ".xlsx");
                    var _data = getGridData();
                    for (int i = 0; i < _data.Count; i++)
                    {
                        var _row = _data[i];
                        for (var j = 0; j < _data[0].Count; j++)
                        {
                            sheet.Cells[i + 3, j + 1].Value = _row[j].Value;

                            if (_row[j].Back.Name == "0")
                            {
                                sheet.Cells[i + 3, j + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                sheet.Cells[i + 3, j + 1].Style.Fill.BackgroundColor.SetColor(Color.Transparent);
                                sheet.Cells[i + 3, j + 1].Style.Font.Color.SetColor(Color.Black);
                            }
                            else
                            {
                                sheet.Cells[i + 3, j + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                sheet.Cells[i + 3, j + 1].Style.Fill.BackgroundColor.SetColor(_row[j].Back);
                                sheet.Cells[i + 3, j + 1].Style.Font.Color.SetColor(_row[j].Fore);
                            }

                        }
                    }
                    pk.SaveAs(file);
                    MessageBox.Show("File is exported.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        private List<List<GridCellData>> getGridData()
        {
            var lst = new List<List<GridCellData>>();
            for (int i = 0; i < dgStroke.RowCount; i++)
            {
                var sublst = new List<GridCellData>();
                for (var j = 0; j < dgStroke.ColumnCount; j++)
                {
                    var val = dgStroke[j, i].Value.ToString();
                    var _back = dgStroke.Rows[i].Cells[j].Style.BackColor;
                    var _fore = dgStroke.Rows[i].Cells[j].Style.ForeColor;
                    var _cell = new GridCellData()
                    {
                        Back = _back,
                        Fore = _fore,
                        Value = val
                    };
                    sublst.Add(_cell);
                }
                lst.Add(sublst);
            }
            return lst;
        }
        int selectedRowIndex = -1;
        private void dgStroke_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //handle the row selection on right click
            if (e.Button == MouseButtons.Right)
            {
                //MessageBox.Show("Ok");
                try
                {
                    dgStroke.CurrentCell = dgStroke.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    // Can leave these here - doesn't hurt
                    dgStroke.Rows[e.RowIndex].Selected = true;
                    dgStroke.Focus();
                    selectedRowIndex = e.RowIndex;
                }
                catch (Exception)
                {

                }
            }
        }
        void refreshId()
        {
            for (int i = 0; i < dgStroke.Rows.Count; i++)
            {
                dgStroke[0, i].Value = i + 1;
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                dgStroke.Rows.RemoveAt(selectedRowIndex);
                txtPlayerNo.Text = dgStroke.Rows.Count.ToString();
                refreshId();
            }
            else
            {
                MessageBox.Show("Please, select any row.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void dgStroke_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dgStroke_SelectionChanged(object sender, EventArgs e)
        {
            bool flag = dgStroke.CurrentRow.Selected;

            if (flag)
            {
                selectedRowIndex = dgStroke.SelectedRows[0].Index;

            }
            else
            {
                /// no  row is selected or last empty row is selected
                selectedRowIndex = -1;
            }
        }


        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgStroke.Rows.Clear();
            dgStroke.Refresh();
            txtPlayerNo.Text = "";
        }

        private void newGameScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgStroke.Rows.Clear();
            dgStroke.Refresh();
            txtPlayerNo.Text = 5.ToString();
            if (string.IsNullOrEmpty(txtPlayerNo.Text)) return;

            var col = standardHoleAndStrokes.GetHoleCount();
            var row = int.Parse(txtPlayerNo.Text);
            DrawTable(col, row);
        }



        class SortMarks
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<int> Strokes { get; set; }
            public int TotalScore { get; set; }
            public int TotalMark { get; set; }
            public int HS { get; set; }
            public int NetMark { get; set; }
            public string Diff { get; set; }
            public SortMarks()
            {
                Strokes = new List<int>();
            }
        }

        private void addNewRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgStroke.Rows.Add();
            txtPlayerNo.Text = dgStroke.Rows.Count.ToString();
        }

        private void txtPlayerNo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlayerNo.Text)) return;

            var col = standardHoleAndStrokes.GetHoleCount();
            var row = int.Parse(txtPlayerNo.Text);
            DrawTable(col, row);
        }
        private void dgStroke_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var col = e.ColumnIndex;
            var row = e.RowIndex;
            var colcount = dgStroke.ColumnCount;
            var total_column = colcount - 5;
            if (col < total_column && col >= 1)
            {
                var total = 0;
                for (int i = 1; i < total_column; i++)
                {
                    int stroke = 0;
                    if (dgStroke[i, row].Value == null) continue;
                    var tmp = dgStroke[i, row].Value.ToString();
                    if (!int.TryParse(tmp, out stroke)) continue;
                    var val = dgStroke[i, row].Value == null ? 0 : int.Parse(dgStroke[i, row].Value.ToString());
                    total = total + val;
                }
                dgStroke[total_column, row].Value = total;
            }
        }

        private void dgStroke_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                gridMenu.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
    }
}
