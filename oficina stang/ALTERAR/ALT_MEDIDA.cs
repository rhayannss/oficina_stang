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
    public partial class ALT_MEDIDA : Form
    {
        public ALT_MEDIDA()
        {
            InitializeComponent();
        }

        private void categoriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           // this.categoriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void medidasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medidasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }
        public int ASD;
        private void ALT_MEDIDA_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.medidas'. Você pode movê-la ou removê-la conforme necessário.
            this.medidasTableAdapter.Fill(this.bANCO.medidas);
            int pos = medidasBindingSource.Find("id_medida", ASD);
            medidasBindingSource.Position = pos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            medidasBindingSource.EndEdit();
            medidasTableAdapter.Update(bANCO);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
