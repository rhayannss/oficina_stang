using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace oficina_stang.CADASTRAR
{
    public partial class CAD_PRODUTO : Form
    {
        public CAD_PRODUTO()
        {
            InitializeComponent();
        }

        private void produtosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void CAD_PRODUTO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.medidas'. Você pode movê-la ou removê-la conforme necessário.
            this.medidasTableAdapter.Fill(this.bANCO.medidas);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.categorias'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriasTableAdapter.Fill(this.bANCO.categorias);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.bANCO.produtos);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.bANCO.produtos);
            produtosBindingSource.AddNew();
            margemTextBox.Text = "100";
        }

        private void produtosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void margemTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (margemTextBox.Text != "" && preco_custoTextBox.Text != "")
                {
                    float a, b, c, d;
                    a = float.Parse(preco_custoTextBox.Text);

                    b = float.Parse(margemTextBox.Text) / 100;

                    c = a * b;

                    d = a + c;
                    preco_vendaTextBox.Text = d.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao calcular os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preco_vendaTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (preco_vendaTextBox.Text != "" && preco_custoTextBox.Text != "")
                {
                    float a, b, c, d;
                    a = float.Parse(preco_custoTextBox.Text);

                    b = float.Parse(preco_vendaTextBox.Text) * 100;

                    c = b / a;

                    d = c - 100;
                    margemTextBox.Text = d.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao calcular os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quantidadeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (quantidadeTextBox.Text != "" && kg_metroTextBox.Text != "")
                {
                    float a, b, d;
                    a = float.Parse(quantidadeTextBox.Text);

                    b = float.Parse(kg_metroTextBox.Text);

                    d = a * b;

                    quantidade_convertidaTextBox.Text = d.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao calcular os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quantidade_convertidaTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (quantidade_convertidaTextBox.Text != "" && kg_metroTextBox.Text != "")
                {
                    float a, b, d;
                    a = float.Parse(quantidade_convertidaTextBox.Text);

                    b = float.Parse(kg_metroTextBox.Text);

                    d = a / b;

                    quantidadeTextBox.Text = d.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao calcular os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int A = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            produtosBindingSource.EndEdit();
            produtosTableAdapter.Update(bANCO);
            DialogResult X = MessageBox.Show("DESEJA ADICIONAR OUTRO PRODUTO?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (X == DialogResult.Yes)
            {
                A = 1;
                produtosBindingSource.AddNew();
                margemTextBox.Text = "100";
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

        private void kg_metroTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (quantidadeTextBox.Text != "" && kg_metroTextBox.Text != "")
                {
                    float a, b, d;
                    a = float.Parse(quantidadeTextBox.Text);

                    b = float.Parse(kg_metroTextBox.Text);

                    d = a * b;

                    quantidade_convertidaTextBox.Text = d.ToString();
                }
                else if (quantidade_convertidaTextBox.Text != "" && kg_metroTextBox.Text != "")
                {
                    float a, b, d;
                    a = float.Parse(quantidade_convertidaTextBox.Text);

                    b = float.Parse(kg_metroTextBox.Text);

                    d = a / b;

                    quantidadeTextBox.Text = d.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao calcular os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preco_custoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (margemTextBox.Text != "" && preco_custoTextBox.Text != "")
            {
                float a, b, c, d;
                a = float.Parse(preco_custoTextBox.Text);

                b = float.Parse(margemTextBox.Text) / 100;

                c = a * b;

                d = a + c;
                preco_vendaTextBox.Text = d.ToString();
            }
        }

        private void preco_custoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CAD_PRODUTO_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (A == 1)
            {
                e.Cancel = true;
                return;
            }
        }

        private void id_medidaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void preco_custoTextBox_Leave(object sender, EventArgs e)
        {
            if (margemTextBox.Text != "" && preco_custoTextBox.Text != "")
            {
                float a, b, c, d;
                a = float.Parse(preco_custoTextBox.Text);

                b = float.Parse(margemTextBox.Text) / 100;

                c = a * b;

                d = a + c;
                preco_vendaTextBox.Text = d.ToString();
            }
        }

        private void margemTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (margemTextBox.Text != "" && preco_custoTextBox.Text != "")
                {
                    float a, b, c, d;
                    a = float.Parse(preco_custoTextBox.Text);

                    b = float.Parse(margemTextBox.Text) / 100;

                    c = a * b;

                    d = a + c;
                    preco_vendaTextBox.Text = d.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao calcular os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preco_vendaTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (preco_vendaTextBox.Text != "" && preco_custoTextBox.Text != "")
                {
                    float a, b, c, d;
                    a = float.Parse(preco_custoTextBox.Text);

                    b = float.Parse(preco_vendaTextBox.Text) * 100;

                    c = b / a;

                    d = c - 100;
                    margemTextBox.Text = d.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao calcular os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quantidadeTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (quantidadeTextBox.Text != "" && kg_metroTextBox.Text != "")
                {
                    float a, b, d;
                    a = float.Parse(quantidadeTextBox.Text);

                    b = float.Parse(kg_metroTextBox.Text);

                    d = a * b;

                    quantidade_convertidaTextBox.Text = d.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao calcular os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kg_metroTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (quantidadeTextBox.Text != "" && kg_metroTextBox.Text != "")
                {
                    float a, b, d;
                    a = float.Parse(quantidadeTextBox.Text);

                    b = float.Parse(kg_metroTextBox.Text);

                    d = a * b;

                    quantidade_convertidaTextBox.Text = d.ToString();
                }
                else if (quantidade_convertidaTextBox.Text != "" && kg_metroTextBox.Text != "")
                {
                    float a, b, d;
                    a = float.Parse(quantidade_convertidaTextBox.Text);

                    b = float.Parse(kg_metroTextBox.Text);

                    d = a / b;

                    quantidadeTextBox.Text = d.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao calcular os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quantidade_convertidaTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (quantidade_convertidaTextBox.Text != "" && kg_metroTextBox.Text != "")
                {
                    float a, b, d;
                    a = float.Parse(quantidade_convertidaTextBox.Text);

                    b = float.Parse(kg_metroTextBox.Text);

                    d = a / b;

                    quantidadeTextBox.Text = d.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao calcular os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void produtosBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            margemTextBox.Text = "100";
        }

        private void margemTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }
    }
}
