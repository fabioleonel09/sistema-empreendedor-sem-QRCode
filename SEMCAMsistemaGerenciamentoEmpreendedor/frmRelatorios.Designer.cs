namespace sistemaGerenciamentoEmpreendedor
{
    partial class frmRelatorios
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.gerenciamentoEmpreendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerenciamentoEmpreendedorDataSet = new sistemaGerenciamentoEmpreendedor.gerenciamentoEmpreendedorDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrarRelatorio = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gerenciamentoEmpreendedorTableAdapter = new sistemaGerenciamentoEmpreendedor.gerenciamentoEmpreendedorDataSetTableAdapters.gerenciamentoEmpreendedorTableAdapter();
            this.tableAdapterManager = new sistemaGerenciamentoEmpreendedor.gerenciamentoEmpreendedorDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciamentoEmpreendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciamentoEmpreendedorDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gerenciamentoEmpreendedorBindingSource
            // 
            this.gerenciamentoEmpreendedorBindingSource.DataMember = "gerenciamentoEmpreendedor";
            this.gerenciamentoEmpreendedorBindingSource.DataSource = this.gerenciamentoEmpreendedorDataSet;
            // 
            // gerenciamentoEmpreendedorDataSet
            // 
            this.gerenciamentoEmpreendedorDataSet.DataSetName = "gerenciamentoEmpreendedorDataSet";
            this.gerenciamentoEmpreendedorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 700);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFiltrarRelatorio);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1059, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de busca";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskedTextBox2.Location = new System.Drawing.Point(553, 38);
            this.maskedTextBox2.Mask = "99/99/9999";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox2.TabIndex = 7;
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskedTextBox1.Location = new System.Drawing.Point(399, 38);
            this.maskedTextBox1.Mask = "99/99/9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Entre:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "e:";
            // 
            // btnFiltrarRelatorio
            // 
            this.btnFiltrarRelatorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFiltrarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarRelatorio.Image = global::sistemaGerenciamentoEmpreendedor.Properties.Resources.filtrar;
            this.btnFiltrarRelatorio.Location = new System.Drawing.Point(659, 32);
            this.btnFiltrarRelatorio.Name = "btnFiltrarRelatorio";
            this.btnFiltrarRelatorio.Size = new System.Drawing.Size(75, 37);
            this.btnFiltrarRelatorio.TabIndex = 1;
            this.btnFiltrarRelatorio.UseVisualStyleBackColor = true;
            this.btnFiltrarRelatorio.Click += new System.EventHandler(this.btnFiltrarRelatorio_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.gerenciamentoEmpreendedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sistemaGerenciamentoEmpreendedor.rpvRelatorios1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1065, 596);
            this.reportViewer1.TabIndex = 0;
            // 
            // gerenciamentoEmpreendedorTableAdapter
            // 
            this.gerenciamentoEmpreendedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gerenciamentoEmpreendedorTableAdapter = this.gerenciamentoEmpreendedorTableAdapter;
            this.tableAdapterManager.UpdateOrder = sistemaGerenciamentoEmpreendedor.gerenciamentoEmpreendedorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 700);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gerenciamentoEmpreendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciamentoEmpreendedorDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrarRelatorio;
        private gerenciamentoEmpreendedorDataSet gerenciamentoEmpreendedorDataSet;
        private System.Windows.Forms.BindingSource gerenciamentoEmpreendedorBindingSource;
        private gerenciamentoEmpreendedorDataSetTableAdapters.gerenciamentoEmpreendedorTableAdapter gerenciamentoEmpreendedorTableAdapter;
        private gerenciamentoEmpreendedorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}