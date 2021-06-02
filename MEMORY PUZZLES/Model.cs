using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MEMORY_PUZZLES
{
    public class Model
    {
        public static Random random = new Random();//model
        public static readonly List<string> icons = new List<string>()//мб вью
{
"!", "!", "$", "$", "o", "o", "%", "%","f", "f", ".", ".","t", "t", "m", "m"
};
        public static readonly List<string> icons2 = new List<string>()
{
"!", "!", "$", "$", "o", "o", "%", "%","f", "f", ".", ".","t", "t", "m", "m"
};

        public static Label firstClicked, secondClicked;//вью

        public static void AssignsIconsSquares(TableLayoutPanel table)//вью и модел#
        {
            Label label;
            int randomnumber;
            for (int i = 0; i < table.Controls.Count; i++)
            {
                label = (Label)table.Controls[i];
                randomnumber = random.Next(0, icons.Count);
                label.Text = icons[randomnumber];
                icons.RemoveAt(randomnumber);
            }
        }


        public static void Restart()
        {
            for (int i = 0; i < icons2.Count; i++)
            {
                icons.Add(icons2[i]);
            }
            Label label;
            for (int i = 0; i < Data.tableLayoutPanel.Controls.Count; i++)
            {
                label = Data.tableLayoutPanel.Controls[i] as Label;
                label.ForeColor = label.BackColor;
            }
            AssignsIconsSquares(Data.tableLayoutPanel);
        }


        public static void CheckForWinner()//model#
        {
            Label label;
            for (int i = 0; i < Data.tableLayoutPanel.Controls.Count; i++)
            {
                label = Data.tableLayoutPanel.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                    return;


            }
            Form1.WinMessage();
        }

        public static void LabelClick(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel == null)
                return;

            if (clickedLabel.ForeColor == Color.MistyRose)
                return;

            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.MistyRose;
                return;
            }

            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.MistyRose;

            CheckForWinner();

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
                Tick.timer.Start();
        }

        public static void TimerTick(object sender, EventArgs e)
        {
            Tick.timer.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }
    }
}
