using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Advert : Form
    {
        public Advert()
        {
            InitializeComponent();
            
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }
        public void FillDGV()
        {
            DB db = new DB();
            MySqlCommand Command = new MySqlCommand("SELECT name,image,namecat,status FROM advert", db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            dataGridViewAdvert.RowTemplate.Height = 60;
            dataGridViewAdvert.AllowUserToAddRows = false;
            dataGridViewAdvert.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridViewAdvert.Columns[1];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewAdvert.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }


       

        private void Advert_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        

      

        private void dataGridViewAdvert_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AfficheForm affiche = new AfficheForm();
            affiche.textBoxName.Text = this.dataGridViewAdvert.CurrentRow.Cells[0].Value.ToString();
            affiche.textBoxCatg.Text = this.dataGridViewAdvert.CurrentRow.Cells[2].Value.ToString();
            Byte[] img = (Byte[])dataGridViewAdvert.CurrentRow.Cells[1].Value;
            MemoryStream ms = new MemoryStream(img);
           affiche.pictureBoxAdvert.Image = Image.FromStream(ms);
            
            affiche.ShowDialog();
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand Command = new MySqlCommand("SELECT name,image,namecat,status FROM advert", db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            dataGridViewAdvert.RowTemplate.Height = 60;
            dataGridViewAdvert.AllowUserToAddRows = false;
            dataGridViewAdvert.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridViewAdvert.Columns[1];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewAdvert.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
    }






