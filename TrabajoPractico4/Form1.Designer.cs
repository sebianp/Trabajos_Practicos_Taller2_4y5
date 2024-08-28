namespace TrabajoPractico4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.BGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDesde = new System.Windows.Forms.TextBox();
            this.textBoxHasta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBoxPrimos = new System.Windows.Forms.CheckBox();
            this.checkBoxImpares = new System.Windows.Forms.CheckBox();
            this.checkBoxPares = new System.Windows.Forms.CheckBox();
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            this.BSalir = new System.Windows.Forms.Button();
            this.BBorrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.Location = new System.Drawing.Point(244, 93);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(301, 264);
            this.listBoxNumeros.TabIndex = 0;
            // 
            // BGenerar
            // 
            this.BGenerar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BGenerar.FlatAppearance.BorderSize = 2;
            this.BGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGenerar.Location = new System.Drawing.Point(38, 217);
            this.BGenerar.Name = "BGenerar";
            this.BGenerar.Size = new System.Drawing.Size(111, 33);
            this.BGenerar.TabIndex = 1;
            this.BGenerar.Text = "Generar Funcion";
            this.BGenerar.UseVisualStyleBackColor = false;
            this.BGenerar.Click += new System.EventHandler(this.BGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lista de Numeros";
            // 
            // textBoxDesde
            // 
            this.textBoxDesde.Location = new System.Drawing.Point(115, 93);
            this.textBoxDesde.Name = "textBoxDesde";
            this.textBoxDesde.Size = new System.Drawing.Size(100, 20);
            this.textBoxDesde.TabIndex = 5;
            this.textBoxDesde.TextChanged += new System.EventHandler(this.textBoxDesde_TextChanged);
            this.textBoxDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDesde_KeyPress);
            // 
            // textBoxHasta
            // 
            this.textBoxHasta.Location = new System.Drawing.Point(115, 152);
            this.textBoxHasta.Name = "textBoxHasta";
            this.textBoxHasta.Size = new System.Drawing.Size(100, 20);
            this.textBoxHasta.TabIndex = 6;
            this.textBoxHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHasta_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BBorrar);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.checkBoxPrimos);
            this.panel1.Controls.Add(this.checkBoxImpares);
            this.panel1.Controls.Add(this.checkBoxPares);
            this.panel1.Controls.Add(this.checkBoxTodos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxHasta);
            this.panel1.Controls.Add(this.textBoxDesde);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BGenerar);
            this.panel1.Controls.Add(this.listBoxNumeros);
            this.panel1.Location = new System.Drawing.Point(46, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 397);
            this.panel1.TabIndex = 10;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DarkGray;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(561, 93);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "numeros";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(349, 264);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // checkBoxPrimos
            // 
            this.checkBoxPrimos.AutoSize = true;
            this.checkBoxPrimos.Location = new System.Drawing.Point(168, 279);
            this.checkBoxPrimos.Name = "checkBoxPrimos";
            this.checkBoxPrimos.Size = new System.Drawing.Size(57, 17);
            this.checkBoxPrimos.TabIndex = 13;
            this.checkBoxPrimos.Text = "Primos";
            this.checkBoxPrimos.UseVisualStyleBackColor = true;
            this.checkBoxPrimos.CheckedChanged += new System.EventHandler(this.checkBoxPrimos_CheckedChanged);
            // 
            // checkBoxImpares
            // 
            this.checkBoxImpares.AutoSize = true;
            this.checkBoxImpares.Location = new System.Drawing.Point(168, 256);
            this.checkBoxImpares.Name = "checkBoxImpares";
            this.checkBoxImpares.Size = new System.Drawing.Size(63, 17);
            this.checkBoxImpares.TabIndex = 12;
            this.checkBoxImpares.Text = "Impares";
            this.checkBoxImpares.UseVisualStyleBackColor = true;
            this.checkBoxImpares.CheckedChanged += new System.EventHandler(this.checkBoxImpares_CheckedChanged);
            // 
            // checkBoxPares
            // 
            this.checkBoxPares.AutoSize = true;
            this.checkBoxPares.Location = new System.Drawing.Point(168, 233);
            this.checkBoxPares.Name = "checkBoxPares";
            this.checkBoxPares.Size = new System.Drawing.Size(53, 17);
            this.checkBoxPares.TabIndex = 11;
            this.checkBoxPares.Text = "Pares";
            this.checkBoxPares.UseVisualStyleBackColor = true;
            this.checkBoxPares.CheckedChanged += new System.EventHandler(this.checkBoxPares_CheckedChanged);
            // 
            // checkBoxTodos
            // 
            this.checkBoxTodos.AutoSize = true;
            this.checkBoxTodos.Location = new System.Drawing.Point(168, 210);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(56, 17);
            this.checkBoxTodos.TabIndex = 10;
            this.checkBoxTodos.Text = "Todos";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            this.checkBoxTodos.CheckedChanged += new System.EventHandler(this.checkBoxTodos_CheckedChanged);
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.Red;
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.Location = new System.Drawing.Point(888, 436);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(88, 25);
            this.BSalir.TabIndex = 12;
            this.BSalir.Text = "SALIR";
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BBorrar
            // 
            this.BBorrar.BackColor = System.Drawing.Color.IndianRed;
            this.BBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBorrar.Location = new System.Drawing.Point(38, 256);
            this.BBorrar.Name = "BBorrar";
            this.BBorrar.Size = new System.Drawing.Size(111, 33);
            this.BBorrar.TabIndex = 15;
            this.BBorrar.Text = "BORRAR";
            this.BBorrar.UseVisualStyleBackColor = false;
            this.BBorrar.Click += new System.EventHandler(this.BBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1015, 473);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Lista de Numeros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNumeros;
        private System.Windows.Forms.Button BGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDesde;
        private System.Windows.Forms.TextBox textBoxHasta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxPrimos;
        private System.Windows.Forms.CheckBox checkBoxImpares;
        private System.Windows.Forms.CheckBox checkBoxPares;
        private System.Windows.Forms.CheckBox checkBoxTodos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BBorrar;
    }
}

