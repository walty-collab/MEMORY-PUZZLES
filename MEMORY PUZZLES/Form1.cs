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
    public partial class Form1 : Form// цвет Misty rose
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "$", "$", "o", "o", "%", "%","f", "f", ".", ".","t", "t", "m", "m"
        };

        Label firstClicked, secondClicked;
       
        public Form1()
        {

            InitializeComponent();
           
            AssignsIconsSquares();
        }    
        public void AssignsIconsSquares()
        {
            Label label;
            int randomnumber;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else
                    continue;                
                randomnumber = random.Next(0,icons.Count);
                label.Text = icons[randomnumber];
                icons.RemoveAt(randomnumber);
            }
        }


        private void label_Click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel == null)
                return;

            if (clickedLabel.ForeColor == Color.MistyRose)
                return;

            if(firstClicked == null)
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
            timer1.Start();


            
        }

        private void CheckForWinner()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                    return;


            }

            MessageBox.Show("   ПОЗДРАВЛЯЮ ВЫ ПРОШЛИ НАШУ НЕВЕРОЯТНО ТРУДНУЮ ИГРУ!!!!!!");
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;

        }

        
     
    }
}
