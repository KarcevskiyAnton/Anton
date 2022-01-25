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
    { public class sotrudniki
        {
            public string data;
            public string naspunkt;
            public string stoimost;
            public string lgota;
            public int id;

        }
        sotrudniki s = new sotrudniki();
        public static string c = "select data,  naspunkt, stoimostmin, lgota, id from sotrud";

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
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = ("INSERT INTO sotrud ( data,  naspunkt,stoimostmin, lgota, id) VALUES (@F,@S,@t,@g,@I)");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@F", textBox1.Text);
            s.data = textBox1.Text;
            command.Parameters.AddWithValue("@S", textBox2.Text);
            s.naspunkt = textBox2.Text;
            command.Parameters.AddWithValue("@t", textBox3.Text);
            s.stoimost = textBox3.Text;
            command.Parameters.AddWithValue("@g", textBox4.Text);
            s.lgota = textBox4.Text;


            command.Parameters.AddWithValue("@I", Convert.ToInt32(textBox5.Text));
            s.id = Convert.ToInt32(textBox5.Text);




            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено успешно");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "UPDATE sotrud SET data='" + textBox1.Text + "' WHERE id=" + textBox5.Text;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();

            string q = "UPDATE sotrud  SET naspunkt='" + textBox2.Text + "' WHERE id=" + textBox5.Text;
            OleDbCommand com = new OleDbCommand(q, myConnection);
            com.ExecuteNonQuery();
            string qu = "UPDATE sotrud  SET stoimostmin='" + textBox3.Text + "' WHERE id=" + textBox5.Text;
            OleDbCommand co = new OleDbCommand(qu, myConnection);
            com.ExecuteNonQuery();

            string u = "UPDATE sotrud  SET lgota='" + textBox3.Text + "' WHERE id=" + textBox5.Text;
            OleDbCommand c = new OleDbCommand(qu, myConnection);
            com.ExecuteNonQuery();

            MessageBox.Show("Запись успешно изменена");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = ("DELETE FROM sotrud  WHERE id = @I ");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@I", Convert.ToInt32(textBox5.Text));



            command.ExecuteNonQuery();
            MessageBox.Show(" Удалено успешно");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
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
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string query = "UPDATE sotrud SET data='" + textBox1.Text + "' WHERE id=" + textBox5.Text;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();

            string q = "UPDATE sotrud  SET naspunkt='" + textBox2.Text + "' WHERE id=" + textBox5.Text;
            OleDbCommand com = new OleDbCommand(q, myConnection);
            com.ExecuteNonQuery();
            string qu = "UPDATE sotrud  SET stoimostmin='" + textBox3.Text + "' WHERE id=" + textBox5.Text;
            OleDbCommand co = new OleDbCommand(qu, myConnection);
            com.ExecuteNonQuery();

            string u = "UPDATE sotrud  SET lgota='" + textBox3.Text + "' WHERE id=" + textBox5.Text;
            OleDbCommand c = new OleDbCommand(qu, myConnection);
            com.ExecuteNonQuery();

            MessageBox.Show("Запись успешно изменена");



        }

        private void button12_Click(object sender, EventArgs e)
        {
           



                    }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void автомобильToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void датаПрохожденияТОToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        }

        private void владелецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          

        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }

