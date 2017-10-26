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
    public partial class TAB_OS_V : Form
    {
        public TAB_OS_V()
        {
            InitializeComponent();
        }

        private void ordem_servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordem_servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void TAB_OS_V_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.ordem_servico'. Você pode movê-la ou removê-la conforme necessário.
            this.ordem_servicoTableAdapter.Fill(this.bANCO.ordem_servico);

        }
    }
}
