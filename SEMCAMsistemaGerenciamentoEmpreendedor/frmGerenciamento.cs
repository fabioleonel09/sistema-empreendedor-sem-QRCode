using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder; //deve ser baixado no pacote Nuget do gerenciador de soluções
//estas bibliotecas são ativadas ao baixar e instalar seus pacotes no NuGet
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Media;

namespace sistemaGerenciamentoEmpreendedor
{
    public partial class frmGerenciamento : Form
    {
        public frmGerenciamento()
        {
            InitializeComponent();

            //tira o check ao iniciar o frm
            alugadoCheckBox.Checked = false;

            //ao iniciar este frm, estas funções ficam inabilitadas
            dataVendaDateTimePicker.Enabled = false; //data da venda na tab loja
            dataSaidaDateTimePicker.Enabled = false; //data saída na tab consignados
            tbDados2.SelectTab(tabPage12); // a aba 12 na tabdados2
            tbGeral.Enabled = false; //a tab geral
            blocoNotasTextBox.Enabled = false; //o txt no bloco de notas
            nomeNotaTextBox.Enabled = false; //o txt nome da nota

            gerenciamentoEmpreendedorBindingNavigatorSaveItem.Enabled = false; //o botão de salvar na barra binding do BD
            bindingNavigatorDeleteItem.Enabled = false; //o botão de excluir na barra binding do BD
            toolStripBloquear.Enabled = false; //o botão de bloquear na barra binding do BD

            //bloqueia os pb's para pesquisa
            pbQRCodeLoja.Visible = false;
            pbQRCodeConsig.Visible = false;       

            //bloqueia o gb da aba aluguel
            gbIdentifProduto.Enabled = false;

            //filtra o BD do notas
            gerenciamentoEmpreendedorBindingSource.Filter = $"dataNotas >= '#{DateTime.Now}#'"; //filtra a BD do ACCESS como o que estiver na data escolhida

            //deixa apenas a tabPage 11, aluguel, inativa
            ((Control)tbGeral.TabPages["tabPage11"]).Enabled = false;

            alugadoCheckBox.Enabled = false; //inabilita o botão chkb

            //inabilita todos os controles que usam webcam's
            rbQRCodeLoja.Enabled = false;
            txtCapCamLoja.Enabled = false;
            btnVerCapLoja.Enabled = false;
            rcQRCodeConsig.Enabled = false;
            txtCapCamConsig.Enabled = false;
            btnCapCamConsig.Enabled = false;
            btnQRCode.Enabled = false;
            ((Control)tbDados2.TabPages["tabPage6"]).Enabled = false;
            btnPararCam.Enabled = false;
            cboDevice.Enabled = false;
        }

        //lê as imagens nos pictureBoxes loja e consignados
        private void CaptureDevice_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            pbQRCodeLoja.Image = (Bitmap)eventArgs.Frame.Clone();
            pbQRCodeConsig.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        //esse botão finaliza a aplicação e o timer da cam
        private void btnSair_Click(object sender, EventArgs e)
        {
                Application.Exit();          
        }

        //implementa as ações do botão loja, de forma sincrônica, ao ser clicado
        private void btnLoja_Click(object sender, EventArgs e)
        {
            tbGeral.SelectTab(tabPage7); //seleciona a aba 7 do tab geral
            tbDados.SelectTab(tabPage1); //seleciona a aba 1 do tab dados
        }

        //implementa as ações do botão consignado, de forma sincrônica, ao ser clicado
        private void btnConsignado_Click(object sender, EventArgs e)
        {
            tbGeral.SelectTab(tabPage8); //seleciona a aba 8 do tab geral
            tbDados.SelectTab(tabPage2); //seleciona a aba 2 do tab dados
        }

        //implementa as ações do botão fornecedor, de forma sincrônica, ao ser clicado
        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            tbGeral.SelectTab(tabPage9); //seleciona a aba 9 do tab geral
            tbDados.SelectTab(tabPage5); //seleciona a aba 5 do tab dados
        }

