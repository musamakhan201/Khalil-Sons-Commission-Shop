using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSCS
{
    public partial class Main : Form
    {
        public Main()
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

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login lg = new Login();
                this.Hide();
                lg.ShowDialog();
            }
        }

        private void expenditure_Click(object sender, EventArgs e)
        {
            farmers1.Hide();
            employees1.Hide();
            expenditures1.Show();
            expenditures1.BringToFront();
            inventory1.Hide();
            order1.Hide();
            salary1.Hide();
            commission1.Hide();
            buyer1.Hide();
            userSetting1.Hide();
            aboutUs1.Hide();
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            farmers1.Hide();
            employees1.Hide();
            expenditures1.Hide();
            inventory1.Show();
            inventory1.BringToFront();
            order1.Hide();
            salary1.Hide();
            commission1.Hide();
            buyer1.Hide();
            userSetting1.Hide();
            aboutUs1.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            time.Text = DateTime.Now.ToString("dddd MM/dd/yyyy hh:mm:ss");
            farmers1.Hide();
            employees1.Hide();
            expenditures1.Hide();
            inventory1.Hide();
            order1.Hide();
            salary1.Hide();
            commission1.Hide();
            buyer1.Hide();
            userSetting1.Hide();
            aboutUs1.Hide();
        }

        private void farmer_Click(object sender, EventArgs e)
        {
            farmers1.Show();
            farmers1.BringToFront();
            employees1.Hide();
            expenditures1.Hide();
            inventory1.Hide();
            order1.Hide();
            salary1.Hide();
            commission1.Hide();
            buyer1.Hide();
            userSetting1.Hide();
            aboutUs1.Hide();
        }

        private void employees_Click(object sender, EventArgs e)
        {
            farmers1.Hide();
            employees1.Show();
            employees1.BringToFront();
            expenditures1.Hide();
            inventory1.Hide();
            order1.Hide();
            salary1.Hide();
            commission1.Hide();
            buyer1.Hide();
            userSetting1.Hide();
            aboutUs1.Hide();
        }

        private void order_Click(object sender, EventArgs e)
        {
            farmers1.Hide();
            employees1.Hide();
            expenditures1.Hide();
            inventory1.Hide();
            order1.Show();
            order1.BringToFront();
            salary1.Hide();
            commission1.Hide();
            buyer1.Hide();
            userSetting1.Hide();
            aboutUs1.Hide();
        }

        private void salary_Click(object sender, EventArgs e)
        {
            farmers1.Hide();
            employees1.Hide();
            expenditures1.Hide();
            inventory1.Hide();
            order1.Hide();
            salary1.Show();
            salary1.BringToFront();
            commission1.Hide();
            buyer1.Hide();
            userSetting1.Hide();
            aboutUs1.Hide();
        }

        private void commission_Click(object sender, EventArgs e)
        {
            farmers1.Hide();
            employees1.Hide();
            expenditures1.Hide();
            inventory1.Hide();
            order1.Hide();
            salary1.Hide();
            commission1.Show();
            commission1.BringToFront();
            buyer1.Hide();
            userSetting1.Hide();
            aboutUs1.Hide();
        }

        private void buyer_Click(object sender, EventArgs e)
        {
            farmers1.Hide();
            employees1.Hide();
            expenditures1.Hide();
            inventory1.Hide();
            order1.Hide();
            salary1.Hide();
            commission1.Hide();
            buyer1.Show();
            buyer1.BringToFront();
            userSetting1.Hide();
            aboutUs1.Hide();
        }

        private void usersetting_Click(object sender, EventArgs e)
        {
            farmers1.Hide();
            employees1.Hide();
            expenditures1.Hide();
            inventory1.Hide();
            order1.Hide();
            salary1.Hide();
            commission1.Hide();
            buyer1.Hide();
            userSetting1.Show();
            userSetting1.BringToFront();
            aboutUs1.Hide();
        }

        private void aboutus_Click(object sender, EventArgs e)
        {
            farmers1.Hide();
            employees1.Hide();
            expenditures1.Hide();
            inventory1.Hide();
            order1.Hide();
            salary1.Hide();
            commission1.Hide();
            buyer1.Hide();
            userSetting1.Hide();
            aboutUs1.Show();
            aboutUs1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            time.Text = DateTime.Now.ToString("dddd MM/dd/yyyy hh:mm:ss");
        }

        private void userSetting1_Load(object sender, EventArgs e)
        {

        }
    }
}
