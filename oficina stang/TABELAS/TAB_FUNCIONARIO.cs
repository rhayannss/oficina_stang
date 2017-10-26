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
    public partial class TAB_FUNCIONARIO : Form
    {
        public TAB_FUNCIONARIO()
        {
            InitializeComponent();
        }

        private void funcionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void TAB_FUNCIONARIO_Load(object sender, EventArgs e)
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
