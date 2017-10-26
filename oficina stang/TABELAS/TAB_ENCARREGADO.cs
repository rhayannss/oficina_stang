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
    public partial class TAB_ENCARREGADO : Form
    {
        public TAB_ENCARREGADO()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void TAB_ENCARREGADO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.cidades'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadesTableAdapter.Fill(this.bANCO.cidades);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.encarregados'. Você pode movê-la ou removê-la conforme necessário.
            this.encarregadosTableAdapter.Fill(this.bANCO.encarregados);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bANCO.clientes);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clientesBindingSource.Filter = "nome like '" + textBox1.Text + "%'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            encarregadosBindingSource.Filter = "nome like'" + textBox2.Text + "%'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_ENCARREGADOS CE = new CADASTRAR.CAD_ENCARREGADOS();
            CE.Show();
            encarregadosTableAdapter.Fill(bANCO.encarregados);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_ENCARREGADOS CE = new CADASTRAR.CAD_ENCARREGADOS();
            CE.id = int.Parse(id_clienteTextBox.Text);
            CE.Show();
            encarregadosTableAdapter.Fill(bANCO.encarregados);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("DESEJA REALMENTE EXCLUIR?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    encarregadosBindingSource.RemoveCurrent();
                    encarregadosTableAdapter.Update(bANCO);
                }
            }
            catch
            {
                encarregadosTableAdapter.Fill(bANCO.encarregados);
                MessageBox.Show("NÃO FOI POSSIVEL EXCLUIR POIS O ENCARREGADO ESTA SENDO USADO!", " ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            encarregadosTableAdapter.Fill(bANCO.encarregados);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ALTERAR.ALT_CLIENTE DC = new ALTERAR.ALT_CLIENTE();
            DC.ASD = int.Parse(id_encarregadoTextBox.Text);
            DC.Show();
            encarregadosTableAdapter.Fill(bANCO.encarregados);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void TAB_ENCARREGADO_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer sair?\r", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
