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
        DateTime fechaBase = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
            ConfigurarTabla();
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
            ConfigurarTabla();

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

            LlenarGridConMatriz(AmortizacionAlemana(), Convert.ToInt32(numericUpDownTiempoPagar.Value), fechaBase);
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

        //private decimal[,] AmortizacionFrancesa(decimal monto, decimal tasaInteresAnual, int plazoMeses)
        //{
        //     //como 

        //}
        public decimal[,] AmortizacionAlemana()
        {
            double monto = Convert.ToDouble(textBoxMontoSolicitado.Text);
            int cuotas = Convert.ToInt32(numericUpDownTiempoPagar.Value);
            double tasaInteresMensual = Convert.ToDouble(numericUpDownTasaInteres.Value) / 1200;
            double tasaSeguro = 0.0014;
            double gasto = monto * 0.005;
            double capital = monto - gasto;
            double amortizacion = Math.Round(capital / cuotas, 0);
            double saldo = capital;
            decimal[,] tabla = new decimal[cuotas, 7];
            for (int i = 0; i < cuotas; i++)
            {
                double amortizacionCuota = amortizacion;
                double interes = saldo * tasaInteresMensual;
                double seguro = saldo * tasaSeguro;
                double valorCuota = amortizacionCuota + interes + seguro;
                double saldoFinal = saldo - amortizacionCuota;
                tabla[i, 0] = i + 1;
                tabla[i, 1] = Convert.ToDecimal(Math.Round(amortizacionCuota, 0));
                tabla[i, 2] = Convert.ToDecimal(interes);
                tabla[i, 3] = Convert.ToDecimal(seguro);
                tabla[i, 4] = 0;
                tabla[i, 5] = Convert.ToDecimal(valorCuota);
                tabla[i, 6] = Convert.ToDecimal(saldoFinal);
                saldo = saldoFinal;
            }
            return tabla;
        }
        private void ExportarExcel()
        {

        }
        private void ConfigurarTabla()
        {
            dataGridViewAmortizacion.Columns.Clear();
            dataGridViewAmortizacion.Rows.Clear();

            dataGridViewAmortizacion.Columns.Add("Cuotas", "Cuotas");
            dataGridViewAmortizacion.Columns.Add("FechaPago", "Fecha de pago");
            dataGridViewAmortizacion.Columns.Add("Capital", "Capital");
            dataGridViewAmortizacion.Columns.Add("Interes", "Interés");
            dataGridViewAmortizacion.Columns.Add("SeguroDesgravamen", "Seguros desg.");
            dataGridViewAmortizacion.Columns.Add("SeguroIncendios", "Seguro Incendios/Vehiculo");
            dataGridViewAmortizacion.Columns.Add("ValorCuota", "Valor cuota");
            dataGridViewAmortizacion.Columns.Add("Saldo", "Saldo");

            dataGridViewAmortizacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LlenarGridConMatriz(decimal[,] matriz, int filas, DateTime fechaInicio)
        {
            ConfigurarTabla();


            for (int i = 0; i < filas; i++)
            {
                DateTime fechaPago = fechaInicio.AddMonths(i + 1);
                dataGridViewAmortizacion.Rows.Add(
                    matriz[i, 0],
                    fechaPago.ToString("yyyy-MM-dd"),
                    Math.Round(matriz[i, 1], 2), 
                    Math.Round(matriz[i, 2], 2),
                    Math.Round(matriz[i, 3], 2),
                    Math.Round(matriz[i, 4], 2),
                    Math.Round(matriz[i, 5], 2),
                    Math.Round(matriz[i, 6], 2)
                   // Math.Round(matriz[i, 7], 2)
                    //Math.Round(matriz[i, 8], 2)
                );
            }
        }

    }
}
