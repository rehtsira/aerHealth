using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aerHealth
{
    public partial class Splash : Form
    {
    

        public Splash()
        {
            InitializeComponent();
            threadTime.Start();
            threadTime.Interval = 40;
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
        int i = 0;
        private void threadTimeTicker(object sender, EventArgs e)
        {
           
            i++;
            progressBar.Value = i;
            if (progressBar.Value <= 10)
            {
                progressBar.ForeColor = Color.FromArgb(203, 51, 59);
            }
            else if (progressBar.Value <= 20)
            {
                progressBar.ForeColor = Color.White;
            }

            else if (progressBar.Value <= 30)
            {
                progressBar.ForeColor = Color.FromArgb(203, 51, 59);
            }

            else if (progressBar.Value <= 40)
            {
                progressBar.ForeColor = Color.White;
            }
            else if (progressBar.Value <= 50)
            {
                progressBar.ForeColor = Color.FromArgb(203, 51, 59);
            }
            else if (progressBar.Value <= 60)
            {
                progressBar.ForeColor = Color.White;
            }
            else if (progressBar.Value <= 70)
            {
                progressBar.ForeColor = Color.FromArgb(203, 51, 59);
            }
            else if (progressBar.Value <= 80)
            {
                progressBar.ForeColor = Color.White;
            }
            else if (progressBar.Value <= 90)
            {
                progressBar.ForeColor = Color.FromArgb(203, 51, 59);
            }
            else
            {
                progressBar.ForeColor = Color.White;
            }
            if (progressBar.Value == 100)
            {
                threadTime.Stop();
                this.Close();
            }
        }
    }
}
