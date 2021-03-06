﻿using System;
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
    public partial class CAD_NT_SAIDA : Form
    {
        public CAD_NT_SAIDA()
        {
            InitializeComponent();
        }
        
        private void notas_saidaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notas_saidaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void CAD_NT_SAIDA_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bANCO.clientes);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.notas_saida'. Você pode movê-la ou removê-la conforme necessário.
            this.notas_saidaTableAdapter.Fill(this.bANCO.notas_saida);
            notas_saidaBindingSource.AddNew();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            notas_saidaBindingSource.EndEdit();
            notas_saidaTableAdapter.Update(bANCO);
            notas_saidaBindingSource.MoveLast();
            CAD_ITEM_NT_SAIDA cis = new CAD_ITEM_NT_SAIDA();
            cis.asdf = int.Parse(id_notaTextBox.Text);
            cis.fdsa = int.Parse(id_clienteTextBox.Text);
            cis.ShowDialog();
            notas_saidaTableAdapter.Fill(bANCO.notas_saida);
            notas_saidaBindingSource.MoveLast();

        }
    }
}
