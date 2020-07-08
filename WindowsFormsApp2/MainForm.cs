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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAdvert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Advert advertform = new Advert();
            advertform.Show();

        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category categoryform = new Category();
            categoryform.Show();
        }

       

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginform = new Form1();
            loginform.Show();
        }

        
        private void MainForm_Load_1(object sender, EventArgs e)
        {
            if (Form1.loginUser != null)
            {
                labelwelo.Text = Form1.loginUser;
            }

        }
    }
}
