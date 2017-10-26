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
    public partial class ALT_SERVICO : Form
    {
        public ALT_SERVICO()
        {
            InitializeComponent();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }
        public int ASD;
        private void ALT_SERVICO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.bANCO.servico);
            int pos = servicoBindingSource.Find("id_servico", ASD);
            servicoBindingSource.Position = pos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            servicoBindingSource.EndEdit();
            servicoTableAdapter.Update(bANCO);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
