using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEMORY_PUZZLES
{
    public static class Controller
    {
        public static void Restart()
        {
            Model.Restart();
        }
        public static void LabelClick(object sender, EventArgs e)
        {
            Model.LabelClick(sender, e);
        }
        public static void TimerTick(object sender, EventArgs e)
        {
            Model.TimerTick(sender, e);
        }
        public static void AssignsIconsSquares(TableLayoutPanel table)
        {
            Model.AssignsIconsSquares(table);
        }
    }
}
