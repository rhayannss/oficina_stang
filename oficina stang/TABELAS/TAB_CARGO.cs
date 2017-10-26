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
    public partial class TAB_CARGO : Form
    {
        public TAB_CARGO()
        {
            InitializeComponent();
        }

        private void funcoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void TAB_CARGO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.funcoes'. Você pode movê-la ou removê-la conforme necessário.
            this.funcoesTableAdapter.Fill(this.bANCO.funcoes);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            funcoesBindingSource.Filter = "cargo like '" + textBox1.Text + "'%";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            A = 1;
            CADASTRAR.CAD_CARGO CC = new CADASTRAR.CAD_CARGO();
            CC.Show();
            funcoesTableAdapter.Fill(bANCO.funcoes);
            AS();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("DESEJA REALMENTE EXCLUIR?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    A = 1;
                    funcoesBindingSource.RemoveCurrent();
                    funcoesTableAdapter.Update(bANCO);
                    funcoesTableAdapter.Fill(bANCO.funcoes);
                }
            }
            catch
            {
                funcoesTableAdapter.Fill(bANCO.funcoes);
                MessageBox.Show("NÃO FOI POSSIVEL EXCLUIR POIS O CARGO ESTA SENDO USADO!", " ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AS()
        {
            A = 0;
        }
        public int A = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            A = 1;
            ALTERAR.ALT_CARGO DC = new ALTERAR.ALT_CARGO();
            DC.ASD = int.Parse(id_funcaoTextBox.Text);
            DC.Show();
            funcoesTableAdapter.Fill(bANCO.funcoes);
            AS();
        }

        private void TAB_CARGO_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer sair?\r", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
