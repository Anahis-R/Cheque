using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheque
{
    public partial class frmEmisionCheque : Form
    {
        public frmEmisionCheque()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            Cheque.NumeroLetras.testUnidades();
            int num = Int32.Parse(this.txtCantidad.Text);
            this.txtResultado.Text = Cheque.NumeroLetras.getmillon(num);
        }
    }
}
