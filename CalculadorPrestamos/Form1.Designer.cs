namespace CalculadorPrestamos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTipoCredito = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMontoSolicitado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownTasaInteres = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTiempoPagar = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewAmortizacion = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxAmortizacion = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTasaInteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTiempoPagar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmortizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(75, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 10);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculadora de Préstamos BanUTA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculadorPrestamos.Properties.Resources.Gemini_Generated_Image_2u84xq2u84xq2u84;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxAmortizacion);
            this.groupBox1.Controls.Add(this.numericUpDownTiempoPagar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxMontoSolicitado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxTipoCredito);
            this.groupBox1.Controls.Add(this.numericUpDownTasaInteres);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(17, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 191);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos para la simulación de prestamos";
            // 
            // comboBoxTipoCredito
            // 
            this.comboBoxTipoCredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoCredito.FormattingEnabled = true;
            this.comboBoxTipoCredito.Items.AddRange(new object[] {
            "PRECISO",
            "HIPOTECARIO VIVIENDA",
            "EDUCACIÓN SUPERIOR",
            "VIVIENDA DE INTERÉAS PÚBLICO",
            "LIBRE"});
            this.comboBoxTipoCredito.Location = new System.Drawing.Point(138, 31);
            this.comboBoxTipoCredito.Name = "comboBoxTipoCredito";
            this.comboBoxTipoCredito.Size = new System.Drawing.Size(226, 24);
            this.comboBoxTipoCredito.TabIndex = 2;
            this.comboBoxTipoCredito.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBoxTipoCredito.Enter += new System.EventHandler(this.comboBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Crédito";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = " Monto Solicitado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxMontoSolicitado
            // 
            this.textBoxMontoSolicitado.AccessibleName = "";
            this.textBoxMontoSolicitado.Location = new System.Drawing.Point(138, 67);
            this.textBoxMontoSolicitado.Name = "textBoxMontoSolicitado";
            this.textBoxMontoSolicitado.Size = new System.Drawing.Size(226, 22);
            this.textBoxMontoSolicitado.TabIndex = 5;
            this.textBoxMontoSolicitado.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBoxMontoSolicitado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMontoSolicitado_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tasa de interés (%)";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // numericUpDownTasaInteres
            // 
            this.numericUpDownTasaInteres.DecimalPlaces = 2;
            this.numericUpDownTasaInteres.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numericUpDownTasaInteres.Location = new System.Drawing.Point(207, 141);
            this.numericUpDownTasaInteres.Name = "numericUpDownTasaInteres";
            this.numericUpDownTasaInteres.Size = new System.Drawing.Size(134, 22);
            this.numericUpDownTasaInteres.TabIndex = 1;
            this.numericUpDownTasaInteres.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            // 
            // numericUpDownTiempoPagar
            // 
            this.numericUpDownTiempoPagar.Location = new System.Drawing.Point(207, 104);
            this.numericUpDownTiempoPagar.Name = "numericUpDownTiempoPagar";
            this.numericUpDownTiempoPagar.Size = new System.Drawing.Size(134, 22);
            this.numericUpDownTiempoPagar.TabIndex = 7;
            this.numericUpDownTiempoPagar.Enter += new System.EventHandler(this.numericUpDown1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tiempo a Pagar (meses)";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel1.Text = "Info.";
            // 
            // dataGridViewAmortizacion
            // 
            this.dataGridViewAmortizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAmortizacion.Location = new System.Drawing.Point(17, 267);
            this.dataGridViewAmortizacion.Name = "dataGridViewAmortizacion";
            this.dataGridViewAmortizacion.RowTemplate.Height = 24;
            this.dataGridViewAmortizacion.Size = new System.Drawing.Size(771, 246);
            this.dataGridViewAmortizacion.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo de Amortización";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBoxAmortizacion
            // 
            this.comboBoxAmortizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAmortizacion.FormattingEnabled = true;
            this.comboBoxAmortizacion.Items.AddRange(new object[] {
            "ALEMANA",
            "FRANCESA"});
            this.comboBoxAmortizacion.Location = new System.Drawing.Point(549, 67);
            this.comboBoxAmortizacion.Name = "comboBoxAmortizacion";
            this.comboBoxAmortizacion.Size = new System.Drawing.Size(164, 24);
            this.comboBoxAmortizacion.TabIndex = 8;
            this.comboBoxAmortizacion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(533, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "EXPORTAR EXCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(626, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "LIMPIAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.dataGridViewAmortizacion);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Simulador de Crédito BanUTA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTasaInteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTiempoPagar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmortizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxTipoCredito;
        private System.Windows.Forms.TextBox textBoxMontoSolicitado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownTasaInteres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownTiempoPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridViewAmortizacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxAmortizacion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

