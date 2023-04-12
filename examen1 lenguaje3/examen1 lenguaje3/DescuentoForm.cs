using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen1_lenguaje3
{
    public partial class DescuentoForm : Form
    {
        public DescuentoForm()
        {
            InitializeComponent();
        }

        private void DescuentoForm_Load(object sender, EventArgs e)
        {


        }


        private async Task Calcularbutton_Click(object sender, EventArgs e)
        {
            {
                decimal Producto1 = Convert.ToDecimal(prod1textBox.Text);
                decimal Producto2 = Convert.ToDecimal(prod2textBox.Text);
                decimal Impuesto = Convert.ToDecimal(imptextBox.Text);
                decimal Descuento = Convert.ToDecimal(desctextBox.Text);


                decimal GenerarFactura = await GenerarFacturaAsync(Producto1, Producto2, Impuesto, Descuento);


                MessageBox.Show($"El Descuento es:{GenerarFactura}");
            }
        }

        private static async Task<decimal> GenerarFacturaAsync(decimal Prod1, decimal Prod2, decimal IMP, decimal DESC)
        {
            decimal Factura = await Task.Run(() =>
            {
                return (Prod1 + Prod2 * IMP - DESC);
            });
            return Factura;
        }
    }
}
    
