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
    public partial class TAB_FUNCIONARIO_EXCLUIR : Form
    {
        public TAB_FUNCIONARIO_EXCLUIR()
        {
            InitializeComponent();
        }

        private void funcionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void TAB_FUNCIONARIO_EXCLUIR_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.funcoes'. Você pode movê-la ou removê-la conforme necessário.
            this.funcoesTableAdapter.Fill(this.bANCO.funcoes);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.bANCO.funcionarios);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            funcionariosBindingSource.Filter = "nome like '" + textBox1.Text + "%'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_FUNCIONARIO CF = new CADASTRAR.CAD_FUNCIONARIO();
            CF.Show();
            funcionariosTableAdapter.Fill(bANCO.funcionarios);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.RemoveCurrent();
            funcionariosTableAdapter.Update(bANCO);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("DESEJA REALMENTE EXCLUIR?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    funcionariosBindingSource.RemoveCurrent();
                    funcionariosTableAdapter.Update(bANCO);
                }
            }
            catch
            {
                funcionariosTableAdapter.Fill(bANCO.funcionarios);
                MessageBox.Show("NÃO FOI POSSIVEL EXCLUIR POIS O FUNCIONARIO ESTA SENDO USADO!", " ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            funcionariosTableAdapter.Fill(bANCO.funcionarios);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DADOS.DAD_FUNCIONARIO DC = new DADOS.DAD_FUNCIONARIO();
            DC.ASD = int.Parse(id_funcionarioTextBox.Text);
            DC.Show();
            funcionariosTableAdapter.Fill(bANCO.funcionarios);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ALTERAR.ALT_FUNCIONARIO DC = new ALTERAR.ALT_FUNCIONARIO();
            DC.ASD = int.Parse(id_funcionarioTextBox.Text);
            DC.Show();
            funcionariosTableAdapter.Fill(bANCO.funcionarios);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TAB_FUNCIONARIO_EXCLUIR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer sair?\r", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
