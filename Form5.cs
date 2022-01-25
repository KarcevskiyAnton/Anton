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
    public partial class Form5 : Form
    {
        public static string c = "select fio,  adress, pol,namesupruga,deti from vladelec";

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=practica.mdb;";
        public OleDbConnection myConnection;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(c, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "vladelec");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(c, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "vladelec");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = ("INSERT INTO vladelec ( fio,  adress, pol,namesupruga,deti) VALUES (@F,@S,@t,@l,@L)");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@F", textBox1.Text);

            command.Parameters.AddWithValue("@S", textBox2.Text);
            command.Parameters.AddWithValue("@t", textBox3.Text);
            command.Parameters.AddWithValue("@l", textBox4.Text);
            command.Parameters.AddWithValue("@L", textBox5.Text);
        




            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено успешно");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE vladelec SET fio='" + textBox1.Text + "' WHERE id=" + textBox4.Text;
                OleDbCommand command = new OleDbCommand(query, myConnection);


                string q = "UPDATE vladelec SET adress='" + textBox2.Text + "' WHERE id=" + textBox4.Text;
                OleDbCommand com = new OleDbCommand(q, myConnection);
                string qu = "UPDATE vladelec SET pol='" + textBox3.Text + "' WHERE id=" + textBox4.Text;
                OleDbCommand co = new OleDbCommand(qu, myConnection);
                command.ExecuteNonQuery();
            }
            catch
            { }


            MessageBox.Show("Запись успешно изменена");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = ("DELETE FROM vladelec  WHERE  id= @I ");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@I", Convert.ToInt32(textBox6.Text));



            command.ExecuteNonQuery();
            MessageBox.Show(" Удалено успешно");
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
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

        private void button13_Click(object sender, EventArgs e)
        {
            string query = ("SELECT fio,  adress, pol,namesupruga,deti FROM vladelec WHERE fio LIKE '%" + textBox1.Text + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "vladelec");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string query = ("SELECT fio,  adress, pol,namesupruga,deti FROM vladelec WHERE adress LIKE '%" + textBox2.Text + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "vladelec");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string query = ("SELECT fio,  adress, pol,namesupruga,deti FROM vladelec WHERE pol LIKE '%" + textBox3.Text + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "vladelec");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string query = ("SELECT fio,  adress, pol,namesupruga,deti FROM vladelec WHERE namesupruga LIKE '%" + textBox4.Text + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "vladelec");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();

        }

        private void автомобильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void датаПрохожденияТОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            string query = ("SELECT fio,  adress, pol,namesupruga,deti FROM vladelec WHERE deti LIKE '%" + textBox5.Text + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "vladelec");
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
