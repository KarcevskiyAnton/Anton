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
    public partial class Form3 : Form
    {
        public static string c = "select data, fio, dolzn, spetsialn from sotrudniki";

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=practica.mdb;";
        public OleDbConnection myConnection;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(c, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "sotrud");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(c, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "sotrudniki");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            label1.Text = "ID:";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = ("INSERT INTO sotrud ( fio,  dol, razryad,id) VALUES (@F,@S,@t,@I)");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@F", textBox1.Text);

            command.Parameters.AddWithValue("@S", textBox2.Text);
            command.Parameters.AddWithValue("@t", textBox3.Text);
            command.Parameters.AddWithValue("@I", Convert.ToInt32(textBox4.Text));




            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено успешно");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = ("DELETE FROM sotrudniki  WHERE id = @I ");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@I", Convert.ToInt32(textBox1.Text));



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
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            string query = ("SELECT data, fio, dolzn, spetsialn FROM sotrudniki WHERE dolzn LIKE '%" + textBox1.Text + "%'");


            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "sotrudniki");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            




        }
    }
}
