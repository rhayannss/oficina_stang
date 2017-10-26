using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oficina_stang.DADOS
{
    public partial class DAD_PRODUTO : Form
    {
        public DAD_PRODUTO()
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
        private void DAD_PRODUTO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.medidas'. Você pode movê-la ou removê-la conforme necessário.
            this.medidasTableAdapter.Fill(this.bANCO.medidas);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.bANCO.produtos);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.categorias'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriasTableAdapter.Fill(this.bANCO.categorias);
            int pos = produtosBindingSource.Find("id_produto", ASD);
            produtosBindingSource.Position = pos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            produtosBindingSource = null;
            produtosTableAdapter = null;
            Close();
        }
    }
}
