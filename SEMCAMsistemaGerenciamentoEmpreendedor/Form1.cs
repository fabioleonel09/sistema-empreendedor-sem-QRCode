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
    public partial class frmLogin : Form
    {     
        public frmLogin()
        {
            InitializeComponent();

            //inabilita alguns controles
            btnEntrar.Visible = true;
            txtQRCode.Visible = true;
        }

        //Sai do sistema
        private void pbSair_Click(object sender, EventArgs e)
        {         
           Application.Exit(); //sai da aplicação              
        }

        //ocorre quando o usuário digita a senha no txt e clica no botão para entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtQRCode.Text == "admlua1030#$") //esta é a senha
            {
                this.Visible = false; // o frmLogin fecha

                frmGerenciamento fg = new frmGerenciamento();
                fg.Show(); // o próximo formulário abre               
            }

            else
            {
                if (txtQRCode.Text == "") //caso txt vazio
                {
                    MessageBox.Show("Digite a senha para abrir o sistema!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibe esta msg para o usuário
                }

                else
                {
                    //caso senha errada
                    MessageBox.Show("Digite a senha correta para abrir o sistema!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibe essa msg para o usuário
                    txtQRCode.Clear(); //limpa o txt do QRCode
                }
            }
        }     
    }
}