        //implementa as ações do botão clientes, de forma sincrônica, ao ser clicado
        private void btnClientes_Click(object sender, EventArgs e)
        {
            tbGeral.SelectTab(tabPage10); //seleciona a aba 10 do tab geral
            tbDados2.SelectTab(tabPage3); //seleciona a aba 3 do tab dados2
        }

        //implementa as ações do botão faturamento, de forma sincrônica, ao ser clicado
        private void btnFaturamento_Click(object sender, EventArgs e)
        {
            tbDados2.SelectTab(tabPage4); //seleciona a aba 4 do tab dados2
        }

        //implementa as ações do botão para gerar o QRCode, de forma sincrônica, ao ser clicado
        private void btnQRCode_Click(object sender, EventArgs e)
        {
            tbDados2.SelectTab(tabPage6); //seleciona a aba 6 do tab dados2
        }

        //implementa as ações do botão salvar
        private void gerenciamentoEmpreendedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {         
            //edita, atualiza e salva
            this.Validate();
            this.gerenciamentoEmpreendedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gerenciamentoEmpreendedorDataSet);
            
            alugadoCheckBox.Enabled = false; //inabilita o botão chkb

            //inabilita os componentes após salvar
            dataVendaDateTimePicker.Enabled = false; //data da venda na tab loja
            dataSaidaDateTimePicker.Enabled = false; //data de saída na tab consignado
            tbGeral.Enabled = false; //a tab geral
            blocoNotasTextBox.Enabled = false; // o txt no bloco de notas
            nomeNotaTextBox.Enabled = false; //o txt nome da nota

            //exibe a msg de confirmação do salvamento
            MessageBox.Show("O item foi salvo ou editado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //inabilita o botão salvar e o botão deletar
            gerenciamentoEmpreendedorBindingNavigatorSaveItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;            
        }

        //no evento Load do frm
        private void frmGerenciamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gerenciamentoEmpreendedorDataSet.gerenciamentoEmpreendedor'. Você pode movê-la ou removê-la conforme necessário.
            this.gerenciamentoEmpreendedorTableAdapter.Fill(this.gerenciamentoEmpreendedorDataSet.gerenciamentoEmpreendedor);
         
