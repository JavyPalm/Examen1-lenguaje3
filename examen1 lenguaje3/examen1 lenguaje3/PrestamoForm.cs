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
    public partial class PrestamoForm : Form
    {
        public PrestamoForm()
        {
            InitializeComponent();
        }

        private void descuentoToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            decimal monto = Convert.ToDecimal(MontoprestamoTextBox.Text);
            decimal tasa = Convert.ToDecimal(TasaprestamotextBox.Text);
            decimal tiempo = Convert.ToDecimal(TiempoTextBox.Text);

            decimal interesenero = monto * tasa * ((tiempo / 12));
            decimal nuevomonto = interesenero + monto;
            decimal interesfeb = nuevomonto * tasa * ((tiempo / 12) + 1);
            decimal nuevomonto2 = interesfeb + monto;
            decimal interesmar = nuevomonto2 * tasa * ((tiempo / 12) + 2);
            decimal nuevomonto3 = interesmar + monto;
            decimal interesabr = nuevomonto3 * tasa * ((tiempo / 12) + 3);
            decimal nuevomonto4 = interesabr + monto;
            decimal interesmay = nuevomonto4 * tasa * ((tiempo / 12) + 4);
            decimal nuevomonto5 = interesmay + monto;
            decimal interesjun = nuevomonto5 * tasa * ((tiempo / 12) + 5);
            decimal nuevomonto6 = interesjun + monto;
            decimal interesjul = nuevomonto6 * tasa * ((tiempo / 12) + 6);
            decimal nuevomonto7 = interesjul + monto;
            decimal interesago = nuevomonto7 * tasa * ((tiempo / 12) + 7);
            decimal nuevomonto8 = interesago + monto;
            decimal interessept = nuevomonto8 * tasa * ((tiempo / 12) + 8);
            decimal nuevomonto9 = interessept + monto;
            decimal interesoct = nuevomonto9 * tasa * ((tiempo / 12) + 9);
            decimal nuevomonto10 = interesoct + monto;
            decimal interesnov = nuevomonto10 * tasa * ((tiempo / 12) + 10);
            decimal nuevomonto11 = interesnov + monto;
            decimal interesdic = nuevomonto11 * tasa * ((tiempo / 12) + 11);
            decimal nuevomonto12 = interesdic + monto;

            listBox1.Items.Add("Enero: " + nuevomonto);
            listBox1.Items.Add("Febrero: " + nuevomonto2);
            listBox1.Items.Add("Marzo: " + nuevomonto3);
            listBox1.Items.Add("Abril: " + nuevomonto4);
            listBox1.Items.Add("Mayo: " + nuevomonto5);
            listBox1.Items.Add("Junio: " + nuevomonto6);
            listBox1.Items.Add("Julio: " + nuevomonto7);
            listBox1.Items.Add("Agosto: " + nuevomonto8);
            listBox1.Items.Add("Septiembre: " + nuevomonto9);
            listBox1.Items.Add("Octubre: " + nuevomonto10);
            listBox1.Items.Add("Noviembre: " + nuevomonto11);
            listBox1.Items.Add("Diciembre: " + nuevomonto12);

        }
    }
}
