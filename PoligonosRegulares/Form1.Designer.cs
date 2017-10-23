using System;

namespace GestionPoligonosReg
{
    partial class FormDibujo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDibujo));
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.trackY = new System.Windows.Forms.TrackBar();
            this.trackX = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackRadio = new System.Windows.Forms.TrackBar();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.nudNumLados = new System.Windows.Forms.NumericUpDown();
            this.cbGrosor = new System.Windows.Forms.ComboBox();
            this.txtGiro = new System.Windows.Forms.TextBox();
            this.trackGiro = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.rbAzul = new System.Windows.Forms.RadioButton();
            this.rbVerde = new System.Windows.Forms.RadioButton();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.rbNegro = new System.Windows.Forms.RadioButton();
            this.lbCoord = new System.Windows.Forms.Label();
            this.btnRellenar = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRadio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumLados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGiro)).BeginInit();
            this.gbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDibujo
            // 
            this.panelDibujo.BackColor = System.Drawing.Color.White;
            this.panelDibujo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDibujo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelDibujo.Location = new System.Drawing.Point(25, 24);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(500, 500);
            this.panelDibujo.TabIndex = 1;
            this.panelDibujo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelDibujo_MouseClick);
            // 
            // trackY
            // 
            this.trackY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.trackY.LargeChange = 50;
            this.trackY.Location = new System.Drawing.Point(530, 15);
            this.trackY.Maximum = 500;
            this.trackY.Name = "trackY";
            this.trackY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackY.Size = new System.Drawing.Size(45, 520);
            this.trackY.SmallChange = 10;
            this.trackY.TabIndex = 1;
            this.trackY.TickFrequency = 10;
            // 
            // trackX
            // 
            this.trackX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.trackX.LargeChange = 50;
            this.trackX.Location = new System.Drawing.Point(15, 530);
            this.trackX.Maximum = 550;
            this.trackX.Name = "trackX";
            this.trackX.Size = new System.Drawing.Size(520, 45);
            this.trackX.SmallChange = 10;
            this.trackX.TabIndex = 3;
            this.trackX.TickFrequency = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Radio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Núm. lados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Grosor";
            // 
            // trackRadio
            // 
            this.trackRadio.AutoSize = false;
            this.trackRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.trackRadio.Location = new System.Drawing.Point(607, 80);
            this.trackRadio.Maximum = 250;
            this.trackRadio.Name = "trackRadio";
            this.trackRadio.Size = new System.Drawing.Size(258, 30);
            this.trackRadio.TabIndex = 28;
            this.trackRadio.TickFrequency = 5;
            this.trackRadio.Scroll += new System.EventHandler(this.trackRadio_Scroll);
            // 
            // txtRadio
            // 
            this.txtRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtRadio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRadio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadio.Location = new System.Drawing.Point(871, 80);
            this.txtRadio.MaxLength = 3;
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(48, 29);
            this.txtRadio.TabIndex = 29;
            this.txtRadio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRadio.TextChanged += new System.EventHandler(this.txtRadio_TextChanged);
            // 
            // nudNumLados
            // 
            this.nudNumLados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nudNumLados.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumLados.Location = new System.Drawing.Point(607, 142);
            this.nudNumLados.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumLados.Name = "nudNumLados";
            this.nudNumLados.Size = new System.Drawing.Size(57, 29);
            this.nudNumLados.TabIndex = 30;
            this.nudNumLados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbGrosor
            // 
            this.cbGrosor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbGrosor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrosor.FormattingEnabled = true;
            this.cbGrosor.Location = new System.Drawing.Point(607, 213);
            this.cbGrosor.Name = "cbGrosor";
            this.cbGrosor.Size = new System.Drawing.Size(57, 30);
            this.cbGrosor.TabIndex = 31;
            // 
            // txtGiro
            // 
            this.txtGiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtGiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiro.Location = new System.Drawing.Point(871, 282);
            this.txtGiro.MaxLength = 3;
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(48, 29);
            this.txtGiro.TabIndex = 35;
            this.txtGiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGiro.TextChanged += new System.EventHandler(this.txtGiro_TextChanged);
            // 
            // trackGiro
            // 
            this.trackGiro.AutoSize = false;
            this.trackGiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.trackGiro.Location = new System.Drawing.Point(607, 282);
            this.trackGiro.Maximum = 90;
            this.trackGiro.Name = "trackGiro";
            this.trackGiro.Size = new System.Drawing.Size(258, 30);
            this.trackGiro.TabIndex = 34;
            this.trackGiro.TickFrequency = 5;
            this.trackGiro.Scroll += new System.EventHandler(this.trackGiro_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Giro inicial";
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(606, 396);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(313, 40);
            this.btnConectar.TabIndex = 38;
            this.btnConectar.Text = "Conectar Vértices";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Maroon;
            this.btnBorrar.Location = new System.Drawing.Point(850, 501);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(69, 36);
            this.btnBorrar.TabIndex = 37;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.Location = new System.Drawing.Point(606, 350);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(313, 36);
            this.btnDibujar.TabIndex = 36;
            this.btnDibujar.Text = "Dibujar Polígono";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // gbColor
            // 
            this.gbColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbColor.Controls.Add(this.lbColor);
            this.gbColor.Controls.Add(this.btnColor);
            this.gbColor.Controls.Add(this.rbAzul);
            this.gbColor.Controls.Add(this.rbVerde);
            this.gbColor.Controls.Add(this.rbRojo);
            this.gbColor.Controls.Add(this.rbNegro);
            this.gbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbColor.Location = new System.Drawing.Point(687, 125);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(230, 142);
            this.gbColor.TabIndex = 39;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Color del dibujo";
            // 
            // lbColor
            // 
            this.lbColor.BackColor = System.Drawing.Color.Transparent;
            this.lbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbColor.Location = new System.Drawing.Point(11, 29);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(102, 50);
            this.lbColor.TabIndex = 5;
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(119, 35);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(102, 38);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Otro Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // rbAzul
            // 
            this.rbAzul.AutoSize = true;
            this.rbAzul.ForeColor = System.Drawing.Color.Blue;
            this.rbAzul.Location = new System.Drawing.Point(135, 116);
            this.rbAzul.Name = "rbAzul";
            this.rbAzul.Size = new System.Drawing.Size(51, 20);
            this.rbAzul.TabIndex = 3;
            this.rbAzul.Text = "Azul";
            this.rbAzul.UseVisualStyleBackColor = true;
            this.rbAzul.CheckedChanged += new System.EventHandler(this.rbNegro_CheckedChanged);
            // 
            // rbVerde
            // 
            this.rbVerde.AutoSize = true;
            this.rbVerde.ForeColor = System.Drawing.Color.Green;
            this.rbVerde.Location = new System.Drawing.Point(135, 88);
            this.rbVerde.Name = "rbVerde";
            this.rbVerde.Size = new System.Drawing.Size(63, 20);
            this.rbVerde.TabIndex = 2;
            this.rbVerde.Text = "Verde";
            this.rbVerde.UseVisualStyleBackColor = true;
            this.rbVerde.CheckedChanged += new System.EventHandler(this.rbNegro_CheckedChanged);
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.ForeColor = System.Drawing.Color.Red;
            this.rbRojo.Location = new System.Drawing.Point(19, 116);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(55, 20);
            this.rbRojo.TabIndex = 1;
            this.rbRojo.Text = "Rojo";
            this.rbRojo.UseVisualStyleBackColor = true;
            this.rbRojo.CheckedChanged += new System.EventHandler(this.rbNegro_CheckedChanged);
            // 
            // rbNegro
            // 
            this.rbNegro.AutoSize = true;
            this.rbNegro.Checked = true;
            this.rbNegro.Location = new System.Drawing.Point(19, 88);
            this.rbNegro.Name = "rbNegro";
            this.rbNegro.Size = new System.Drawing.Size(64, 20);
            this.rbNegro.TabIndex = 0;
            this.rbNegro.TabStop = true;
            this.rbNegro.Text = "Negro";
            this.rbNegro.UseVisualStyleBackColor = true;
            this.rbNegro.CheckedChanged += new System.EventHandler(this.rbNegro_CheckedChanged);
            // 
            // lbCoord
            // 
            this.lbCoord.AutoSize = true;
            this.lbCoord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbCoord.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoord.Location = new System.Drawing.Point(541, 548);
            this.lbCoord.Name = "lbCoord";
            this.lbCoord.Size = new System.Drawing.Size(98, 22);
            this.lbCoord.TabIndex = 40;
            this.lbCoord.Text = "(550, 550)";
            // 
            // btnRellenar
            // 
            this.btnRellenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRellenar.Location = new System.Drawing.Point(607, 446);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(313, 40);
            this.btnRellenar.TabIndex = 41;
            this.btnRellenar.Text = "Rellenar";
            this.btnRellenar.UseVisualStyleBackColor = true;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // FormDibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(952, 611);
            this.Controls.Add(this.btnRellenar);
            this.Controls.Add(this.lbCoord);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.txtGiro);
            this.Controls.Add(this.trackGiro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbGrosor);
            this.Controls.Add(this.nudNumLados);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.trackRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackX);
            this.Controls.Add(this.trackY);
            this.Controls.Add(this.panelDibujo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDibujo";
            this.Text = "Plígonos Regulares";
            this.Load += new System.EventHandler(this.FormDibujo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRadio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumLados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGiro)).EndInit();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void trackY_MouseClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.TrackBar trackY;
        private System.Windows.Forms.TrackBar trackX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.NumericUpDown nudNumLados;
        private System.Windows.Forms.ComboBox cbGrosor;
        private System.Windows.Forms.TextBox txtGiro;
        private System.Windows.Forms.TrackBar trackGiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.RadioButton rbAzul;
        private System.Windows.Forms.RadioButton rbVerde;
        private System.Windows.Forms.RadioButton rbRojo;
        private System.Windows.Forms.RadioButton rbNegro;
        private System.Windows.Forms.Label lbCoord;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

