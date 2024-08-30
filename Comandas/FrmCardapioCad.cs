using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmCardapioCad : Form
    {  //variavel que indica se esta criando um novo cardapio
        bool ehNovo = false;
        public FrmCardapioCad(bool acao)
        {
            ehNovo = acao;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void thunderLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //se o form está em modo de inclusão
            if (ehNovo) 
            {
                //Executa o método que realiza o INSERT na tabela
                AdicionarCardapio();
            }
            else
            {
                //Executa o método que realiza
                AtualizarCardapio();
            }
            Close();
        }

        private void AtualizarCardapio()
        {
           
        }

        private void AdicionarCardapio()
        {
            //usar o banco de dados
            //cria uma variavel banco que 
           using(var banco = new AppDbContext())
            {
                var novoCardapio = new Cardapio()
                {
                   Titulo = txtTitulo.TextButton, 
                   Descricao = txtDescrição.TextButton,
                   Preco = decimal.Parse(txtPreço.TextButton),
                   PossuiPreparo = chkPreparo.Checked
                };
                banco.Cardapio.Add(novoCardapio);
                banco.SaveChanges();
            }
        }
    }
}
