using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Comandas
{
    public partial class frmCardapio : Form
    {
        //variaveis locais
        public int ID { get; set; }
        public string? TITULO { get;  set; }
        public string? DESCRICAO { get; set; }
        public decimal PRECO { get;  set; }
        public bool POSSUIPREPARO { get; set; }

        public frmCardapio()
        {
            InitializeComponent();
            ListarCardapios();
        }

        public void ListarCardapios()
        {
            using (var banco = new AppDbContext())
            {
                var cardapios = banco.Cardapio.ToList();
                dgvCardapio.DataSource = cardapios;
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {   //criei uma variavel booleana para indicar o tipo da cad
            var ehnovo = true;
            new FrmCardapioCad(ehnovo, this).ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
           var result = MessageBox.Show($"Confirma a exclusão do item {TITULO} ?", "Excluir Carddápio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                //para o metódo 
                return;
            }
            //chamar o método de excluir
            if (ExcluirCardapio(ID));
            {   //atualiza a tabela
                ListarCardapios();
                //exibi a messagem de sucesso
                MessageBox.Show($"Cardápio '{TITULO}' excluído com sucesso!");
                //desabilita o botão de excluir
                btnExcluir.Enabled = false;
            }
        }

        private bool ExcluirCardapio(int iD)
        {
             //conectar no banco
             using (var banco = new AppDbContext()) 
            {
               //buscar o cardapio através do id
               // select * from Cardapio Where id = @id
               var card = banco.Cardapio.FirstOrDefault(c=>c.Id == iD);
               //avisar o banco da exclusão
               banco.Cardapio.Remove(card);
               //confirmar para o banco a ação
               banco.SaveChanges();
            }
             return true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var ehNovo = false;
            new FrmCardapioCad(ehNovo, ID, TITULO, DESCRICAO, PRECO, POSSUIPREPARO, this).ShowDialog();
        }

        private void dgvCardapio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // obtem o numero da linha clicada
            var numeroLinha = e.RowIndex;
            //verifica se alguma linha foi selencionada
            if (numeroLinha > 0) 
            {
             
               var id = dgvCardapio.Rows[numeroLinha].Cells["Id"].Value.ToString();
                var titulo =  dgvCardapio.Rows[numeroLinha].Cells["Titulo"].Value.ToString();
                var descricao = dgvCardapio.Rows[numeroLinha].Cells["Descricao"].Value.ToString();
                var preco = dgvCardapio.Rows[numeroLinha].Cells["Preco"].Value.ToString();
                var possuiPreparo = dgvCardapio.Rows[numeroLinha].Cells["PossuiPreparo"].Value.ToString();

             //converter para tipos corretos 

                ID = int.Parse(id);
                TITULO = titulo;
                DESCRICAO = descricao;
                PRECO = decimal.Parse(preco);
                POSSUIPREPARO = bool.Parse(possuiPreparo);

             //habilitar o botão Editar
             btnEditar.Enabled = true;
             btnExcluir.Enabled = true;

            }

        }
    }
}
