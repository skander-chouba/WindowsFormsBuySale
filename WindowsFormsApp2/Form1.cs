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


    public partial class Form1 : Form
    {
        public static String loginUser = "";
        

        public Form1()
        {

            InitializeComponent();
        }

        

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            String login = textBoxUsername.Text;

            String password = textBoxPassword.Text;
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `authentification` WHERE `login`= @log and `password` = @pass", db.getConnection());

            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            // check if the user exists or not
            String cmbItemValue = comboBoxUserType.SelectedItem.ToString();

            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++) {

                    if (table.Rows[i]["usertype"].ToString() == cmbItemValue)
                    {

                        MessageBox.Show("you are login as " + table.Rows[i][6]);
                        if (comboBoxUserType.SelectedIndex == 0)
                        {
                            loginUser = textBoxUsername.Text;
                            this.Hide();
                            MainForm mainform = new MainForm();
                            mainform.Show();

                        }
                        else
                        {
                            loginUser = textBoxUsername.Text;
                            this.Hide();
                            UserForm userform = new UserForm();
                            userform.Show();
                        }

                    }

                  
                }




                
            }
            else
            {
                // check if the username field is empty
                if (login.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // check if the password field is empty
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // check if the username or the password don't exist
                else
                {
                    MessageBox.Show("Wrong Username Or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelGoToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

