using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CreateAD : UserControl
    {
        public CreateAD()
        {
            InitializeComponent();
            FillCombo();
            

        }
        public void FillDGV()
        {
            DB db = new DB();
            MySqlCommand Command = new MySqlCommand("SELECT * FROM advert", db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewPost.RowTemplate.Height = 60;
            dataGridViewPost.AllowUserToAddRows = false;
            dataGridViewPost.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridViewPost.Columns[4];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewPost.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
        private void CreateAD_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog Opf = new OpenFileDialog();
            Opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF;*)|*.jpg;*.png;*.gif;*";
            if (Opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(Opf.FileName);
            }

        }

        private void dataGridViewPost_Click(object sender, EventArgs e)
        {
            Byte[] img = (Byte[])dataGridViewPost.CurrentRow.Cells[4].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox.Image = Image.FromStream(ms);
            textBoxPrice.Text = dataGridViewPost.CurrentRow.Cells[2].Value.ToString();
            textBoxId.Text = dataGridViewPost.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewPost.CurrentRow.Cells[1].Value.ToString();
            textBoxPhone.Text = dataGridViewPost.CurrentRow.Cells[3].Value.ToString();
            richTextBoxDesc.Text = dataGridViewPost.CurrentRow.Cells[5].Value.ToString();

        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("INSERT INTO `advert`(`price`, `name`,`phone_number`,`description`,`image`,`namecat`,`status`) VALUES (@pri, @name, @ph, @desc, @img, @cat,@stat)", db.getConnection());

            command.Parameters.AddWithValue("@cat", comboBoxCat.Text.ToString());
            command.Parameters.Add("@pri", MySqlDbType.VarChar).Value = textBoxPrice.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = textBoxPhone.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = richTextBoxDesc.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;
            command.Parameters.Add("@stat", MySqlDbType.VarChar).Value = "waiting";
            
            db.openConnection();
            
            if (comboBoxCat.Text.Equals("") || textBoxPrice.Text.Equals("") || textBoxName.Text.Equals("") || textBoxPhone.Text.Equals("") || richTextBoxDesc.Text.Equals(""))
            {

                MessageBox.Show("Fill All", "Empty Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            else if (command.ExecuteNonQuery() == 1)
            {
               
                MessageBox.Show("data inserted");
            }
            else
            {
                MessageBox.Show("Query not executed");

            }
            db.closeConnection();

            FillDGV();
        }
        void FillCombo()
        {
            DB db = new DB();
            MySqlCommand Command = new MySqlCommand("SELECT * FROM category", db.getConnection());

            MySqlDataReader myReader;
            try
            {
                db.openConnection();
                myReader = Command.ExecuteReader();
                while (myReader.Read())
                {
                    
                    comboBoxCat.Items.Add(myReader["name_cat"].ToString());
                }
                db.closeConnection();
            }

            

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdatePost_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
            byte[] img = ms.ToArray();
            MySqlCommand command = new MySqlCommand("UPDATE `advert` SET `price`=@pri, `name`=@name, `phone_number`=@ph,`description`=@desc,`image`=@img,`namecat`=@cat  WHERE  id_ad=@id  ", db.getConnection());
            command.Parameters.AddWithValue("@cat", comboBoxCat.Text.ToString());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxId.Text;
            command.Parameters.Add("@pri", MySqlDbType.VarChar).Value = textBoxPrice.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = textBoxPhone.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = richTextBoxDesc.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;
            
            db.openConnection();
            if (comboBoxCat.Text.Equals("") || textBoxPrice.Text.Equals("") || textBoxName.Text.Equals("") || textBoxPhone.Text.Equals("") || richTextBoxDesc.Text.Equals(""))
            {

                MessageBox.Show("select All", "Advert not updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            FillDGV();
        }
    }
}
