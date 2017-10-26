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
    public partial class CAD_CATEGORIA : Form
    {
        public CAD_CATEGORIA()
        {
            InitializeComponent();
        }

        private void categoriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void CAD_CATEGORIA_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.categorias'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriasTableAdapter.Fill(this.bANCO.categorias);
            categoriasBindingSource.AddNew();

        }
        int A = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            categoriasBindingSource.EndEdit();
            categoriasTableAdapter.Update(bANCO); 
            DialogResult X = MessageBox.Show("DESEJA ADICIONAR OUTRO ESTADO?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (X == DialogResult.Yes)
            {
                A = 1;
                categoriasBindingSource.AddNew();

            }
            else
            {
                A = 0;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A = 0;
            Close();
        }

        private void CAD_CATEGORIA_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (A == 1)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
