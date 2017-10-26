using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oficina_stang.CADASTRAR
{
    public partial class CAD_PAGAMENTO_PARC : Form
    {
        public CAD_PAGAMENTO_PARC()
        {
            InitializeComponent();
        }

        private void prazoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prazoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void CAD_PAGAMENTO_PARC_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.prazo'. Você pode movê-la ou removê-la conforme necessário.
            this.prazoTableAdapter.Fill(this.bANCO.prazo);

        }
    }
}
