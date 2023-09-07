namespace CALCULADORA
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
            lblhistorial = new Label();
            cajaresultado = new TextBox();
            btnuno = new Button();
            btndos = new Button();
            btnsuma = new Button();
            btntres = new Button();
            btnresta = new Button();
            btnseis = new Button();
            btncinco = new Button();
            btncuatro = new Button();
            btnmultiplicar = new Button();
            btnnueve = new Button();
            btnocho = new Button();
            btnsiete = new Button();
            btnpunto = new Button();
            btncero = new Button();
            btnresultado = new Button();
            btnmodulo = new Button();
            btndivicion = new Button();
            btnreset = new Button();
            btnborrar = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblhistorial
            // 
            lblhistorial.AutoSize = true;
            lblhistorial.BackColor = SystemColors.ButtonHighlight;
            lblhistorial.Font = new Font("American Captain", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblhistorial.Location = new Point(48, 18);
            lblhistorial.Name = "lblhistorial";
            lblhistorial.Size = new Size(0, 30);
            lblhistorial.TabIndex = 0;
            // 
            // cajaresultado
            // 
            cajaresultado.BackColor = Color.FromArgb(128, 255, 255);
            cajaresultado.Font = new Font("American Captain", 18F, FontStyle.Bold, GraphicsUnit.Point);
            cajaresultado.ForeColor = Color.FromArgb(0, 0, 192);
            cajaresultado.Location = new Point(14, 51);
            cajaresultado.Multiline = true;
            cajaresultado.Name = "cajaresultado";
            cajaresultado.ReadOnly = true;
            cajaresultado.Size = new Size(259, 50);
            cajaresultado.TabIndex = 1;
            cajaresultado.Text = "0";
            cajaresultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnuno
            // 
            btnuno.BackColor = SystemColors.ActiveBorder;
            btnuno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnuno.Location = new Point(14, 308);
            btnuno.Name = "btnuno";
            btnuno.Size = new Size(60, 61);
            btnuno.TabIndex = 7;
            btnuno.Text = "1";
            btnuno.UseVisualStyleBackColor = false;
            btnuno.Click += btnuno_Click;
            // 
            // btndos
            // 
            btndos.BackColor = SystemColors.ActiveBorder;
            btndos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btndos.Location = new Point(80, 308);
            btndos.Name = "btndos";
            btndos.Size = new Size(60, 61);
            btndos.TabIndex = 8;
            btndos.Text = "2";
            btndos.UseVisualStyleBackColor = false;
            btndos.Click += btndos_Click;
            // 
            // btnsuma
            // 
            btnsuma.BackColor = SystemColors.ActiveBorder;
            btnsuma.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnsuma.Location = new Point(213, 308);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(60, 61);
            btnsuma.TabIndex = 10;
            btnsuma.Text = "+";
            btnsuma.UseVisualStyleBackColor = false;
            btnsuma.Click += btnsuma_Click;
            // 
            // btntres
            // 
            btntres.BackColor = SystemColors.ActiveBorder;
            btntres.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btntres.Location = new Point(147, 308);
            btntres.Name = "btntres";
            btntres.Size = new Size(60, 61);
            btntres.TabIndex = 9;
            btntres.Text = "3";
            btntres.UseVisualStyleBackColor = false;
            btntres.Click += btntres_Click;
            // 
            // btnresta
            // 
            btnresta.BackColor = SystemColors.ActiveBorder;
            btnresta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnresta.Location = new Point(213, 241);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(60, 61);
            btnresta.TabIndex = 14;
            btnresta.Text = "-";
            btnresta.UseVisualStyleBackColor = false;
            btnresta.Click += btnresta_Click;
            // 
            // btnseis
            // 
            btnseis.BackColor = SystemColors.ActiveBorder;
            btnseis.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnseis.Location = new Point(147, 241);
            btnseis.Name = "btnseis";
            btnseis.Size = new Size(60, 61);
            btnseis.TabIndex = 13;
            btnseis.Text = "6";
            btnseis.UseVisualStyleBackColor = false;
            btnseis.Click += btnseis_Click;
            // 
            // btncinco
            // 
            btncinco.BackColor = SystemColors.ActiveBorder;
            btncinco.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btncinco.Location = new Point(80, 241);
            btncinco.Name = "btncinco";
            btncinco.Size = new Size(60, 61);
            btncinco.TabIndex = 12;
            btncinco.Text = "5";
            btncinco.UseVisualStyleBackColor = false;
            btncinco.Click += btncinco_Click;
            // 
            // btncuatro
            // 
            btncuatro.BackColor = SystemColors.ActiveBorder;
            btncuatro.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btncuatro.Location = new Point(14, 241);
            btncuatro.Name = "btncuatro";
            btncuatro.Size = new Size(60, 61);
            btncuatro.TabIndex = 11;
            btncuatro.Text = "4";
            btncuatro.UseVisualStyleBackColor = false;
            btncuatro.Click += btncuatro_Click;
            // 
            // btnmultiplicar
            // 
            btnmultiplicar.BackColor = SystemColors.ActiveBorder;
            btnmultiplicar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnmultiplicar.Location = new Point(213, 174);
            btnmultiplicar.Name = "btnmultiplicar";
            btnmultiplicar.Size = new Size(60, 61);
            btnmultiplicar.TabIndex = 18;
            btnmultiplicar.Text = "X";
            btnmultiplicar.UseVisualStyleBackColor = false;
            btnmultiplicar.Click += btnmultiplicar_Click;
            // 
            // btnnueve
            // 
            btnnueve.BackColor = SystemColors.ActiveBorder;
            btnnueve.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnnueve.Location = new Point(147, 174);
            btnnueve.Name = "btnnueve";
            btnnueve.Size = new Size(60, 61);
            btnnueve.TabIndex = 17;
            btnnueve.Text = "9";
            btnnueve.UseVisualStyleBackColor = false;
            btnnueve.Click += btnnueve_Click;
            // 
            // btnocho
            // 
            btnocho.BackColor = SystemColors.ActiveBorder;
            btnocho.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnocho.Location = new Point(80, 174);
            btnocho.Name = "btnocho";
            btnocho.Size = new Size(60, 61);
            btnocho.TabIndex = 16;
            btnocho.Text = "8";
            btnocho.UseVisualStyleBackColor = false;
            btnocho.Click += btnocho_Click;
            // 
            // btnsiete
            // 
            btnsiete.BackColor = SystemColors.ActiveBorder;
            btnsiete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnsiete.Location = new Point(14, 174);
            btnsiete.Name = "btnsiete";
            btnsiete.Size = new Size(60, 61);
            btnsiete.TabIndex = 15;
            btnsiete.Text = "7";
            btnsiete.UseVisualStyleBackColor = false;
            btnsiete.Click += btnsiete_Click;
            // 
            // btnpunto
            // 
            btnpunto.BackColor = SystemColors.ActiveBorder;
            btnpunto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnpunto.Location = new Point(147, 375);
            btnpunto.Name = "btnpunto";
            btnpunto.Size = new Size(60, 61);
            btnpunto.TabIndex = 21;
            btnpunto.Text = ".";
            btnpunto.UseVisualStyleBackColor = false;
            btnpunto.Click += btnpunto_Click;
            // 
            // btncero
            // 
            btncero.BackColor = SystemColors.ActiveBorder;
            btncero.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btncero.Location = new Point(12, 375);
            btncero.Name = "btncero";
            btncero.Size = new Size(127, 61);
            btncero.TabIndex = 19;
            btncero.Text = "0";
            btncero.UseVisualStyleBackColor = false;
            btncero.Click += btncero_Click;
            // 
            // btnresultado
            // 
            btnresultado.BackColor = SystemColors.ActiveBorder;
            btnresultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnresultado.Location = new Point(213, 375);
            btnresultado.Name = "btnresultado";
            btnresultado.Size = new Size(60, 61);
            btnresultado.TabIndex = 22;
            btnresultado.Text = "=";
            btnresultado.UseVisualStyleBackColor = false;
            btnresultado.Click += btnresultado_Click;
            // 
            // btnmodulo
            // 
            btnmodulo.BackColor = SystemColors.ActiveBorder;
            btnmodulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnmodulo.Location = new Point(14, 107);
            btnmodulo.Name = "btnmodulo";
            btnmodulo.Size = new Size(60, 61);
            btnmodulo.TabIndex = 23;
            btnmodulo.Text = "%";
            btnmodulo.UseVisualStyleBackColor = false;
            btnmodulo.Click += btnmodulo_Click;
            // 
            // btndivicion
            // 
            btndivicion.BackColor = SystemColors.ActiveBorder;
            btndivicion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btndivicion.Location = new Point(81, 107);
            btndivicion.Name = "btndivicion";
            btndivicion.Size = new Size(60, 61);
            btndivicion.TabIndex = 24;
            btndivicion.Text = "/";
            btndivicion.UseVisualStyleBackColor = false;
            btndivicion.Click += btndivicion_Click;
            // 
            // btnreset
            // 
            btnreset.BackColor = SystemColors.ActiveBorder;
            btnreset.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnreset.Location = new Point(147, 107);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(60, 61);
            btnreset.TabIndex = 25;
            btnreset.Text = "C";
            btnreset.UseVisualStyleBackColor = false;
            btnreset.Click += btnreset_Click;
            // 
            // btnborrar
            // 
            btnborrar.BackColor = SystemColors.ActiveBorder;
            btnborrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnborrar.Location = new Point(213, 107);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(60, 61);
            btnborrar.TabIndex = 26;
            btnborrar.Text = "<--";
            btnborrar.UseVisualStyleBackColor = false;
            btnborrar.Click += btnborrar_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(80, 442);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 41);
            textBox1.TabIndex = 27;
            textBox1.Text = "Martin ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(297, 481);
            Controls.Add(textBox1);
            Controls.Add(btnborrar);
            Controls.Add(btnreset);
            Controls.Add(btndivicion);
            Controls.Add(btnmodulo);
            Controls.Add(btnresultado);
            Controls.Add(btnpunto);
            Controls.Add(btncero);
            Controls.Add(btnmultiplicar);
            Controls.Add(btnnueve);
            Controls.Add(btnocho);
            Controls.Add(btnsiete);
            Controls.Add(btnresta);
            Controls.Add(btnseis);
            Controls.Add(btncinco);
            Controls.Add(btncuatro);
            Controls.Add(btnsuma);
            Controls.Add(btntres);
            Controls.Add(btndos);
            Controls.Add(btnuno);
            Controls.Add(cajaresultado);
            Controls.Add(lblhistorial);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblhistorial;
        private TextBox cajaresultado;
        private Button btnuno;
        private Button btndos;
        private Button btnsuma;
        private Button btntres;
        private Button btnresta;
        private Button btnseis;
        private Button btncinco;
        private Button btncuatro;
        private Button btnmultiplicar;
        private Button btnnueve;
        private Button btnocho;
        private Button btnsiete;
        private Button btnpunto;
        private Button btncero;
        private Button btnresultado;
        private Button btnmodulo;
        private Button btndivicion;
        private Button btnreset;
        private Button btnborrar;
        private TextBox textBox1;
    }
}