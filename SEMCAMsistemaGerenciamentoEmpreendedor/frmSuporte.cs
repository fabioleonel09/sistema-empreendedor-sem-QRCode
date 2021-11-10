using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace sistemaGerenciamentoEmpreendedor
{
    public partial class frmSuporte : Form
    {
        public frmSuporte()
        {
            InitializeComponent();
        }

        
        //evento do linklabel, para abrir a página de download do assistente remoto
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.teamviewer.com/pt-br/download/windows/");
        }       
    }
}
