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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Configuration;
using System.IO;
using iText.Kernel.Pdf;

namespace KSCS
{
    public partial class Buyer : UserControl
    {
        SqlConnection sc = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=KSCS;Persist Security Info=True;User ID=sa;Password=1234");
        public Buyer()
        {
            InitializeComponent();
        }
        private void bphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || e.KeyChar == 45))
                e.Handled = true;
        }
        private void dataGridView4_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void crops_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (bname.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bname.LineFocusedColor = System.Drawing.Color.Red;
                    bname.Focus();
                }

                else if (bphone.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Phone No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bphone.LineFocusedColor = System.Drawing.Color.Red;
                    bphone.Focus();
                }

                else if (bemail.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bemail.LineFocusedColor = System.Drawing.Color.Red;
                    bemail.Focus();
                }
                else if (bphone.Text.Length != 12)
                {
                    MessageBox.Show("Please Enter Phone No According to Format 0000-0000000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bphone.LineFocusedColor = System.Drawing.Color.Red;
                    bphone.Focus();
                }
                else if (bcrops.Text.Trim() == "Select")
                {
                    MessageBox.Show("Please Select Crops.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (bcompany.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Company.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bcompany.LineFocusedColor = System.Drawing.Color.Red;
                    bcompany.Focus();
                }

                else if (baddress.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter ADDRESS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    baddress.LineFocusedColor = System.Drawing.Color.Red;
                    baddress.Focus();
                }



                else
                {


                    sc.Open();
                    string sql = ("insert into buyer values ('" + bidno.Text + "','" + bname.Text + "', '" + bemail.Text + "', '" + bphone.Text + "', '" + bcrops.selectedValue + "', '" + bcompany.Text + "', '" + baddress.Text + "','" + bdate.Text + "')");

                    SqlCommand comd = new SqlCommand(sql, sc);

                    comd.ExecuteNonQuery();

                    MessageBox.Show("Buyer Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bname.Text = "";
                    bemail.Text="";
                    bphone.Text = "";
                    bcrops.selectedIndex = 0;
                    bcompany.Text = "";
                    baddress.Text = "";
                    
                   

                    string sq = ("select * from buyer order by BUYER_ID");
                    SqlDataAdapter sda = new SqlDataAdapter(sq, sc);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;


                    string id;
                    SqlCommand s = new SqlCommand("select BUYER_ID from buyer order by BUYER_ID Desc", sc);
                    SqlDataReader sdr = s.ExecuteReader();
                    if (sdr.Read())
                    {
                        int i = int.Parse(sdr[0].ToString()) + 1;
                        id = i.ToString("0");
                    }
                    else if (Convert.IsDBNull(sdr))
                    {
                        id = "1";
                    }
                    else
                    {
                        id = "1";
                    }
                    bidno.Text = id.ToString();
                    sdr.Close();
                    sc.Close();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sc.Close();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                string sql = ("update buyer set BUYER_NAME='" +ubname.Text + "', BUYER_EMAIL='" + ubemail.Text + "',BUYER_PHONE='" + ubphone.Text + "', CROPS_BUY='" + ubcrops.Text + "', COMPANY='" + ubcompany.Text + "', ADDRESS='" + ubaddress.Text + "' where BUYER_ID='" + bid.Text + "'");

                SqlCommand comd = new SqlCommand(sql, sc);

                comd.ExecuteNonQuery();

                MessageBox.Show("Buyer Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ubname.Text = "";
                ubemail.Text = "";
                ubphone.Text = "";
                ubcompany.Text = "";
                
                ubaddress.Text = "";
                

                string sq = ("select * from buyer order by BUYER_ID");
                SqlDataAdapter sda = new SqlDataAdapter(sq, sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView3.DataSource = dt;
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sc.Close();
            }
        }

        private void rfrsh_Click(object sender, EventArgs e)
        {

            sc.Open();
            string sq = ("select * from buyer order by BUYER_ID");
            SqlDataAdapter sda = new SqlDataAdapter(sq, sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView3.DataSource = dt;
            sc.Close();
        }

        private void bid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                string sql = ("select * from buyer where BUYER_ID='" + bid.SelectedItem.ToString() + "'");
                SqlDataAdapter sda = new SqlDataAdapter(sql, sc);
                SqlCommand cmd = new SqlCommand(sql, sc);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ubname.Text = dr["BUYER_NAME"].ToString();
                    ubemail.Text = dr["BUYER_EMAIL"].ToString();
                    ubphone.Text = dr["BUYER_PHONE"].ToString();
                    ubcrops.Text = dr["CROPS_BUY"].ToString();
                    ubcompany.Text = dr["COMPANY"].ToString();
                    ubaddress.Text = dr["ADDRESS"].ToString();
                    ubdate.Text = dr["DATE"].ToString();
                }
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sc.Close();
            }
        }

        private void rfreshh_Click(object sender, EventArgs e)
        {

            sc.Open();
            string sq = ("select * from buyer order by BUYER_ID");
            SqlDataAdapter sda = new SqlDataAdapter(sq, sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView4.DataSource = dt;
            sc.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Are you sure to delete data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sc.Open();
                    string selectedid = dataGridView4.CurrentRow.Cells["BUYER_ID"].Value.ToString();
                    string selectedname = dataGridView4.CurrentRow.Cells["BUYER_NAME"].Value.ToString();
                    string selectedemail = dataGridView4.CurrentRow.Cells["BUYER_EMAIL"].Value.ToString();
                    string selectedphone = dataGridView4.CurrentRow.Cells["BUYER_PHONE"].Value.ToString();
                    string selectedcrops = dataGridView4.CurrentRow.Cells["CROPS_BUY"].Value.ToString();
                    string selectedcompany = dataGridView4.CurrentRow.Cells["COMPANY"].Value.ToString();
                    string selectedADDRESS = dataGridView4.CurrentRow.Cells["ADDRESS"].Value.ToString();
                    string selecteddate = dataGridView4.CurrentRow.Cells["DATE"].Value.ToString();
                    string delete = "delete from buyer where BUYER_ID='" + selectedid + "' and BUYER_NAME='" + selectedname + "' and BUYER_EMAIL='" + selectedemail + "' and BUYER_PHONE='" + selectedphone + "' and CROPS_BUY='" + selectedcrops + "' and COMPANY='" + selectedcompany + "' and ADDRESS='" + selectedADDRESS + "'and DATE='" + selecteddate + "'";
                    SqlCommand cmd = new SqlCommand(delete, sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Buyer Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string sq = ("select * from buyer order by BUYER_ID");
                    SqlDataAdapter sda = new SqlDataAdapter(sq, sc);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView4.DataSource = dt;
                    sc.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sc.Close();
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            sc.Open();
            string sq = ("select * from buyer order by BUYER_ID");
            SqlDataAdapter sda = new SqlDataAdapter(sq, sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dg1.DataSource = dt;
            sc.Close();
        }
        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.Open();
            string sq = ("select * from buyer");
            SqlDataAdapter sda = new SqlDataAdapter(sq, sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dg1.DataSource = dt;
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("BUYER_NAME like '%{0}%'", search.Text);
                dataGridView4.DataSource = dv.ToTable();
            }
            sc.Close();
        }

        private void search_OnValueChanged(object sender, EventArgs e)
        {

        }
        

        public void exportexcel(string name)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
                worksheet = workbook.Sheets["sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Buyers";
                for (int i = 1; i < dg1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dg1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dg1.Rows.Count; i++)
                {
                    for (int j = 0; j < dg1.Columns.Count; j++)
                    {
                        if (dg1.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dg1.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                }
                var savefile = new SaveFileDialog();
                savefile.FileName = name;
                savefile.DefaultExt = ".xlsx";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(savefile.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("File is open in another application, closed it first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exppdf_Click(object sender, EventArgs e)
        {

            exportpdf(dg1, "Buyers");
            System.Diagnostics.Process.Start(@"C:\Users\zaeem  hassan\Documents\Buyers.pdf");
        }

        private void expexl_Click(object sender, EventArgs e)
        {
            exportexcel("Buyers");
            System.Diagnostics.Process.Start(@"C:\Users\zaeem  hassan\Documents\Buyers.xlsx");
        }

        private void Buyer_Load_1(object sender, EventArgs e)
        {
            string id;
            bdate.Text = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss");
            sc.Open();
            SqlCommand s = new SqlCommand("select BUYER_ID from buyer order by BUYER_ID Desc", sc);
            SqlDataReader sdr = s.ExecuteReader();
            if (sdr.Read())
            {
                int i = int.Parse(sdr[0].ToString()) + 1;
                id = i.ToString("0");
            }
            else if (Convert.IsDBNull(sdr))
            {
                id = "1";
            }
            else
            {
                id = "1";
            }
            bidno.Text = id.ToString();
            sdr.Close();
            string sql = ("select * from buyer order by BUYER_ID");
            SqlDataAdapter sda = new SqlDataAdapter(sql, sc);
            SqlCommand cmd = new SqlCommand(sql, sc);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dg1.DataSource = dt.DefaultView;
            dataGridView2.DataSource = dt.DefaultView;
            dataGridView3.DataSource = dt.DefaultView;
            dataGridView4.DataSource = dt.DefaultView;
            foreach (DataRow dr in dt.Rows)
            {
                bid.Items.Add(dr["BUYER_ID"].ToString());
            }
            sc.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void search_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            sc.Open();
            string sq = ("select * from buyer");
            SqlDataAdapter sda = new SqlDataAdapter(sq, sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dg1.DataSource = dt;
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("BUYER_NAME like '%{0}%'", search.Text);
                dataGridView4.DataSource = dv.ToTable();
            }
            sc.Close();
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
                        //table.AddCell(new Phrase(cell.Value.ToString(), text));
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
    }
    }
    
   


