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
    public partial class frmUsuarios : Form
    {
        private bool ehNovo;

        public frmUsuarios()
        {
            InitializeComponent();
            //metodo que lista os usuarios
            ListarUsuarios();

        }

        private void ListarUsuarios()
        {
            //1. conectar no banco
            using (var banco = new AppDbContext())
            {
                //2. SELECT * FROM  usuarios
                var usuarios = banco.Usuarios.ToList();
                //3. Popular a tabela na tela DataGridView
                dgvUsuarios.DataSource = usuarios;
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cyberButton3_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
           
            if (ehNovo)
                CriarUsuario();

            else
                AtualizarUsuario();

            DesabilitarCampos();

            ListarUsuarios();

            LimparCampos();


        }

        private void LimparCampos()
        {
            txtId.TextButton = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        private void AtualizarUsuario()
        {
            using (var banco = new AppDbContext())
            {
                //consulta um usuario na tabela usando o Id da tela
                var usuario = banco
                  .Usuarios
                    .Where(e => e.Id == int.Parse(txtId.TextButton))
                    .FirstOrDefault();

                usuario.Nome = txtNome.TextButton;
                usuario.Email = txtNome.TextButton;
                usuario.Senha = txtEmail.TextButton;
                banco.SaveChanges();

            }
        }

        private void CriarUsuario()
        {
            //acessar o banco
            using (var banco = new AppDbContext())
            {
                //criar um novo usuario
                var novoUsuario = new Usuario();
                //atributos as propriedades do usario
                novoUsuario.Nome = txtId.TextButton;
                novoUsuario.Email = txtNome.TextButton;
                novoUsuario.Senha = txtEmail.TextButton;
                //salvar alteração(INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();

                MessageBox.Show("Usuário cadastrado com sucesso.");
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            ehNovo = true;
            HabilitarCampos();

        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //indica que esta editando usuario
            ehNovo = false;
        }
    }
}
