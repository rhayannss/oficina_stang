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
    public partial class TAB_CAIXA : Form
    {
        public TAB_CAIXA()
        {
            InitializeComponent();
        }

        private void TAB_CAIXA_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.View_caixa'. Você pode movê-la ou removê-la conforme necessário.
            this.view_caixaTableAdapter.Fill(this.bANCO.View_caixa);

        }
    }
}
