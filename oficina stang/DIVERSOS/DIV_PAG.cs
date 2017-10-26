using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oficina_stang.DIVERSOS
{
    public partial class DIV_PAG : Form
    {
        public DIV_PAG()
        {
            InitializeComponent();
        }

        private void notas_saidaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notas_saidaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void DIV_PAG_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.notas_saida'. Você pode movê-la ou removê-la conforme necessário.
            this.notas_saidaTableAdapter.Fill(this.bANCO.notas_saida);

        }
    }
}
