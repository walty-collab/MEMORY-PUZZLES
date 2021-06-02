using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MEMORY_PUZZLES
{
    public partial class Form1 : Form // цвет - Misty rose
    {

        public Form1()
        {

            InitializeComponent();
            Data.tableLayoutPanel = tableLayoutPanel1;
            AssignsIconsSquares(tableLayoutPanel1);
            Tick.timer = timer1;
        }
        public void AssignsIconsSquares(TableLayoutPanel table)
        {
            Controller.AssignsIconsSquares(table);
        }


        private void label_Click(object sender, EventArgs e)
        {
            Controller.LabelClick(sender, e);
        }

        public static void WinMessage()
        {
            MessageBox.Show(" ПОЗДРАВЛЯЮ ВЫ ПРОШЛИ НАШУ НЕВЕРОЯТНО ТРУДНУЮ ИГРУ!!!!!!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Controller.TimerTick(sender, e);
        }

    }
    public static class Data
    {
        public static TableLayoutPanel tableLayoutPanel { get; set; }
    }

    public static class Tick
    {
        public static Timer timer { get; set; }


    }
}
