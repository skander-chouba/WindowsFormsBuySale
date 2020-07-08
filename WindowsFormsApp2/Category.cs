using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Category : Form
    {
      
        public Category()
        {
            InitializeComponent();
           
        }
        private void Category_Load(object sender, EventArgs e)
        {
            FillDGV("");
        }


        public void FillDGV(string valueToSearch) {
            DB db = new DB();
            
            MySqlCommand Command = new MySqlCommand("SELECT * FROM category WHERE CONCAT(id_cat,name_cat) Like'%"+ valueToSearch+"%'",db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
            DataTable table = new DataTable();
            adapter.Fill(table);
           

            dataGridViewCat.AllowUserToAddRows = false;
           
            dataGridViewCat.DataSource = table;
            dataGridViewCat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
          
            



        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
       
    }

        private void dataGridViewCat_Click(object sender, EventArgs e)
        {
            textBoxIdCat.Text = dataGridViewCat.CurrentRow.Cells[0].Value.ToString();
            textBoxNameCat.Text = dataGridViewCat.CurrentRow.Cells[1].Value.ToString();
        }





        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `category`(`id_cat`, `name_cat`) VALUES (@icat, @ncat)", db.getConnection());

            command.Parameters.Add("@icat", MySqlDbType.VarChar).Value = textBoxIdCat.Text;
            command.Parameters.Add("@ncat", MySqlDbType.VarChar).Value = textBoxNameCat.Text;

            db.openConnection();


            if (textBoxIdCat.Text.Equals("") || textBoxNameCat.Text.Equals(""))
            {

                MessageBox.Show("Fill Id and Name of Category", "Empty Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (command.ExecuteNonQuery() == 1 )
            {
                MessageBox.Show("data inserted");
            }
            
            
            
            else {
                MessageBox.Show("Query not executed");

            }
        
            db.closeConnection();

            FillDGV("");
        }
       

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `category` SET `name_cat`=@ncat WHERE id_cat=@icat", db.getConnection());
             
            command.Parameters.Add("@icat", MySqlDbType.VarChar).Value = textBoxIdCat.Text;
            command.Parameters.Add("@ncat", MySqlDbType.VarChar).Value = textBoxNameCat.Text;

            db.openConnection();

            if (textBoxIdCat.Text.Equals("") || textBoxNameCat.Text.Equals(""))
            {

                MessageBox.Show("Select Id and Name of Category", "Empty Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("data Updated");
               
            }

            
            else
            {
                MessageBox.Show("Query not executed");

            }
            db.closeConnection();
            FillDGV("");

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `category` WHERE id_cat=@icat  ", db.getConnection());

            command.Parameters.Add("@icat", MySqlDbType.VarChar).Value = textBoxIdCat.Text;
            db.openConnection();

            if (textBoxIdCat.Text.Equals("") || textBoxNameCat.Text.Equals(""))
            {

                MessageBox.Show("Select Id and Name of Category", "Empty Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("data was deleted");

            }


            else
            {
                MessageBox.Show("Query not executed");

            }
            db.closeConnection();

            FillDGV("");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FillDGV(textBoxSearch.Text);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand Command = new MySqlCommand("SELECT * FROM category WHERE id_cat=@icat", db.getConnection());
            Command.Parameters.Add("@icat", MySqlDbType.VarChar).Value = textBoxIdCat.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count <= 0) {

                MessageBox.Show("no data found");




            }
            else
            {
                textBoxIdCat.Text = table.Rows[0][0].ToString();
                textBoxNameCat.Text = table.Rows[0][1].ToString();
            }
        }
    }
    }

