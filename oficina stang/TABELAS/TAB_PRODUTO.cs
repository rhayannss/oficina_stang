using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oficina_stang.TABELAS
{
    public partial class TAB_PRODUTO : Form
    {
        public TAB_PRODUTO()
        {
            InitializeComponent();
        }

        private void produtosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void TAB_PRODUTO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.categorias'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriasTableAdapter.Fill(this.bANCO.categorias);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.bANCO.produtos);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            produtosBindingSource.Filter="descricao like '" + textBox1.Text + "%'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_PRODUTO CP = new CADASTRAR.CAD_PRODUTO();
            CP.Show();
            produtosTableAdapter.Fill(bANCO.produtos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_PRODUTO CP = new CADASTRAR.CAD_PRODUTO();
            CP.Show();
            produtosTableAdapter.Fill(bANCO.produtos);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("DESEJA REALMENTE EXCLUIR?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    produtosBindingSource.RemoveCurrent();
                    produtosTableAdapter.Update(bANCO);
                }
            }
            catch
            {
                produtosTableAdapter.Fill(bANCO.produtos);
                MessageBox.Show("NÃO FOI POSSIVEL EXCLUIR POIS O PRODUTO ESTA SENDO USADO!", " ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            produtosTableAdapter.Fill(bANCO.produtos);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DADOS.DAD_PRODUTO DC = new DADOS.DAD_PRODUTO();
            DC.ASD = int.Parse(id_produtoTextBox.Text);
            DC.Show();
            produtosTableAdapter.Fill(bANCO.produtos);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ALTERAR.ALT_PRODUTO DC = new ALTERAR.ALT_PRODUTO();
            DC.ASD = int.Parse(id_produtoTextBox.Text);
            DC.Show();
            produtosTableAdapter.Fill(bANCO.produtos);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TAB_PRODUTO_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer sair?\r", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
