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
    public partial class TAB_FAZENDA : Form
    {
        public TAB_FAZENDA()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void TAB_FAZENDA_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.cidades'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadesTableAdapter.Fill(this.bANCO.cidades);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.fazendas'. Você pode movê-la ou removê-la conforme necessário.
            this.fazendasTableAdapter.Fill(this.bANCO.fazendas);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bANCO.clientes);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clientesBindingSource.Filter = "nome like '" + textBox1.Text + "%'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_CLIENTE CC = new CADASTRAR.CAD_CLIENTE();
            CC.Show();
            clientesTableAdapter.Fill(bANCO.clientes);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            fazendasBindingSource.Filter = "nome like '" + textBox2.Text + "%'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_FAZENDA CF = new CADASTRAR.CAD_FAZENDA();
            CF.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("DESEJA REALMENTE EXCLUIR?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    fazendasBindingSource.EndEdit();
                    fazendasTableAdapter.Update(bANCO);
                }
            }
            catch
            {
                fazendasTableAdapter.Fill(bANCO.fazendas);
                MessageBox.Show("NÃO FOI POSSIVEL EXCLUIR POIS A FAZENDA ESTA SENDO USADA!", " ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            fazendasTableAdapter.Fill(bANCO.fazendas);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_FAZENDA CF = new CADASTRAR.CAD_FAZENDA();
            CF.id = int.Parse(id_clienteTextBox.Text);
            CF.Show();
            fazendasTableAdapter.Fill(bANCO.fazendas);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DADOS.DAD_FAZENDA DC = new DADOS.DAD_FAZENDA();
            DC.ASD = int.Parse(id_fazendaTextBox.Text);
            DC.Show();
            fazendasTableAdapter.Fill(bANCO.fazendas);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ALTERAR.ALT_FAZENDA DC = new ALTERAR.ALT_FAZENDA();
            DC.ASD = int.Parse(id_fazendaTextBox.Text);
            DC.Show();
            fazendasTableAdapter.Fill(bANCO.fazendas);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TAB_FAZENDA_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer sair?\r", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
