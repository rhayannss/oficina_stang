namespace oficina_stang.CADASTRAR
{
    partial class CAD_ORDEM
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
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label id_fazendaLabel;
            System.Windows.Forms.Label id_encarregadoLabel;
            System.Windows.Forms.Label id_funcionarioLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label data_saidaLabel;
            System.Windows.Forms.Label data_entradaLabel;
            System.Windows.Forms.Label id_ordenLabel;
            System.Windows.Forms.Label subtotal_servicoLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label sub_totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAD_ORDEM));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.id_ordenTextBox = new System.Windows.Forms.TextBox();
            this.ordem_servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANCO = new oficina_stang.BANCO();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.solicitanteTextBox = new System.Windows.Forms.TextBox();
            this.id_ordenTextBox1 = new System.Windows.Forms.TextBox();
            this.data_saidaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.data_entradaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.id_funcionarioComboBox = new System.Windows.Forms.ComboBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_fazendaComboBox = new System.Windows.Forms.ComboBox();
            this.fKfazendasclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_clienteComboBox = new System.Windows.Forms.ComboBox();
            this.fKencarregadosclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordem_servicoTableAdapter = new oficina_stang.BANCOTableAdapters.ordem_servicoTableAdapter();
            this.tableAdapterManager = new oficina_stang.BANCOTableAdapters.TableAdapterManager();
            this.clientesTableAdapter = new oficina_stang.BANCOTableAdapters.clientesTableAdapter();
            this.encarregadosTableAdapter = new oficina_stang.BANCOTableAdapters.encarregadosTableAdapter();
            this.fazendasTableAdapter = new oficina_stang.BANCOTableAdapters.fazendasTableAdapter();
            this.funcionariosTableAdapter = new oficina_stang.BANCOTableAdapters.funcionariosTableAdapter();
            this.ordem_servicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ordem_servicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subtotal_servicoTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.descontoTextBox = new System.Windows.Forms.TextBox();
            this.sub_totalTextBox = new System.Windows.Forms.TextBox();
            id_clienteLabel = new System.Windows.Forms.Label();
            id_fazendaLabel = new System.Windows.Forms.Label();
            id_encarregadoLabel = new System.Windows.Forms.Label();
            id_funcionarioLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            data_saidaLabel = new System.Windows.Forms.Label();
            data_entradaLabel = new System.Windows.Forms.Label();
            id_ordenLabel = new System.Windows.Forms.Label();
            subtotal_servicoLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            sub_totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordem_servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKfazendasclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKencarregadosclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordem_servicoBindingNavigator)).BeginInit();
            this.ordem_servicoBindingNavigator.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(3, 54);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(55, 13);
            id_clienteLabel.TabIndex = 0;
            id_clienteLabel.Text = "CLIENTE:";
            // 
            // id_fazendaLabel
            // 
            id_fazendaLabel.AutoSize = true;
            id_fazendaLabel.Location = new System.Drawing.Point(259, 54);
            id_fazendaLabel.Name = "id_fazendaLabel";
            id_fazendaLabel.Size = new System.Drawing.Size(60, 13);
            id_fazendaLabel.TabIndex = 0;
            id_fazendaLabel.Text = "FAZENDA:";
            // 
            // id_encarregadoLabel
            // 
            id_encarregadoLabel.AutoSize = true;
            id_encarregadoLabel.Location = new System.Drawing.Point(3, 94);
            id_encarregadoLabel.Name = "id_encarregadoLabel";
            id_encarregadoLabel.Size = new System.Drawing.Size(93, 13);
            id_encarregadoLabel.TabIndex = 0;
            id_encarregadoLabel.Text = "ENCARREGADO:";
            // 
            // id_funcionarioLabel
            // 
            id_funcionarioLabel.AutoSize = true;
            id_funcionarioLabel.Location = new System.Drawing.Point(259, 94);
            id_funcionarioLabel.Name = "id_funcionarioLabel";
            id_funcionarioLabel.Size = new System.Drawing.Size(84, 13);
            id_funcionarioLabel.TabIndex = 0;
            id_funcionarioLabel.Text = "FUNCIONARIO:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(389, 15);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(57, 13);
            statusLabel.TabIndex = 9;
            statusLabel.Text = "POSIÇÃO:";
            // 
            // data_saidaLabel
            // 
            data_saidaLabel.AutoSize = true;
            data_saidaLabel.Location = new System.Drawing.Point(259, 16);
            data_saidaLabel.Name = "data_saidaLabel";
            data_saidaLabel.Size = new System.Drawing.Size(42, 13);
            data_saidaLabel.TabIndex = 10;
            data_saidaLabel.Text = "SAIDA:";
            // 
            // data_entradaLabel
            // 
            data_entradaLabel.AutoSize = true;
            data_entradaLabel.Location = new System.Drawing.Point(132, 16);
            data_entradaLabel.Name = "data_entradaLabel";
            data_entradaLabel.Size = new System.Drawing.Size(62, 13);
            data_entradaLabel.TabIndex = 11;
            data_entradaLabel.Text = "ENTRADA:";
            // 
            // id_ordenLabel
            // 
            id_ordenLabel.AutoSize = true;
            id_ordenLabel.Location = new System.Drawing.Point(3, 16);
            id_ordenLabel.Name = "id_ordenLabel";
            id_ordenLabel.Size = new System.Drawing.Size(46, 13);
            id_ordenLabel.TabIndex = 16;
            id_ordenLabel.Text = "N° S.O.:";
            // 
            // subtotal_servicoLabel
            // 
            subtotal_servicoLabel.AutoSize = true;
            subtotal_servicoLabel.Location = new System.Drawing.Point(93, 16);
            subtotal_servicoLabel.Name = "subtotal_servicoLabel";
            subtotal_servicoLabel.Size = new System.Drawing.Size(57, 13);
            subtotal_servicoLabel.TabIndex = 2;
            subtotal_servicoLabel.Text = "SERVIÇO:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(7, 132);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(45, 13);
            totalLabel.TabIndex = 0;
            totalLabel.Text = "TOTAL:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(6, 93);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(70, 13);
            descontoLabel.TabIndex = 0;
            descontoLabel.Text = "DESCONTO:";
            // 
            // sub_totalLabel
            // 
            sub_totalLabel.AutoSize = true;
            sub_totalLabel.Location = new System.Drawing.Point(6, 16);
            sub_totalLabel.Name = "sub_totalLabel";
            sub_totalLabel.Size = new System.Drawing.Size(45, 13);
            sub_totalLabel.TabIndex = 0;
            sub_totalLabel.Text = "PEÇAS:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::oficina_stang.Properties.Resources.hitech;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(160, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sentinel Programações";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(480, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "CONCLUIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(587, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.X1 = 276;
            this.lineShape1.X2 = 688;
            this.lineShape1.Y1 = 346;
            this.lineShape1.Y2 = 346;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(697, 409);
            this.shapeContainer1.TabIndex = 36;
            this.shapeContainer1.TabStop = false;
            // 
            // id_ordenTextBox
            // 
            this.id_ordenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "id_orden", true));
            this.id_ordenTextBox.Location = new System.Drawing.Point(269, 472);
            this.id_ordenTextBox.Name = "id_ordenTextBox";
            this.id_ordenTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_ordenTextBox.TabIndex = 1;
            // 
            // ordem_servicoBindingSource
            // 
            this.ordem_servicoBindingSource.DataMember = "ordem_servico";
            this.ordem_servicoBindingSource.DataSource = this.bANCO;
            this.ordem_servicoBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.ordem_servicoBindingSource_AddingNew);
            // 
            // bANCO
            // 
            this.bANCO.DataSetName = "BANCO";
            this.bANCO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.solicitanteTextBox);
            this.groupBox1.Controls.Add(id_ordenLabel);
            this.groupBox1.Controls.Add(this.id_ordenTextBox1);
            this.groupBox1.Controls.Add(this.data_saidaMaskedTextBox);
            this.groupBox1.Controls.Add(this.data_entradaMaskedTextBox);
            this.groupBox1.Controls.Add(this.statusComboBox);
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(data_saidaLabel);
            this.groupBox1.Controls.Add(data_entradaLabel);
            this.groupBox1.Controls.Add(this.id_funcionarioComboBox);
            this.groupBox1.Controls.Add(id_funcionarioLabel);
            this.groupBox1.Controls.Add(id_encarregadoLabel);
            this.groupBox1.Controls.Add(this.id_fazendaComboBox);
            this.groupBox1.Controls.Add(id_fazendaLabel);
            this.groupBox1.Controls.Add(this.id_clienteComboBox);
            this.groupBox1.Controls.Add(id_clienteLabel);
            this.groupBox1.Location = new System.Drawing.Point(163, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // solicitanteTextBox
            // 
            this.solicitanteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.solicitanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "solicitante", true));
            this.solicitanteTextBox.Location = new System.Drawing.Point(6, 110);
            this.solicitanteTextBox.Name = "solicitanteTextBox";
            this.solicitanteTextBox.Size = new System.Drawing.Size(250, 20);
            this.solicitanteTextBox.TabIndex = 6;
            // 
            // id_ordenTextBox1
            // 
            this.id_ordenTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "id_orden", true));
            this.id_ordenTextBox1.Location = new System.Drawing.Point(6, 31);
            this.id_ordenTextBox1.Name = "id_ordenTextBox1";
            this.id_ordenTextBox1.ReadOnly = true;
            this.id_ordenTextBox1.Size = new System.Drawing.Size(123, 20);
            this.id_ordenTextBox1.TabIndex = 17;
            this.id_ordenTextBox1.TabStop = false;
            // 
            // data_saidaMaskedTextBox
            // 
            this.data_saidaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "data_saida", true));
            this.data_saidaMaskedTextBox.Location = new System.Drawing.Point(262, 31);
            this.data_saidaMaskedTextBox.Mask = "00/00/0000";
            this.data_saidaMaskedTextBox.Name = "data_saidaMaskedTextBox";
            this.data_saidaMaskedTextBox.Size = new System.Drawing.Size(123, 20);
            this.data_saidaMaskedTextBox.TabIndex = 1;
            this.data_saidaMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // data_entradaMaskedTextBox
            // 
            this.data_entradaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "data_entrada", true));
            this.data_entradaMaskedTextBox.Location = new System.Drawing.Point(135, 31);
            this.data_entradaMaskedTextBox.Mask = "00/00/0000";
            this.data_entradaMaskedTextBox.Name = "data_entradaMaskedTextBox";
            this.data_entradaMaskedTextBox.Size = new System.Drawing.Size(123, 20);
            this.data_entradaMaskedTextBox.TabIndex = 0;
            this.data_entradaMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // statusComboBox
            // 
            this.statusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.statusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "EM ANDAMENTO",
            "CONCLUIDO"});
            this.statusComboBox.Location = new System.Drawing.Point(392, 31);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(123, 21);
            this.statusComboBox.TabIndex = 2;
            // 
            // id_funcionarioComboBox
            // 
            this.id_funcionarioComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_funcionarioComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_funcionarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordem_servicoBindingSource, "id_funcionario", true));
            this.id_funcionarioComboBox.DataSource = this.funcionariosBindingSource;
            this.id_funcionarioComboBox.DisplayMember = "nome";
            this.id_funcionarioComboBox.FormattingEnabled = true;
            this.id_funcionarioComboBox.Location = new System.Drawing.Point(262, 110);
            this.id_funcionarioComboBox.Name = "id_funcionarioComboBox";
            this.id_funcionarioComboBox.Size = new System.Drawing.Size(253, 21);
            this.id_funcionarioComboBox.TabIndex = 7;
            this.id_funcionarioComboBox.ValueMember = "id_funcionario";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.bANCO;
            // 
            // id_fazendaComboBox
            // 
            this.id_fazendaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_fazendaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_fazendaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordem_servicoBindingSource, "id_fazenda", true));
            this.id_fazendaComboBox.DataSource = this.fKfazendasclientesBindingSource;
            this.id_fazendaComboBox.DisplayMember = "nome";
            this.id_fazendaComboBox.FormattingEnabled = true;
            this.id_fazendaComboBox.Location = new System.Drawing.Point(262, 70);
            this.id_fazendaComboBox.Name = "id_fazendaComboBox";
            this.id_fazendaComboBox.Size = new System.Drawing.Size(253, 21);
            this.id_fazendaComboBox.TabIndex = 5;
            this.id_fazendaComboBox.ValueMember = "id_fazenda";
            // 
            // fKfazendasclientesBindingSource
            // 
            this.fKfazendasclientesBindingSource.DataMember = "FK_fazendas_clientes";
            this.fKfazendasclientesBindingSource.DataSource = this.clientesBindingSource;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.bANCO;
            // 
            // id_clienteComboBox
            // 
            this.id_clienteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_clienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordem_servicoBindingSource, "id_cliente", true));
            this.id_clienteComboBox.DataSource = this.clientesBindingSource;
            this.id_clienteComboBox.DisplayMember = "nome";
            this.id_clienteComboBox.FormattingEnabled = true;
            this.id_clienteComboBox.Location = new System.Drawing.Point(6, 70);
            this.id_clienteComboBox.Name = "id_clienteComboBox";
            this.id_clienteComboBox.Size = new System.Drawing.Size(250, 21);
            this.id_clienteComboBox.TabIndex = 4;
            this.id_clienteComboBox.ValueMember = "id_cliente";
            // 
            // fKencarregadosclientesBindingSource
            // 
            this.fKencarregadosclientesBindingSource.DataMember = "FK_encarregados_clientes";
            this.fKencarregadosclientesBindingSource.DataSource = this.clientesBindingSource;
            // 
            // ordem_servicoTableAdapter
            // 
            this.ordem_servicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.cidadesTableAdapter = null;
            this.tableAdapterManager.clientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.encarregadosTableAdapter = this.encarregadosTableAdapter;
            this.tableAdapterManager.estadosTableAdapter = null;
            this.tableAdapterManager.fazendasTableAdapter = this.fazendasTableAdapter;
            this.tableAdapterManager.fornecedoresTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = this.funcionariosTableAdapter;
            this.tableAdapterManager.funcoesTableAdapter = null;
            this.tableAdapterManager.horas_servicosTableAdapter = null;
            this.tableAdapterManager.itens_orcamentoTableAdapter = null;
            this.tableAdapterManager.itens_ordemTableAdapter = null;
            this.tableAdapterManager.itens_saidaTableAdapter = null;
            this.tableAdapterManager.itens_servicoTableAdapter = null;
            this.tableAdapterManager.medidasTableAdapter = null;
            this.tableAdapterManager.mov_caixaTableAdapter = null;
            this.tableAdapterManager.mov_cartaoTableAdapter = null;
            this.tableAdapterManager.notas_saidaTableAdapter = null;
            this.tableAdapterManager.orcamentoTableAdapter = null;
            this.tableAdapterManager.ordem_servicoTableAdapter = this.ordem_servicoTableAdapter;
            this.tableAdapterManager.prazoTableAdapter = null;
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
            // encarregadosTableAdapter
            // 
            this.encarregadosTableAdapter.ClearBeforeFill = true;
            // 
            // fazendasTableAdapter
            // 
            this.fazendasTableAdapter.ClearBeforeFill = true;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // ordem_servicoBindingNavigator
            // 
            this.ordem_servicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ordem_servicoBindingNavigator.BindingSource = this.ordem_servicoBindingSource;
            this.ordem_servicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordem_servicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordem_servicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ordem_servicoBindingNavigatorSaveItem});
            this.ordem_servicoBindingNavigator.Location = new System.Drawing.Point(154, 0);
            this.ordem_servicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordem_servicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordem_servicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordem_servicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordem_servicoBindingNavigator.Name = "ordem_servicoBindingNavigator";
            this.ordem_servicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordem_servicoBindingNavigator.Size = new System.Drawing.Size(543, 25);
            this.ordem_servicoBindingNavigator.TabIndex = 38;
            this.ordem_servicoBindingNavigator.Text = "bindingNavigator1";
            this.ordem_servicoBindingNavigator.Visible = false;
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
            // ordem_servicoBindingNavigatorSaveItem
            // 
            this.ordem_servicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordem_servicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordem_servicoBindingNavigatorSaveItem.Image")));
            this.ordem_servicoBindingNavigatorSaveItem.Name = "ordem_servicoBindingNavigatorSaveItem";
            this.ordem_servicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ordem_servicoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.ordem_servicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordem_servicoBindingNavigatorSaveItem_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.observacoesTextBox);
            this.groupBox3.Location = new System.Drawing.Point(163, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 174);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SERVIÇOS REALIZADOS";
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "observacoes", true));
            this.observacoesTextBox.Location = new System.Drawing.Point(6, 16);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(317, 152);
            this.observacoesTextBox.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "IMPRIMIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(375, 354);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 47);
            this.button4.TabIndex = 0;
            this.button4.Text = "ITENS DA ORDEN";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(267, 354);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 47);
            this.button5.TabIndex = 1;
            this.button5.Text = "SERVIÇOS DA ORDEM";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(subtotal_servicoLabel);
            this.groupBox2.Controls.Add(this.subtotal_servicoTextBox);
            this.groupBox2.Controls.Add(this.totalTextBox);
            this.groupBox2.Controls.Add(totalLabel);
            this.groupBox2.Controls.Add(this.descontoTextBox);
            this.groupBox2.Controls.Add(descontoLabel);
            this.groupBox2.Controls.Add(this.sub_totalTextBox);
            this.groupBox2.Controls.Add(sub_totalLabel);
            this.groupBox2.Location = new System.Drawing.Point(498, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 174);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "subtotal2", true));
            this.textBox1.Location = new System.Drawing.Point(6, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "0,00";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SUBTOTAL:";
            // 
            // subtotal_servicoTextBox
            // 
            this.subtotal_servicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "subtotal_servico", true));
            this.subtotal_servicoTextBox.Location = new System.Drawing.Point(96, 32);
            this.subtotal_servicoTextBox.Name = "subtotal_servicoTextBox";
            this.subtotal_servicoTextBox.ReadOnly = true;
            this.subtotal_servicoTextBox.Size = new System.Drawing.Size(84, 20);
            this.subtotal_servicoTextBox.TabIndex = 3;
            this.subtotal_servicoTextBox.TabStop = false;
            this.subtotal_servicoTextBox.Text = "0,00";
            this.subtotal_servicoTextBox.TextChanged += new System.EventHandler(this.subtotal_servicoTextBox_TextChanged);
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(9, 148);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(171, 20);
            this.totalTextBox.TabIndex = 1;
            this.totalTextBox.Text = "0,00";
            this.totalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalTextBox_KeyPress);
            this.totalTextBox.Leave += new System.EventHandler(this.totalTextBox_Leave);
            // 
            // descontoTextBox
            // 
            this.descontoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "desconto", true));
            this.descontoTextBox.Location = new System.Drawing.Point(9, 109);
            this.descontoTextBox.Name = "descontoTextBox";
            this.descontoTextBox.Size = new System.Drawing.Size(171, 20);
            this.descontoTextBox.TabIndex = 0;
            this.descontoTextBox.Text = "0,00";
            this.descontoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalTextBox_KeyPress);
            this.descontoTextBox.Leave += new System.EventHandler(this.descontoTextBox_Leave);
            // 
            // sub_totalTextBox
            // 
            this.sub_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordem_servicoBindingSource, "sub_total", true));
            this.sub_totalTextBox.Location = new System.Drawing.Point(9, 32);
            this.sub_totalTextBox.Name = "sub_totalTextBox";
            this.sub_totalTextBox.ReadOnly = true;
            this.sub_totalTextBox.Size = new System.Drawing.Size(84, 20);
            this.sub_totalTextBox.TabIndex = 0;
            this.sub_totalTextBox.TabStop = false;
            this.sub_totalTextBox.Text = "0,00";
            this.sub_totalTextBox.TextChanged += new System.EventHandler(this.sub_totalTextBox_TextChanged_1);
            // 
            // CAD_ORDEM
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(697, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ordem_servicoBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.id_ordenTextBox);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "CAD_ORDEM";
            this.Text = "CADASTRAR O.S.";
            this.Load += new System.EventHandler(this.CAD_ORDEM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordem_servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKfazendasclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKencarregadosclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordem_servicoBindingNavigator)).EndInit();
            this.ordem_servicoBindingNavigator.ResumeLayout(false);
            this.ordem_servicoBindingNavigator.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private BANCOTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordem_servicoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ordem_servicoBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox id_funcionarioComboBox;
        private System.Windows.Forms.ComboBox id_fazendaComboBox;
        private System.Windows.Forms.ComboBox id_clienteComboBox;
        private BANCOTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private BANCOTableAdapters.fazendasTableAdapter fazendasTableAdapter;
        private System.Windows.Forms.BindingSource fKfazendasclientesBindingSource;
        private BANCOTableAdapters.encarregadosTableAdapter encarregadosTableAdapter;
        private System.Windows.Forms.BindingSource fKencarregadosclientesBindingSource;
        private BANCOTableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        public BANCO bANCO;
        public System.Windows.Forms.BindingSource ordem_servicoBindingSource;
        private System.Windows.Forms.TextBox id_ordenTextBox;
        private System.Windows.Forms.MaskedTextBox data_saidaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox data_entradaMaskedTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        public System.Windows.Forms.TextBox id_ordenTextBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subtotal_servicoTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox descontoTextBox;
        private System.Windows.Forms.TextBox sub_totalTextBox;
        private System.Windows.Forms.TextBox solicitanteTextBox;
        public BANCOTableAdapters.ordem_servicoTableAdapter ordem_servicoTableAdapter;
        private System.Windows.Forms.TextBox observacoesTextBox;
    }
}