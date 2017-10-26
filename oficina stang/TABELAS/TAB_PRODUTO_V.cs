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
    public partial class TAB_PRODUTO_V : Form
    {
        public TAB_PRODUTO_V()
        {
            InitializeComponent();
            this.textBox1.Focus();
        }

        private void produtosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);
            this.textBox1.Focus();

        }

        private void TAB_PRODUTO_V_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.bANCO.produtos);
            this.textBox1.Focus();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            produtosBindingSource.Filter = "descricao like '" + textBox1.Text + "%'";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TAB_PRODUTO_V_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Focus();
        }
    }
}
