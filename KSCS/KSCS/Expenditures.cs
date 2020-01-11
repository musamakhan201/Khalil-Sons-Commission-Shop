using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace KSCS
{
    public partial class Expenditures : UserControl
    {
        public Expenditures()
        {
            InitializeComponent();
        }
        private PrintDocument document = new PrintDocument();

        private void Expenditures_Load(object sender, EventArgs e)
        {
            
            datebox.Text = DateTime.Now.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
