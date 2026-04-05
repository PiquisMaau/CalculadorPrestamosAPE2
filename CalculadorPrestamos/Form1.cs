using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadorPrestamos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ingrese el monto total del préstamo sin símbolos (Ej: 10000).";
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ingrese el tipo de crédito que desea solicitar";
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ingrese el tiempo en que va a pagar el crédito en meses";
        }

        private void numericUpDown2_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Tasa de interés recomendada por el tipo de préstamo (puede modificarse)";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMontoSolicitado.Text))
            {
                MessageBox.Show("Debe ingresar un valor en Monto Solicitado.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(textBoxMontoSolicitado.Text) <= 0 || numericUpDownTiempoPagar.Value <= 0)
            {
                MessageBox.Show("Valores 0 o menores no permitidos en Monto y Tiempo a Pagar", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (comboBoxAmortizacion.SelectedIndex == -1) 
            {
                MessageBox.Show("Seleccione el tipo de amortización (Francés o Alemán).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBoxMontoSolicitado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private decimal[,] AmortizacionFrancesa()
        {

        }
    }
}
