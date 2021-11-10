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
    public partial class frmAluguel : Form
    {
        public frmAluguel()
        {
            InitializeComponent();

            reportViewer1.Visible = false; //deixa o report invisível
        }

        private void frmAluguel_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gerenciamentoEmpreendedorDataSet.gerenciamentoEmpreendedor'. Você pode movê-la ou removê-la conforme necessário.
            this.gerenciamentoEmpreendedorTableAdapter.Fill(this.gerenciamentoEmpreendedorDataSet.gerenciamentoEmpreendedor);
            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrarLocatario_Click(object sender, EventArgs e)
        {
            if (txtFiltrarLocatario.Text == "")
            {
                MessageBox.Show("Preencha com o número de identificação do produto alugado para gerar o relatório!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                reportViewer1.Visible = true; // deixa o report visível
                this.reportViewer1.RefreshReport(); //atualiza o report
                gerenciamentoEmpreendedorBindingSource.Filter = $"identificacaoProduto like '*{txtFiltrarLocatario.Text}*'"; //filtra a BD do ACCESS pelo cpf pela digitação no txt
            }
        }      
    }
}
