using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
   
    class DB
         
    {
        MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=venteachat");
       
       

        // create a function to open the connection
        public void openConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }



            // create a function to close the connection
            public void closeConnection()
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
            }

            // create a function to return the connection
            public MySqlConnection getConnection()
            {
                return Connection;
            }


    }





}
