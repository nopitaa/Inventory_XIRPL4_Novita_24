using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Inventory_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create connection with database
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Barang Kosmetik.accdb");

            //create dataadapter
            OleDbDataAdapter da = new OleDbDataAdapter("select count(*) from login where username ='" +txtusername .Text + "'and password ='"+txtpassword .Text +"' ", con);

            //create databasetable
            DataTable dt = new DataTable();

            //fill datatable
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                //means the username and password is correct
                Form2 f2 = new Form2();
                f2.Show(); 
            }
            else
            {
                //means the user name or password is incorect
                MessageBox.Show("Invalid username or password, try again...");
            }
        }
    }
}
