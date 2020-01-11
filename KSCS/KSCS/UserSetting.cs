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
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace KSCS
{
    public partial class UserSetting : UserControl
    {
        SqlConnection sc = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=KSCS;Persist Security Info=True;User ID=sa;Password=1234");
        public UserSetting()
        {
            InitializeComponent();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void UserSetting_Load(object sender, EventArgs e)
        {
            sc.Open();
            string sql = ("select * from Registeration order by NAME");
            SqlDataAdapter sda = new SqlDataAdapter(sql, sc);
            SqlCommand cmd = new SqlCommand(sql, sc);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                users1.Items.Add(dr["USERNAME"].ToString());
                users.Items.Add(dr["USERNAME"].ToString());
            }
            sc.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void updt_Click(object sender, EventArgs e)
        {
            if (oldpass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter old password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                oldpass.LineFocusedColor = Color.Red;
                oldpass.Focus();
            }
            else if (newpass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newpass.LineFocusedColor = Color.Red;
                newpass.Focus();
            }
            else
            {
                try
                {
                    sc.Open();
                    string sql = "select password from Registeration where username='" + users1.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, sc);
                    SqlDataAdapter sda = new SqlDataAdapter(sql, sc);
                    DataTable dt = new DataTable();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (oldpass.Text == reader["PASSWORD"].ToString())
                        {
                            if (newpass.Text == rpass.Text)
                            {
                                reader.Close();
                                string sq = "update Registeration set password='" + newpass.Text + "' where username='" + users1.Text + "'";
                                SqlCommand cd = new SqlCommand(sq, sc);
                                cd.ExecuteNonQuery();
                                MessageBox.Show("Password changed successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                oldpass.Text = "";
                                newpass.Text = "";
                                rpass.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Password must be same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                rpass.LineFocusedColor = Color.Red;
                                rpass.Focus();
                                reader.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            oldpass.LineFocusedColor = Color.Red;
                            oldpass.Focus();
                            reader.Close();
                        }
                    }
                    reader.Close();
                    sc.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void backup_Click(object sender, EventArgs e)
        {
            try
            {
                ProgressBar1.Value = 0;
                Server dbserver = new Server(new ServerConnection(txtServer.Text, txtuser.Text, txtpassword.Text));
                Backup dbbackup = new Backup() { Action = BackupActionType.Database, Database = txtDatabase.Text };
                dbbackup.Devices.AddDevice(@"C:\Users\USAMA\Documents\KSCS.bak", DeviceType.File);
                dbbackup.Initialize = true;
                dbbackup.PercentComplete += DbBackup_PercentComplete;
                dbbackup.Complete += DbBackup_Complete;
                dbbackup.SqlBackupAsync(dbserver);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            ProgressBar1.Invoke((MethodInvoker)delegate
            {
                ProgressBar1.Value = e.Percent;
                ProgressBar1.Update();
            });
            percent.Invoke((MethodInvoker)delegate
                {
                    percent.Text = $"{e.Percent}%";
                });
        }
        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                status.Invoke((MethodInvoker)delegate
                {
                    status.Text = e.Error.Message;
                }
                    );
            }
        }

        private void users_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                string sql = ("select * from Registeration where USERNAME='" + users.SelectedItem.ToString() + "'");
                SqlDataAdapter sda = new SqlDataAdapter(sql, sc);
                SqlCommand cmd = new SqlCommand(sql, sc);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    name.Text = dr["NAME"].ToString();
                    email.Text = dr["EMAIL"].ToString();
                    phone.Text = dr["PHONE"].ToString();
                    cnic.Text = dr["CNIC"].ToString();
                    address.Text = dr["ADDRESS"].ToString();
                }
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sc.Close();
            }
        }

        private void udt_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                string sql = ("update Registeration set NAME='" + name.Text + "', EMAIL='" + email.Text + "',PHONE='" + phone.Text + "', CNIC='" + cnic.Text + "', ADDRESS='" + address.Text + "' where USERNAME='" + users.Text + "'");

                SqlCommand comd = new SqlCommand(sql, sc);

                comd.ExecuteNonQuery();

                MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sc.Close();
                name.Text = "";
                email.Text = "";
                phone.Text = "";
                cnic.Text = "";
                address.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sc.Close();
            }
        }
    }
}
