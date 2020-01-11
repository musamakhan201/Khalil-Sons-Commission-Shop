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
    public partial class employees : UserControl
    {
        SqlConnection sc = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=KSCS;Persist Security Info=True;User ID=sa;Password=1234");
        public employees()
        {
            InitializeComponent();
        }
        
        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || e.KeyChar == 45))
                e.Handled = true;
        }

        private void cnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || e.KeyChar == 45))
                e.Handled = true;
        }

        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void employees_Load(object sender, EventArgs e)
        {
            string id;
            date.Text = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss");
            sc.Open();
            SqlCommand s = new SqlCommand("select EMPLOYEE_ID from employees order by EMPLOYEE_ID Desc", sc);
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
            idno.Text = id.ToString();
            sdr.Close();
            string sql = ("select * from employees order by EMPLOYEE_ID");
            SqlDataAdapter sda = new SqlDataAdapter(sql, sc);
            SqlCommand cmd = new SqlCommand(sql, sc);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt;
            dataGridView3.DataSource = dt;
            dataGridView4.DataSource = dt;
            foreach (DataRow dr in dt.Rows)
            {
                eid.Items.Add(dr["EMPLOYEE_ID"].ToString());
            }
            sc.Close();
        }


        private void eid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                string sql = ("select * from employees where EMPLOYEE_ID='" + eid.SelectedItem.ToString() + "'");
                SqlDataAdapter sda = new SqlDataAdapter(sql, sc);
                SqlCommand cmd = new SqlCommand(sql, sc);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ename.Text = dr["EMPLOYEE_NAME"].ToString();
                    ephone.Text = dr["EMPLOYEE_PHONE#"].ToString();
                    ecnic.Text = dr["EMPLOYEE_CNIC"].ToString();
                    esalary.Text = dr["EMPLOYEE_SALARY"].ToString();
                    epaybasis.Text = dr["PAY_BASIS"].ToString();
                    etype.Text = dr["EMPLOYEE_TYPE"].ToString();
                    eaddress.Text = dr["ADDRESS"].ToString();
                    edate.Text = dr["DATE"].ToString();
                }
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sc.Close();
            }
        }

       
           

        private void dataGridView4_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sc.Open();
                    string selectedid = dataGridView4.CurrentRow.Cells["EMPLOYEE_ID"].Value.ToString();
                    string selectedname = dataGridView4.CurrentRow.Cells["EMPLOYEE_NAME"].Value.ToString();
                    string selectedphone = dataGridView4.CurrentRow.Cells["EMPLOYEE_PHONE#"].Value.ToString();
                    string selectedcnic = dataGridView4.CurrentRow.Cells["EMPLOYEE_CNIC"].Value.ToString();
                    string selectedsalary = dataGridView4.CurrentRow.Cells["EMPLOYEE_SALARY"].Value.ToString();
                    string selectedpay = dataGridView4.CurrentRow.Cells["PAY_BASIS"].Value.ToString();
                    string selectedtype = dataGridView4.CurrentRow.Cells["EMPLOYEE_TYPE"].Value.ToString();
                    string selectedADDRESS = dataGridView4.CurrentRow.Cells["ADDRESS"].Value.ToString();
                    string selecteddate = dataGridView4.CurrentRow.Cells["DATE"].Value.ToString();
                    string delete = "delete from employees where EMPLOYEE_ID='" + selectedid + "' and EMPLOYEE_NAME='" + selectedname + "' and EMPLOYEE_PHONE#='" + selectedphone + "' and EMPLOYEE_CNIC='" + selectedcnic + "' and EMPLOYEE_SALARY='" + selectedsalary + "' and PAY_BASIS='" + selectedpay + "' and EMPLOYEE_TYPE='" + selectedtype + "' and ADDRESS='" + selectedADDRESS + "'and DATE='" + selecteddate + "'";
                    SqlCommand cmd = new SqlCommand(delete, sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string sq = ("select * from employees order by EMPLOYEE_ID");
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

        public void exportexcel(string name)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
                worksheet = workbook.Sheets["sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Employees";
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
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

        

       

        private void pdf_Click_1(object sender, EventArgs e)
        {
            exportpdf(dataGridView1, "Employees");
            System.Diagnostics.Process.Start(@"C:\Users\zaeem  hassan\Documents\Employees.pdf");
        }

        private void excel_Click_1(object sender, EventArgs e)
        {
            exportexcel("Employees");
            System.Diagnostics.Process.Start(@"C:\Users\zaeem  hassan\Documents\Employees.xlsx");
        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void refresh_Click_1(object sender, EventArgs e)
        {
            sc.Open();
            string sq = ("select * from employees order by EMPLOYEE_ID");
            SqlDataAdapter sda = new SqlDataAdapter(sq, sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sc.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    name.LineFocusedColor = System.Drawing.Color.Red;
                    name.Focus();
                }


                else if (phone.Text.Length > 12)
                {
                    MessageBox.Show("Please Enter Phone No According to Format 0000-0000000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    phone.LineFocusedColor = System.Drawing.Color.Red;
                    phone.Focus();
                }

                else if (cnic.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter CNIC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cnic.LineFocusedColor = System.Drawing.Color.Red;
                    cnic.Focus();
                }

                else if (cnic.Text.Length != 15)
                {
                    MessageBox.Show("Please Enter CNIC According to Format 00000-0000000-0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cnic.LineFocusedColor = System.Drawing.Color.Red;
                    cnic.Focus();
                }

                else if (salary.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Salary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    salary.LineFocusedColor = System.Drawing.Color.Red;
                    salary.Focus();
                }

                else if (address.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter ADDRESS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    address.LineFocusedColor = System.Drawing.Color.Red;
                    address.Focus();
                }



                else
                {


                    sc.Open();
                    string sql = ("insert into employees values ('" + idno.Text + "','" + name.Text + "', '" + phone.Text + "', '" + cnic.Text + "', '" + type.selectedValue + "', '" + paybasis.selectedValue + "','" + salary.Text + "', '" + address.Text + "','" + date.Text + "')");

                    SqlCommand comd = new SqlCommand(sql, sc);

                    comd.ExecuteNonQuery();

                    MessageBox.Show("Employee Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    name.Text = "";
                    phone.Text = "";
                    cnic.Text = "";
                    address.Text = "";
                    salary.Text = "";
                    paybasis.selectedIndex = 0;
                    type.selectedIndex = 0;
                    string sq = ("select * from employees order by EMPLOYEE_ID");
                    SqlDataAdapter sda = new SqlDataAdapter(sq, sc);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;


                    string id;
                    SqlCommand s = new SqlCommand("select EMPLOYEE_ID from employees order by EMPLOYEE_ID Desc", sc);
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
                    idno.Text = id.ToString();
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
                string sql = ("update employees set EMPLOYEE_NAME='" + ename.Text + "', EMPLOYEE_PHONE#='" + ephone.Text + "',EMPLOYEE_CNIC='" + ecnic.Text + "', EMPLOYEE_SALARY='" + esalary.Text + "', PAY_BASIS='" + epaybasis.Text + "', EMPLOYEE_TYPE='" + etype.Text + "', ADDRESS='" + eaddress.Text + "', DATE='" + edate.Text + "' where EMPLOYEE_ID='" + eid.Text + "'");

                SqlCommand comd = new SqlCommand(sql, sc);

                comd.ExecuteNonQuery();

                MessageBox.Show("Employee Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ename.Text = "";
                ephone.Text = "";
                ecnic.Text = "";
                eaddress.Text = "";
                esalary.Text = "";
                edate.Text = "";

                string sq = ("select * from employees order by EMPLOYEE_ID");
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
            string sq = ("select * from employees order by EMPLOYEE_ID");
            SqlDataAdapter sda = new SqlDataAdapter(sq, sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView3.DataSource = dt;
            sc.Close();
        }

        private void rfreshh_Click(object sender, EventArgs e)
        {
            sc.Open();
            string sq = ("select * from employees order by EMPLOYEE_ID");
            SqlDataAdapter sda = new SqlDataAdapter(sq, sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView4.DataSource = dt;
            sc.Close();
        }

        private void search_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.Open();
            string sq = ("select * from employees");
            SqlDataAdapter sda = new SqlDataAdapter(sq, sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("EMPLOYEE_NAME like '%{0}%'", search.Text);
                dataGridView4.DataSource = dv.ToTable();
            }
            sc.Close();
        }
    }
    }


