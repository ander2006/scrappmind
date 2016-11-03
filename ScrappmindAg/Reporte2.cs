using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrappmindAg
{
    public partial class Reporte2 : Form
    {
        public Reporte2()
        {
            InitializeComponent();
        }
        public string IdCliente;
        private void Reporte2_Load(object sender, EventArgs e)
        {
            Reporte1 Objreporte = new Reporte1();
            crystalReportViewer1.ReportSource = Objreporte;
        }
    }
}
