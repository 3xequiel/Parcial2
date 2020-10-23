namespace parcial2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botoncamisa = new System.Windows.Forms.RadioButton();
            this.botonpantalon = new System.Windows.Forms.RadioButton();
            this.mangacorta = new System.Windows.Forms.CheckBox();
            this.bermuda = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.botonpremiun = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas al por mayor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bermuda);
            this.groupBox1.Controls.Add(this.mangacorta);
            this.groupBox1.Controls.Add(this.botonpantalon);
            this.groupBox1.Controls.Add(this.botoncamisa);
            this.groupBox1.Location = new System.Drawing.Point(75, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de prenda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.botonpremiun);
            this.groupBox2.Location = new System.Drawing.Point(75, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 62);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad de la prenda";
            // 
            // botoncamisa
            // 
            this.botoncamisa.AutoSize = true;
            this.botoncamisa.Location = new System.Drawing.Point(20, 20);
            this.botoncamisa.Name = "botoncamisa";
            this.botoncamisa.Size = new System.Drawing.Size(59, 17);
            this.botoncamisa.TabIndex = 0;
            this.botoncamisa.TabStop = true;
            this.botoncamisa.Text = "Camisa";
            this.botoncamisa.UseVisualStyleBackColor = true;
            // 
            // botonpantalon
            // 
            this.botonpantalon.AutoSize = true;
            this.botonpantalon.Location = new System.Drawing.Point(20, 57);
            this.botonpantalon.Name = "botonpantalon";
            this.botonpantalon.Size = new System.Drawing.Size(67, 17);
            this.botonpantalon.TabIndex = 1;
            this.botonpantalon.TabStop = true;
            this.botonpantalon.Text = "Pantalon";
            this.botonpantalon.UseVisualStyleBackColor = true;
            // 
            // mangacorta
            // 
            this.mangacorta.AutoSize = true;
            this.mangacorta.Location = new System.Drawing.Point(128, 20);
            this.mangacorta.Name = "mangacorta";
            this.mangacorta.Size = new System.Drawing.Size(86, 17);
            this.mangacorta.TabIndex = 2;
            this.mangacorta.Text = "Manga corta";
            this.mangacorta.UseVisualStyleBackColor = true;
            // 
            // bermuda
            // 
            this.bermuda.AutoSize = true;
            this.bermuda.Location = new System.Drawing.Point(128, 58);
            this.bermuda.Name = "bermuda";
            this.bermuda.Size = new System.Drawing.Size(68, 17);
            this.bermuda.TabIndex = 3;
            this.bermuda.Text = "Bermuda";
            this.bermuda.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular precio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonpremiun
            // 
            this.botonpremiun.AutoSize = true;
            this.botonpremiun.Location = new System.Drawing.Point(20, 20);
            this.botonpremiun.Name = "botonpremiun";
            this.botonpremiun.Size = new System.Drawing.Size(63, 17);
            this.botonpremiun.TabIndex = 0;
            this.botonpremiun.TabStop = true;
            this.botonpremiun.Text = "Premiun";
            this.botonpremiun.UseVisualStyleBackColor = true;
            this.botonpremiun.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(128, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(62, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Standar";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(75, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(105, 56);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Location = new System.Drawing.Point(193, 304);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(102, 56);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cantidad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox bermuda;
        private System.Windows.Forms.CheckBox mangacorta;
        private System.Windows.Forms.RadioButton botonpantalon;
        private System.Windows.Forms.RadioButton botoncamisa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton botonpremiun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox2;
    }
}

