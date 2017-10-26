namespace oficina_stang.DADOS
{
    partial class DAD_PRODUTO
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
            System.Windows.Forms.Label quantidade_convertidaLabel;
            System.Windows.Forms.Label kg_metroLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label preco_vendaLabel;
            System.Windows.Forms.Label margemLabel;
            System.Windows.Forms.Label preco_custoLabel;
            System.Windows.Forms.Label unidadeLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label id_categoriaLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DAD_PRODUTO));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.bANCO = new oficina_stang.BANCO();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new oficina_stang.BANCOTableAdapters.categoriasTableAdapter();
            this.tableAdapterManager = new oficina_stang.BANCOTableAdapters.TableAdapterManager();
            this.produtosTableAdapter = new oficina_stang.BANCOTableAdapters.produtosTableAdapter();
            this.categoriasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.categoriasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.quantidade_convertidaTextBox = new System.Windows.Forms.TextBox();
            this.kg_metroTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.preco_vendaTextBox = new System.Windows.Forms.TextBox();
            this.margemTextBox = new System.Windows.Forms.TextBox();
            this.preco_custoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_medidaComboBox = new System.Windows.Forms.ComboBox();
            this.medidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.id_categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.medidasTableAdapter = new oficina_stang.BANCOTableAdapters.medidasTableAdapter();
            quantidade_convertidaLabel = new System.Windows.Forms.Label();
            kg_metroLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            preco_vendaLabel = new System.Windows.Forms.Label();
            margemLabel = new System.Windows.Forms.Label();
            preco_custoLabel = new System.Windows.Forms.Label();
            unidadeLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            id_categoriaLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingNavigator)).BeginInit();
            this.categoriasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medidasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quantidade_convertidaLabel
            // 
            quantidade_convertidaLabel.AutoSize = true;
            quantidade_convertidaLabel.Location = new System.Drawing.Point(6, 94);
            quantidade_convertidaLabel.Name = "quantidade_convertidaLabel";
            quantidade_convertidaLabel.Size = new System.Drawing.Size(142, 13);
            quantidade_convertidaLabel.TabIndex = 0;
            quantidade_convertidaLabel.Text = "QUANT. CONVERTIDA (M):";
            // 
            // kg_metroLabel
            // 
            kg_metroLabel.AutoSize = true;
            kg_metroLabel.Location = new System.Drawing.Point(6, 55);
            kg_metroLabel.Name = "kg_metroLabel";
            kg_metroLabel.Size = new System.Drawing.Size(126, 13);
            kg_metroLabel.TabIndex = 0;
            kg_metroLabel.Text = "TAXA DE CONVERÇÃO:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(6, 16);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(105, 13);
            quantidadeLabel.TabIndex = 0;
            quantidadeLabel.Text = "QUANTIDADE (KG):";
            // 
            // preco_vendaLabel
            // 
            preco_vendaLabel.AutoSize = true;
            preco_vendaLabel.Location = new System.Drawing.Point(6, 94);
            preco_vendaLabel.Name = "preco_vendaLabel";
            preco_vendaLabel.Size = new System.Drawing.Size(105, 13);
            preco_vendaLabel.TabIndex = 0;
            preco_vendaLabel.Text = "PREÇO DE VENDA:";
            // 
            // margemLabel
            // 
            margemLabel.AutoSize = true;
            margemLabel.Location = new System.Drawing.Point(6, 55);
            margemLabel.Name = "margemLabel";
            margemLabel.Size = new System.Drawing.Size(116, 13);
            margemLabel.TabIndex = 0;
            margemLabel.Text = "MARGEM DE LUCRO:";
            // 
            // preco_custoLabel
            // 
            preco_custoLabel.AutoSize = true;
            preco_custoLabel.Location = new System.Drawing.Point(6, 16);
            preco_custoLabel.Name = "preco_custoLabel";
            preco_custoLabel.Size = new System.Drawing.Size(105, 13);
            preco_custoLabel.TabIndex = 0;
            preco_custoLabel.Text = "PREÇO DE CUSTO:";
            // 
            // unidadeLabel
            // 
            unidadeLabel.AutoSize = true;
            unidadeLabel.Location = new System.Drawing.Point(150, 55);
            unidadeLabel.Name = "unidadeLabel";
            unidadeLabel.Size = new System.Drawing.Size(122, 13);
            unidadeLabel.TabIndex = 6;
            unidadeLabel.Text = "UNIDADE DE MEDIDA:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(6, 55);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(48, 13);
            marcaLabel.TabIndex = 4;
            marcaLabel.Text = "MARCA:";
            // 
            // id_categoriaLabel
            // 
            id_categoriaLabel.AutoSize = true;
            id_categoriaLabel.Location = new System.Drawing.Point(278, 16);
            id_categoriaLabel.Name = "id_categoriaLabel";
            id_categoriaLabel.Size = new System.Drawing.Size(72, 13);
            id_categoriaLabel.TabIndex = 2;
            id_categoriaLabel.Text = "CATEGORIA:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(6, 16);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(72, 13);
            descricaoLabel.TabIndex = 0;
            descricaoLabel.Text = "DESCRIÇÃO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(156, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Sentinel Programações";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(470, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 47);
            this.button2.TabIndex = 47;
            this.button2.Text = "CONCLUIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::oficina_stang.Properties.Resources.hitech;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.X1 = 272;
            this.lineShape1.X2 = 590;
            this.lineShape1.Y1 = 270;
            this.lineShape1.Y2 = 270;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(607, 336);
            this.shapeContainer1.TabIndex = 51;
            this.shapeContainer1.TabStop = false;
            // 
            // bANCO
            // 
            this.bANCO.DataSetName = "BANCO";
            this.bANCO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "categorias";
            this.categoriasBindingSource.DataSource = this.bANCO;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = this.categoriasTableAdapter;
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
            this.tableAdapterManager.itens_ordemTableAdapter = null;
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
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // categoriasBindingNavigator
            // 
            this.categoriasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categoriasBindingNavigator.BindingSource = this.categoriasBindingSource;
            this.categoriasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categoriasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categoriasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.categoriasBindingNavigatorSaveItem});
            this.categoriasBindingNavigator.Location = new System.Drawing.Point(154, 0);
            this.categoriasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categoriasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categoriasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categoriasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categoriasBindingNavigator.Name = "categoriasBindingNavigator";
            this.categoriasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categoriasBindingNavigator.Size = new System.Drawing.Size(453, 25);
            this.categoriasBindingNavigator.TabIndex = 52;
            this.categoriasBindingNavigator.Text = "bindingNavigator1";
            this.categoriasBindingNavigator.Visible = false;
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
            // categoriasBindingNavigatorSaveItem
            // 
            this.categoriasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoriasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriasBindingNavigatorSaveItem.Image")));
            this.categoriasBindingNavigatorSaveItem.Name = "categoriasBindingNavigatorSaveItem";
            this.categoriasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.categoriasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.categoriasBindingNavigatorSaveItem.Click += new System.EventHandler(this.categoriasBindingNavigatorSaveItem_Click);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.bANCO;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.quantidade_convertidaTextBox);
            this.groupBox3.Controls.Add(quantidade_convertidaLabel);
            this.groupBox3.Controls.Add(this.kg_metroTextBox);
            this.groupBox3.Controls.Add(kg_metroLabel);
            this.groupBox3.Controls.Add(this.quantidadeTextBox);
            this.groupBox3.Controls.Add(quantidadeLabel);
            this.groupBox3.Location = new System.Drawing.Point(369, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 140);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            // 
            // quantidade_convertidaTextBox
            // 
            this.quantidade_convertidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "quantidade_convertida", true));
            this.quantidade_convertidaTextBox.Location = new System.Drawing.Point(9, 110);
            this.quantidade_convertidaTextBox.Name = "quantidade_convertidaTextBox";
            this.quantidade_convertidaTextBox.ReadOnly = true;
            this.quantidade_convertidaTextBox.Size = new System.Drawing.Size(131, 20);
            this.quantidade_convertidaTextBox.TabIndex = 2;
            // 
            // kg_metroTextBox
            // 
            this.kg_metroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "kg_metro", true));
            this.kg_metroTextBox.Location = new System.Drawing.Point(9, 71);
            this.kg_metroTextBox.Name = "kg_metroTextBox";
            this.kg_metroTextBox.ReadOnly = true;
            this.kg_metroTextBox.Size = new System.Drawing.Size(131, 20);
            this.kg_metroTextBox.TabIndex = 1;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(9, 32);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.ReadOnly = true;
            this.quantidadeTextBox.Size = new System.Drawing.Size(131, 20);
            this.quantidadeTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.preco_vendaTextBox);
            this.groupBox2.Controls.Add(preco_vendaLabel);
            this.groupBox2.Controls.Add(this.margemTextBox);
            this.groupBox2.Controls.Add(margemLabel);
            this.groupBox2.Controls.Add(this.preco_custoTextBox);
            this.groupBox2.Controls.Add(preco_custoLabel);
            this.groupBox2.Location = new System.Drawing.Point(219, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 140);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            // 
            // preco_vendaTextBox
            // 
            this.preco_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "preco_venda", true));
            this.preco_vendaTextBox.Location = new System.Drawing.Point(9, 110);
            this.preco_vendaTextBox.Name = "preco_vendaTextBox";
            this.preco_vendaTextBox.ReadOnly = true;
            this.preco_vendaTextBox.Size = new System.Drawing.Size(107, 20);
            this.preco_vendaTextBox.TabIndex = 2;
            // 
            // margemTextBox
            // 
            this.margemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "margem", true));
            this.margemTextBox.Location = new System.Drawing.Point(9, 71);
            this.margemTextBox.Name = "margemTextBox";
            this.margemTextBox.ReadOnly = true;
            this.margemTextBox.Size = new System.Drawing.Size(110, 20);
            this.margemTextBox.TabIndex = 1;
            // 
            // preco_custoTextBox
            // 
            this.preco_custoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "preco_custo", true));
            this.preco_custoTextBox.Location = new System.Drawing.Point(9, 32);
            this.preco_custoTextBox.Name = "preco_custoTextBox";
            this.preco_custoTextBox.ReadOnly = true;
            this.preco_custoTextBox.Size = new System.Drawing.Size(110, 20);
            this.preco_custoTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_medidaComboBox);
            this.groupBox1.Controls.Add(unidadeLabel);
            this.groupBox1.Controls.Add(marcaLabel);
            this.groupBox1.Controls.Add(this.marcaTextBox);
            this.groupBox1.Controls.Add(id_categoriaLabel);
            this.groupBox1.Controls.Add(this.id_categoriaComboBox);
            this.groupBox1.Controls.Add(descricaoLabel);
            this.groupBox1.Controls.Add(this.descricaoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(159, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 102);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // id_medidaComboBox
            // 
            this.id_medidaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_medidaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_medidaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtosBindingSource, "id_medida", true));
            this.id_medidaComboBox.DataSource = this.medidasBindingSource;
            this.id_medidaComboBox.DisplayMember = "unidade";
            this.id_medidaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.id_medidaComboBox.FormattingEnabled = true;
            this.id_medidaComboBox.Location = new System.Drawing.Point(152, 71);
            this.id_medidaComboBox.Name = "id_medidaComboBox";
            this.id_medidaComboBox.Size = new System.Drawing.Size(142, 21);
            this.id_medidaComboBox.TabIndex = 10;
            this.id_medidaComboBox.ValueMember = "id_medida";
            // 
            // medidasBindingSource
            // 
            this.medidasBindingSource.DataMember = "medidas";
            this.medidasBindingSource.DataSource = this.bANCO;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(9, 71);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.ReadOnly = true;
            this.marcaTextBox.Size = new System.Drawing.Size(137, 20);
            this.marcaTextBox.TabIndex = 2;
            // 
            // id_categoriaComboBox
            // 
            this.id_categoriaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_categoriaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtosBindingSource, "id_categoria", true));
            this.id_categoriaComboBox.DataSource = this.categoriasBindingSource;
            this.id_categoriaComboBox.DisplayMember = "nome";
            this.id_categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.id_categoriaComboBox.FormattingEnabled = true;
            this.id_categoriaComboBox.Location = new System.Drawing.Point(278, 31);
            this.id_categoriaComboBox.Name = "id_categoriaComboBox";
            this.id_categoriaComboBox.Size = new System.Drawing.Size(152, 21);
            this.id_categoriaComboBox.TabIndex = 1;
            this.id_categoriaComboBox.ValueMember = "id_categoria";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(9, 32);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ReadOnly = true;
            this.descricaoTextBox.Size = new System.Drawing.Size(263, 20);
            this.descricaoTextBox.TabIndex = 0;
            // 
            // medidasTableAdapter
            // 
            this.medidasTableAdapter.ClearBeforeFill = true;
            // 
            // DAD_PRODUTO
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(607, 336);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.categoriasBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.shapeContainer1);
            this.MaximumSize = new System.Drawing.Size(623, 374);
            this.MinimumSize = new System.Drawing.Size(623, 374);
            this.Name = "DAD_PRODUTO";
            this.Text = "DADOS PRODUTO";
            this.Load += new System.EventHandler(this.DAD_PRODUTO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingNavigator)).EndInit();
            this.categoriasBindingNavigator.ResumeLayout(false);
            this.categoriasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medidasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private BANCO bANCO;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private BANCOTableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private BANCOTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categoriasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton categoriasBindingNavigatorSaveItem;
        private BANCOTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox quantidade_convertidaTextBox;
        private System.Windows.Forms.TextBox kg_metroTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox preco_vendaTextBox;
        private System.Windows.Forms.TextBox margemTextBox;
        private System.Windows.Forms.TextBox preco_custoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.ComboBox id_categoriaComboBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.BindingSource medidasBindingSource;
        private BANCOTableAdapters.medidasTableAdapter medidasTableAdapter;
        private System.Windows.Forms.ComboBox id_medidaComboBox;
    }
}