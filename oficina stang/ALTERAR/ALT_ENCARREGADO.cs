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
    public partial class ALT_ENCARREGADO : Form
    {
        public ALT_ENCARREGADO()
        {
            InitializeComponent();
        }

        private void encarregadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.encarregadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }
        public int ASD;
        private void ALT_ENCARREGADO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.encarregados'. Você pode movê-la ou removê-la conforme necessário.
            this.encarregadosTableAdapter.Fill(this.bANCO.encarregados);
            int pos = encarregadosBindingSource.Find("id_encarregado", ASD);
            encarregadosBindingSource.Position = pos;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            encarregadosBindingSource.EndEdit();
            encarregadosTableAdapter.Update(bANCO);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
