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
    public partial class TAB_CARTAO : Form
    {
        public TAB_CARTAO()
        {
            InitializeComponent();
        }

        private void TAB_CARTAO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.View_cartao'. Você pode movê-la ou removê-la conforme necessário.
            this.view_cartaoTableAdapter.Fill(this.bANCO.View_cartao);

        }
    }
}
