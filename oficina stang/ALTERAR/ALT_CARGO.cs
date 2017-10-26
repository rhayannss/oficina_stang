using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oficina_stang.ALTERAR
{
    public partial class ALT_CARGO : Form
    {
        public ALT_CARGO()
        {
            InitializeComponent();
        }

        private void funcoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }
        public int ASD;
        private void ALT_CARGO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.funcoes'. Você pode movê-la ou removê-la conforme necessário.
            this.funcoesTableAdapter.Fill(this.bANCO.funcoes);
            int pos = funcoesBindingSource.Find("id_funcao", ASD);
            funcoesBindingSource.Position = pos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcoesBindingSource.EndEdit();
            funcoesTableAdapter.Update(bANCO);
            Close();
            TABELAS.TAB_CARGO TC = new TABELAS.TAB_CARGO();
            TC.A = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TABELAS.TAB_CARGO TC = new TABELAS.TAB_CARGO();
            TC.A = 0;
            Close();
        }
    }
}
