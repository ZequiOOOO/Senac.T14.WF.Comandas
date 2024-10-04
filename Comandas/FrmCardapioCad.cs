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
        private frmCardapio _frmCardapio;

        public int ID { get; }
        public string? TITULO { get; }
        public string? DESCRICAO { get; }
        public decimal PRECO { get; }
        public bool POSSUIPREPARO { get; }

        public FrmCardapioCad(bool acao, frmCardapio frmCardapio)
        {
            ehNovo = acao;
            _frmCardapio = frmCardapio;
            InitializeComponent();
        }

        public FrmCardapioCad(bool acao, int iD, string? tITULO, string? dESCRICAO, decimal pRECO, bool pOSSUIPREPARO, frmCardapio frmCardapio) : this(acao, frmCardapio)
        {
            ehNovo = acao;
            InitializeComponent();
            ID = iD;
            TITULO = tITULO;
            DESCRICAO = dESCRICAO;
            PRECO = pRECO;
            POSSUIPREPARO = pOSSUIPREPARO;
            PopularCampos();
        }

        private void PopularCampos()
        {
            txtId.TextButton = ID.ToString();
            txtTitulo.TextButton = TITULO;
            txtDescrição.TextButton = DESCRICAO;
            txtPreço.TextButton = PRECO.ToString();
            chkPreparo.Checked = POSSUIPREPARO;
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
            _frmCardapio.ListarCardapios();
            // fecha a tela atual (
            Close();
        }

        private void AtualizarCardapio()
        {
            //conectar no banco de dados
           using (var banco = new AppDbContext()) 
            {
              var cardapio = banco.Cardapio.FirstOrDefault(f=>f.Id == int.Parse(txtId.TextButton));
              
                cardapio.Titulo = txtTitulo.TextButton;
                cardapio.Descricao = txtDescrição.TextButton;
                cardapio.Preco = decimal.Parse(txtPreço.TextButton);  
                cardapio.PossuiPreparo = chkPreparo.Checked;
                banco.SaveChanges();
            }
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
