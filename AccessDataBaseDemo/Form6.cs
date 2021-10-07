using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AccessDataBaseDemo
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\vladelec4.docx");
        }

        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
