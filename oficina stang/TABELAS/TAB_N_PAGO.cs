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
    public partial class TAB_N_PAGO : Form
    {
        public TAB_N_PAGO()
        {
            InitializeComponent();
        }

        private void TAB_N_PAGO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.View_debito'. Você pode movê-la ou removê-la conforme necessário.
            this.view_debitoTableAdapter.Fill(this.bANCO.View_debito);

        }
    }
}
