using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace KSCS
{
    public partial class Login : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=KSCS;Persist Security Info=True;User ID=sa;Password=1234");
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registeration rg = new Registeration();
            this.Hide();
            rg.ShowDialog();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            try
            {

                if (uname.Text.Trim() == string.Empty)
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


                else
                {
                    sc.Open();
                    string sql = ("select * from registeration where username='" + uname.Text + "' AND password='" + pass.Text + "'");

                    SqlDataAdapter oda = new SqlDataAdapter(sql, sc);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Main m = new Main();
                        this.Hide();
                        m.ShowDialog();
                        sc.Close();
                    }

                    else
                    {
                        MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        sc.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sc.Close();
            }

        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                pass.isPassword = false;
            }
            else
            {
                pass.isPassword = true;
            }
        }
        

        private void pass_OnValueChanged(object sender, EventArgs e)
        {
            pass.isPassword = true;
        }
    }
}

