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
                label = (Label)tableLayoutPanel1.Controls[i];
                randomnumber = Appearance.random.Next(0, Appearance.icons.Count);
                label.Text = Appearance.icons[randomnumber];
                Appearance.icons.RemoveAt(randomnumber);
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {

                for (int i = 0; i < Appearance.icons2.Count; i++)
                {
                    Appearance.icons.Add(Appearance.icons2[i]);
                }
                Label label;
                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                {
                    label = tableLayoutPanel1.Controls[i] as Label;
                    label.ForeColor = label.BackColor;
                }
                AssignsIconsSquares();
            }
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
