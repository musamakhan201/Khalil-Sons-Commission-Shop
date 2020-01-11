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
    public partial class Commission : UserControl
    {
        SqlConnection sc = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=KSCS;Persist Security Info=True;User ID=sa;Password=1234");
        public Commission()
        {
            InitializeComponent();
        }

        private void Commission_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss");
        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                double cmsn = (double.Parse(mktrate.Text) * double.Parse(comision.Text));
                double cms = cmsn / 100;
                double crntrate = double.Parse(mktrate.Text) + cms;
                currentrate.Text = crntrate.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }
        

        private void mktrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void comision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void sve_Click(object sender, EventArgs e)
        {
            try
            {
                if (mktrate.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Market Rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mktrate.LineFocusedColor = System.Drawing.Color.Red;
                    mktrate.Focus();
                }

                else if (comision.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Your Commission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comision.LineFocusedColor = System.Drawing.Color.Red;
                    comision.Focus();
                }
                else
                {


                    sc.Open();
                    string sql = ("insert into commission values ('" + croptype.selectedValue + "','" + mktrate.Text + "','" + comision.Text + "','" + currentrate.Text + "','" + date.Text + "')");
                    SqlCommand comd = new SqlCommand(sql, sc);

                    comd.ExecuteNonQuery();

                    MessageBox.Show("Commission Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mktrate.Text = "";
                    comision.Text = "";
                    sc.Close();
                }
            }
            catch (Exception ex)
            {
                sc.Close();
            }
        }

        private void currentrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || e.KeyChar == 45))
                e.Handled = true;
        }
    }
}
