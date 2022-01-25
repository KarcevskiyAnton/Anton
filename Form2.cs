using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AccessDataBaseDemo
{
    public partial class Form2 : Form
    {
        
        public static string c = "select postavsh,datadog,nomerdog,contactlico from postovsh";
        
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=practica.mdb;";
        public OleDbConnection myConnection;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(c, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "postovsh");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(c, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "postovsh");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = ("INSERT INTO postovsh ( postavsh,datadog,nomerdog,contactlico) VALUES (@S,@I,@U,@P)");


            OleDbCommand command = new OleDbCommand(query, myConnection);



            command.Parameters.AddWithValue("@S", textBox1.Text);

            command.Parameters.AddWithValue("@I", textBox2.Text);
            command.Parameters.AddWithValue("@U", textBox4.Text);
            command.Parameters.AddWithValue("@P", textBox5.Text);
            
            
            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено успешно");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "UPDATE dataproh SET result='" + textBox1.Text + "' WHERE id=" + Convert.ToInt32(textBox3.Text);
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();




            MessageBox.Show("Запись успешно изменена");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = ("DELETE FROM postovsh  WHERE id = @I ");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@I", Convert.ToInt32(textBox3.Text));



            command.ExecuteNonQuery();
            MessageBox.Show(" Удалено успешно");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 f1 = new Form5();
            f1.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 f7 = new Form6();
            f7.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            string query = ("SELECT postavsh,datadog,nomerdog,contactlico FROM postovsh WHERE postavsh LIKE '%" + textBox1.Text + "%'");
            

            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "postovsh");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
           
            
           
            command.ExecuteNonQuery();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string query = ("SELECT postavsh,datadog,nomerdog,contactlico FROM postovsh WHERE datadog LIKE '%" + textBox2.Text + "%'");

            
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "postovsh");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string query = ("SELECT* FROM dataproh WHERE id LIKE '%" + Convert.ToInt32(textBox3.Text) + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "dataproh");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();

        }

        private void базыДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void автомобильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();

        }

        private void владелецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f1 = new Form5();
            f1.Show();
            this.Hide();
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f7 = new Form6();
            f7.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 f7 = new Form9();
            f7.Show();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string query = ("SELECT postavsh,datadog,nomerdog,contactlico FROM postovsh WHERE nomerdog LIKE '%" + textBox5.Text + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "postovsh");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string query = ("SELECT postavsh,datadog,nomerdog,contactlico FROM postovsh WHERE contactlico LIKE '%" + textBox4.Text + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "postovsh");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
