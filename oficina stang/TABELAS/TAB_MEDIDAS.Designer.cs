﻿namespace oficina_stang.TABELAS
{
    partial class TAB_MEDIDAS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TAB_MEDIDAS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bANCO = new oficina_stang.BANCO();
            this.medidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medidasTableAdapter = new oficina_stang.BANCOTableAdapters.medidasTableAdapter();
            this.tableAdapterManager = new oficina_stang.BANCOTableAdapters.TableAdapterManager();
            this.funcoesTableAdapter = new oficina_stang.BANCOTableAdapters.funcoesTableAdapter();
            this.medidasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.medidasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.medidasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.funcoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_medidaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidasBindingNavigator)).BeginInit();
            this.medidasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medidasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Location = new System.Drawing.Point(160, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 82);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FERRAMENTAS";
            // 
            // button10
            // 
            this.button10.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button10.Image = global::oficina_stang.Properties.Resources.Edit_icon;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button10.Location = new System.Drawing.Point(144, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(58, 54);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button6
            // 
            this.button6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button6.Image = global::oficina_stang.Properties.Resources.Delete_icon;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.Location = new System.Drawing.Point(80, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 54);
            this.button6.TabIndex = 8;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Image = global::oficina_stang.Properties.Resources.Folder_add_icon;
            this.button8.Location = new System.Drawing.Point(16, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(58, 54);
            this.button8.TabIndex = 5;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(-500, -500);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 54);
            this.button9.TabIndex = 6;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(160, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 82);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PESQUISAR";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bANCO
            // 
            this.bANCO.DataSetName = "BANCO";
            this.bANCO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medidasBindingSource
            // 
            this.medidasBindingSource.DataMember = "medidas";
            this.medidasBindingSource.DataSource = this.bANCO;
            // 
            // medidasTableAdapter
            // 
            this.medidasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.cidadesTableAdapter = null;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.encarregadosTableAdapter = null;
            this.tableAdapterManager.estadosTableAdapter = null;
            this.tableAdapterManager.fazendasTableAdapter = null;
            this.tableAdapterManager.fornecedoresTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = null;
            this.tableAdapterManager.funcoesTableAdapter = this.funcoesTableAdapter;
            this.tableAdapterManager.horas_servicosTableAdapter = null;
            this.tableAdapterManager.itens_orcamentoTableAdapter = null;
            this.tableAdapterManager.itens_ordemTableAdapter = null;
            this.tableAdapterManager.itens_servicoTableAdapter = null;
            this.tableAdapterManager.medidasTableAdapter = this.medidasTableAdapter;
            this.tableAdapterManager.orcamentoTableAdapter = null;
            this.tableAdapterManager.ordem_servicoTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.servicos_orcamentoTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.transportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = oficina_stang.BANCOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // funcoesTableAdapter
            // 
            this.funcoesTableAdapter.ClearBeforeFill = true;
            // 
            // medidasBindingNavigator
            // 
            this.medidasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medidasBindingNavigator.BindingSource = this.medidasBindingSource;
            this.medidasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medidasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medidasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.medidasBindingNavigatorSaveItem});
            this.medidasBindingNavigator.Location = new System.Drawing.Point(154, 0);
            this.medidasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medidasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medidasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medidasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medidasBindingNavigator.Name = "medidasBindingNavigator";
            this.medidasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medidasBindingNavigator.Size = new System.Drawing.Size(334, 25);
            this.medidasBindingNavigator.TabIndex = 46;
            this.medidasBindingNavigator.Text = "bindingNavigator1";
            this.medidasBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // medidasBindingNavigatorSaveItem
            // 
            this.medidasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medidasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medidasBindingNavigatorSaveItem.Image")));
            this.medidasBindingNavigatorSaveItem.Name = "medidasBindingNavigatorSaveItem";
            this.medidasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.medidasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.medidasBindingNavigatorSaveItem.Click += new System.EventHandler(this.medidasBindingNavigatorSaveItem_Click);
            // 
            // medidasDataGridView
            // 
            this.medidasDataGridView.AllowUserToAddRows = false;
            this.medidasDataGridView.AllowUserToDeleteRows = false;
            this.medidasDataGridView.AutoGenerateColumns = false;
            this.medidasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medidasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.medidasDataGridView.DataSource = this.medidasBindingSource;
            this.medidasDataGridView.Location = new System.Drawing.Point(160, 188);
            this.medidasDataGridView.Name = "medidasDataGridView";
            this.medidasDataGridView.ReadOnly = true;
            this.medidasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medidasDataGridView.Size = new System.Drawing.Size(220, 160);
            this.medidasDataGridView.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_medida";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_medida";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "unidade";
            this.dataGridViewTextBoxColumn2.HeaderText = "UNIDADE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 135;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sigla";
            this.dataGridViewTextBoxColumn3.HeaderText = "UN.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::oficina_stang.Properties.Resources.hitech;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // funcoesBindingSource
            // 
            this.funcoesBindingSource.DataMember = "funcoes";
            this.funcoesBindingSource.DataSource = this.bANCO;
            // 
            // id_medidaTextBox
            // 
            this.id_medidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidasBindingSource, "id_medida", true));
            this.id_medidaTextBox.Location = new System.Drawing.Point(-244, -204);
            this.id_medidaTextBox.Name = "id_medidaTextBox";
            this.id_medidaTextBox.ReadOnly = true;
            this.id_medidaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_medidaTextBox.TabIndex = 47;
            this.id_medidaTextBox.TabStop = false;
            // 
            // TAB_MEDIDAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 356);
            this.Controls.Add(this.id_medidaTextBox);
            this.Controls.Add(this.medidasDataGridView);
            this.Controls.Add(this.medidasBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TAB_MEDIDAS";
            this.Text = "TABELA DE MEDIDAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TAB_MEDIDAS_FormClosing);
            this.Load += new System.EventHandler(this.TAB_MEDIDAS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidasBindingNavigator)).EndInit();
            this.medidasBindingNavigator.ResumeLayout(false);
            this.medidasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medidasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcoesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BANCO bANCO;
        private System.Windows.Forms.BindingSource medidasBindingSource;
        private BANCOTableAdapters.medidasTableAdapter medidasTableAdapter;
        private BANCOTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medidasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton medidasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView medidasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BANCOTableAdapters.funcoesTableAdapter funcoesTableAdapter;
        private System.Windows.Forms.BindingSource funcoesBindingSource;
        private System.Windows.Forms.TextBox id_medidaTextBox;

    }
}