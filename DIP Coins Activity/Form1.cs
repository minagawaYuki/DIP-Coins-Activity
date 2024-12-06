using Coins_Activity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIP_Coins_Activity
{
    public partial class Form1 : Form
    {
        Bitmap loaded;
        Bitmap processed;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loaded = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = loaded;
            }
        }

        private void countToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;

            Coins.Binary(loaded, ref processed);
            pictureBox2.Image = processed;

            float totalValue = 0;
            int totalCount = 0, peso5Count = 0, peso1Count = 0, cent25Count = 0, cent10Count = 0, cent5Count = 0;
            Coins.GetCoinPixels(
                processed,
                ref totalCount,
                ref totalValue,
                ref peso5Count,
                ref peso1Count,
                ref cent25Count,
                ref cent10Count,
                ref cent5Count
            );

            TotalCoinCount.Text = totalCount.ToString();
            Peso5Count.Text = peso5Count.ToString();
            Peso1Count.Text = peso1Count.ToString();
            Cent25Count.Text = cent25Count.ToString();
            Cent10Count.Text = cent10Count.ToString();
            Cent5Count.Text = cent5Count.ToString();
            TotalValue.Text = Math.Round(totalValue, 2).ToString();
        }

    }
}
