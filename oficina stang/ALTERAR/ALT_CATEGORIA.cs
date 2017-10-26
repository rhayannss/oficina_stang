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
    public partial class ALT_CATEGORIA : Form
    {
        public ALT_CATEGORIA()
        {
            InitializeComponent();
        }

        private void categoriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }
        public int ASD;
        private void ALT_CATEGORIA_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.categorias'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriasTableAdapter.Fill(this.bANCO.categorias);
            int pos = categoriasBindingSource.Find("id_categoria", ASD);
            categoriasBindingSource.Position = pos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            categoriasBindingSource.EndEdit();
            categoriasTableAdapter.Update(bANCO);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
