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
    public partial class Form1 : Form
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

        private void label1_Click(object sender, EventArgs e)
        {
            Label clicedLabel = sender as Label;
            clicedLabel.ForeColor = Color.MistyRose;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Label clicedLabel = sender as Label;
            clicedLabel.ForeColor = Color.MistyRose;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Label clicedLabel = sender as Label;
            clicedLabel.ForeColor = Color.MistyRose;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Label clicedLabel = sender as Label;
            clicedLabel.ForeColor = Color.MistyRose;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Label clicedLabel = sender as Label;
            clicedLabel.ForeColor = Color.MistyRose;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Label clicedLabel = sender as Label;
            clicedLabel.ForeColor = Color.MistyRose;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Label clicedLabel = sender as Label;
            clicedLabel.ForeColor = Color.MistyRose;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Label clicedLabel = sender as Label;
            clicedLabel.ForeColor = Color.MistyRose;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Label clicedLabel = sender as Label;
            clicedLabel.ForeColor = Color.MistyRose;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Label clicedLabel = sender as Label;
            clicedLabel.ForeColor = Color.MistyRose;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Label clicedLabel = sender as Label;
            clicedLabel.ForeColor = Color.MistyRose;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Label clicedLabel = sender as Label;
            clicedLabel.ForeColor = Color.MistyRose;
        }
        private void label13_Click(object sender, EventArgs e)
        {
            Label clicedLabel = sender as Label;
            clicedLabel.ForeColor = Color.MistyRose;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Label clicedLabel = sender as Label;
            clicedLabel.ForeColor = Color.MistyRose;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Label clicedLabel = sender as Label;
            clicedLabel.ForeColor = Color.MistyRose;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Label clicedLabel = sender as Label;
            clicedLabel.ForeColor = Color.MistyRose;
        } 
     
    }
}
