using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenejadorTransacciones
{
    public partial class CalculadoraML : Form
    {
        public CalculadoraML()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            decimal precioVenta = decimal.Parse(inputGanDeseada.Text) + decimal.Parse(inputCostoProd.Text) + decimal.Parse(inputRetGan.Text) + decimal.Parse(inputCostEnv.Text);
            precioVenta /= (1 - decimal.Parse(inputRetML.Text) / 100 - decimal.Parse(inputImpIVA.Text) / 100);
            MessageBox.Show($"El precio de venta es: {precioVenta:C2}", "Precio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Threading.Thread.Sleep(2000);
            this.Close();
        }
    }
}
