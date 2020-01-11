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

namespace KSCS
{
    public partial class Registeration : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=KSCS;Persist Security Info=True;User ID=sa;Password=1234");
        public Registeration()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }
        
        private void signup_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    name.LineFocusedColor = Color.Red;
                    name.Focus();
                }



                else if (email.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    email.LineFocusedColor = Color.Red;
                    email.Focus();
                }

                else if (phone.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Phone No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    phone.LineFocusedColor = Color.Red;
                    phone.Focus();
                }

                else if (phone.Text.Length!=12)
                {
                    MessageBox.Show("Please Enter Correct Phone No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    phone.LineFocusedColor = Color.Red;
                    phone.Focus();
                }

                else if (cnic.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter CNIC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cnic.LineFocusedColor = Color.Red;
                    cnic.Focus();
                }

                else if (cnic.Text.Length!=15)
                {
                    MessageBox.Show("Please Enter CNIC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cnic.LineFocusedColor = Color.Red;
                    cnic.Focus();
                }

                else if (address.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    address.LineFocusedColor = Color.Red;
                    address.Focus();
                }

                else if (uname.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    uname.LineFocusedColor = Color.Red;
                    uname.Focus();
                }

                else if (pass.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pass.LineFocusedColor = Color.Red;
                    pass.Focus();
                }


                else if (rpass.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Retype Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rpass.LineFocusedColor = Color.Red;
                    rpass.Focus();
                }

                else if (pass.Text.Trim() != rpass.Text.Trim())
                {
                    MessageBox.Show("Password must be same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rpass.LineFocusedColor = Color.Red;
                    rpass.Focus();
                }


                else
                {


                    sc.Open();
                    string sql = ("insert into Registeration values ('" + name.Text + "' , '" + email.Text + "', '" + phone.Text + "', '" + cnic.Text + "', '" + address.Text + "', '" + uname.Text + "', '" + pass.Text + "')");

                    SqlCommand comd = new SqlCommand(sql, sc);

                    comd.ExecuteNonQuery();

                   
                    MessageBox.Show("User Registered Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    name.Text = "";
                    email.Text = "";
                    phone.Text = "";
                    cnic.Text = "";
                    address.Text = "";
                    uname.Text = "";
                    pass.Text = "";
                    rpass.Text = "";
                    sc.Close();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)||e.KeyChar==45))
                e.Handled = true;
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)|| e.KeyChar == 45))
                e.Handled = true;
        }
    }


    }
