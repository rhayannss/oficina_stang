namespace oficina_stang.CADASTRAR
{
    partial class CAD_ITEM_NT_SAIDA
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
            System.Windows.Forms.Label id_ordenLabel;
            System.Windows.Forms.Label data_entradaLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label observacoesLabel;
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label id_notaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAD_ITEM_NT_SAIDA));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bANCO = new oficina_stang.BANCO();
            this.itens_saidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itens_saidaTableAdapter = new oficina_stang.BANCOTableAdapters.itens_saidaTableAdapter();
            this.tableAdapterManager = new oficina_stang.BANCOTableAdapters.TableAdapterManager();
            this.clientesTableAdapter = new oficina_stang.BANCOTableAdapters.clientesTableAdapter();
            this.notas_saidaTableAdapter = new oficina_stang.BANCOTableAdapters.notas_saidaTableAdapter();
            this.ordem_servicoTableAdapter = new oficina_stang.BANCOTableAdapters.ordem_servicoTableAdapter();
            this.itens_saidaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.itens_saidaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.itens_saidaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKitenssaidanotassaidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notas_saidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.ordem_servicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.data_entradaTextBox = new System.Windows.Forms.TextBox();
            this.id_ordenComboBox = new System.Windows.Forms.ComboBox();
            this.ordem_servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            this.id_notaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            id_ordenLabel = new System.Windows.Forms.Label();
            data_entradaLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            observacoesLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            id_notaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_saidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_saidaBindingNavigator)).BeginInit();
            this.itens_saidaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itens_saidaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKitenssaidanotassaidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notas_saidaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordem_servicoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordem_servicoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_ordenLabel
            // 
            id_ordenLabel.AutoSize = true;
            id_ordenLabel.Location = new System.Drawing.Point(6, 16);
            id_ordenLabel.Name = "id_ordenLabel";
            id_ordenLabel.Size = new System.Drawing.Size(46, 13);
            id_ordenLabel.TabIndex = 0;
            id_ordenLabel.Text = "Nº O.S.:";
            // 
            // data_entradaLabel
            // 
            data_entradaLabel.AutoSize = true;
            data_entradaLabel.Location = new System.Drawing.Point(115, 16);
            data_entradaLabel.Name = "data_entradaLabel";
            data_entradaLabel.Size = new System.Drawing.Size(39, 13);
            data_entradaLabel.TabIndex = 2;
            data_entradaLabel.Text = "DATA:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(224, 16);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(46, 13);
            totalLabel.TabIndex = 4;
            totalLabel.Text = "VALOR:";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.Location = new System.Drawing.Point(6, 62);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(118, 13);
            observacoesLabel.TabIndex = 39;
            observacoesLabel.Text = "SERVICO REALIZADO";
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(195, 476);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(52, 13);
            id_clienteLabel.TabIndex = 0;
            id_clienteLabel.Text = "id cliente:";
            // 
            // id_notaLabel
            // 
            id_notaLabel.AutoSize = true;
            id_notaLabel.Location = new System.Drawing.Point(203, 509);
            id_notaLabel.Name = "id_notaLabel";
            id_notaLabel.Size = new System.Drawing.Size(42, 13);
            id_notaLabel.TabIndex = 2;
            id_notaLabel.Text = "id nota:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(166, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Sentinel Programações";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "CONCLUIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bANCO
            // 
            this.bANCO.DataSetName = "BANCO";
            this.bANCO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itens_saidaBindingSource
            // 
            this.itens_saidaBindingSource.DataMember = "itens_saida";
            this.itens_saidaBindingSource.DataSource = this.bANCO;
            // 
            // itens_saidaTableAdapter
            // 
            this.itens_saidaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.cidadesTableAdapter = null;
            this.tableAdapterManager.clientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.encarregadosTableAdapter = null;
            this.tableAdapterManager.estadosTableAdapter = null;
            this.tableAdapterManager.fazendasTableAdapter = null;
            this.tableAdapterManager.fornecedoresTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = null;
            this.tableAdapterManager.funcoesTableAdapter = null;
            this.tableAdapterManager.horas_servicosTableAdapter = null;
            this.tableAdapterManager.itens_orcamentoTableAdapter = null;
            this.tableAdapterManager.itens_ordemTableAdapter = null;
            this.tableAdapterManager.itens_saidaTableAdapter = this.itens_saidaTableAdapter;
            this.tableAdapterManager.itens_servicoTableAdapter = null;
            this.tableAdapterManager.medidasTableAdapter = null;
            this.tableAdapterManager.notas_saidaTableAdapter = this.notas_saidaTableAdapter;
            this.tableAdapterManager.orcamentoTableAdapter = null;
            this.tableAdapterManager.ordem_servicoTableAdapter = this.ordem_servicoTableAdapter;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.servicos_orcamentoTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.transportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = oficina_stang.BANCOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // notas_saidaTableAdapter
            // 
            this.notas_saidaTableAdapter.ClearBeforeFill = true;
            // 
            // ordem_servicoTableAdapter
            // 
            this.ordem_servicoTableAdapter.ClearBeforeFill = true;
            // 
            // itens_saidaBindingNavigator
            // 
            this.itens_saidaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.itens_saidaBindingNavigator.BindingSource = this.itens_saidaBindingSource;
            this.itens_saidaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itens_saidaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.itens_saidaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.itens_saidaBindingNavigatorSaveItem});
            this.itens_saidaBindingNavigator.Location = new System.Drawing.Point(154, 0);
            this.itens_saidaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itens_saidaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itens_saidaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itens_saidaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itens_saidaBindingNavigator.Name = "itens_saidaBindingNavigator";
            this.itens_saidaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itens_saidaBindingNavigator.Size = new System.Drawing.Size(641, 25);
            this.itens_saidaBindingNavigator.TabIndex = 38;
            this.itens_saidaBindingNavigator.Text = "bindingNavigator1";
            this.itens_saidaBindingNavigator.Visible = false;
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
            // itens_saidaBindingNavigatorSaveItem
            // 
            this.itens_saidaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itens_saidaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itens_saidaBindingNavigatorSaveItem.Image")));
            this.itens_saidaBindingNavigatorSaveItem.Name = "itens_saidaBindingNavigatorSaveItem";
            this.itens_saidaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.itens_saidaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.itens_saidaBindingNavigatorSaveItem.Click += new System.EventHandler(this.itens_saidaBindingNavigatorSaveItem_Click);
            // 
            // itens_saidaDataGridView
            // 
            this.itens_saidaDataGridView.AllowUserToAddRows = false;
            this.itens_saidaDataGridView.AllowUserToDeleteRows = false;
            this.itens_saidaDataGridView.AutoGenerateColumns = false;
            this.itens_saidaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itens_saidaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.itens_saidaDataGridView.DataSource = this.fKitenssaidanotassaidaBindingSource;
            this.itens_saidaDataGridView.Location = new System.Drawing.Point(206, 206);
            this.itens_saidaDataGridView.Name = "itens_saidaDataGridView";
            this.itens_saidaDataGridView.ReadOnly = true;
            this.itens_saidaDataGridView.Size = new System.Drawing.Size(251, 181);
            this.itens_saidaDataGridView.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_item";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_ordem";
            this.dataGridViewTextBoxColumn2.HeaderText = "NºO.S.";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_saida";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_saida";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn4.HeaderText = "VALOR";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // fKitenssaidanotassaidaBindingSource
            // 
            this.fKitenssaidanotassaidaBindingSource.DataMember = "FK_itens_saida_notas_saida";
            this.fKitenssaidanotassaidaBindingSource.DataSource = this.notas_saidaBindingSource;
            // 
            // notas_saidaBindingSource
            // 
            this.notas_saidaBindingSource.DataMember = "notas_saida";
            this.notas_saidaBindingSource.DataSource = this.bANCO;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.observacoesTextBox);
            this.groupBox1.Controls.Add(observacoesLabel);
            this.groupBox1.Controls.Add(totalLabel);
            this.groupBox1.Controls.Add(this.totalTextBox);
            this.groupBox1.Controls.Add(this.data_entradaTextBox);
            this.groupBox1.Controls.Add(data_entradaLabel);
            this.groupBox1.Controls.Add(id_ordenLabel);
            this.groupBox1.Controls.Add(this.id_ordenComboBox);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nome", true));
            this.groupBox1.Location = new System.Drawing.Point(160, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource1, "observacoes", true));
            this.observacoesTextBox.Location = new System.Drawing.Point(9, 78);
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.ReadOnly = true;
            this.observacoesTextBox.Size = new System.Drawing.Size(315, 20);
            this.observacoesTextBox.TabIndex = 40;
            // 
            // ordem_servicoBindingSource1
            // 
            this.ordem_servicoBindingSource1.DataMember = "FK_ordem_servico_clientes";
            this.ordem_servicoBindingSource1.DataSource = this.clientesBindingSource;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.bANCO;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource1, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(224, 33);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 5;
            // 
            // data_entradaTextBox
            // 
            this.data_entradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource1, "data_entrada", true));
            this.data_entradaTextBox.Location = new System.Drawing.Point(118, 33);
            this.data_entradaTextBox.Name = "data_entradaTextBox";
            this.data_entradaTextBox.ReadOnly = true;
            this.data_entradaTextBox.Size = new System.Drawing.Size(100, 20);
            this.data_entradaTextBox.TabIndex = 4;
            // 
            // id_ordenComboBox
            // 
            this.id_ordenComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.id_ordenComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_ordenComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource1, "id_orden", true));
            this.id_ordenComboBox.DataSource = this.ordem_servicoBindingSource1;
            this.id_ordenComboBox.DisplayMember = "id_orden";
            this.id_ordenComboBox.FormattingEnabled = true;
            this.id_ordenComboBox.Location = new System.Drawing.Point(9, 33);
            this.id_ordenComboBox.Name = "id_ordenComboBox";
            this.id_ordenComboBox.Size = new System.Drawing.Size(103, 21);
            this.id_ordenComboBox.TabIndex = 0;
            this.id_ordenComboBox.ValueMember = "id_orden";
            // 
            // ordem_servicoBindingSource
            // 
            this.ordem_servicoBindingSource.DataMember = "ordem_servico";
            this.ordem_servicoBindingSource.DataSource = this.bANCO;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.X1 = 282;
            this.lineShape1.X2 = 491;
            this.lineShape1.Y1 = 398;
            this.lineShape1.Y2 = 398;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(514, 466);
            this.shapeContainer1.TabIndex = 40;
            this.shapeContainer1.TabStop = false;
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "id_cliente", true));
            this.id_clienteTextBox.Location = new System.Drawing.Point(253, 473);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.id_clienteTextBox.ReadOnly = true;
            this.id_clienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_clienteTextBox.TabIndex = 1;
            this.id_clienteTextBox.TabStop = false;
            // 
            // id_notaTextBox
            // 
            this.id_notaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notas_saidaBindingSource, "id_nota", true));
            this.id_notaTextBox.Location = new System.Drawing.Point(251, 506);
            this.id_notaTextBox.Name = "id_notaTextBox";
            this.id_notaTextBox.ReadOnly = true;
            this.id_notaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_notaTextBox.TabIndex = 3;
            this.id_notaTextBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(228, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FERRAMENTAS";
            // 
            // button6
            // 
            this.button6.Image = global::oficina_stang.Properties.Resources.Add_icon;
            this.button6.Location = new System.Drawing.Point(70, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 54);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Image = global::oficina_stang.Properties.Resources.Delete_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(134, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 54);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::oficina_stang.Properties.Resources.Search_icon;
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 54);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(-500, -500);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 54);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::oficina_stang.Properties.Resources.hitech;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // CAD_ITEM_NT_SAIDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(514, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(id_notaLabel);
            this.Controls.Add(this.id_notaTextBox);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.itens_saidaDataGridView);
            this.Controls.Add(this.itens_saidaBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "CAD_ITEM_NT_SAIDA";
            this.Text = "CAD_ITEM_NT_SAIDA";
            this.Load += new System.EventHandler(this.CAD_ITEM_NT_SAIDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_saidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_saidaBindingNavigator)).EndInit();
            this.itens_saidaBindingNavigator.ResumeLayout(false);
            this.itens_saidaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itens_saidaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKitenssaidanotassaidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notas_saidaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordem_servicoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordem_servicoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private BANCO bANCO;
        private System.Windows.Forms.BindingSource itens_saidaBindingSource;
        private BANCOTableAdapters.itens_saidaTableAdapter itens_saidaTableAdapter;
        private BANCOTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator itens_saidaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton itens_saidaBindingNavigatorSaveItem;
        private BANCOTableAdapters.ordem_servicoTableAdapter ordem_servicoTableAdapter;
        private System.Windows.Forms.DataGridView itens_saidaDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource ordem_servicoBindingSource;
        private BANCOTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.ComboBox id_ordenComboBox;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.BindingSource ordem_servicoBindingSource1;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox data_entradaTextBox;
        private BANCOTableAdapters.notas_saidaTableAdapter notas_saidaTableAdapter;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox id_clienteTextBox;
        private System.Windows.Forms.BindingSource notas_saidaBindingSource;
        private System.Windows.Forms.TextBox id_notaTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource fKitenssaidanotassaidaBindingSource;
    }
}