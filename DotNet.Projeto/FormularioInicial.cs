using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet.Projeto
{
    public partial class FormularioInicial : Form
    {
        public FormularioInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor();

            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            listaFornecedores.Add(RetornarFornecedor(fornecedor));
            dgvFornecedores.DataSource = listaFornecedores;
        
        }

        private Fornecedor RetornarFornecedor(Fornecedor fornecedor)
        {

            if (txtNomeFornecedor.Text != String.Empty)
            {
                fornecedor.NomeFornecedor = txtNomeFornecedor.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome!!!");

            }
            if (txtEndereco.Text != String.Empty)
            {
                fornecedor.Endereco = txtEndereco.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o Endereço!!!");

            }
            if (txtContato.Text != String.Empty)
            {
                fornecedor.NomeContato = txtContato.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome do contato!!!");

            }
            if (txtTelefone.Text != String.Empty)
            {
                fornecedor.Telefone = txtTelefone.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o Telefone!!!");

            }
            return fornecedor;
        }
    }
}
