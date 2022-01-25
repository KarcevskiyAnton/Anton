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
    public partial class Form9 : Form
    {
        public static string c = "select Fio,  vozrast, datapostupl,adress from Director";

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=practica.mdb;";
        public OleDbConnection myConnection;
        
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(c, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Director");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(c, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Director");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = ("INSERT INTO Director (Fio,  vozrast, datapostupl,adress) VALUES (@F,@S,@t,@l)");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@F", textBox1.Text);

            command.Parameters.AddWithValue("@S", textBox2.Text);
            command.Parameters.AddWithValue("@t", textBox3.Text);
            command.Parameters.AddWithValue("@l", textBox4.Text);
            





            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено успешно");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = ("DELETE FROM Director  WHERE  id= @I ");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@I", Convert.ToInt32(textBox5.Text));



            command.ExecuteNonQuery();
            MessageBox.Show(" Удалено успешно");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string query = ("SELECT Fio,  vozrast, datapostupl,adress FROM Director  WHERE Fio LIKE '%" + textBox1.Text + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Director");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string query = ("SELECT Fio,  vozrast, datapostupl,adress FROM Director  WHERE vozrast LIKE '%" + textBox2.Text + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Director");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string query = ("SELECT Fio,  vozrast, datapostupl,adress FROM Director  WHERE datapostupl LIKE '%" + textBox3.Text + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Director");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string query = ("SELECT Fio,  vozrast, datapostupl,adress FROM Director  WHERE adress LIKE '%" + textBox4.Text + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Director");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 f7 = new Form9();
            f7.Show();
        }
    }
}
