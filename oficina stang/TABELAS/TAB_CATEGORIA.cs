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
    public partial class TAB_CATEGORIA : Form
    {
        public TAB_CATEGORIA()
        {
            InitializeComponent();
        }

        private void categoriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void TAB_CATEGORIA_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.categorias'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriasTableAdapter.Fill(this.bANCO.categorias);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            categoriasBindingSource.Filter = " nome like '" + textBox1.Text + "%'";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_CATEGORIA CC = new CADASTRAR.CAD_CATEGORIA();
            CC.Show();
            categoriasTableAdapter.Fill(bANCO.categorias);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("DESEJA REALMENTE EXCLUIR?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    categoriasBindingSource.RemoveCurrent();
                    categoriasTableAdapter.Update(bANCO);
                }
            }
            catch
            {
                categoriasTableAdapter.Fill(bANCO.categorias);
                MessageBox.Show("NÃO FOI POSSIVEL EXCLUIR POIS A CATEGORIA ESTA SENDO USADA!", " ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            categoriasTableAdapter.Fill(bANCO.categorias);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ALTERAR.ALT_CATEGORIA DC = new ALTERAR.ALT_CATEGORIA();
            DC.ASD = int.Parse(id_categoriaTextBox.Text);
            DC.Show();
            categoriasTableAdapter.Fill(bANCO.categorias);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TAB_CATEGORIA_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer sair?\r", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
