using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaGerenciamentoEmpreendedor
{
    public partial class frmRelatorioConsig : Form
    {
        public frmRelatorioConsig()
        {
            InitializeComponent();

            this.reportViewer1.Visible = false; //oculta o report logo no início
        }

        private void frmRelatorioConsig_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gerenciamentoEmpreendedorDataSet.gerenciamentoEmpreendedor'. Você pode movê-la ou removê-la conforme necessário.
            this.gerenciamentoEmpreendedorTableAdapter.Fill(this.gerenciamentoEmpreendedorDataSet.gerenciamentoEmpreendedor);

            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrarRelatorio_Click(object sender, EventArgs e)
        {
            this.reportViewer1.Visible = true; //mostra o report logo no início
            this.reportViewer1.RefreshReport(); //atualiza o report

            gerenciamentoEmpreendedorBindingSource.Filter = $"vendidoConsignado"; //filtra a BD do ACCESS pelos vendidos
            gerenciamentoEmpreendedorBindingSource.Filter = $"dataSaida >= '#{maskedTextBox1.Text}#'"; //filtra a BD do ACCESS como o que estiver na data escolhida
            gerenciamentoEmpreendedorBindingSource.Filter = $"dataSaida <= '#{maskedTextBox2.Text}#'"; //filtra a BD do ACCESS como o que estiver na data escolhida
        }
    }
}
