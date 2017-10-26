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
    public partial class TAB_SERVICOS_V : Form
    {
        public TAB_SERVICOS_V()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);
            textBox1.Focus();

        }

        private void TAB_SERVICOS_V_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.bANCO.servico);
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            servicoBindingSource.Filter = "descricao like '" + textBox1.Text + "%'";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