            ((Control)tbGeral.TabPages["tabPage11"]).Enabled = false; //desabilita apenas a tabPage11, aluguel
        }

        //se o rb estiver clicado, habilita a data de venda no tab loja
        private void vendidoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (vendidoRadioButton.Checked == true)
            {
                dataVendaDateTimePicker.Enabled = true;
            }          
        }

        //aqui temos os eventos para gerar um QRCode, ao clicar no botão 'Gerar' na tab gerarQRCode
        private void btnQRcode2_Click(object sender, EventArgs e)
        {
            pbCodigoBarras.Image = null; //analisa de a pictureBox está vazia
            QRCodeGenerator qr = new QRCodeGenerator(); //instancia o gerador do qrCode
            QRCodeData data = qr.CreateQrCode(txtCodigoBarras.Text, QRCodeGenerator.ECCLevel.Q); // pega o que está escrito no txt para gerar o código
            QRCode code = new QRCode(data); //instancia o código
            pbCodigoBarras.Image = code.GetGraphic(5); //gera a imagem

            txtCodigoBarras.Clear(); //limpa o txt automaticamente
        }

        //realiza a ação do btn 'salvar', para salvar o QRCode gerado
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (pbCodigoBarras.Image == null) //se não tiver nada na pictureBox...
                return; //retorna, não faz nada
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PNG|*.png" }) //vai instanciar para salvar no formato .png
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK) //clicando no OK da caixa de diálogo
                    pbCodigoBarras.Image.Save(saveFileDialog.FileName); //salva a imagem gerada, em documentos
            }
        }

        //este botão abre a tab do bloco de notas
        private void toolStripNotas_Click(object sender, EventArgs e)
        {
            tbDados2.SelectTab(tabPage12); //tab do bloco de notas
        }

        //implementa as ações logo ao começar a escrever no txt para buscar na base de dados...
        private void txtProdutos_TextChanged(object sender, EventArgs e) //caso digite-se algo no txt...
        {
                    if (rbProduto.Checked == true) //o rb deve estar clicado
                    {
                        tbGeral.SelectTab(tabPage7); //seleciona a aba 7 do tab geral
                        tbDados.SelectTab(tabPage1); //seleciona a aba 1 do tab dados
                        txtProdutos.Enabled = true; //habilita o txt
                        gerenciamentoEmpreendedorBindingSource.Filter = $"produto like '*{txtProdutos.Text}*'"; //filtra a base de dados do ACCESS pelo protudo digitado na txt e retorna no dgw
                    }

                    else //se não estiver clicado
                    {
                        tbGeral.SelectTab(tabPage7); //seleciona a aba 7 do tab geral
                        tbDados.SelectTab(tabPage1); //seleciona a aba 1 do tab dados
                        txtProdutos.Enabled = true; //desabilita o txt para digitação
                        MessageBox.Show("Selecione o botão 'produto' para fazer a busca!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibe a msg para o usuário
                        txtProdutos.Clear(); //limpa o txt
                    }
        }

        //implementa as ações do rb vendidos
        private void rbVendidos_CheckedChanged(object sender, EventArgs e) //para buscar os produtos já vendidos
        {
                    if ((vendidoRadioButton.Checked == true) && (rbVendidos.Checked == true)) //caso os rb's da base de dados e de busca estiverem clicados
                    {
                        txtProdutos.Clear(); //limpa o txt
                        txtProdutos.Enabled = false; //inabilita o txt para digitações
                        gerenciamentoEmpreendedorBindingSource.Filter = $"vendido"; //filtra a BD por protutos vendidos
                    }

                    else
                    {
                        if ((vendidoRadioButton.Checked == false) && (rbVendidos.Checked == true)) //caso o rd da BD não estiver clicado...
                        {
                            txtProdutos.Clear(); //limpa o txt
                            txtProdutos.Enabled = false; //inabilita o txt
                            MessageBox.Show("Nenhum produto vendido ainda!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibe essa msg para dizer que não houve baixa de produtos  
                        }
                    }

            //inabilita os pb's
            pbQRCodeLoja.Visible = false;
            pbQRCodeConsig.Visible = false;

            //atualiza os pb's
            pbQRCodeLoja.Image = null;
            pbQRCodeConsig.Image = null;
        }

        //implementa a ação do rb ao ser clicado
        private void rbProduto_CheckedChanged(object sender, EventArgs e)
        {
             tbGeral.SelectTab(tabPage7); //seleciona a aba 7 do tab geral
             tbDados.SelectTab(tabPage1); //seleciona a aba 1 do tab dados
             txtProdutos.Enabled = true; //habilita a txt
             txtProdutos.Clear(); //limpa a txt 

            //inabilita os pb's
             pbQRCodeLoja.Visible = false;
             pbQRCodeConsig.Visible = false;

            //atualiza os pb's
            pbQRCodeLoja.Image = null;
            pbQRCodeConsig.Image = null;
        }

        //implementa a ação do txt para buscas o BD
        private void txtConsignado_TextChanged(object sender, EventArgs e) //ao digitar no txt..
        {
            if (rbCPFconsignado.Checked == true) //se o rb estiver clicado...
            {
                tbGeral.SelectTab(tabPage8); //seleciona a aba 8 do tab geral
                tbDados.SelectTab(tabPage2); //seleciona a aba 2 do tab dados
                txtConsignado.Enabled = true; //habilita o txt para digitação
                gerenciamentoEmpreendedorBindingSource.Filter = $"cpf like '*{txtConsignado.Text}*'"; //filtra a BD do ACCESS pelo cpf pela digitação no txt
            }

            else // do contrário
            {
                if (radioButton1.Checked == true) // se o rb estiver clicado...
                {
                    tbGeral.SelectTab(tabPage8); //seleciona a aba 8 do tab geral
                    tbDados.SelectTab(tabPage2); //seleciona a aba 2 do tab dados
                    txtConsignado.Enabled = true; //habilita o txt para digitação
                    gerenciamentoEmpreendedorBindingSource.Filter = $"identificacaoConsignado like '*{txtConsignado.Text}*'"; //filtra a BD do ACCESS pelo cpf pela digitação no txt
                }

                else //do contrário
                {
                    tbGeral.SelectTab(tabPage8); //seleciona a aba 8 do tab geral
                    tbDados.SelectTab(tabPage2); //seleciona a aba 2 do tab dados
                    txtConsignado.Enabled = true; //o txt continua habilitado
                    MessageBox.Show("Selecione o botão 'CPF' ou 'n⁰ identif. prod. consig.' para fazer a busca!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibe essa msg para o usuário
                    txtConsignado.Clear(); //limpa o txt
                }
            }
        }

        //implementa o rb do cpf do consignado
        private void rbCPFconsignado_CheckedChanged(object sender, EventArgs e) //ao ser clicado...
        {
            tbGeral.SelectTab(tabPage8); //seleciona a aba 8 do tab geral
            tbDados.SelectTab(tabPage2); //seleciona a aba 2 do tab dados
            txtConsignado.Enabled = true; //habilita o txt
            txtConsignado.Clear(); //limpa o txt

            //inabilita os pb's
            pbQRCodeLoja.Visible = false;
            pbQRCodeConsig.Visible = false;

            //atualiza os pb's
            pbQRCodeLoja.Image = null;
            pbQRCodeConsig.Image = null;
        }

        //implementa o rb vendido consignado
        private void rbVendidoConsignado_CheckedChanged(object sender, EventArgs e) //ao ser clicado
        { 
                    if ((vendidoConsignadoRadioButton.Checked == true) && (rbVendidoConsignado.Checked == true)) //caso o rb vendido do BD e o rb de pesquisa estiverem clicados...
                    {
                        txtConsignado.Clear(); //limpa o txt consignado
                        txtConsignado.Enabled = false; //habilita o txt consignado
                        gerenciamentoEmpreendedorBindingSource.Filter = $"vendidoConsignado"; //filtra a BD do ACCESS pelos vendidos
                    }

                    else //do contrário
                    {
                        if ((vendidoConsignadoRadioButton.Checked == false) && (rbVendidoConsignado.Checked == true)) //se o rb de vendido consignados não estiver clicado...
                        {
                            txtConsignado.Clear(); //limpa o txt consignado
                            txtConsignado.Enabled = false; //inabilita o txt consignado
                            MessageBox.Show("Nenhum produto consignado vendido ainda!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibe essa msg na tela do usuário
                        }
                    }

            //inabilita os pb's
            pbQRCodeLoja.Visible = false;
            pbQRCodeConsig.Visible = false;

            //atualiza os pb's
            pbQRCodeLoja.Image = null;
            pbQRCodeConsig.Image = null;
        }

        //implementa as ações do txt pesquisa do fornecedor
        private void txtFornecedor_TextChanged(object sender, EventArgs e) //caso digite-se algo no txt...
        {
            if (rbNomeFornecedor.Checked == true) //caso o rb nome do fornecedor esteja clicado
            {
                tbGeral.SelectTab(tabPage9); //seleciona a aba 9 do tab geral
                tbDados.SelectTab(tabPage5); //seleciona a aba 5 do tab dados
                txtFornecedor.Clear(); //limpa o txt do fornecedor
                gerenciamentoEmpreendedorBindingSource.Filter = $"nomeFornecedor like '*{txtFornecedor.Text}*'"; //filtra a BD do ACCESS como o que estiver digitado no txt fornecedor
            }

            else //caso contrário
            {
                if (rbCPFfornecedor.Checked == true) //caso o rb cpf do fornecedor esteja clicado
                {
                    tbGeral.SelectTab(tabPage9); //seleciona a aba 9 do tab geral
                    tbDados.SelectTab(tabPage5); //seleciona a aba 5 do tab dados
                    txtFornecedor.Clear(); //limpa o txt do fornecedor
                    gerenciamentoEmpreendedorBindingSource.Filter = $"cpfFornecedor like '*{txtFornecedor.Text}*'"; //filtra a BD do ACCESS como o que estiver digitado no txt fornecedor
                }

                else //caso contrário
                {
                    if (rbCNPJfornecedor.Checked == true) //caso o rb cnpj do fornecedor esteja clicado
                    {
                        tbGeral.SelectTab(tabPage9); //seleciona a aba 9 do tab geral
                        tbDados.SelectTab(tabPage5); //seleciona a aba 5 do tab dados
                        txtFornecedor.Clear(); //limpa o txt do fornecedor
                        gerenciamentoEmpreendedorBindingSource.Filter = $"cnpjFornecedor like '*{txtFornecedor.Text}*'"; //filtra a BD do ACCESS como o que estiver digitado no txt fornecedor
                    }

                    else //caso contrário
                    {
                        tbGeral.SelectTab(tabPage9); //seleciona a aba 9 do tab geral
                        tbDados.SelectTab(tabPage5); //seleciona a aba 5 do tab dados
                        txtFornecedor.Clear();  //limpa o txt do fornecedor                    
                        MessageBox.Show("Selecione um dos botões para realizar a pesquisa!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //filtra a BD do ACCESS como o que estiver digitado no txt fornecedor
                    }
                }
            }
        }

        //implementa a ação do txt clientes para pesquisa
        private void txtClientes_TextChanged(object sender, EventArgs e) //caso digite-se algo no txt...
        {
            gerenciamentoEmpreendedorBindingSource.Filter = $"nomeCliente like '*{txtClientes.Text}*'"; //filtra a BD do ACCESS como o que estiver digitado no txt clicar
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) //implemtena as ações do botãoa adicionar
        {
            //tira o check ao iniciar o frm
            alugadoCheckBox.Checked = false;

            tbGeral.SelectTab(tabPage7); //seleciona a aba 7 do tab geral
            tbDados.SelectTab(tabPage1); //seleciona a aba 1 do tab dados

            if (tbGeral.Enabled == true)
            {
                //tira o check ao iniciar o frm
                alugadoCheckBox.Checked = false;
                alugadoCheckBox.Enabled = false; //inabilita o botão chkb

                ((Control)tbGeral.TabPages["tabPage11"]).Enabled = false; //habilita apenas a tabPage11, aluguel
            }           

            tbGeral.Enabled = true; //habilita a tab
            blocoNotasTextBox.Enabled = true; //habilita o txt no notas
            nomeNotaTextBox.Enabled = true; //o txt nome da nota

            gerenciamentoEmpreendedorBindingNavigatorSaveItem.Enabled = true; //habilita o botão salvar
            bindingNavigatorDeleteItem.Enabled = true; //habilita o botão excluir
          
            MessageBox.Show("Modo 'adicionar item' foi aberto. \n\n 1 - Delete a ação, no caso de não adicionar item algum!\n\n 2 - O botão 'Alugado' e a aba 'Aluguel' são ativados apenas pelo botão 'Editar'!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //gera esta msg para o usuário, como alerta 
        }

        private void vendidoConsignadoRadioButton_CheckedChanged(object sender, EventArgs e) //se o rb vendido no consignado estiver clicado
        {
            if (vendidoConsignadoRadioButton.Checked == true) //se estiver clicado
            {
                dataSaidaDateTimePicker.Enabled = true; //habilita o dateTimePicker para saída do produto consignado
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) //implementa o botão excluiir ou deletar
        {       
            //edita, atulaiza e salva as ações
            this.Validate();
            this.gerenciamentoEmpreendedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gerenciamentoEmpreendedorDataSet);
           
            alugadoCheckBox.Enabled = false; //inabilita o botão chkb
            dataVendaDateTimePicker.Enabled = false; //inabilita o dateTimePicker de venda
            dataSaidaDateTimePicker.Enabled = false; //inabilita o dateTimePicker de saída
            tbGeral.Enabled = false; //inabilita o tab geral
            blocoNotasTextBox.Enabled = false; //inabilita o txt no notas
            nomeNotaTextBox.Enabled = false; //o txt nome da nota

            MessageBox.Show("O item foi apagado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibe esta msg para o usuário

            gerenciamentoEmpreendedorBindingNavigatorSaveItem.Enabled = false; //inabilita o botão salvar
            bindingNavigatorDeleteItem.Enabled = false; //inabilita o botão excluir
        }

        private void toolStripEditar_Click(object sender, EventArgs e) //implementa o botal editar
        {
            MessageBox.Show("O modo editar possibilita a edição do conteúdo já inserido. Salve ou bloqueie para que as edições sejam armazenadas!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibe esta msg para o usuário...

            alugadoCheckBox.Enabled = true; //habilita o botão chkb

            ((Control)tbGeral.TabPages["tabPage11"]).Enabled = true; //desabilita apenas a tabPage11, aluguel
           
            tbGeral.Enabled = true; //habilita o tab geral
            blocoNotasTextBox.Enabled = true; //habilita o txt no notas
            nomeNotaTextBox.Enabled = true; //o txt nome da nota

            gerenciamentoEmpreendedorBindingNavigatorSaveItem.Enabled = true; //habilita o botão salvar
            bindingNavigatorDeleteItem.Enabled = true; //habilita o botão excluir
            toolStripBloquear.Enabled = true; //habilita o botão bloquear                     
        }

        private void toolStripBloquear_Click(object sender, EventArgs e) //implementa o botão bloquear
        {
            try
            {
                alugadoCheckBox.Enabled = false; //inabilita o botão chkb

                ((Control)tbGeral.TabPages["tabPage11"]).Enabled = false; //inabilita apenas a tabPage11, aluguel

                dataVendaDateTimePicker.Enabled = false; //inabilita o dateTimerPicker de venda
                dataSaidaDateTimePicker.Enabled = false; //inabilita o dateTimePicker de saída
                tbGeral.Enabled = false; //inabilita o tab geral
                blocoNotasTextBox.Enabled = false; //iniabilita o txt no notas
                nomeNotaTextBox.Enabled = false; //o txt nome da nota

                gerenciamentoEmpreendedorBindingNavigatorSaveItem.Enabled = false; //inabilita o botão de salvar
                bindingNavigatorDeleteItem.Enabled = false; //inabilita o botão de deletar, excluir
                toolStripBloquear.Enabled = false; //inabilita o botão bloquear

                MessageBox.Show("O modo editar foi fechado! Se houveram edições, elas foram realizadas com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibe essa msg para o usuário
            }
            catch 
            {

            }

            finally
            {
                //edita, atualiza e salva as ações
                this.Validate();
                this.gerenciamentoEmpreendedorBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gerenciamentoEmpreendedorDataSet);
            }
        }

        //implementa o linkLabel para inserir uma foto no BD na aba loja
        private void linkLabelLoja_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //evento clicked da label
        {
            if (this.ofd.ShowDialog() == DialogResult.OK) //se a caixa de diálogo tiver resultado como ok
            {
                this.imagemProdutoPictureBox.Image = System.Drawing.Image.FromFile(this.ofd.FileName); //pega-se a imagem e coloca no pictureBox
            }
        }
        //implementa o linkLabel para inserir uma foto no BD na aba Consignado
        private void linkLabelConsignado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //evento clicked da label
        {
            if (this.ofd.ShowDialog() == DialogResult.OK) //se a caixa de diálogo tiver resultado como ok
            {
                this.imagemConsignadoPictureBox.Image = System.Drawing.Image.FromFile(this.ofd.FileName); //pega-se a imagem e coloca no pictureBox
            }
        }

        //implementa o btn buscar notas
        private void btnBuscarNotas_Click(object sender, EventArgs e)
        {
            gerenciamentoEmpreendedorBindingSource.Filter = $"dataNotas >= '#{mtbBlocoNotas.Text}#'"; //filtra a BD do ACCESS como o que estiver na data escolhida

            mtbBlocoNotas.Clear(); //limpa a caixa de pesquisa 
        }

        //implementa o btn para buscar por qrcode
        private void btnVerCapLoja_Click(object sender, EventArgs e)
        {
            try
            { 
                gerenciamentoEmpreendedorBindingSource.Filter = $"identificacaoProduto like '*{txtCapCamLoja.Text}*'"; //filtra a base de dados do ACCESS pelo protudo digitado na txt e retorna no dgw 
            }
            catch
            {

            }

            txtCapCamLoja.Clear(); //limpa o txt
            pbQRCodeLoja.Image = null; //atualiza o pb
        }

        //implementa o btn para buscar por qrcode
        private void btnCapCamConsig_Click(object sender, EventArgs e)
        {
            try
            {
                gerenciamentoEmpreendedorBindingSource.Filter = $"identificacaoConsignado like '*{txtCapCamConsig.Text}*'"; //filtra a BD do ACCESS pelo cpf pela digitação no txt                
            }
            catch 
            {

            }

            txtCapCamConsig.Clear(); //limpa o txt
            pbQRCodeConsig.Image = null; //atualiza o pb
        }

        //implementa os botões na aba relatórios
        private void btnContratoConsignado_Click(object sender, EventArgs e) //o btn contrato
        {
            frmContratoConsignado fcc = new frmContratoConsignado(); //instancia o frm de contrato
            fcc.Show(); //abre o frm de contrato
        }

        //implementa o btn relatório
        private void btnRelatorio_Click(object sender, EventArgs e) // o btn relatórios
        {
            frmRelatorios fr = new frmRelatorios(); //instancia o frm relatórios
            fr.Show(); // abre o frm relatórios
        }

        //implementa o btn aluguel
        private void btnAluguel_Click(object sender, EventArgs e) //ao clicar no btn
        {
            tbGeral.SelectTab(tabPage11); //seleciona a aba 11 do tab geral
            tbDados.SelectTab(tabPage13); //seleciona a aba 13 do tab dados
        }

        //implementa o btn relatório aluguel
        private void btnAlugelRelatorio_Click(object sender, EventArgs e) //ao clicar no btn
        {
            frmAluguel fa = new frmAluguel(); //instancia o frm aluguel
            fa.Show(); //abre o frm aluguel
        }

        //evento para buscas no txt
        private void txtCPFlocatario_TextChanged(object sender, EventArgs e)
        {
            if (rbCPFlocatário.Checked == true) //o rb deve estar clicado
            {
                txtCPFlocatario.Enabled = true; //habilita o txt
                gerenciamentoEmpreendedorBindingSource.Filter = $"cpfAluguel like '*{txtCPFlocatario.Text}*'"; //filtra a base de dados do ACCESS pelo protudo digitado na txt e retorna no dgw
            }

            else //se não estiver clicado
            {
                txtCPFlocatario.Enabled = true; //desabilita o txt para digitação
                MessageBox.Show("Selecione o botão 'CPF' para fazer a busca!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibe a msg para o usuário
                txtCPFlocatario.Clear(); //limpa o txt
            }
        }

        //evento ao clique do rb alugado
        private void rbItensAlugados_CheckedChanged(object sender, EventArgs e)
        {
            if ((alugadoCheckBox.Checked == true) && (rbItensAlugados.Checked == true)) //caso os rb's da base de dados e de busca estiverem clicados
            {
                txtCPFlocatario.Clear(); //limpa o txt
                txtCPFlocatario.Enabled = false; //inabilita o txt para digitações
                gerenciamentoEmpreendedorBindingSource.Filter = $"alugado"; //filtra a BD por protutos vendidos
            }

            else
            {
                if ((alugadoCheckBox.Checked == false) && (rbItensAlugados.Checked == true)) //caso o rd da BD não estiver clicado...
                {
                    txtCPFlocatario.Clear(); //limpa o txt
                    txtCPFlocatario.Enabled = false; //inabilita o txt
                    MessageBox.Show("Nenhum produto alugado ainda!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibe essa msg para dizer que não houve baixa de produtos  
                }
            }
        }

        //evento do btn alugar no tab loja
        private void rbCPFlocatário_CheckedChanged(object sender, EventArgs e)
        {
            txtCPFlocatario.Enabled = true; //habilita a txt
            txtCPFlocatario.Clear(); //limpa a txt 
        }

        //evento do rb alugado no tab loja
        private void rbAlugados_CheckedChanged(object sender, EventArgs e)
        {
            if ((alugadoCheckBox.Checked == true) && (rbAlugados.Checked == true)) //caso os rb's da base de dados e de busca estiverem clicados
            {
                txtProdutos.Clear(); //limpa o txt
                txtProdutos.Enabled = false; //inabilita o txt para digitações
                gerenciamentoEmpreendedorBindingSource.Filter = $"alugado"; //filtra a BD por protutos vendidos
            }

            else
            {
                if ((alugadoCheckBox.Checked == false) && (rbAlugados.Checked == true)) //caso o rd da BD não estiver clicado...
                {
                    txtProdutos.Clear(); //limpa o txt
                    txtProdutos.Enabled = false; //inabilita o txt
                    MessageBox.Show("Nenhum produto alugado ainda!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibe essa msg para dizer que não houve baixa de produtos  
                }
            }

            //inabilita os pb's
            pbQRCodeLoja.Visible = false;
            pbQRCodeConsig.Visible = false;

            //atualiza os pb's
            pbQRCodeLoja.Image = null;
            pbQRCodeConsig.Image = null;
        }

        //evento apaga dados do locatário
        private void btnApagarLocatario_Click(object sender, EventArgs e)
        {
            nomeClienteAluguelTextBox.Clear();
            cpfAluguelMaskedTextBox.Clear();
            celularAluguelMaskedTextBox.Clear();
            telefoneAluguelMaskedTextBox.Clear();
            cEPaluguelMaskedTextBox.Clear();
            enderecoTextBox.Clear();
            bairroAluguelTextBox.Clear();
            cidadeAluguelTextBox.Clear();
            uFAluguelTextBox.Clear();
            descricaoAluguelTextBox.Clear();
            valorAluguelTextBox.Clear();
            valorMultaTextBox.Clear();
        }

        //implementa o rb de busca de número identificador do prod. consig.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tbGeral.SelectTab(tabPage8); //seleciona a aba 8 do tab geral
            tbDados.SelectTab(tabPage2); //seleciona a aba 2 do tab dados
            txtConsignado.Enabled = true; //habilita o txt
            txtConsignado.Clear(); //limpa o txt

            //inabilita os pb's
            pbQRCodeLoja.Visible = false;
            pbQRCodeConsig.Visible = false;

            //atualiza os pb's
            pbQRCodeLoja.Image = null;
            pbQRCodeConsig.Image = null;
        }

        //implementa o btn suporte
        private void btnSistemasLua_Click(object sender, EventArgs e) //ao clicar
        {
            frmSuporte fs = new frmSuporte(); //instancia o frm
            fs.Show(); //abre o frm
        }

        //este evento implementa a ação de busca do cep por meio da internet
        private void enderecoTextBox_Click(object sender, EventArgs e)
        {
            //limpa os txtBoxes
            enderecoTextBox.Clear();
            bairroAluguelTextBox.Clear();
            cidadeAluguelTextBox.Clear();
            uFAluguelTextBox.Clear();

            try
            {
                DataSet ds = new DataSet(); //faz a instância do dataset

                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", cEPaluguelMaskedTextBox.Text); //busca as informações pelo cep
                ds.ReadXml(xml); //o arquivo é em xml

                //converte as informações para os txtBoxes
                enderecoTextBox.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                bairroAluguelTextBox.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                cidadeAluguelTextBox.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                uFAluguelTextBox.Text = ds.Tables[0].Rows[0]["UF"].ToString();
            }
            catch (Exception ex) //tratamento
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void rbNomeFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            tbGeral.SelectTab(tabPage9); //seleciona a aba 9 do tab geral
            tbDados.SelectTab(tabPage5); //seleciona a aba 5 do tab dados
        }

        private void rbCPFfornecedor_CheckedChanged(object sender, EventArgs e)
        {
            tbGeral.SelectTab(tabPage9); //seleciona a aba 9 do tab geral
            tbDados.SelectTab(tabPage5); //seleciona a aba 5 do tab dados
        }

        private void rbCNPJfornecedor_CheckedChanged(object sender, EventArgs e)
        {
            tbGeral.SelectTab(tabPage9); //seleciona a aba 9 do tab geral
            tbDados.SelectTab(tabPage5); //seleciona a aba 5 do tab dados
        }

        //implementa o botão para gerar o relatório consignado
        private void btnFinanConsig_Click(object sender, EventArgs e)
        {
            frmRelatorioConsig frc = new frmRelatorioConsig(); //instancia
            frc.Show(); //abre
        }
    }
}
