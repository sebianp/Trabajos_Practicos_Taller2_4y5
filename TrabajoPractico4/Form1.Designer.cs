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
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.BGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDesde = new System.Windows.Forms.TextBox();
            this.textBoxHasta = new System.Windows.Forms.TextBox();
            this.BNumerosPares = new System.Windows.Forms.Button();
            this.BNumerosImpares = new System.Windows.Forms.Button();
            this.BNumerosPrimos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.Location = new System.Drawing.Point(244, 93);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(301, 225);
            this.listBoxNumeros.TabIndex = 0;
            // 
            // BGenerar
            // 
            this.BGenerar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BGenerar.FlatAppearance.BorderSize = 2;
            this.BGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BGenerar.Location = new System.Drawing.Point(114, 208);
            this.BGenerar.Name = "BGenerar";
            this.BGenerar.Size = new System.Drawing.Size(101, 23);
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
            this.label3.Location = new System.Drawing.Point(213, 32);
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
            // BNumerosPares
            // 
            this.BNumerosPares.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BNumerosPares.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BNumerosPares.Location = new System.Drawing.Point(114, 237);
            this.BNumerosPares.Name = "BNumerosPares";
            this.BNumerosPares.Size = new System.Drawing.Size(101, 23);
            this.BNumerosPares.TabIndex = 7;
            this.BNumerosPares.Text = "Numeros Pares";
            this.BNumerosPares.UseVisualStyleBackColor = false;
            this.BNumerosPares.Click += new System.EventHandler(this.BNumerosPares_Click);
            // 
            // BNumerosImpares
            // 
            this.BNumerosImpares.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BNumerosImpares.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BNumerosImpares.Location = new System.Drawing.Point(114, 266);
            this.BNumerosImpares.Name = "BNumerosImpares";
            this.BNumerosImpares.Size = new System.Drawing.Size(101, 23);
            this.BNumerosImpares.TabIndex = 8;
            this.BNumerosImpares.Text = "Numeros Impares";
            this.BNumerosImpares.UseVisualStyleBackColor = false;
            this.BNumerosImpares.Click += new System.EventHandler(this.BNumerosImpares_Click);
            // 
            // BNumerosPrimos
            // 
            this.BNumerosPrimos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BNumerosPrimos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BNumerosPrimos.Location = new System.Drawing.Point(114, 295);
            this.BNumerosPrimos.Name = "BNumerosPrimos";
            this.BNumerosPrimos.Size = new System.Drawing.Size(101, 23);
            this.BNumerosPrimos.TabIndex = 9;
            this.BNumerosPrimos.Text = "Numeros Primos";
            this.BNumerosPrimos.UseVisualStyleBackColor = false;
            this.BNumerosPrimos.Click += new System.EventHandler(this.BNumerosPrimos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BNumerosPrimos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BNumerosImpares);
            this.panel1.Controls.Add(this.BNumerosPares);
            this.panel1.Controls.Add(this.textBoxHasta);
            this.panel1.Controls.Add(this.textBoxDesde);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BGenerar);
            this.panel1.Controls.Add(this.listBoxNumeros);
            this.panel1.Location = new System.Drawing.Point(46, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 376);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(721, 427);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Lista de Numeros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button BNumerosPares;
        private System.Windows.Forms.Button BNumerosImpares;
        private System.Windows.Forms.Button BNumerosPrimos;
        private System.Windows.Forms.Panel panel1;
    }
}

