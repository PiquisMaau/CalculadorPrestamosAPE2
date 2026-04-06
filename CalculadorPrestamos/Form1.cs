using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

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

            if (comboBoxAmortizacion.Text == "ALEMANA") 
            {
                LlenarGridConMatriz(AmortizacionAlemana(Convert.ToDecimal(textBoxMontoSolicitado.Text), Convert.ToInt32(numericUpDownTiempoPagar.Value), numericUpDownTasaInteres.Value), Convert.ToInt32(numericUpDownTiempoPagar.Value), fechaBase);

            }
            if (comboBoxAmortizacion.Text == "FRANCESA")
            {
                LlenarGridConMatriz(AmortizacionFrancesa(Convert.ToDecimal(textBoxMontoSolicitado.Text), Convert.ToInt32(numericUpDownTiempoPagar.Value), numericUpDownTasaInteres.Value), Convert.ToInt32(numericUpDownTiempoPagar.Value), fechaBase);

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

        //private decimal[,] AmortizacionFrancesa(decimal monto, decimal tasaInteresAnual, int plazoMeses)
        //{
        //     //como 

        //}
        public decimal[,] AmortizacionAlemana(decimal monto, int cuotas, decimal tasaInteresAnual)
        {
            decimal tasaInteresMensual = (tasaInteresAnual / 100m) / 12m;
            decimal tasaSeguroDesg = 0.0014m;
            decimal tasaSeguroIncendios = 0.00m;
            if (comboBoxTipoCredito.SelectedItem.ToString() == "VIVIENDA DE INTERÉS PÚBLICO")
            {
                tasaSeguroIncendios = 0.0002m;
            }
            if (comboBoxTipoCredito.SelectedItem.ToString() == "HIPOTECARIO VIVIENDA")
            {
                tasaSeguroIncendios = 0.00015m;
            }

            decimal amortizacionConstante = monto / cuotas;
            decimal saldo = monto;

            decimal[,] tabla = new decimal[cuotas, 7];

            for (int i = 0; i < cuotas; i++)
            {
                decimal interesMes = saldo * tasaInteresMensual;
                decimal seguroDesg = saldo * tasaSeguroDesg;
                decimal seguroInc = saldo * tasaSeguroIncendios;

                decimal valorCuota = amortizacionConstante + interesMes + seguroDesg + seguroInc;

                saldo = saldo - amortizacionConstante;

                tabla[i, 0] = i + 1;
                tabla[i, 1] = amortizacionConstante;
                tabla[i, 2] = interesMes;
                tabla[i, 3] = seguroDesg;
                tabla[i, 4] = seguroInc;
                tabla[i, 5] = valorCuota;
                tabla[i, 6] = Math.Abs(saldo);
            }

            return tabla;
        }
        public decimal[,] AmortizacionFrancesa(decimal monto, int cuotas, decimal tasaInteresAnual)
        {
            decimal tasaInteresMensual = (tasaInteresAnual / 100m) / 12m;
            decimal tasaSeguroDesg = 0.0014m;
            decimal tasaSeguroIncendios = 0.00m;
            if (comboBoxTipoCredito.SelectedItem.ToString() == "VIVIENDA DE INTERÉS PÚBLICO")
            {
                tasaSeguroIncendios = 0.0002m;
            }
            if (comboBoxTipoCredito.SelectedItem.ToString() == "HIPOTECARIO VIVIENDA")
            {
                tasaSeguroIncendios = 0.00015m;
            }

            double i_double = (double)tasaInteresMensual;
            double n_double = (double)cuotas;
            double cuotaBaseDouble = (double)monto * (i_double / (1.0 - Math.Pow(1.0 + i_double, -n_double)));
            decimal cuotaFijaBase = (decimal)cuotaBaseDouble;

            decimal saldo = monto;
            decimal[,] tabla = new decimal[cuotas, 7];

            for (int i = 0; i < cuotas; i++)
            {
                decimal interesMes = saldo * tasaInteresMensual;
                decimal amortizacionCapital = cuotaFijaBase - interesMes;

                if (i == cuotas - 1)
                {
                    amortizacionCapital = saldo;
                }

                decimal seguroDesg = saldo * tasaSeguroDesg;
                decimal seguroInc = saldo * tasaSeguroIncendios;

                decimal valorCuota = amortizacionCapital + interesMes + seguroDesg + seguroInc;

                saldo = saldo - amortizacionCapital;

                tabla[i, 0] = i + 1;
                tabla[i, 1] = amortizacionCapital;
                tabla[i, 2] = interesMes;
                tabla[i, 3] = seguroDesg;
                tabla[i, 4] = seguroInc;
                tabla[i, 5] = valorCuota;
                tabla[i, 6] = Math.Abs(saldo);
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

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxMontoSolicitado.Clear();

            numericUpDownTiempoPagar.Value = numericUpDownTiempoPagar.Minimum;
            numericUpDownTasaInteres.Value = numericUpDownTasaInteres.Minimum;

            comboBoxTipoCredito.SelectedIndex = -1;
            comboBoxAmortizacion.SelectedIndex = -1;

            dataGridViewAmortizacion.Rows.Clear();
            dataGridViewAmortizacion.Columns.Clear();

            textBoxMontoSolicitado.Focus();
        }
        private void InteresSegunTipo()
        {
            if (comboBoxTipoCredito.SelectedItem.ToString() == "PRECISO")
            {
                numericUpDownTasaInteres.Value = Convert.ToDecimal(15.60);
                numericUpDownTasaInteres.Visible = true;
            }
            if (comboBoxTipoCredito.SelectedItem.ToString() == "HIPOTECARIO VIVIENDA")
            {
                numericUpDownTasaInteres.Value = Convert.ToDecimal(10.10);
                numericUpDownTasaInteres.Visible = true;
               // label_ValorVivienda.Visible = true;
               // textBox_ValorVivienda.Visible = true;
            }
            if (comboBoxTipoCredito.SelectedItem.ToString() == "EDUCACIÓN SUPERIOR")
            {
                numericUpDownTasaInteres.Value = Convert.ToDecimal(9);
                numericUpDownTasaInteres.Visible = true;
            }
            if (comboBoxTipoCredito.SelectedItem.ToString() == "VIVIENDA DE INTERÉS PÚBLICO")
            {
                numericUpDownTasaInteres.Value = Convert.ToDecimal(4.87);
                numericUpDownTasaInteres.Visible = true;
            }
            if (comboBoxTipoCredito.SelectedItem.ToString() == "LIBRE(INTERÉS CUSTOM)")
            {
                numericUpDownTasaInteres.Value = Convert.ToDecimal(0);
                numericUpDownTasaInteres.Visible = true;
            }
        }

        private void comboBoxTipoCredito_SelectionChangeCommitted(object sender, EventArgs e)
        {
            InteresSegunTipo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewAmortizacion.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar. Calcule una tabla primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            if (comboBoxAmortizacion.Text == "ALEMANA" )
            {
                dialog.FileName = "AmortizacionAlemana_BanUTA_.xlsx";

            }
            else if (comboBoxAmortizacion.Text == "FRANCESA")
            {
                dialog.FileName = "AmortizacionFrancesa_BanUTA_.xlsx";
            }


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Tabla de Amortización");

                        for (int i = 0; i < dataGridViewAmortizacion.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dataGridViewAmortizacion.Columns[i].HeaderText;
                            worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                            worksheet.Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                        }

                        for (int i = 0; i < dataGridViewAmortizacion.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridViewAmortizacion.Columns.Count; j++)
                            {
                                if (dataGridViewAmortizacion.Rows[i].Cells[j].Value != null)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dataGridViewAmortizacion.Rows[i].Cells[j].Value.ToString();
                                }
                            }
                        }

                        worksheet.Columns().AdjustToContents();
                        workbook.SaveAs(dialog.FileName);

                        MessageBox.Show("Excel exportado con éxito :)", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
