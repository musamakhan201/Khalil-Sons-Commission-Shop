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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace KSCS
{
    public partial class Order : UserControl
    {
        SqlConnection sc = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=KSCS;Persist Security Info=True;User ID=sa;Password=1234");
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss");
            buyerdate.Text = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss");
            sc.Open();
            string sql = ("select * from farmer order by FARMER_NAME");
            SqlDataAdapter sda = new SqlDataAdapter(sql, sc);
            SqlCommand cmd = new SqlCommand(sql, sc);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                fname.Items.Add(dr["FARMER_NAME"].ToString());
            }
            sc.Close();
            sc.Open();
            string sq = ("select * from buyer order by BUYER_NAME");
            SqlDataAdapter sd = new SqlDataAdapter(sq, sc);
            SqlCommand cm = new SqlCommand(sq, sc);
            cm.ExecuteNonQuery();
            DataTable d = new DataTable();
            sd.Fill(d);
            foreach (DataRow dd in d.Rows)
            {
                bbname.Items.Add(dd["BUYER_NAME"].ToString());
            }

            string ss = ("select FARMER_ID,NAME,PHONE#,CNIC,CROPS,TOTAL_WEIGHT,RATE,TOTAL_AMOUNT,PAYMENT,BALANCE,REMAIN,DATE from order1 where BUYER_ID = 0");
            SqlDataAdapter sdd = new SqlDataAdapter(ss, sc);
            SqlCommand cmdd = new SqlCommand(ss, sc);
            cmdd.ExecuteNonQuery();
            DataTable dtt = new DataTable();
            sdd.Fill(dtt);
            dataGridView2.DataSource = dtt.DefaultView;

            string s = ("select BUYER_ID,NAME,PHONE#,CROPS,TOTAL_WEIGHT,RATE,TOTAL_AMOUNT,PAYMENT,BALANCE,REMAIN,DATE from order1 where FARMER_ID = 0");
            SqlDataAdapter sdp = new SqlDataAdapter(s, sc);
            SqlCommand cdd = new SqlCommand(s, sc);
            cdd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            sdp.Fill(dta);
            dataGridView1.DataSource = dta.DefaultView;
            sc.Close();
        }

        private void fid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                string sql = ("select * from farmer where FARMER_NAME='" + fname.SelectedItem.ToString() + "'");
                SqlDataAdapter sda = new SqlDataAdapter(sql, sc);
                SqlCommand cmd = new SqlCommand(sql, sc);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    idno.Text = dr["FARMER_ID"].ToString();
                    name.Text = dr["FARMER_NAME"].ToString();
                    phone.Text = dr["FARMER_PHONE#"].ToString();
                    cnic.Text = dr["FARMER_CNIC"].ToString();
                }
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sc.Close();
            }
        }
       
        private void purchase_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                string sql = "insert into order1 values('"+idno.Text+ "','0','" + name.Text + "','" + phone.Text + "','" + cnic.Text + "','" + crops.selectedValue + "','" +tweight.Text + "','" + rate.Text + "','" + tamount.Text + "','" + payment.Text + "','" + balance.Text + "','" + remain.Text + "','" + date.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, sc);
                cmd.ExecuteNonQuery();
                string ss = ("select FARMER_ID,NAME,PHONE#,CNIC,CROPS,TOTAL_WEIGHT,RATE,TOTAL_AMOUNT,PAYMENT,BALANCE,REMAIN,DATE from order1 where BUYER_ID = 0");
                SqlDataAdapter sdd = new SqlDataAdapter(ss, sc);
                SqlCommand cmdd = new SqlCommand(ss, sc);
                cmdd.ExecuteNonQuery();
                DataTable dtt = new DataTable();
                sdd.Fill(dtt);
                dataGridView2.DataSource = dtt.DefaultView;
                if (MessageBox.Show("Are you want to print recipit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    exportpdf(dataGridView2, "RECIPIT");
                    System.Diagnostics.Process.Start(@"C:\Users\zaeem  hassan\Documents\RECIPIT.pdf");
                }
                    sc.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sc.Close();
            }
        }

        private void rate_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (crops.selectedIndex == 0)
                {
                    MessageBox.Show("Please Select The Crop First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rate.Text = "";
                }
                else if (tweight.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Weight First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tweight.LineFocusedColor = System.Drawing.Color.Red;
                    tweight.Focus();
                    rate.Text = "";
                }
                else
                {
                    double weight = double.Parse(tweight.Text);
                    double price = double.Parse(rate.Text);
                    double tprice = (weight * price);
                    tamount.Text = tprice.ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void payment_OnValueChanged(object sender, EventArgs e)
        {
          try
            {
                if (crops.selectedIndex <= 0)
                {
                    MessageBox.Show("Please Select The Crop First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rate.Text = "";
                }
                else if (tweight.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Weight First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tweight.LineFocusedColor = System.Drawing.Color.Red;
                    tweight.Focus();
                    rate.Text = "";
                }
                else
                {
                    double total = double.Parse(tamount.Text);
                    double paymnt = double.Parse(payment.Text);
                    double blnc = total - paymnt;
                    if (paymnt < total)
                    {
                        balance.Text = blnc.ToString();
                    }
                    else
                    {
                        balance.Text = "0";

                       double rr =(-1*(blnc));
                        remain.Text = blnc.ToString();
                    }
                }
               
                
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void remaining_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (crops.selectedIndex == 0)
                {
                    MessageBox.Show("Please Select The Crop First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rate.Text = "";
                }
                else if (tweight.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Weight First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tweight.LineFocusedColor = System.Drawing.Color.Red;
                    tweight.Focus();
                    rate.Text = "";
                }
                else
                {
                    double total = double.Parse(tamount.Text);
                    double rem = double.Parse(remaining.Text);
                    double tt = total - rem;
                    tamount.Text = tt.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void bunifuMaterialTextbox14_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (bcrops.selectedIndex == 0)
                {
                    MessageBox.Show("Please Select The Crop First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   brate.Text = "";
                }
                else if (btweight.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Weight First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btweight.LineFocusedColor = System.Drawing.Color.Red;
                    btweight.Focus();
                    brate.Text = "";
                }
                else
                {
                    double bweight = double.Parse(btweight.Text);
                    double bprice = double.Parse(brate.Text);
                    double btprice = (bweight * bprice);
                    btamount.Text = btprice.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bbname_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                sc.Open();
                string sql = ("select * from buyer where BUYER_NAME='" + bbname.SelectedItem.ToString() + "'");
                SqlDataAdapter sda = new SqlDataAdapter(sql, sc);
                SqlCommand cmd = new SqlCommand(sql, sc);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    buyerid.Text = dr["BUYER_ID"].ToString();
                    bname.Text = dr["BUYER_NAME"].ToString();
                    bphone.Text = dr["BUYER_PHONE"].ToString();
                }
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sc.Close();
            }
        }
        public void exportpdf(DataGridView dgw, string filename)
        {
            try
            {
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                PdfPTable table = new PdfPTable(dgw.Columns.Count);
                table.DefaultCell.Padding = 3;
                table.WidthPercentage = 100;
                table.HorizontalAlignment = Element.ALIGN_LEFT;
                table.DefaultCell.BorderWidth = 0;
                iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

                //Adding Header
                PdfPTable table1 = new PdfPTable(1);
                table1.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                table1.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                table.DefaultCell.Padding = 1;
                table1.DefaultCell.BorderWidth = 0;

                PdfPTable table2 = new PdfPTable(1);
                table2.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                table2.DefaultCell.VerticalAlignment = Element.ALIGN_RIGHT;
                table2.DefaultCell.BorderWidth = 0;

                Chunk c1 = new Chunk("Khalil Sons Commission Shop", FontFactory.GetFont("Times New Roman"));
                c1.Font.Size = 25;
                Chunk c2 = new Chunk("Multan Road Pull Pakori, Sarai Sidhu", FontFactory.GetFont("Times New Roman"));
                c2.Font.Size = 15;
                Chunk c3 = new Chunk("+923336228241\n\n", FontFactory.GetFont("Times New Roman"));
                c1.Font.SetStyle(0);
                Phrase p1 = new Phrase(c1);
                Phrase p2 = new Phrase(c2);
                Phrase p3 = new Phrase(c3);
                table1.AddCell(p1);
                table1.AddCell(p2);
                table1.AddCell(p3);
                Chunk c = new Chunk("\n\n\n\n\n\n Generated at:  " + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt"));
                c.Font.Size = 8;
                Phrase t = new Phrase(c);
                table2.AddCell(t);
                foreach (DataGridViewColumn column in dgw.Columns)
                {


                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                    table.AddCell(cell);

                }

                //Adding DataRow

                foreach (DataGridViewRow row in dgw.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(new Phrase(cell.Value.ToString(), text));
                    }
                }

                var savefile = new SaveFileDialog();
                savefile.FileName = filename;
                savefile.DefaultExt = ".pdf";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

                        iTextSharp.text.pdf.PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();
                        pdfdoc.Add(table1);
                        pdfdoc.Add(table);
                        pdfdoc.Add(table2);
                        pdfdoc.Close();
                        stream.Close();

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("File is open in another application, closed it first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                string sql = "insert into order1 values('0','" + buyerid.Text + "','" + bname.Text + "','" + bphone.Text + "','11111-1111111-1','" + bcrops.selectedValue + "','" + btweight.Text + "','" + brate.Text + "','" + btamount.Text + "','" + bpayment.Text + "','" + bbalance.Text + "','" + bremain.Text + "','" + buyerdate.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, sc);
                cmd.ExecuteNonQuery();
                string ss = ("select BUYER_ID,NAME,PHONE#,CROPS,TOTAL_WEIGHT,RATE,TOTAL_AMOUNT,PAYMENT,BALANCE,REMAIN,DATE from order1 where FARMER_ID = 0");
                SqlDataAdapter sdd = new SqlDataAdapter(ss, sc);
                SqlCommand cmdd = new SqlCommand(ss, sc);
                cmdd.ExecuteNonQuery();
                DataTable dtt = new DataTable();
                sdd.Fill(dtt);
                dataGridView1.DataSource = dtt.DefaultView;
                if (MessageBox.Show("Are you want to print recipit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    exportpdf(dataGridView1, "RECIPIT");
                    System.Diagnostics.Process.Start(@"C:\Users\zaeem  hassan\Documents\RECIPIT.pdf");
                }
                sc.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sc.Close();
            }
        }

        private void bcrops_onItemSelected(object sender, EventArgs e)
        {

        }

        private void crops_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bremaining_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (bcrops.selectedIndex == 0)
                {
                    MessageBox.Show("Please Select The Crop First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    brate.Text = "";
                }
                else if (btweight.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Weight First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   btweight.LineFocusedColor = System.Drawing.Color.Red;
                    btweight.Focus();
                    brate.Text = "";
                }
                else
                {
                    double total = double.Parse(btamount.Text);
                    double rem = double.Parse(bremaining.Text);
                    double tt = total - rem;
                    btamount.Text = tt.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bpayment_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (bcrops.selectedIndex == 0)
                {
                    MessageBox.Show("Please Select The Crop First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    brate.Text = "";
                }
                else if (btweight.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Weight First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btweight.LineFocusedColor = System.Drawing.Color.Red;
                    btweight.Focus();
                    brate.Text = "";
                }
                else
                {
                    double total = double.Parse(btamount.Text);
                    double paymnt = double.Parse(bpayment.Text);
                    double blnc = total - paymnt;
                    if (paymnt < total)
                    {
                        bbalance.Text = blnc.ToString();
                    }
                    else
                    {
                       bbalance.Text = "0";

                        double rr = (-1 * (blnc));
                        bremain.Text = blnc.ToString();
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bremain_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void remain_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void tweight_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void tamount_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void balance_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void date_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btweight_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bcrops_onItemSelected_1(object sender, EventArgs e)
        {

        }

        private void btamount_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
