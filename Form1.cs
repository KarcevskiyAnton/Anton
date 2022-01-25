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
    public partial class Form1 : Form
    {
        public static string cmd = "select fio, adrees, pol, namesupruga, deti from infsotr";
        public static string c = "select * from uvolen";
        public static string cm = "select * from sotrud";
        public static string cm1 = "select * from vladelec";
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=practica.mdb;";

        public OleDbConnection myConnection;
        
        public Form1()
        {
            InitializeComponent();

            
        }

        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        
        private void selectButton1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void selectButton2_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(cmd, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "infsotr");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
          


            myConnection.Open();
        }
        
        private void insertButton_Click(object sender, EventArgs e)
        {
            
        }

        
        private void updateButton_Click(object sender, EventArgs e)

        {
            
            
           
        }

       
        private void deleteButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(cmd, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "avto");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            
           
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click_1(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void avtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(cmd, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "avto");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            textBox4.Visible = true;
            label3.Text = "gos:";
            label4.Text = "marka:";
            label5.Text = "texpasp:";
            label6.Text = "cvet:";
            label7.Visible = true;
            label7.Text = "win №";
            label6.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
        }

        private void vstavkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO avto(gos, marka, texpasp,cvet,win) VALUES(@F, @S, @t,@I,@W)";


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@F", Convert.ToInt32 (textBox2.Text));

            command.Parameters.AddWithValue("@S", textBox3.Text);
            command.Parameters.AddWithValue("@t", Convert.ToInt32(textBox4.Text));
            command.Parameters.AddWithValue("@I", textBox5.Text);
            command.Parameters.AddWithValue("@W", Convert.ToInt32(textBox6.Text));



            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено успешно");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void udalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = ("DELETE FROM avto  WHERE gos = @I ");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@I", Convert.ToInt32(textBox2.Text));
            


                command.ExecuteNonQuery();
                MessageBox.Show(" Удалено успешно");

            
        }

        private void izmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string query = "UPDATE avto SET marka='" + textBox3.Text + "' WHERE gos=" + textBox2.Text;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();

            string q = "UPDATE avto SET texpasp='" + textBox4.Text + "' WHERE gos=" + textBox2.Text;
            OleDbCommand com = new OleDbCommand(q, myConnection);
            string qu = "UPDATE avto SET cvet='" + textBox5.Text + "' WHERE gos=" + textBox2.Text;
            OleDbCommand co = new OleDbCommand(qu, myConnection);
            string que = "UPDATE avto SET win №='" + textBox6.Text + "' WHERE gos=" + textBox2.Text;
            OleDbCommand c = new OleDbCommand(que, myConnection);
            com.ExecuteNonQuery();
            MessageBox.Show("Запись успешно изменена");
        }

        private void dataprohToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(c, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "dataproh");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            textBox5.Visible = false;
            textBox6.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label3.Text = "result:";
            label4.Text = "data:";
            label5.Text = "id:";
        }

        private void vstavkaToolStripMenuItem1_Click(object sender, EventArgs  e)
        {
            string query = ("INSERT INTO dataproh ( data,result,id) VALUES (@S,@F,@G)");

            
             OleDbCommand command = new OleDbCommand(query, myConnection);
            
            

            command.Parameters.AddWithValue("@S", textBox2.Text);
            
            command.Parameters.AddWithValue("@I", textBox3.Text);
            command.Parameters.AddWithValue("@G",Convert.ToInt32 (textBox4.Text));









            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено успешно");
        }

        private void izmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE dataproh SET result='" + textBox2.Text + "' WHERE id=" + Convert.ToInt32( textBox3.Text);
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
           



            MessageBox.Show("Запись успешно изменена");
        }

        private void udalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string query = ("DELETE FROM dataproh  WHERE id = @I ");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@I", Convert.ToInt32(textBox2.Text));



            command.ExecuteNonQuery();
            MessageBox.Show(" Удалено успешно");

        }

        private void sotrudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(cm, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "sotrud");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            textBox5.Visible = true;
            textBox6.Visible = false;
            label3.Text = "fio:";
            label4.Text = "dol:";
            label5.Text = "zva:";
            label6.Text = "id:";
            label6.Visible = true;

        }

        private void izmToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE sotrud SET fio='" + textBox2.Text + "' WHERE id=" + textBox5.Text;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();

            string q = "UPDATE sotrud  SET dol='" + textBox3.Text + "' WHERE id=" + textBox5.Text;
            OleDbCommand com = new OleDbCommand(q, myConnection);
            com.ExecuteNonQuery();
            string qu = "UPDATE sotrud  SET zva='" + textBox4.Text + "' WHERE id=" + textBox5.Text;
            OleDbCommand co = new OleDbCommand(qu, myConnection);
            com.ExecuteNonQuery();
            MessageBox.Show("Запись успешно изменена");
        }

        private void бдToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vstavitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = ("INSERT INTO sotrud ( fio,  dol, zva,id) VALUES (@F,@S,@t,@I)");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@F", textBox2.Text);

            command.Parameters.AddWithValue("@S", textBox3.Text);
            command.Parameters.AddWithValue("@t", textBox4.Text);
            command.Parameters.AddWithValue("@I", Convert.ToInt32(textBox5.Text));
            



            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено успешно");
        }

        private void deliteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = ("DELETE FROM sotrud  WHERE id = @I ");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@I", Convert.ToInt32(textBox2.Text));



            command.ExecuteNonQuery();
            MessageBox.Show(" Удалено успешно");
        }

        private void vstavkaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string query = ("INSERT INTO vladelec ( fio,  adress, pol,id) VALUES (@F,@S,@t,@I)");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@F", textBox2.Text);

            command.Parameters.AddWithValue("@S", textBox3.Text);
            command.Parameters.AddWithValue("@t", textBox4.Text);
            command.Parameters.AddWithValue("@I", Convert.ToInt32(textBox5.Text));
            



            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено успешно");
        }

        private void vladelecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(cm1, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "vladelec");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
            textBox5.Visible = true;
            textBox6.Visible = false;
            label3.Text = "fio:";
            label4.Text = "adress:";
            label5.Text = "pol:";
            label6.Text = "id:";
            label6.Visible = true;




            myConnection.Open();
            textBox5.Visible = true;
            textBox6.Visible = false;




        }

        private void deliteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string query = ("DELETE FROM vladelec  WHERE  id= @I ");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@I", Convert.ToInt32(textBox2.Text));



            command.ExecuteNonQuery();
            MessageBox.Show(" Удалено успешно");
        }

        private void izmToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE vladelec SET fio='" + textBox2.Text + "' WHERE id=" + textBox5.Text;
                OleDbCommand command = new OleDbCommand(query, myConnection);


                string q = "UPDATE vladelec SET adress='" + textBox3.Text + "' WHERE id=" + textBox5.Text;
                OleDbCommand com = new OleDbCommand(q, myConnection);
                string qu = "UPDATE vladelec SET pol='" + textBox4.Text + "' WHERE id=" + textBox5.Text;
                OleDbCommand co = new OleDbCommand(qu, myConnection);
                command.ExecuteNonQuery();
            }
            catch
            { }


            MessageBox.Show("Запись успешно изменена");
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Process.Start(@"D:\vladelec4.docx");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
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
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(cmd, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "avto");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button7_Click(object sender, EventArgs e)
        {try
            {
                string query = "INSERT INTO avto(gos, marka, texpasp,cvet,win) VALUES(@F, @S, @t,@I,@W)";


                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.Parameters.AddWithValue("@F", textBox2.Text);

                command.Parameters.AddWithValue("@S", textBox3.Text);
                command.Parameters.AddWithValue("@t", Convert.ToInt32(textBox4.Text));
                command.Parameters.AddWithValue("@I", textBox5.Text);
                command.Parameters.AddWithValue("@W", Convert.ToInt32(textBox6.Text));



                command.ExecuteNonQuery();
                MessageBox.Show("Добавлено успешно");
            }
            catch
            { MessageBox.Show("Ошибка"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = ("DELETE FROM avto  WHERE win = @I ");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@I", Convert.ToInt32(textBox1.Text));



            command.ExecuteNonQuery();
            MessageBox.Show(" Удалено успешно");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "UPDATE avto SET marka='" + textBox3.Text + "' WHERE gos=" + textBox2.Text;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();

            string q = "UPDATE avto SET texpasp='" + textBox4.Text + "' WHERE gos=" + textBox2.Text;
            OleDbCommand com = new OleDbCommand(q, myConnection);
            string qu = "UPDATE avto SET cvet='" + textBox5.Text + "' WHERE gos=" + textBox2.Text;
            OleDbCommand co = new OleDbCommand(qu, myConnection);
            string que = "UPDATE avto SET win='" + textBox6.Text + "' WHERE gos=" + textBox2.Text;
            OleDbCommand c = new OleDbCommand(que, myConnection);
            com.ExecuteNonQuery();
            MessageBox.Show("Запись успешно изменена");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            Form6 f7 = new Form6();
            f7.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string query = ("SELECT gos, marka, texpasp,cvet,win FROM avto WHERE gos LIKE '%" + textBox2.Text + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "avto");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string query = ("SELECT gos, marka, texpasp,cvet,win FROM avto WHERE marka LIKE '%" + textBox3.Text + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "avto");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string query = ("SELECT gos, marka, texpasp,cvet,win FROM avto WHERE texpasp LIKE '%" + textBox4.Text + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "avto");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string query = ("SELECT gos, marka, texpasp,cvet,win FROM avto WHERE cvet LIKE '%" + textBox5.Text + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "avto");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string query = ("SELECT gos, marka, texpasp,cvet,win FROM avto WHERE win LIKE '%" + textBox6.Text + "%'");


            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, connectString);
            DataSet ds = new DataSet();
            da.Fill(ds, "avto");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection = new OleDbConnection(connectString);



            command.ExecuteNonQuery();
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

        private void владелецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
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

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {Application.Exit();

        }
    }
}
