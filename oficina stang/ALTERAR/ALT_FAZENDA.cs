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
    public partial class ALT_FAZENDA : Form
    {
        public ALT_FAZENDA()
        {
            InitializeComponent();
        }
        public int ASD;
        private void ALT_FAZENDA_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.cidades'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadesTableAdapter.Fill(this.bANCO.cidades);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.fazendas'. Você pode movê-la ou removê-la conforme necessário.
            this.fazendasTableAdapter.Fill(this.bANCO.fazendas);
            int pos = fazendasBindingSource.Find("id_fazenda", ASD);
            fazendasBindingSource.Position = pos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fazendasBindingSource.EndEdit();
            fazendasTableAdapter.Update(bANCO);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
