namespace AreaTrapezio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTituto = new System.Windows.Forms.Label();
            this.lblBaseMaior = new System.Windows.Forms.Label();
            this.lblBaseMenor = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.textBoxBaseMaior = new System.Windows.Forms.TextBox();
            this.textBoxBaseMenor = new System.Windows.Forms.TextBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.btnClique = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituto
            // 
            this.lblTituto.AutoSize = true;
            this.lblTituto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituto.Location = new System.Drawing.Point(69, 38);
            this.lblTituto.Name = "lblTituto";
            this.lblTituto.Size = new System.Drawing.Size(259, 19);
            this.lblTituto.TabIndex = 0;
            this.lblTituto.Text = "CALCULE A AREA DO TRAPEZIO";
            // 
            // lblBaseMaior
            // 
            this.lblBaseMaior.AutoSize = true;
            this.lblBaseMaior.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMaior.Location = new System.Drawing.Point(41, 104);
            this.lblBaseMaior.Name = "lblBaseMaior";
            this.lblBaseMaior.Size = new System.Drawing.Size(119, 20);
            this.lblBaseMaior.TabIndex = 1;
            this.lblBaseMaior.Text = "Digite Base Maior:";
            // 
            // lblBaseMenor
            // 
            this.lblBaseMenor.AutoSize = true;
            this.lblBaseMenor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMenor.Location = new System.Drawing.Point(42, 167);
            this.lblBaseMenor.Name = "lblBaseMenor";
            this.lblBaseMenor.Size = new System.Drawing.Size(124, 20);
            this.lblBaseMenor.TabIndex = 2;
            this.lblBaseMenor.Text = "Digite Base Menor:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(42, 227);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(84, 20);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Digite Altura:";
            // 
            // textBoxBaseMaior
            // 
            this.textBoxBaseMaior.Location = new System.Drawing.Point(44, 127);
            this.textBoxBaseMaior.Name = "textBoxBaseMaior";
            this.textBoxBaseMaior.Size = new System.Drawing.Size(133, 20);
            this.textBoxBaseMaior.TabIndex = 4;
            // 
            // textBoxBaseMenor
            // 
            this.textBoxBaseMenor.Location = new System.Drawing.Point(45, 190);
            this.textBoxBaseMenor.Name = "textBoxBaseMenor";
            this.textBoxBaseMenor.Size = new System.Drawing.Size(133, 20);
            this.textBoxBaseMenor.TabIndex = 5;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(46, 250);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(132, 20);
            this.textBoxAltura.TabIndex = 6;
            // 
            // btnClique
            // 
            this.btnClique.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClique.Location = new System.Drawing.Point(41, 297);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(92, 32);
            this.btnClique.TabIndex = 7;
            this.btnClique.Text = "Clique";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(155, 297);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 32);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(265, 297);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 32);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(406, 350);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnClique);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBoxBaseMenor);
            this.Controls.Add(this.textBoxBaseMaior);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBaseMenor);
            this.Controls.Add(this.lblBaseMaior);
            this.Controls.Add(this.lblTituto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area do Trapezio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituto;
        private System.Windows.Forms.Label lblBaseMaior;
        private System.Windows.Forms.Label lblBaseMenor;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox textBoxBaseMaior;
        private System.Windows.Forms.TextBox textBoxBaseMenor;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.Button btnClique;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

