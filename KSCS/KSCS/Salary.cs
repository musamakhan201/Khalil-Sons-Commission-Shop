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
    public partial class Salary : UserControl
    {
        SqlConnection sc = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=KSCS;Persist Security Info=True;User ID=sa;Password=1234");
        public Salary()
        {
            InitializeComponent();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            sc.Open();
            sdate.Text = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss");
            edate.Text = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss");
            string sql = ("select * from employees order by EMPLOYEE_ID");
            SqlDataAdapter sda = new SqlDataAdapter(sql, sc);
            SqlCommand cmd = new SqlCommand(sql, sc);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                seid.Items.Add(dr["EMPLOYEE_ID"].ToString());
                sid.Items.Add(dr["EMPLOYEE_ID"].ToString());
            }
            sc.Close();
        }

        private void sid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                string sql = ("select * from employees where EMPLOYEE_ID='" + sid.SelectedItem.ToString() + "'");
                SqlDataAdapter sda = new SqlDataAdapter(sql, sc);
                SqlCommand cmd = new SqlCommand(sql, sc);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    eid.Text = dr["EMPLOYEE_ID"].ToString();
                    name.Text = dr["EMPLOYEE_NAME"].ToString();
                }
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sc.Close();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                int x;
                int a;
                int value = int.Parse(blnc.Text);
                if (value < 0)
                {
                    x = value;
                    a=-(0);
                }
                else
                {
                    x = 0;
                    a = value;
                }
                string sql = ("insert into salary(EMPLOYEE_ID, EMPLOYEE_NAME, EMPLOYEE_SALARY, REMAININGS, PAY, BALANCE, DATE) values ('" + ssid.Text + "','" + sename.Text + "', '" + ssal.Text + "', '" + x + "','" + pay.Text + "','" + a + "','" + sdate.Text + "')");

                SqlCommand comd = new SqlCommand(sql, sc);

                comd.ExecuteNonQuery();

                MessageBox.Show("Salary Given Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ssid.Text = "";
                sename.Text = "";
                ssal.Text = "";
                srem.Text = "";
                gtotal.Text = "";
                pay.Text = "";
                blnc.Text = "";
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sc.Close();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (expamount.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    expamount.LineFocusedColor = System.Drawing.Color.Red;
                    expamount.Focus();
                }
                else if (purpose.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter purpose.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    purpose.LineFocusedColor = System.Drawing.Color.Red;
                    purpose.Focus();
                }
                else
                {
                    sc.Open();
                    string sql = ("insert into salary(EMPLOYEE_ID, EMPLOYEE_NAME, REMAININGS, PURPOSE,DATE) values ('" + eid.Text + "','" + name.Text + "', '" + expamount.Text + "', '" + purpose.Text + "','" + edate.Text + "')");

                    SqlCommand comd = new SqlCommand(sql, sc);

                    comd.ExecuteNonQuery();

                    MessageBox.Show("Expense Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    eid.Text = "";
                    name.Text = "";
                    purpose.Text = "";
                    expamount.Text = "";
                    sc.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sc.Close();
            }
        }

        private void seid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                string sql = ("select * from employees where EMPLOYEE_ID='" + seid.SelectedItem.ToString() + "'");
                SqlDataAdapter sda = new SqlDataAdapter(sql, sc);
                SqlCommand cmd = new SqlCommand(sql, sc);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ssid.Text = dr["EMPLOYEE_ID"].ToString();
                    sename.Text = dr["EMPLOYEE_NAME"].ToString();
                    ssal.Text = dr["EMPLOYEE_SALARY"].ToString();
                }
                string sq = ("select SUM(CAST(REMAININGS as int)) as total from salary where EMPLOYEE_ID='" + seid.SelectedItem.ToString() + "'");
                SqlCommand cm = new SqlCommand(sq, sc);
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    srem.Text = sdr["total"].ToString();
                }
                if (String.IsNullOrEmpty(srem.Text))
                {
                    int a = int.Parse(ssal.Text);
                    int c = a - 0;
                    gtotal.Text = c.ToString();
                }
                else
                {
                    int a = int.Parse(ssal.Text);
                    int b = int.Parse(srem.Text);
                    int c = a - b;
                    gtotal.Text = c.ToString();
                }
                    
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sc.Close();
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(pay.Text))
            {
                int a = int.Parse(gtotal.Text);
                int b = 0;
                int c = a - b;
                blnc.Text = c.ToString();
            }
            else
            {
                int a = int.Parse(gtotal.Text);
                int b = int.Parse(pay.Text);
                int c = a - b;
                blnc.Text = c.ToString();
            }
        }
    }
}
