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
    public partial class TAB_APRAZO_PAGO : Form
    {
        public TAB_APRAZO_PAGO()
        {
            InitializeComponent();
        }

        private void TAB_APRAZO_PAGO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.View_debito_pago'. Você pode movê-la ou removê-la conforme necessário.
            this.view_debito_pagoTableAdapter.Fill(this.bANCO.View_debito_pago);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Focus();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Focus();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (radioButton3.Checked)
            {
                view_debito_pagoBindingSource.Filter = "data = " + maskedTextBox1.Text;
            }
            if (radioButton4.Checked)
            {
                view_debito_pagoBindingSource.Filter = "venc = " + maskedTextBox1.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                view_debito_pagoBindingSource.Filter = "nome like '" + textBox1.Text + "%'";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                view_debito_pagoBindingSource.Filter = "numero_nf = " + textBox1.Text;
            }
        }
    }
}
