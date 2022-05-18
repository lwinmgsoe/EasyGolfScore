using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGolfScore.Helpers
{
    class CellColor
    {
        public Color Back { get; set; }
        public Color Fore { get; set; }
    }
    public class GridCellData
    {
        public Color Back { get; set; }
        public Color Fore { get; set; }
        public string Value { get; set; }
    }
    class UserAndMark
    {
        public string Name { get; set; }
        public int Handi { get; set; }
        public int Net { get; set; }
        public int TotalMark { get; set; }
        public List<StrokeAndMark> Marks { get; set; }
        public UserAndMark()
        {
            this.Marks = new List<StrokeAndMark>();
        }
    }
    public class MarkRule
    {
        public string HoleNo { get; set; }
        public int Stroke { get; set; }
    }
    public static class GolfStandard
    {
        public static List<MarkRule> getHoleAndStroke()
        {
            var lst = new List<MarkRule>()
            {
                new MarkRule(){HoleNo="1", Stroke=4},
                new MarkRule(){HoleNo="2", Stroke=4},
                new MarkRule(){HoleNo="3", Stroke=5},
                new MarkRule(){HoleNo="4", Stroke=4},
                new MarkRule(){HoleNo="5", Stroke=5},
                new MarkRule(){HoleNo="6", Stroke=3},
                new MarkRule(){HoleNo="7", Stroke=4},
                new MarkRule(){HoleNo="8", Stroke=3},
                new MarkRule(){HoleNo="9", Stroke=4},
                new MarkRule(){HoleNo="10", Stroke=5},
                new MarkRule(){HoleNo="11", Stroke=4},
                new MarkRule(){HoleNo="12", Stroke=3},
                new MarkRule(){HoleNo="13", Stroke=4},
                new MarkRule(){HoleNo="14", Stroke=4},
                new MarkRule(){HoleNo="15", Stroke=4},
                new MarkRule(){HoleNo="16", Stroke=3},
                new MarkRule(){HoleNo="17", Stroke=4},
                new MarkRule(){HoleNo="18", Stroke=5},
            };
            return lst;
        }
    }
    public class myGolfMark
    {
        public StrokeAndMark getMark(int std, int cur)
        {
            var res = new StrokeAndMark();
            var sm = res.getStrokeAndMark(std);
            var oo = cur - std;
            //System.Windows.Forms.MessageBox.Show(oo.ToString());
            var val = new StrokeAndMark();
            if (oo >= 2)
            {
                val.StrokeName = "Double Bogey နှင့်အထက်";
                val.Mark = 0;
                val.MinusStroke = oo;
            }
            else if (oo <= -4)
            {
                val.StrokeName = "Albatross";
                val.Mark = 2;
                val.MinusStroke = oo;
            }

            else
            {
                //System.Windows.Forms.MessageBox.Show(oo.ToString());
                val = sm.Where(x => x.MinusStroke.ToString() == oo.ToString()).FirstOrDefault();
            }
            return val;

        }
    }
    public class StrokeAndMark
    {
        public string StrokeName { get; set; }
        public int Mark { get; set; }
        public int MinusStroke { get; set; }
        public List<StrokeAndMark> getStrokeAndMark(int std)
        {
            var lst = new List<StrokeAndMark>()
            {
                new StrokeAndMark(){StrokeName="Albatross", Mark=2, MinusStroke=-3},
                new StrokeAndMark(){StrokeName="Eagle", Mark=2, MinusStroke=-2},
                new StrokeAndMark(){StrokeName="Birdie", Mark=2, MinusStroke=-1},
                new StrokeAndMark(){StrokeName="Par", Mark=2, MinusStroke=0},
                new StrokeAndMark(){StrokeName="Bogey", Mark=1, MinusStroke=1},
                new StrokeAndMark(){StrokeName="Double Bogey", Mark=0, MinusStroke=2},
            };
            var lst2 = new List<StrokeAndMark>()
            {

                new StrokeAndMark(){StrokeName="Hole-in-One", Mark=2, MinusStroke=-2},
                new StrokeAndMark(){StrokeName="Birdie", Mark=2, MinusStroke=-1},
                new StrokeAndMark(){StrokeName="Par", Mark=2, MinusStroke=0},
                new StrokeAndMark(){StrokeName="Bogey", Mark=1, MinusStroke=1},
                new StrokeAndMark(){StrokeName="Double Bogey", Mark=0, MinusStroke=2},
            };
            if (std <= 3)
            {
                return lst2;
            }
            else
            {
                return lst;
            }
            //return lst;
        }
    }

    public class ParAndBirdie
    {
        public string Name { get; set; }
        public int Pars { get; set; }
        public int Birdies { get; set; }
        public int Eagles { get; set; }
        public int HoleInOne { get; set; }
        public int NetScroe { get; set; }
        public int Boegies { get; set; }
        public int Others { get; set; }
    }
}
