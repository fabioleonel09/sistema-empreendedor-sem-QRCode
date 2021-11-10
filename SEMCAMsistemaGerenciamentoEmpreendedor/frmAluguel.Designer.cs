namespace sistemaGerenciamentoEmpreendedor
{
    partial class frmAluguel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrarLocatario = new System.Windows.Forms.Button();
            this.txtFiltrarLocatario = new System.Windows.Forms.TextBox();
            this.gerenciamentoEmpreendedorDataSet = new sistemaGerenciamentoEmpreendedor.gerenciamentoEmpreendedorDataSet();
            this.gerenciamentoEmpreendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerenciamentoEmpreendedorTableAdapter = new sistemaGerenciamentoEmpreendedor.gerenciamentoEmpreendedorDataSetTableAdapters.gerenciamentoEmpreendedorTableAdapter();
            this.tableAdapterManager = new sistemaGerenciamentoEmpreendedor.gerenciamentoEmpreendedorDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciamentoEmpreendedorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciamentoEmpreendedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 681);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.gerenciamentoEmpreendedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sistemaGerenciamentoEmpreendedor.rpvAluguel.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1001, 609);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFiltrarLocatario);
            this.groupBox1.Controls.Add(this.txtFiltrarLocatario);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de busca";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o número de identificação do produto alugado:";
            // 
            // btnFiltrarLocatario
            // 
            this.btnFiltrarLocatario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFiltrarLocatario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarLocatario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarLocatario.Image = global::sistemaGerenciamentoEmpreendedor.Properties.Resources.filtrar;
            this.btnFiltrarLocatario.Location = new System.Drawing.Point(810, 15);
            this.btnFiltrarLocatario.Name = "btnFiltrarLocatario";
            this.btnFiltrarLocatario.Size = new System.Drawing.Size(75, 37);
            this.btnFiltrarLocatario.TabIndex = 1;
            this.btnFiltrarLocatario.UseVisualStyleBackColor = true;
            this.btnFiltrarLocatario.Click += new System.EventHandler(this.btnFiltrarLocatario_Click);
            // 
            // txtFiltrarLocatario
            // 
            this.txtFiltrarLocatario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFiltrarLocatario.Location = new System.Drawing.Point(478, 22);
            this.txtFiltrarLocatario.Name = "txtFiltrarLocatario";
            this.txtFiltrarLocatario.Size = new System.Drawing.Size(317, 26);
            this.txtFiltrarLocatario.TabIndex = 0;
            // 
            // gerenciamentoEmpreendedorDataSet
            // 
            this.gerenciamentoEmpreendedorDataSet.DataSetName = "gerenciamentoEmpreendedorDataSet";
            this.gerenciamentoEmpreendedorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gerenciamentoEmpreendedorBindingSource
            // 
            this.gerenciamentoEmpreendedorBindingSource.DataMember = "gerenciamentoEmpreendedor";
            this.gerenciamentoEmpreendedorBindingSource.DataSource = this.gerenciamentoEmpreendedorDataSet;
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
            // frmAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 681);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAluguel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato aluguel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAluguel_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciamentoEmpreendedorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciamentoEmpreendedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrarLocatario;
        private System.Windows.Forms.TextBox txtFiltrarLocatario;
        private gerenciamentoEmpreendedorDataSet gerenciamentoEmpreendedorDataSet;
        private System.Windows.Forms.BindingSource gerenciamentoEmpreendedorBindingSource;
        private gerenciamentoEmpreendedorDataSetTableAdapters.gerenciamentoEmpreendedorTableAdapter gerenciamentoEmpreendedorTableAdapter;
        private gerenciamentoEmpreendedorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}