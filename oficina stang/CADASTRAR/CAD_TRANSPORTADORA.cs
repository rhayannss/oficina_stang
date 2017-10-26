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
    public partial class CAD_TRANSPORTADORA : Form
    {
        public CAD_TRANSPORTADORA()
        {
            InitializeComponent();
        }

        private void transportadorasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transportadorasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void CAD_TRANSPORTADORA_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.cidades'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadesTableAdapter.Fill(this.bANCO.cidades);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.transportadoras'. Você pode movê-la ou removê-la conforme necessário.
            this.transportadorasTableAdapter.Fill(this.bANCO.transportadoras);

        }
    }
}
