using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3_ConLinQName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-G086NFFQ\\SQLEXPRESS;Initial Catalog=MyTestDB;Integrated Security=True");


            SqlCommand cmd = new SqlCommand("insert into User_Tab values(@ID, @Name, @Age)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txt_ID.Text));
            cmd.Parameters.AddWithValue("@Name",txt_Name.Text);
            cmd.Parameters.AddWithValue("@Age", double.Parse(txt_Age.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Suceessfully Saved");





        }
    }
}
