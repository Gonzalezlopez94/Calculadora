namespace CALCULADORA
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
            this.pantalla = new System.Windows.Forms.TextBox();
            this.BTNlimpiar = new System.Windows.Forms.Button();
            this.BTN7 = new System.Windows.Forms.Button();
            this.BTN4 = new System.Windows.Forms.Button();
            this.BTN1 = new System.Windows.Forms.Button();
            this.BTNcero = new System.Windows.Forms.Button();
            this.BTNdividir = new System.Windows.Forms.Button();
            this.BTN8 = new System.Windows.Forms.Button();
            this.BTN5 = new System.Windows.Forms.Button();
            this.BTN2 = new System.Windows.Forms.Button();
            this.BTN9 = new System.Windows.Forms.Button();
            this.BTN3 = new System.Windows.Forms.Button();
            this.BTNpunto = new System.Windows.Forms.Button();
            this.BTNmenos = new System.Windows.Forms.Button();
            this.BTN6 = new System.Windows.Forms.Button();
            this.BTNmultiplicar = new System.Windows.Forms.Button();
            this.BTNmas = new System.Windows.Forms.Button();
            this.BTNraiz = new System.Windows.Forms.Button();
            this.BTNigual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pantalla.Location = new System.Drawing.Point(25, 12);
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(180, 20);
            this.pantalla.TabIndex = 0;
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BTNlimpiar
            // 
            this.BTNlimpiar.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.BTNlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNlimpiar.FlatAppearance.BorderSize = 0;
            this.BTNlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BTNlimpiar.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNlimpiar.Location = new System.Drawing.Point(159, 201);
            this.BTNlimpiar.Name = "BTNlimpiar";
            this.BTNlimpiar.Size = new System.Drawing.Size(47, 41);
            this.BTNlimpiar.TabIndex = 1;
            this.BTNlimpiar.Text = "CE";
            this.BTNlimpiar.UseVisualStyleBackColor = true;
            this.BTNlimpiar.Click += new System.EventHandler(this.BTNlimpiar_Click_1);
            // 
            // BTN7
            // 
            this.BTN7.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BTN7.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold);
            this.BTN7.Location = new System.Drawing.Point(25, 152);
            this.BTN7.Name = "BTN7";
            this.BTN7.Size = new System.Drawing.Size(47, 41);
            this.BTN7.TabIndex = 2;
            this.BTN7.Text = "7";
            this.BTN7.UseVisualStyleBackColor = true;
            this.BTN7.Click += new System.EventHandler(this.BTN7_Click);
            // 
            // BTN4
            // 
            this.BTN4.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BTN4.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold);
            this.BTN4.Location = new System.Drawing.Point(25, 105);
            this.BTN4.Name = "BTN4";
            this.BTN4.Size = new System.Drawing.Size(47, 41);
            this.BTN4.TabIndex = 3;
            this.BTN4.Text = "4";
            this.BTN4.UseVisualStyleBackColor = true;
            this.BTN4.Click += new System.EventHandler(this.BTN4_Click);
            // 
            // BTN1
            // 
            this.BTN1.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BTN1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN1.Location = new System.Drawing.Point(25, 58);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(47, 41);
            this.BTN1.TabIndex = 4;
            this.BTN1.Text = "1";
            this.BTN1.UseVisualStyleBackColor = true;
            this.BTN1.Click += new System.EventHandler(this.BTN1_Click);
            // 
            // BTNcero
            // 
            this.BTNcero.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BTNcero.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold);
            this.BTNcero.Location = new System.Drawing.Point(25, 199);
            this.BTNcero.Name = "BTNcero";
            this.BTNcero.Size = new System.Drawing.Size(47, 41);
            this.BTNcero.TabIndex = 5;
            this.BTNcero.Text = "0";
            this.BTNcero.UseVisualStyleBackColor = true;
            this.BTNcero.Click += new System.EventHandler(this.BTNcero_Click);
            // 
            // BTNdividir
            // 
            this.BTNdividir.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BTNdividir.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdividir.Location = new System.Drawing.Point(238, 60);
            this.BTNdividir.Name = "BTNdividir";
            this.BTNdividir.Size = new System.Drawing.Size(47, 47);
            this.BTNdividir.TabIndex = 10;
            this.BTNdividir.Text = "/";
            this.BTNdividir.UseVisualStyleBackColor = true;
            this.BTNdividir.Click += new System.EventHandler(this.BTNdividir_Click);
            // 
            // BTN8
            // 
            this.BTN8.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BTN8.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold);
            this.BTN8.Location = new System.Drawing.Point(94, 152);
            this.BTN8.Name = "BTN8";
            this.BTN8.Size = new System.Drawing.Size(47, 41);
            this.BTN8.TabIndex = 9;
            this.BTN8.Text = "8";
            this.BTN8.UseVisualStyleBackColor = true;
            this.BTN8.Click += new System.EventHandler(this.BTN8_Click);
            // 
            // BTN5
            // 
            this.BTN5.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BTN5.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold);
            this.BTN5.Location = new System.Drawing.Point(94, 105);
            this.BTN5.Name = "BTN5";
            this.BTN5.Size = new System.Drawing.Size(47, 41);
            this.BTN5.TabIndex = 8;
            this.BTN5.Text = "5";
            this.BTN5.UseVisualStyleBackColor = true;
            this.BTN5.Click += new System.EventHandler(this.BTN5_Click);
            // 
            // BTN2
            // 
            this.BTN2.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BTN2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold);
            this.BTN2.Location = new System.Drawing.Point(95, 58);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(47, 41);
            this.BTN2.TabIndex = 7;
            this.BTN2.Text = "2";
            this.BTN2.UseVisualStyleBackColor = true;
            this.BTN2.Click += new System.EventHandler(this.BTN2_Click);
            // 
            // BTN9
            // 
            this.BTN9.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BTN9.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold);
            this.BTN9.Location = new System.Drawing.Point(158, 152);
            this.BTN9.Name = "BTN9";
            this.BTN9.Size = new System.Drawing.Size(47, 41);
            this.BTN9.TabIndex = 15;
            this.BTN9.Text = "9";
            this.BTN9.UseVisualStyleBackColor = true;
            this.BTN9.Click += new System.EventHandler(this.BTN9_Click);
            // 
            // BTN3
            // 
            this.BTN3.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BTN3.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold);
            this.BTN3.Location = new System.Drawing.Point(159, 60);
            this.BTN3.Name = "BTN3";
            this.BTN3.Size = new System.Drawing.Size(47, 41);
            this.BTN3.TabIndex = 13;
            this.BTN3.Text = "3";
            this.BTN3.UseVisualStyleBackColor = true;
            this.BTN3.Click += new System.EventHandler(this.BTN3_Click);
            // 
            // BTNpunto
            // 
            this.BTNpunto.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BTNpunto.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold);
            this.BTNpunto.Location = new System.Drawing.Point(95, 199);
            this.BTNpunto.Name = "BTNpunto";
            this.BTNpunto.Size = new System.Drawing.Size(47, 41);
            this.BTNpunto.TabIndex = 12;
            this.BTNpunto.Text = ".";
            this.BTNpunto.UseVisualStyleBackColor = true;
            this.BTNpunto.Click += new System.EventHandler(this.BTNpunto_Click);
            // 
            // BTNmenos
            // 
            this.BTNmenos.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BTNmenos.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold);
            this.BTNmenos.Location = new System.Drawing.Point(291, 60);
            this.BTNmenos.Name = "BTNmenos";
            this.BTNmenos.Size = new System.Drawing.Size(47, 47);
            this.BTNmenos.TabIndex = 11;
            this.BTNmenos.Text = "-";
            this.BTNmenos.UseVisualStyleBackColor = true;
            this.BTNmenos.Click += new System.EventHandler(this.BTNmenos_Click);
            // 
            // BTN6
            // 
            this.BTN6.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BTN6.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold);
            this.BTN6.Location = new System.Drawing.Point(158, 105);
            this.BTN6.Name = "BTN6";
            this.BTN6.Size = new System.Drawing.Size(47, 41);
            this.BTN6.TabIndex = 14;
            this.BTN6.Text = "6";
            this.BTN6.UseVisualStyleBackColor = true;
            this.BTN6.Click += new System.EventHandler(this.BTN6_Click);
            // 
            // BTNmultiplicar
            // 
            this.BTNmultiplicar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BTNmultiplicar.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold);
            this.BTNmultiplicar.Location = new System.Drawing.Point(238, 109);
            this.BTNmultiplicar.Name = "BTNmultiplicar";
            this.BTNmultiplicar.Size = new System.Drawing.Size(47, 47);
            this.BTNmultiplicar.TabIndex = 6;
            this.BTNmultiplicar.Text = "*";
            this.BTNmultiplicar.UseVisualStyleBackColor = true;
            this.BTNmultiplicar.Click += new System.EventHandler(this.BTNmultiplicar_Click);
            // 
            // BTNmas
            // 
            this.BTNmas.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BTNmas.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold);
            this.BTNmas.Location = new System.Drawing.Point(291, 109);
            this.BTNmas.Name = "BTNmas";
            this.BTNmas.Size = new System.Drawing.Size(47, 47);
            this.BTNmas.TabIndex = 16;
            this.BTNmas.Text = "+";
            this.BTNmas.UseVisualStyleBackColor = true;
            this.BTNmas.Click += new System.EventHandler(this.BTNmas_Click);
            // 
            // BTNraiz
            // 
            this.BTNraiz.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BTNraiz.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNraiz.Location = new System.Drawing.Point(238, 160);
            this.BTNraiz.Name = "BTNraiz";
            this.BTNraiz.Size = new System.Drawing.Size(100, 41);
            this.BTNraiz.TabIndex = 17;
            this.BTNraiz.Text = "raiz";
            this.BTNraiz.UseVisualStyleBackColor = true;
            this.BTNraiz.Click += new System.EventHandler(this.BTNraiz_Click);
            // 
            // BTNigual
            // 
            this.BTNigual.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BTNigual.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold);
            this.BTNigual.Location = new System.Drawing.Point(238, 201);
            this.BTNigual.Name = "BTNigual";
            this.BTNigual.Size = new System.Drawing.Size(100, 41);
            this.BTNigual.TabIndex = 18;
            this.BTNigual.Text = "=";
            this.BTNigual.UseVisualStyleBackColor = true;
            this.BTNigual.Click += new System.EventHandler(this.BTNigual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(363, 264);
            this.Controls.Add(this.BTNigual);
            this.Controls.Add(this.BTNraiz);
            this.Controls.Add(this.BTNmas);
            this.Controls.Add(this.BTN9);
            this.Controls.Add(this.BTN6);
            this.Controls.Add(this.BTN3);
            this.Controls.Add(this.BTNpunto);
            this.Controls.Add(this.BTNmenos);
            this.Controls.Add(this.BTNdividir);
            this.Controls.Add(this.BTN8);
            this.Controls.Add(this.BTN5);
            this.Controls.Add(this.BTN2);
            this.Controls.Add(this.BTNmultiplicar);
            this.Controls.Add(this.BTNcero);
            this.Controls.Add(this.BTN1);
            this.Controls.Add(this.BTN4);
            this.Controls.Add(this.BTN7);
            this.Controls.Add(this.BTNlimpiar);
            this.Controls.Add(this.pantalla);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button BTNlimpiar;
        private System.Windows.Forms.Button BTN7;
        private System.Windows.Forms.Button BTN4;
        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.Button BTNcero;
        private System.Windows.Forms.Button BTNdividir;
        private System.Windows.Forms.Button BTN8;
        private System.Windows.Forms.Button BTN5;
        private System.Windows.Forms.Button BTN2;
        private System.Windows.Forms.Button BTN9;
        private System.Windows.Forms.Button BTN3;
        private System.Windows.Forms.Button BTNpunto;
        private System.Windows.Forms.Button BTNmenos;
        private System.Windows.Forms.Button BTN6;
        private System.Windows.Forms.Button BTNmultiplicar;
        private System.Windows.Forms.Button BTNmas;
        private System.Windows.Forms.Button BTNraiz;
        private System.Windows.Forms.Button BTNigual;
    }
}

