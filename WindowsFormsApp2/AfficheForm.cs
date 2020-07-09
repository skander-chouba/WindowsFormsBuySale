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
    public partial class AfficheForm : Form
    {
        public AfficheForm()
        {
            InitializeComponent();
        }

        private void AfficheForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `advert` SET  `status`= @stat where name=@na" , db.getConnection());
            command.Parameters.AddWithValue( "@stat", comboBoxStatus.Text.ToString());
            
            command.Parameters.Add("@na", MySqlDbType.VarChar).Value = textBoxName.Text;
            db.openConnection();

            if (comboBoxStatus.Text.Equals(""))
            {

                MessageBox.Show("Select status", "Empty Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                command.ExecuteNonQuery();

                MessageBox.Show("demand accepted");
            }
            db.closeConnection(); 




        }

        private void buttonRefuse_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE  FROM `advert` WHERE name=@na  ", db.getConnection());

            command.Parameters.Add("@na", MySqlDbType.VarChar).Value = textBoxName.Text;
            db.openConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("demand refused");

                }


                else
                {
                    MessageBox.Show("Query not executed");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query not executed");
                Console.WriteLine(ex);
            }
            
            db.closeConnection();
        }

       
    }
}
