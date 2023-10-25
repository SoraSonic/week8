using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace week8
{

    public partial class Form1 : Form
    {
        Connect Ketnoi = new Connect();
        SqlConnection connsql;
        public Form1()
        {
            InitializeComponent();
            connsql = Ketnoi.connect;
        }

        //CONNECT
        public class Connect
        {
            public SqlConnection connect;
            public Connect()
            {
                connect = new SqlConnection("Data source = A209PC29; Initial Catalog= AHIHI; integrated security = true");
            }
            public Connect(string strcn)
            {
                connect = new SqlConnection(strcn);
            }

        }

        //Button create
        private void Create_button_Click(object sender, EventArgs e)
        {
            //check connection before opening
            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();
                int ID = int.Parse(ID_textBox.Text);
                string NAME = Name_textBox.Text;
                string insertString;
                insertString = "insert into INFO values (" +ID + ",'" + NAME + "')";

                //execute new command
                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                MessageBox.Show("Thanh cong");
            }

            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }

        }

        //Read
        private void Read_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();
                
                

                //execute new command
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader= cmd.ExecuteReader();
                while(reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);

                }
                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                MessageBox.Show("Thanh cong");
            }

            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            //check connection before opening
            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();
                int ID = int.Parse(ID_textBox.Text);
                string NAME = Name_textBox.Text;
                string insertString;
                insertString = "delete from INFO where ID =" + ID + "and name = '" + NAME +"'";

                //execute new command
                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                MessageBox.Show("Thanh cong");
            }

            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }

        }
        
    }
}
