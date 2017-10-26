namespace oficina_stang.TABELAS
{
    partial class TAB_ORDEN
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
            System.Windows.Forms.Label sub_totalLabel;
            System.Windows.Forms.Label subtotal_servicoLabel;
            System.Windows.Forms.Label subtotal2Label;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TAB_ORDEN));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.itens_ordemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANCO = new oficina_stang.BANCO();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKitensordemordemservicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordem_servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.totalLabel1 = new System.Windows.Forms.Label();
            this.descontoLabel1 = new System.Windows.Forms.Label();
            this.subtotal2Label1 = new System.Windows.Forms.Label();
            this.subtotal_servicoLabel1 = new System.Windows.Forms.Label();
            this.sub_totalLabel1 = new System.Windows.Forms.Label();
            this.itens_ordemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itens_ordemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ordem_servicoDataGridView = new System.Windows.Forms.DataGridView();
            this.idordenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idfuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfazendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fazendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solicitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalservicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idordenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclienteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idfuncionarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfazendaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idencarregadoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentradaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasaidaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalservicoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopagamentoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.view_ordemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.view_ordemTableAdapter = new oficina_stang.BANCOTableAdapters.View_ordemTableAdapter();
            this.tableAdapterManager = new oficina_stang.BANCOTableAdapters.TableAdapterManager();
            this.itens_ordemTableAdapter = new oficina_stang.BANCOTableAdapters.itens_ordemTableAdapter();
            this.produtosTableAdapter = new oficina_stang.BANCOTableAdapters.produtosTableAdapter();
            this.view_ordemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.view_ordemBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ordem_servicoTableAdapter = new oficina_stang.BANCOTableAdapters.ordem_servicoTableAdapter();
            this.clientesTableAdapter = new oficina_stang.BANCOTableAdapters.clientesTableAdapter();
            this.fazendasTableAdapter = new oficina_stang.BANCOTableAdapters.fazendasTableAdapter();
            this.id_ordenTextBox = new System.Windows.Forms.TextBox();
            sub_totalLabel = new System.Windows.Forms.Label();
            subtotal_servicoLabel = new System.Windows.Forms.Label();
            subtotal2Label = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itens_ordemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKitensordemordemservicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordem_servicoBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itens_ordemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_ordemBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordem_servicoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendasBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_ordemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ordemBindingNavigator)).BeginInit();
            this.view_ordemBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // sub_totalLabel
            // 
            sub_totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            sub_totalLabel.AutoSize = true;
            sub_totalLabel.Location = new System.Drawing.Point(36, 16);
            sub_totalLabel.Name = "sub_totalLabel";
            sub_totalLabel.Size = new System.Drawing.Size(45, 13);
            sub_totalLabel.TabIndex = 0;
            sub_totalLabel.Text = "PEÇAS:";
            // 
            // subtotal_servicoLabel
            // 
            subtotal_servicoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            subtotal_servicoLabel.AutoSize = true;
            subtotal_servicoLabel.Location = new System.Drawing.Point(17, 37);
            subtotal_servicoLabel.Name = "subtotal_servicoLabel";
            subtotal_servicoLabel.Size = new System.Drawing.Size(64, 13);
            subtotal_servicoLabel.TabIndex = 2;
            subtotal_servicoLabel.Text = "SERVIÇOS:";
            // 
            // subtotal2Label
            // 
            subtotal2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            subtotal2Label.AutoSize = true;
            subtotal2Label.Location = new System.Drawing.Point(174, 19);
            subtotal2Label.Name = "subtotal2Label";
            subtotal2Label.Size = new System.Drawing.Size(67, 13);
            subtotal2Label.TabIndex = 4;
            subtotal2Label.Text = "SUBTOTAL:";
            // 
            // descontoLabel
            // 
            descontoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(171, 40);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(70, 13);
            descontoLabel.TabIndex = 6;
            descontoLabel.Text = "DESCONTO:";
            // 
            // totalLabel
            // 
            totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(196, 60);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(45, 13);
            totalLabel.TabIndex = 8;
            totalLabel.Text = "TOTAL:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.itens_ordemDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(603, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 321);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ITENS O.S.";
            // 
            // itens_ordemDataGridView
            // 
            this.itens_ordemDataGridView.AllowUserToAddRows = false;
            this.itens_ordemDataGridView.AllowUserToDeleteRows = false;
            this.itens_ordemDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.itens_ordemDataGridView.AutoGenerateColumns = false;
            this.itens_ordemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itens_ordemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.itens_ordemDataGridView.DataSource = this.fKitensordemordemservicoBindingSource;
            this.itens_ordemDataGridView.Location = new System.Drawing.Point(6, 19);
            this.itens_ordemDataGridView.Name = "itens_ordemDataGridView";
            this.itens_ordemDataGridView.ReadOnly = true;
            this.itens_ordemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itens_ordemDataGridView.Size = new System.Drawing.Size(417, 296);
            this.itens_ordemDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "id_ordem";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_funcionario";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_funcionario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_produto";
            this.dataGridViewTextBoxColumn4.DataSource = this.produtosBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "descricao";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "PRODUTO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "id_produto";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.bANCO;
            // 
            // bANCO
            // 
            this.bANCO.DataSetName = "BANCO";
            this.bANCO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "quant";
            this.dataGridViewTextBoxColumn7.HeaderText = "QTD.";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "unidade";
            this.dataGridViewTextBoxColumn5.HeaderText = "UN.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "valor_unit";
            this.dataGridViewTextBoxColumn6.HeaderText = "VALOR UN.";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 73;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "valor_tot";
            this.dataGridViewTextBoxColumn8.HeaderText = "TOTAL";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 73;
            // 
            // fKitensordemordemservicoBindingSource
            // 
            this.fKitensordemordemservicoBindingSource.DataMember = "FK_itens_ordem_ordem_servico";
            this.fKitensordemordemservicoBindingSource.DataSource = this.ordem_servicoBindingSource;
            // 
            // ordem_servicoBindingSource
            // 
            this.ordem_servicoBindingSource.DataMember = "ordem_servico";
            this.ordem_servicoBindingSource.DataSource = this.bANCO;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(totalLabel);
            this.groupBox4.Controls.Add(this.totalLabel1);
            this.groupBox4.Controls.Add(descontoLabel);
            this.groupBox4.Controls.Add(this.descontoLabel1);
            this.groupBox4.Controls.Add(subtotal2Label);
            this.groupBox4.Controls.Add(this.subtotal2Label1);
            this.groupBox4.Controls.Add(subtotal_servicoLabel);
            this.groupBox4.Controls.Add(this.subtotal_servicoLabel1);
            this.groupBox4.Controls.Add(sub_totalLabel);
            this.groupBox4.Controls.Add(this.sub_totalLabel1);
            this.groupBox4.Location = new System.Drawing.Point(718, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 82);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "VALORES";
            // 
            // totalLabel1
            // 
            this.totalLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "total", true));
            this.totalLabel1.Location = new System.Drawing.Point(247, 60);
            this.totalLabel1.Name = "totalLabel1";
            this.totalLabel1.Size = new System.Drawing.Size(64, 17);
            this.totalLabel1.TabIndex = 9;
            this.totalLabel1.Text = "000000,00";
            // 
            // descontoLabel1
            // 
            this.descontoLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descontoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "desconto", true));
            this.descontoLabel1.Location = new System.Drawing.Point(247, 40);
            this.descontoLabel1.Name = "descontoLabel1";
            this.descontoLabel1.Size = new System.Drawing.Size(64, 13);
            this.descontoLabel1.TabIndex = 7;
            this.descontoLabel1.Text = "000000,00";
            // 
            // subtotal2Label1
            // 
            this.subtotal2Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subtotal2Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "subtotal2", true));
            this.subtotal2Label1.Location = new System.Drawing.Point(247, 19);
            this.subtotal2Label1.Name = "subtotal2Label1";
            this.subtotal2Label1.Size = new System.Drawing.Size(61, 13);
            this.subtotal2Label1.TabIndex = 5;
            this.subtotal2Label1.Text = "000000,00";
            // 
            // subtotal_servicoLabel1
            // 
            this.subtotal_servicoLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subtotal_servicoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "subtotal_servico", true));
            this.subtotal_servicoLabel1.Location = new System.Drawing.Point(87, 37);
            this.subtotal_servicoLabel1.Name = "subtotal_servicoLabel1";
            this.subtotal_servicoLabel1.Size = new System.Drawing.Size(59, 13);
            this.subtotal_servicoLabel1.TabIndex = 3;
            this.subtotal_servicoLabel1.Text = "000000,00";
            // 
            // sub_totalLabel1
            // 
            this.sub_totalLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sub_totalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "sub_total", true));
            this.sub_totalLabel1.Location = new System.Drawing.Point(87, 16);
            this.sub_totalLabel1.Name = "sub_totalLabel1";
            this.sub_totalLabel1.Size = new System.Drawing.Size(59, 13);
            this.sub_totalLabel1.TabIndex = 1;
            this.sub_totalLabel1.Text = "000000,00";
            // 
            // itens_ordemBindingSource1
            // 
            this.itens_ordemBindingSource1.DataSource = this.fKitensordemordemservicoBindingSource;
            // 
            // itens_ordemBindingSource
            // 
            this.itens_ordemBindingSource.DataMember = "itens_ordem";
            this.itens_ordemBindingSource.DataSource = this.bANCO;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ordem_servicoDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(164, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 321);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "O.S.";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ordem_servicoDataGridView
            // 
            this.ordem_servicoDataGridView.AllowUserToAddRows = false;
            this.ordem_servicoDataGridView.AllowUserToDeleteRows = false;
            this.ordem_servicoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ordem_servicoDataGridView.AutoGenerateColumns = false;
            this.ordem_servicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordem_servicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idordenDataGridViewTextBoxColumn,
            this.idclienteDataGridViewTextBoxColumn,
            this.idfuncionarioDataGridViewTextBoxColumn,
            this.idfazendaDataGridViewTextBoxColumn,
            this.solicitanteDataGridViewTextBoxColumn,
            this.dataentradaDataGridViewTextBoxColumn,
            this.datasaidaDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn,
            this.tipopagamentoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.subtotalservicoDataGridViewTextBoxColumn,
            this.subtotal2DataGridViewTextBoxColumn,
            this.horasDataGridViewTextBoxColumn});
            this.ordem_servicoDataGridView.DataSource = this.ordem_servicoBindingSource;
            this.ordem_servicoDataGridView.Location = new System.Drawing.Point(6, 19);
            this.ordem_servicoDataGridView.Name = "ordem_servicoDataGridView";
            this.ordem_servicoDataGridView.ReadOnly = true;
            this.ordem_servicoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordem_servicoDataGridView.Size = new System.Drawing.Size(419, 296);
            this.ordem_servicoDataGridView.TabIndex = 35;
            // 
            // idordenDataGridViewTextBoxColumn
            // 
            this.idordenDataGridViewTextBoxColumn.DataPropertyName = "id_orden";
            this.idordenDataGridViewTextBoxColumn.HeaderText = "O.S.";
            this.idordenDataGridViewTextBoxColumn.Name = "idordenDataGridViewTextBoxColumn";
            this.idordenDataGridViewTextBoxColumn.ReadOnly = true;
            this.idordenDataGridViewTextBoxColumn.Width = 50;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.DataSource = this.clientesBindingSource;
            this.idclienteDataGridViewTextBoxColumn.DisplayMember = "nome";
            this.idclienteDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "CLIENTE";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclienteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idclienteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idclienteDataGridViewTextBoxColumn.ValueMember = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.bANCO;
            // 
            // idfuncionarioDataGridViewTextBoxColumn
            // 
            this.idfuncionarioDataGridViewTextBoxColumn.DataPropertyName = "id_funcionario";
            this.idfuncionarioDataGridViewTextBoxColumn.HeaderText = "id_funcionario";
            this.idfuncionarioDataGridViewTextBoxColumn.Name = "idfuncionarioDataGridViewTextBoxColumn";
            this.idfuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfuncionarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // idfazendaDataGridViewTextBoxColumn
            // 
            this.idfazendaDataGridViewTextBoxColumn.DataPropertyName = "id_fazenda";
            this.idfazendaDataGridViewTextBoxColumn.DataSource = this.fazendasBindingSource;
            this.idfazendaDataGridViewTextBoxColumn.DisplayMember = "nome";
            this.idfazendaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idfazendaDataGridViewTextBoxColumn.HeaderText = "FAZENDA";
            this.idfazendaDataGridViewTextBoxColumn.Name = "idfazendaDataGridViewTextBoxColumn";
            this.idfazendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfazendaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idfazendaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idfazendaDataGridViewTextBoxColumn.ValueMember = "id_fazenda";
            this.idfazendaDataGridViewTextBoxColumn.Width = 150;
            // 
            // fazendasBindingSource
            // 
            this.fazendasBindingSource.DataMember = "fazendas";
            this.fazendasBindingSource.DataSource = this.bANCO;
            // 
            // solicitanteDataGridViewTextBoxColumn
            // 
            this.solicitanteDataGridViewTextBoxColumn.DataPropertyName = "solicitante";
            this.solicitanteDataGridViewTextBoxColumn.HeaderText = "RESPONSAVEL";
            this.solicitanteDataGridViewTextBoxColumn.Name = "solicitanteDataGridViewTextBoxColumn";
            this.solicitanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.solicitanteDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataentradaDataGridViewTextBoxColumn
            // 
            this.dataentradaDataGridViewTextBoxColumn.DataPropertyName = "data_entrada";
            this.dataentradaDataGridViewTextBoxColumn.HeaderText = "DATA";
            this.dataentradaDataGridViewTextBoxColumn.Name = "dataentradaDataGridViewTextBoxColumn";
            this.dataentradaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataentradaDataGridViewTextBoxColumn.Width = 75;
            // 
            // datasaidaDataGridViewTextBoxColumn
            // 
            this.datasaidaDataGridViewTextBoxColumn.DataPropertyName = "data_saida";
            this.datasaidaDataGridViewTextBoxColumn.HeaderText = "data_saida";
            this.datasaidaDataGridViewTextBoxColumn.Name = "datasaidaDataGridViewTextBoxColumn";
            this.datasaidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datasaidaDataGridViewTextBoxColumn.Visible = false;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "sub_total";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "SUBTOTAL";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            this.subtotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.subtotalDataGridViewTextBoxColumn.Width = 75;
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "desconto";
            this.descontoDataGridViewTextBoxColumn.HeaderText = "DESCONTO";
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            this.descontoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descontoDataGridViewTextBoxColumn.Width = 75;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "TOTAL";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 75;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "observacoes";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            this.observacoesDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacoesDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipopagamentoDataGridViewTextBoxColumn
            // 
            this.tipopagamentoDataGridViewTextBoxColumn.DataPropertyName = "tipo_pagamento";
            this.tipopagamentoDataGridViewTextBoxColumn.HeaderText = "tipo_pagamento";
            this.tipopagamentoDataGridViewTextBoxColumn.Name = "tipopagamentoDataGridViewTextBoxColumn";
            this.tipopagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipopagamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // subtotalservicoDataGridViewTextBoxColumn
            // 
            this.subtotalservicoDataGridViewTextBoxColumn.DataPropertyName = "subtotal_servico";
            this.subtotalservicoDataGridViewTextBoxColumn.HeaderText = "subtotal_servico";
            this.subtotalservicoDataGridViewTextBoxColumn.Name = "subtotalservicoDataGridViewTextBoxColumn";
            this.subtotalservicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.subtotalservicoDataGridViewTextBoxColumn.Visible = false;
            // 
            // subtotal2DataGridViewTextBoxColumn
            // 
            this.subtotal2DataGridViewTextBoxColumn.DataPropertyName = "subtotal2";
            this.subtotal2DataGridViewTextBoxColumn.HeaderText = "subtotal2";
            this.subtotal2DataGridViewTextBoxColumn.Name = "subtotal2DataGridViewTextBoxColumn";
            this.subtotal2DataGridViewTextBoxColumn.ReadOnly = true;
            this.subtotal2DataGridViewTextBoxColumn.Visible = false;
            // 
            // horasDataGridViewTextBoxColumn
            // 
            this.horasDataGridViewTextBoxColumn.DataPropertyName = "horas";
            this.horasDataGridViewTextBoxColumn.HeaderText = "horas";
            this.horasDataGridViewTextBoxColumn.Name = "horasDataGridViewTextBoxColumn";
            this.horasDataGridViewTextBoxColumn.ReadOnly = true;
            this.horasDataGridViewTextBoxColumn.Visible = false;
            // 
            // idordenDataGridViewTextBoxColumn1
            // 
            this.idordenDataGridViewTextBoxColumn1.DataPropertyName = "id_orden";
            this.idordenDataGridViewTextBoxColumn1.HeaderText = "O.S.";
            this.idordenDataGridViewTextBoxColumn1.Name = "idordenDataGridViewTextBoxColumn1";
            this.idordenDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idordenDataGridViewTextBoxColumn1.Width = 50;
            // 
            // idclienteDataGridViewTextBoxColumn1
            // 
            this.idclienteDataGridViewTextBoxColumn1.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn1.DataSource = this.clientesBindingSource;
            this.idclienteDataGridViewTextBoxColumn1.DisplayMember = "nome";
            this.idclienteDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idclienteDataGridViewTextBoxColumn1.HeaderText = "CLIENTE";
            this.idclienteDataGridViewTextBoxColumn1.Name = "idclienteDataGridViewTextBoxColumn1";
            this.idclienteDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idclienteDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idclienteDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idclienteDataGridViewTextBoxColumn1.ValueMember = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idfuncionarioDataGridViewTextBoxColumn1
            // 
            this.idfuncionarioDataGridViewTextBoxColumn1.DataPropertyName = "id_funcionario";
            this.idfuncionarioDataGridViewTextBoxColumn1.HeaderText = "FUNCIO";
            this.idfuncionarioDataGridViewTextBoxColumn1.Name = "idfuncionarioDataGridViewTextBoxColumn1";
            this.idfuncionarioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idfuncionarioDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idfazendaDataGridViewTextBoxColumn1
            // 
            this.idfazendaDataGridViewTextBoxColumn1.DataPropertyName = "id_fazenda";
            this.idfazendaDataGridViewTextBoxColumn1.DataSource = this.fazendasBindingSource;
            this.idfazendaDataGridViewTextBoxColumn1.DisplayMember = "nome";
            this.idfazendaDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idfazendaDataGridViewTextBoxColumn1.HeaderText = "FAZENDA";
            this.idfazendaDataGridViewTextBoxColumn1.Name = "idfazendaDataGridViewTextBoxColumn1";
            this.idfazendaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idfazendaDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idfazendaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idfazendaDataGridViewTextBoxColumn1.ValueMember = "id_fazenda";
            this.idfazendaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idencarregadoDataGridViewTextBoxColumn1
            // 
            this.idencarregadoDataGridViewTextBoxColumn1.DataPropertyName = "id_encarregado";
            this.idencarregadoDataGridViewTextBoxColumn1.HeaderText = "ENCARREGADO";
            this.idencarregadoDataGridViewTextBoxColumn1.Name = "idencarregadoDataGridViewTextBoxColumn1";
            this.idencarregadoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idencarregadoDataGridViewTextBoxColumn1.Visible = false;
            this.idencarregadoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataentradaDataGridViewTextBoxColumn1
            // 
            this.dataentradaDataGridViewTextBoxColumn1.DataPropertyName = "data_entrada";
            this.dataentradaDataGridViewTextBoxColumn1.HeaderText = "ENTRADA";
            this.dataentradaDataGridViewTextBoxColumn1.Name = "dataentradaDataGridViewTextBoxColumn1";
            this.dataentradaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataentradaDataGridViewTextBoxColumn1.Width = 75;
            // 
            // datasaidaDataGridViewTextBoxColumn1
            // 
            this.datasaidaDataGridViewTextBoxColumn1.DataPropertyName = "data_saida";
            this.datasaidaDataGridViewTextBoxColumn1.HeaderText = "data_saida";
            this.datasaidaDataGridViewTextBoxColumn1.Name = "datasaidaDataGridViewTextBoxColumn1";
            this.datasaidaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.datasaidaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // subtotalDataGridViewTextBoxColumn1
            // 
            this.subtotalDataGridViewTextBoxColumn1.DataPropertyName = "sub_total";
            this.subtotalDataGridViewTextBoxColumn1.HeaderText = "PEÇAS";
            this.subtotalDataGridViewTextBoxColumn1.Name = "subtotalDataGridViewTextBoxColumn1";
            this.subtotalDataGridViewTextBoxColumn1.ReadOnly = true;
            this.subtotalDataGridViewTextBoxColumn1.Width = 75;
            // 
            // subtotalservicoDataGridViewTextBoxColumn1
            // 
            this.subtotalservicoDataGridViewTextBoxColumn1.DataPropertyName = "subtotal_servico";
            this.subtotalservicoDataGridViewTextBoxColumn1.HeaderText = "SERVIÇOS";
            this.subtotalservicoDataGridViewTextBoxColumn1.Name = "subtotalservicoDataGridViewTextBoxColumn1";
            this.subtotalservicoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.subtotalservicoDataGridViewTextBoxColumn1.Width = 75;
            // 
            // subtotal2DataGridViewTextBoxColumn1
            // 
            this.subtotal2DataGridViewTextBoxColumn1.DataPropertyName = "subtotal2";
            this.subtotal2DataGridViewTextBoxColumn1.HeaderText = "SUBTOTAL";
            this.subtotal2DataGridViewTextBoxColumn1.Name = "subtotal2DataGridViewTextBoxColumn1";
            this.subtotal2DataGridViewTextBoxColumn1.ReadOnly = true;
            this.subtotal2DataGridViewTextBoxColumn1.Width = 75;
            // 
            // descontoDataGridViewTextBoxColumn1
            // 
            this.descontoDataGridViewTextBoxColumn1.DataPropertyName = "desconto";
            this.descontoDataGridViewTextBoxColumn1.HeaderText = "DESCONTO";
            this.descontoDataGridViewTextBoxColumn1.Name = "descontoDataGridViewTextBoxColumn1";
            this.descontoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descontoDataGridViewTextBoxColumn1.Width = 75;
            // 
            // totalDataGridViewTextBoxColumn1
            // 
            this.totalDataGridViewTextBoxColumn1.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn1.HeaderText = "TOTAL";
            this.totalDataGridViewTextBoxColumn1.Name = "totalDataGridViewTextBoxColumn1";
            this.totalDataGridViewTextBoxColumn1.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn1.Width = 75;
            // 
            // observacoesDataGridViewTextBoxColumn1
            // 
            this.observacoesDataGridViewTextBoxColumn1.DataPropertyName = "observacoes";
            this.observacoesDataGridViewTextBoxColumn1.HeaderText = "observacoes";
            this.observacoesDataGridViewTextBoxColumn1.Name = "observacoesDataGridViewTextBoxColumn1";
            this.observacoesDataGridViewTextBoxColumn1.ReadOnly = true;
            this.observacoesDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tipopagamentoDataGridViewTextBoxColumn1
            // 
            this.tipopagamentoDataGridViewTextBoxColumn1.DataPropertyName = "tipo_pagamento";
            this.tipopagamentoDataGridViewTextBoxColumn1.HeaderText = "tipo_pagamento";
            this.tipopagamentoDataGridViewTextBoxColumn1.Name = "tipopagamentoDataGridViewTextBoxColumn1";
            this.tipopagamentoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tipopagamentoDataGridViewTextBoxColumn1.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn1.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton4);
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.maskedTextBox1);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Location = new System.Drawing.Point(164, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(279, 82);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PESQUISAR";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(157, 24);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(57, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "SAIDA";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(74, 24);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ENTRADA";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(173, 53);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.Leave += new System.EventHandler(this.maskedTextBox1_Leave);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "N° O.S.";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(449, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 82);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FERRAMENTAS";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Image = global::oficina_stang.Properties.Resources._141113143918_48;
            this.button2.Location = new System.Drawing.Point(198, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 54);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Image = global::oficina_stang.Properties.Resources.Delete_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(134, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 54);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Image = global::oficina_stang.Properties.Resources.Accept_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(70, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 54);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = global::oficina_stang.Properties.Resources.Folder_add_icon;
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 54);
            this.button4.TabIndex = 5;
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
            // 
            // view_ordemBindingSource
            // 
            this.view_ordemBindingSource.DataMember = "View_ordem";
            this.view_ordemBindingSource.DataSource = this.bANCO;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::oficina_stang.Properties.Resources.hitech;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // view_ordemTableAdapter
            // 
            this.view_ordemTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.funcoesTableAdapter = null;
            this.tableAdapterManager.horas_servicosTableAdapter = null;
            this.tableAdapterManager.itens_orcamentoTableAdapter = null;
            this.tableAdapterManager.itens_ordemTableAdapter = this.itens_ordemTableAdapter;
            this.tableAdapterManager.itens_servicoTableAdapter = null;
            this.tableAdapterManager.medidasTableAdapter = null;
            this.tableAdapterManager.orcamentoTableAdapter = null;
            this.tableAdapterManager.ordem_servicoTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.servicos_orcamentoTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.transportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = oficina_stang.BANCOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itens_ordemTableAdapter
            // 
            this.itens_ordemTableAdapter.ClearBeforeFill = true;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // view_ordemBindingNavigator
            // 
            this.view_ordemBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.view_ordemBindingNavigator.BindingSource = this.view_ordemBindingSource;
            this.view_ordemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.view_ordemBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.view_ordemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.view_ordemBindingNavigatorSaveItem});
            this.view_ordemBindingNavigator.Location = new System.Drawing.Point(154, 0);
            this.view_ordemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.view_ordemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.view_ordemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.view_ordemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.view_ordemBindingNavigator.Name = "view_ordemBindingNavigator";
            this.view_ordemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.view_ordemBindingNavigator.Size = new System.Drawing.Size(884, 25);
            this.view_ordemBindingNavigator.TabIndex = 40;
            this.view_ordemBindingNavigator.Text = "bindingNavigator1";
            this.view_ordemBindingNavigator.Visible = false;
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
            // view_ordemBindingNavigatorSaveItem
            // 
            this.view_ordemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.view_ordemBindingNavigatorSaveItem.Enabled = false;
            this.view_ordemBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("view_ordemBindingNavigatorSaveItem.Image")));
            this.view_ordemBindingNavigatorSaveItem.Name = "view_ordemBindingNavigatorSaveItem";
            this.view_ordemBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.view_ordemBindingNavigatorSaveItem.Text = "Salvar Dados";
            // 
            // ordem_servicoTableAdapter
            // 
            this.ordem_servicoTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // fazendasTableAdapter
            // 
            this.fazendasTableAdapter.ClearBeforeFill = true;
            // 
            // id_ordenTextBox
            // 
            this.id_ordenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "id_orden", true));
            this.id_ordenTextBox.Location = new System.Drawing.Point(-289, -200);
            this.id_ordenTextBox.Name = "id_ordenTextBox";
            this.id_ordenTextBox.ReadOnly = true;
            this.id_ordenTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_ordenTextBox.TabIndex = 41;
            this.id_ordenTextBox.TabStop = false;
            // 
            // TAB_ORDEN
            // 
            this.AcceptButton = this.button3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1038, 433);
            this.Controls.Add(this.id_ordenTextBox);
            this.Controls.Add(this.view_ordemBindingNavigator);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(1054, 471);
            this.MinimumSize = new System.Drawing.Size(1054, 471);
            this.Name = "TAB_ORDEN";
            this.Text = "TABELA DE O.S.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TAB_ORDEN_FormClosing);
            this.Load += new System.EventHandler(this.TAB_ORDEN_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itens_ordemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKitensordemordemservicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordem_servicoBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itens_ordemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_ordemBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordem_servicoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendasBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_ordemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ordemBindingNavigator)).EndInit();
            this.view_ordemBindingNavigator.ResumeLayout(false);
            this.view_ordemBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource view_ordemBindingSource;
        private BANCOTableAdapters.View_ordemTableAdapter view_ordemTableAdapter;
        private BANCOTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator view_ordemBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton view_ordemBindingNavigatorSaveItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private BANCOTableAdapters.itens_ordemTableAdapter itens_ordemTableAdapter;
        private System.Windows.Forms.BindingSource itens_ordemBindingSource;
        private BANCOTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public BANCO bANCO;
        private System.Windows.Forms.BindingSource ordem_servicoBindingSource;
        private BANCOTableAdapters.ordem_servicoTableAdapter ordem_servicoTableAdapter;
        private System.Windows.Forms.BindingSource itens_ordemBindingSource1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private BANCOTableAdapters.clientesTableAdapter clientesTableAdapter;
        public System.Windows.Forms.DataGridView ordem_servicoDataGridView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label totalLabel1;
        private System.Windows.Forms.Label descontoLabel1;
        private System.Windows.Forms.Label subtotal2Label1;
        private System.Windows.Forms.Label subtotal_servicoLabel1;
        private System.Windows.Forms.Label sub_totalLabel1;
        private System.Windows.Forms.BindingSource fazendasBindingSource;
        private BANCOTableAdapters.fazendasTableAdapter fazendasTableAdapter;
        private System.Windows.Forms.DataGridView itens_ordemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource fKitensordemordemservicoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idordenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn idclienteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfuncionarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn idfazendaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idencarregadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentradaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasaidaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalservicoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopagamentoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox id_ordenTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idordenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idfazendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalservicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}