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
    public partial class TAB_SERVICO : Form
    {
        public TAB_SERVICO()
        {
            InitializeComponent();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void TAB_SERVICO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.bANCO.servico);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            servicoBindingSource.Filter = "descricao like '" + textBox1.Text + "%'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_SERVICO CS = new CADASTRAR.CAD_SERVICO();
            CS.Show();
            servicoTableAdapter.Fill(bANCO.servico);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_SERVICO CS = new CADASTRAR.CAD_SERVICO();
            CS.Show();
            servicoTableAdapter.Fill(bANCO.servico);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("DESEJA REALMENTE EXCLUIR?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    servicoBindingSource.RemoveCurrent();
                    servicoTableAdapter.Update(bANCO);
                }
            }
            catch
            {
                servicoTableAdapter.Fill(bANCO.servico);
                MessageBox.Show("NÃO FOI POSSIVEL EXCLUIR POIS O SERVIÇO ESTA SENDO USADO!", " ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            servicoTableAdapter.Fill(bANCO.servico);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ALTERAR.ALT_SERVICO DC = new ALTERAR.ALT_SERVICO();
            DC.ASD = int.Parse(id_servicoTextBox.Text);
            DC.Show();
            servicoTableAdapter.Fill(bANCO.servico);
        }

        private void TAB_SERVICO_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer sair?\r", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
