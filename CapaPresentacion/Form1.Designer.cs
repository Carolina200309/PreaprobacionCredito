namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbnumeroDoc = new TextBox();
            tbingresosTotales = new TextBox();
            tbegresosTotales = new TextBox();
            tbplazo = new TextBox();
            tbmonto = new TextBox();
            btnVerificar = new Button();
            cbtipoDoc = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 30);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo Documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 75);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 1;
            label2.Text = "Número Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 117);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 2;
            label3.Text = "Ingresos Totales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 150);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 3;
            label4.Text = "Egresos Totales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 236);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 4;
            label5.Text = "Plazo solicitado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 194);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 5;
            label6.Text = "Monto solicitado";
            // 
            // tbnumeroDoc
            // 
            tbnumeroDoc.Location = new Point(157, 72);
            tbnumeroDoc.Name = "tbnumeroDoc";
            tbnumeroDoc.Size = new Size(149, 23);
            tbnumeroDoc.TabIndex = 7;
            // 
            // tbingresosTotales
            // 
            tbingresosTotales.Location = new Point(157, 109);
            tbingresosTotales.Name = "tbingresosTotales";
            tbingresosTotales.Size = new Size(149, 23);
            tbingresosTotales.TabIndex = 8;
            // 
            // tbegresosTotales
            // 
            tbegresosTotales.Location = new Point(157, 147);
            tbegresosTotales.Name = "tbegresosTotales";
            tbegresosTotales.Size = new Size(149, 23);
            tbegresosTotales.TabIndex = 9;
            // 
            // tbplazo
            // 
            tbplazo.Location = new Point(157, 236);
            tbplazo.Name = "tbplazo";
            tbplazo.Size = new Size(149, 23);
            tbplazo.TabIndex = 10;
            // 
            // tbmonto
            // 
            tbmonto.Location = new Point(157, 191);
            tbmonto.Name = "tbmonto";
            tbmonto.Size = new Size(149, 23);
            tbmonto.TabIndex = 11;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(34, 275);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(272, 23);
            btnVerificar.TabIndex = 12;
            btnVerificar.Text = "Aprobacion Credito";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // cbtipoDoc
            // 
            cbtipoDoc.FormattingEnabled = true;
            cbtipoDoc.Location = new Point(157, 27);
            cbtipoDoc.Name = "cbtipoDoc";
            cbtipoDoc.Size = new Size(149, 23);
            cbtipoDoc.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 310);
            Controls.Add(cbtipoDoc);
            Controls.Add(btnVerificar);
            Controls.Add(tbmonto);
            Controls.Add(tbplazo);
            Controls.Add(tbegresosTotales);
            Controls.Add(tbingresosTotales);
            Controls.Add(tbnumeroDoc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Credito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbnumeroDoc;
        private TextBox tbingresosTotales;
        private TextBox tbegresosTotales;
        private TextBox tbplazo;
        private TextBox tbmonto;
        private Button btnVerificar;
        private ComboBox cbtipoDoc;
    }
}
