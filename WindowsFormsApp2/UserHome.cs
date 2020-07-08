using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class UserHome : UserControl
    {
        public UserHome()
        {
            InitializeComponent();
            
           
        }
       
        private void button3_Click(object sender, EventArgs e)
        {

       
        


        }

       
        public void fillDGV()
        {
            DB db = new DB();
            MySqlCommand Command = new MySqlCommand("SELECT name,price,phone_number,image,description,namecat FROM advert  WHERE status='Accept'", db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            dataGridViewAcceuil.RowTemplate.Height = 60;
            dataGridViewAcceuil.AllowUserToAddRows = false;
            dataGridViewAcceuil.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridViewAcceuil.Columns[4];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewAcceuil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridViewAcceuil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            


            DB db = new DB();
            MySqlCommand Command = new MySqlCommand("SELECT * FROM category", db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
            
             DataTable table = new DataTable();
            adapter.Fill(table);

            MySqlDataReader myReader;
            try
            {
                db.openConnection();
                myReader = Command.ExecuteReader();
                while (myReader.Read())
                {


                    ListBoxOfCategory.Items.Add(myReader["name_cat"].ToString());
                }
                 
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            

            var link = new DataGridViewLinkColumn();
            link.DisplayIndex = 0;
            link.DefaultCellStyle.NullValue = "Show More";
            link.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            link.Width = 60;
            link.ActiveLinkColor = Color.White;
            link.LinkBehavior = LinkBehavior.HoverUnderline;
            link.LinkColor = Color.Crimson;
            link.TrackVisitedState = true;
            link.VisitedLinkColor = Color.YellowGreen;
            dataGridViewAcceuil.Columns.Add(link);
            dataGridViewAcceuil.AllowUserToAddRows = false;

            fillDGV();

        }

        private void ListBoxOfCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            labelSearch.Text = "";
            foreach (object item in ListBoxOfCategory.SelectedItems)
            {
                labelSearch.Text += (labelSearch.Text == "" ? "" : ",") +"'"+  item.ToString() + "'" ;


                DB db = new DB();
                MySqlCommand Command = new MySqlCommand("SELECT name,price,phone_number,image,description,namecat FROM advert  WHERE status='Accept' AND namecat in (" + labelSearch.Text + ")", db.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
                DataTable table = new DataTable();

                adapter.Fill(table);
                dataGridViewAcceuil.RowTemplate.Height = 60;
                dataGridViewAcceuil.AllowUserToAddRows = false;
                dataGridViewAcceuil.DataSource = table;
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol = (DataGridViewImageColumn)dataGridViewAcceuil.Columns[4];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridViewAcceuil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;




            }


        }

        private void dataGridViewAcceuil_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDetail show = new ShowDetail();
               show.textBoxName.Text = this.dataGridViewAcceuil.CurrentRow.Cells[1].Value.ToString();
            show.textBoxNamecat.Text = this.dataGridViewAcceuil.CurrentRow.Cells[6].Value.ToString();
            show.textBoxPrice.Text = this.dataGridViewAcceuil.CurrentRow.Cells[2].Value.ToString();
            show.textBoxPhone.Text = this.dataGridViewAcceuil.CurrentRow.Cells[3].Value.ToString();
            show.richTextBoxDesc.Text = this.dataGridViewAcceuil.CurrentRow.Cells[5].Value.ToString();
           

            Byte[] img = (Byte[])dataGridViewAcceuil.CurrentRow.Cells[4].Value;
            MemoryStream ms = new MemoryStream(img);
            show.pictureBox.Image = Image.FromStream(ms);

            show.ShowDialog();
           
            

            


        }
    }
}
