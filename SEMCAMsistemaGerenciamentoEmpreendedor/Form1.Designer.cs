namespace sistemaGerenciamentoEmpreendedor
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbSemCam = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbSair = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.txtQRCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 349);
            this.panel1.TabIndex = 0;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Image = global::sistemaGerenciamentoEmpreendedor.Properties.Resources.go;
            this.btnEntrar.Location = new System.Drawing.Point(366, 252);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(35, 35);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(61, 256);
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.PasswordChar = '*';
            this.txtQRCode.Size = new System.Drawing.Size(299, 26);
            this.txtQRCode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(121, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de\r\nGerenciamento Empreendedor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistemaGerenciamentoEmpreendedor.Properties.Resources.shop1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pbSemCam);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pbSair);
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 50);
            this.panel2.TabIndex = 0;
            // 
            // pbSemCam
            // 
            this.pbSemCam.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbSemCam.Image = ((System.Drawing.Image)(resources.GetObject("pbSemCam.Image")));
            this.pbSemCam.Location = new System.Drawing.Point(316, -1);
            this.pbSemCam.Name = "pbSemCam";
            this.pbSemCam.Size = new System.Drawing.Size(65, 50);
            this.pbSemCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSemCam.TabIndex = 2;
            this.pbSemCam.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seguimento Brechó";
            // 
            // pbSair
            // 
            this.pbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSair.Image = global::sistemaGerenciamentoEmpreendedor.Properties.Resources.Close;
            this.pbSair.Location = new System.Drawing.Point(387, -1);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(65, 50);
            this.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSair.TabIndex = 0;
            this.pbSair.TabStop = false;
            this.pbSair.Click += new System.EventHandler(this.pbSair_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(453, 349);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbSemCam;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Timer timer1;
    }
}

