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
    public partial class TAB_CLIENTE_EXCLUIR : Form
    {
        public TAB_CLIENTE_EXCLUIR()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void TAB_CLIENTE_EXCLUIR_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.cidades'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadesTableAdapter.Fill(this.bANCO.cidades);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bANCO.clientes);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clientesBindingSource.Filter = "nome like '" + textBox1.Text + "%'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_CLIENTE cc = new CADASTRAR.CAD_CLIENTE();
            cc.Show();
            clientesTableAdapter.Fill(bANCO.clientes);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientesBindingSource.RemoveCurrent();
            clientesTableAdapter.Update(bANCO);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_CLIENTE cc = new CADASTRAR.CAD_CLIENTE();
            cc.Show();
            clientesTableAdapter.Fill(bANCO.clientes);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DADOS.DAD_CLIENTE DC = new DADOS.DAD_CLIENTE();
            DC.ASD = int.Parse(id_clienteTextBox.Text);
            DC.Show();
            clientesTableAdapter.Fill(bANCO.clientes);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("DESEJA REALMENTE EXCLUIR?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    clientesBindingSource.RemoveCurrent();
                    clientesTableAdapter.Update(bANCO);
                }
            }
            catch
            {
                clientesTableAdapter.Fill(bANCO.clientes);
                MessageBox.Show("NÃO FOI POSSIVEL EXCLUIR POIS O CLIENTE ESTA SENDO USADO!", " ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clientesTableAdapter.Fill(bANCO.clientes);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ALTERAR.ALT_CLIENTE DC = new ALTERAR.ALT_CLIENTE();
            DC.ASD = int.Parse(id_clienteTextBox.Text);
            DC.Show();
            clientesTableAdapter.Fill(bANCO.clientes);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TAB_CLIENTE_EXCLUIR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer sair?\r", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
