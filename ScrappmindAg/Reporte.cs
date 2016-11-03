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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'scrappmindDataSet.tblcampos_registraduria' Puede moverla o quitarla según sea necesario.
            this.tblcampos_registraduriaTableAdapter.Fill(this.scrappmindDataSet.tblcampos_registraduria);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Reporte2 repor = new Reporte2();
            repor.ShowDialog();
        }
    }
}
