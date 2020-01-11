using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KSCS
{
    public partial class Inventory : UserControl
    {
        SqlConnection sc = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=KSCS;Persist Security Info=True;User ID=sa;Password=1234");
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            
            sc.Open();
            string sq = ("select CROPS, SUM(CAST(TOTAL_WEIGHT as int))as QUANTITY from order1 where BUYER_ID='0' GROUP BY CROPS");
            SqlDataAdapter sda = new SqlDataAdapter(sq, sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
           
            sc.Close();
        }
    }
}
