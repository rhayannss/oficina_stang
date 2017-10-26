using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace oficina_stang.CADASTRAR
{
    public partial class CAD_ORDEM : Form
    {
        public CAD_ORDEM()
        {
            InitializeComponent();
        }

        private void ordem_servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordem_servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void CAD_ORDEM_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.bANCO.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.encarregados'. Você pode movê-la ou removê-la conforme necessário.
            this.encarregadosTableAdapter.Fill(this.bANCO.encarregados);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.fazendas'. Você pode movê-la ou removê-la conforme necessário.
            this.fazendasTableAdapter.Fill(this.bANCO.fazendas);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bANCO.clientes);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.ordem_servico'. Você pode movê-la ou removê-la conforme necessário.
            this.ordem_servicoTableAdapter.Fill(this.bANCO.ordem_servico);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.ordem_servico'. Você pode movê-la ou removê-la conforme necessário.
            this.ordem_servicoTableAdapter.Fill(this.bANCO.ordem_servico);
            ordem_servicoBindingSource.AddNew();
        }

        private void ordem_servicoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ordem_servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ordem_servicoBindingSource.EndEdit();
            ordem_servicoTableAdapter.Update(bANCO);
            ordem_servicoBindingSource.MoveLast();
            CAD_ITEM_ORDEM CIO = new CAD_ITEM_ORDEM();
            int pos = ordem_servicoBindingSource.Find("id_orden", id_ordenTextBox.Text);
            //CIO.ordem_servicoBindingSource.Position = pos;
            CIO.asdf = int.Parse(id_ordenTextBox1.Text);
            CIO.ShowDialog();
            ordem_servicoTableAdapter.Fill(bANCO.ordem_servico);
            ordem_servicoBindingSource.MoveLast();
            ASDFG();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ordem_servicoBindingSource.EndEdit();
            ordem_servicoTableAdapter.Update(bANCO);
            if (MessageBox.Show("O.S. CONCLUIDA\nDESEJA ADICIONAR OUTRA O.S.?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                ordem_servicoBindingSource.AddNew();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void descontoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sub_totalTextBox.Text != "" && descontoTextBox.Text != "")
            {
                float a, b, c, d;
                a = float.Parse(sub_totalTextBox.Text);
                b = 100 - float.Parse(descontoTextBox.Text);
                if (b < 0)
                {
                    b = b * -1;
                }
                c = a * b;
                d = c / 100;
                totalTextBox.Text = d.ToString();
            }
        }

        private void totalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sub_totalTextBox.Text != "" && totalTextBox.Text != "")
            {
                float a, b, c, d;
                a = float.Parse(sub_totalTextBox.Text);
                b = float.Parse(totalTextBox.Text)*100;
                c = b / a;
                d = 100 - c;
                totalTextBox.Text = d.ToString();
            }
        }

        private void descontoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < ',' || e.KeyChar > '9')
            {
                // verifica se não é o backspace
                // 8 é o código do backspace
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                   
                }
            }
        }

        private void sub_totalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sub_totalTextBox.Text != "" && descontoTextBox.Text != "")
            {
                float a, b, c, d;
                a = float.Parse(sub_totalTextBox.Text);
                b = 100-float.Parse(descontoTextBox.Text);
                if (b < 0)
                {
                    b = b * -1;
                }
                c = a * b;
                d = c/100;
                totalTextBox.Text = d.ToString();
            }
        }

        private void ordem_servicoBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            string a ="0,00";
            sub_totalTextBox.Text = a;
            descontoTextBox.Text = a;
            totalTextBox.Text = a;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ordem_servicoBindingSource.EndEdit();
            ordem_servicoTableAdapter.Update(bANCO); 
            try
            {
                string Strconn = @"Data Source=localhost\SQLExpress;Initial Catalog=oficina;Integrated Security=True";
                SqlConnection conn = new SqlConnection(Strconn);

                string pesquisa = "SELECT * FROM View_ordem WHERE id_orden = @p1";
                SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", id_ordenTextBox1.Text));


                BANCO bl = new BANCO();
                DA.Fill(bl, "View_ordem");

                RELATORIOS.REL_OS CR = new RELATORIOS.REL_OS();
                CR.SetDataSource(bl);

                RELATORIOS.VISUALIZADOR_RELATORIO V = new RELATORIOS.VISUALIZADOR_RELATORIO();
                V.crystalReportViewer1.ReportSource = CR;
                V.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao visualisar relatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ASDFG()
        {
            if (textBox1.Text != "" && descontoTextBox.Text != "")
            {
                string aa = textBox1.Text, bb = descontoTextBox.Text;
                float a, b, c, d, w;
                a = float.Parse(aa);
                w = float.Parse(bb);
                if (w < 0)
                {
                    w = w * -1;
                }
                b = 100 - w;
                c = a * b;
                d = c / 100;
                totalTextBox.Text = d.ToString();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ordem_servicoBindingSource.EndEdit();
            ordem_servicoTableAdapter.Update(bANCO);
            ordem_servicoBindingSource.MoveLast();
            CAD_ITENS_SERVICO CIO = new CAD_ITENS_SERVICO();
            int pos = ordem_servicoBindingSource.Find("id_orden", id_ordenTextBox.Text);
            //CIO.ordem_servicoBindingSource.Position = pos;
            CIO.asdf = int.Parse(id_ordenTextBox1.Text);
            CIO.ShowDialog();
            ordem_servicoTableAdapter.Fill(bANCO.ordem_servico);
            ordem_servicoBindingSource.MoveLast();
            ASDFG();
            

        }

        private void sub_totalTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (sub_totalTextBox.Text != "" && subtotal_servicoTextBox.Text != "")
            {
                float a, b, c;
                a = float.Parse(sub_totalTextBox.Text);
                b = float.Parse(subtotal_servicoTextBox.Text);
                c = a + b;
                textBox1.Text = c.ToString();
            }
        }

        private void subtotal_servicoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sub_totalTextBox.Text != "" && subtotal_servicoTextBox.Text != "")
            {
                float a, b, c;
                a = float.Parse(sub_totalTextBox.Text);
                b = float.Parse(subtotal_servicoTextBox.Text);
                c = a + b;
                textBox1.Text = c.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && descontoTextBox.Text != "")
            {
                string aa = textBox1.Text, bb = descontoTextBox.Text;
                float a, b, c, d, w;
                a = float.Parse(aa);
                w = float.Parse(bb);
                if (w < 0)
                {
                    w = w * -1;
                }
                b = 100 - w;
                c = a * b;
                d = c / 100;
                totalTextBox.Text = d.ToString();
            }
        }

        private void descontoTextBox_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && descontoTextBox.Text != "")
            {
                string aa = textBox1.Text, bb = descontoTextBox.Text;
                float a, b, c, d, w;
                a = float.Parse(aa);
                w = float.Parse(bb);
                if (w < 0)
                {
                    w = w * -1;
                }
                b = 100 - w;
                c = a * b;
                d = c / 100;
                totalTextBox.Text = d.ToString();
            }
        }

        private void totalTextBox_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && totalTextBox.Text != "")
            {
                float a, b, c, d;
                a = float.Parse(textBox1.Text);
                b = float.Parse(totalTextBox.Text) * 100;
                c = b / a;
                d = 100 - c;
                descontoTextBox.Text = d.ToString();
            }
        }

        private void totalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < ',' || e.KeyChar > '9')
            {
                // verifica se não é o backspace
                // 8 é o código do backspace
                if (e.KeyChar != 8)
                {
                    e.Handled = true;

                }
            }
        }
    }
}
