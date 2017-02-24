namespace Atividades
{
    partial class FormAtividades
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baixasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baixarFolgasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeAtividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusAtividades = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboProjeto = new System.Windows.Forms.ComboBox();
            this.labProjeto = new System.Windows.Forms.Label();
            this.textCodigoProjeto = new System.Windows.Forms.TextBox();
            this.labCodProjeto = new System.Windows.Forms.Label();
            this.labEntrada1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskSaida1 = new System.Windows.Forms.TextBox();
            this.maskEntrada1 = new System.Windows.Forms.TextBox();
            this.labSaida1 = new System.Windows.Forms.Label();
            this.labPeriodo1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maskSaida2 = new System.Windows.Forms.TextBox();
            this.maskEntrada2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labPeriodo2 = new System.Windows.Forms.Label();
            this.labEntrada2 = new System.Windows.Forms.Label();
            this.labPeriodo3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.maskSaida3 = new System.Windows.Forms.TextBox();
            this.maskEntrada3 = new System.Windows.Forms.TextBox();
            this.labSaida3 = new System.Windows.Forms.Label();
            this.labEntrada3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labColaborador = new System.Windows.Forms.Label();
            this.comboColaborador = new System.Windows.Forms.ComboBox();
            this.butInserirAtividade = new System.Windows.Forms.Button();
            this.butExcluirAtividade = new System.Windows.Forms.Button();
            this.TextObservacao = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCodColaborador = new System.Windows.Forms.TextBox();
            this.butAtualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridAtividades = new System.Windows.Forms.DataGridView();
            this.DataAtividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codAtividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrada1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saida1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrada2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saida2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrada3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saida3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMinutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutosExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codGerente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeGerente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsAtividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataConnectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataConnectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deslocamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAtividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConnectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConnectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.baixasToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deslocamentosToolStripMenuItem,
            this.projetoToolStripMenuItem,
            this.colaboradorToolStripMenuItem,
            this.cidadesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // projetoToolStripMenuItem
            // 
            this.projetoToolStripMenuItem.Name = "projetoToolStripMenuItem";
            this.projetoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.projetoToolStripMenuItem.Text = "&Projetos";
            this.projetoToolStripMenuItem.Click += new System.EventHandler(this.projetoToolStripMenuItem_Click);
            // 
            // colaboradorToolStripMenuItem
            // 
            this.colaboradorToolStripMenuItem.Name = "colaboradorToolStripMenuItem";
            this.colaboradorToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.colaboradorToolStripMenuItem.Text = "P&essoas";
            this.colaboradorToolStripMenuItem.Click += new System.EventHandler(this.colaboradorToolStripMenuItem_Click);
            // 
            // cidadesToolStripMenuItem
            // 
            this.cidadesToolStripMenuItem.Name = "cidadesToolStripMenuItem";
            this.cidadesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.cidadesToolStripMenuItem.Text = "&Cidades";
            this.cidadesToolStripMenuItem.Click += new System.EventHandler(this.cidadesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            // 
            // baixasToolStripMenuItem
            // 
            this.baixasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baixarFolgasToolStripMenuItem});
            this.baixasToolStripMenuItem.Name = "baixasToolStripMenuItem";
            this.baixasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.baixasToolStripMenuItem.Text = "&Baixas";
            // 
            // baixarFolgasToolStripMenuItem
            // 
            this.baixarFolgasToolStripMenuItem.Name = "baixarFolgasToolStripMenuItem";
            this.baixarFolgasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.baixarFolgasToolStripMenuItem.Text = "Baixar &Folgas";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeAtividadesToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // relatórioDeAtividadesToolStripMenuItem
            // 
            this.relatórioDeAtividadesToolStripMenuItem.Name = "relatórioDeAtividadesToolStripMenuItem";
            this.relatórioDeAtividadesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.relatórioDeAtividadesToolStripMenuItem.Text = "&Relatório de atividades";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusAtividades});
            this.statusStrip1.Location = new System.Drawing.Point(0, 363);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(688, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // statusAtividades
            // 
            this.statusAtividades.Name = "statusAtividades";
            this.statusAtividades.Size = new System.Drawing.Size(45, 17);
            this.statusAtividades.Text = "Status: ";
            // 
            // comboProjeto
            // 
            this.comboProjeto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboProjeto.FormattingEnabled = true;
            this.comboProjeto.Location = new System.Drawing.Point(12, 40);
            this.comboProjeto.Name = "comboProjeto";
            this.comboProjeto.Size = new System.Drawing.Size(214, 21);
            this.comboProjeto.TabIndex = 2;
            this.comboProjeto.SelectedIndexChanged += new System.EventHandler(this.comboProjeto_SelectedIndexChanged_2);
            // 
            // labProjeto
            // 
            this.labProjeto.AutoSize = true;
            this.labProjeto.Location = new System.Drawing.Point(13, 25);
            this.labProjeto.Name = "labProjeto";
            this.labProjeto.Size = new System.Drawing.Size(102, 13);
            this.labProjeto.TabIndex = 3;
            this.labProjeto.Text = "Selecione o Projeto:";
            this.labProjeto.Click += new System.EventHandler(this.label1_Click);
            // 
            // textCodigoProjeto
            // 
            this.textCodigoProjeto.Enabled = false;
            this.textCodigoProjeto.Location = new System.Drawing.Point(245, 40);
            this.textCodigoProjeto.MaxLength = 8;
            this.textCodigoProjeto.Name = "textCodigoProjeto";
            this.textCodigoProjeto.Size = new System.Drawing.Size(76, 20);
            this.textCodigoProjeto.TabIndex = 3;
            // 
            // labCodProjeto
            // 
            this.labCodProjeto.AutoSize = true;
            this.labCodProjeto.Location = new System.Drawing.Point(242, 25);
            this.labCodProjeto.Name = "labCodProjeto";
            this.labCodProjeto.Size = new System.Drawing.Size(79, 13);
            this.labCodProjeto.TabIndex = 5;
            this.labCodProjeto.Text = "Codigo Projeto:";
            // 
            // labEntrada1
            // 
            this.labEntrada1.AutoSize = true;
            this.labEntrada1.Location = new System.Drawing.Point(3, 13);
            this.labEntrada1.Name = "labEntrada1";
            this.labEntrada1.Size = new System.Drawing.Size(47, 13);
            this.labEntrada1.TabIndex = 7;
            this.labEntrada1.Text = "Entrada:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maskSaida1);
            this.panel1.Controls.Add(this.maskEntrada1);
            this.panel1.Controls.Add(this.labSaida1);
            this.panel1.Controls.Add(this.labPeriodo1);
            this.panel1.Controls.Add(this.labEntrada1);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 53);
            this.panel1.TabIndex = 8;
            // 
            // maskSaida1
            // 
            this.maskSaida1.Location = new System.Drawing.Point(54, 29);
            this.maskSaida1.MaxLength = 4;
            this.maskSaida1.Name = "maskSaida1";
            this.maskSaida1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maskSaida1.Size = new System.Drawing.Size(44, 20);
            this.maskSaida1.TabIndex = 8;
            this.maskSaida1.Leave += new System.EventHandler(this.validaHoraSaida1);
            // 
            // maskEntrada1
            // 
            this.maskEntrada1.Location = new System.Drawing.Point(4, 29);
            this.maskEntrada1.MaxLength = 4;
            this.maskEntrada1.Name = "maskEntrada1";
            this.maskEntrada1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maskEntrada1.Size = new System.Drawing.Size(44, 20);
            this.maskEntrada1.TabIndex = 7;
            this.maskEntrada1.Leave += new System.EventHandler(this.validaHoraEntrada1);
            // 
            // labSaida1
            // 
            this.labSaida1.AutoSize = true;
            this.labSaida1.Location = new System.Drawing.Point(53, 12);
            this.labSaida1.Name = "labSaida1";
            this.labSaida1.Size = new System.Drawing.Size(37, 13);
            this.labSaida1.TabIndex = 10;
            this.labSaida1.Text = "Saida:";
            this.labSaida1.Click += new System.EventHandler(this.label5_Click);
            // 
            // labPeriodo1
            // 
            this.labPeriodo1.AutoSize = true;
            this.labPeriodo1.Location = new System.Drawing.Point(22, -1);
            this.labPeriodo1.Name = "labPeriodo1";
            this.labPeriodo1.Size = new System.Drawing.Size(54, 13);
            this.labPeriodo1.TabIndex = 8;
            this.labPeriodo1.Text = "Período 1";
            this.labPeriodo1.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.maskSaida2);
            this.panel2.Controls.Add(this.maskEntrada2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labPeriodo2);
            this.panel2.Controls.Add(this.labEntrada2);
            this.panel2.Location = new System.Drawing.Point(123, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 53);
            this.panel2.TabIndex = 11;
            // 
            // maskSaida2
            // 
            this.maskSaida2.Location = new System.Drawing.Point(56, 30);
            this.maskSaida2.MaxLength = 4;
            this.maskSaida2.Name = "maskSaida2";
            this.maskSaida2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maskSaida2.Size = new System.Drawing.Size(44, 20);
            this.maskSaida2.TabIndex = 8;
            this.maskSaida2.Leave += new System.EventHandler(this.validaHoraSaida2);
            // 
            // maskEntrada2
            // 
            this.maskEntrada2.Location = new System.Drawing.Point(6, 30);
            this.maskEntrada2.MaxLength = 4;
            this.maskEntrada2.Name = "maskEntrada2";
            this.maskEntrada2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maskEntrada2.Size = new System.Drawing.Size(44, 20);
            this.maskEntrada2.TabIndex = 7;
            this.maskEntrada2.Leave += new System.EventHandler(this.validaHoraEntrada2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Saida:";
            // 
            // labPeriodo2
            // 
            this.labPeriodo2.AutoSize = true;
            this.labPeriodo2.Location = new System.Drawing.Point(22, -1);
            this.labPeriodo2.Name = "labPeriodo2";
            this.labPeriodo2.Size = new System.Drawing.Size(54, 13);
            this.labPeriodo2.TabIndex = 8;
            this.labPeriodo2.Text = "Período 2";
            // 
            // labEntrada2
            // 
            this.labEntrada2.AutoSize = true;
            this.labEntrada2.Location = new System.Drawing.Point(3, 13);
            this.labEntrada2.Name = "labEntrada2";
            this.labEntrada2.Size = new System.Drawing.Size(47, 13);
            this.labEntrada2.TabIndex = 7;
            this.labEntrada2.Text = "Entrada:";
            // 
            // labPeriodo3
            // 
            this.labPeriodo3.AutoSize = true;
            this.labPeriodo3.Location = new System.Drawing.Point(22, -1);
            this.labPeriodo3.Name = "labPeriodo3";
            this.labPeriodo3.Size = new System.Drawing.Size(54, 13);
            this.labPeriodo3.TabIndex = 8;
            this.labPeriodo3.Text = "Período 3";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.maskSaida3);
            this.panel3.Controls.Add(this.maskEntrada3);
            this.panel3.Controls.Add(this.labSaida3);
            this.panel3.Controls.Add(this.labPeriodo3);
            this.panel3.Controls.Add(this.labEntrada3);
            this.panel3.Location = new System.Drawing.Point(232, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 53);
            this.panel3.TabIndex = 12;
            // 
            // maskSaida3
            // 
            this.maskSaida3.Location = new System.Drawing.Point(56, 30);
            this.maskSaida3.MaxLength = 4;
            this.maskSaida3.Name = "maskSaida3";
            this.maskSaida3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maskSaida3.Size = new System.Drawing.Size(44, 20);
            this.maskSaida3.TabIndex = 8;
            this.maskSaida3.Leave += new System.EventHandler(this.validaHoraSaida3);
            // 
            // maskEntrada3
            // 
            this.maskEntrada3.Location = new System.Drawing.Point(6, 30);
            this.maskEntrada3.MaxLength = 4;
            this.maskEntrada3.Name = "maskEntrada3";
            this.maskEntrada3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maskEntrada3.Size = new System.Drawing.Size(44, 20);
            this.maskEntrada3.TabIndex = 7;
            this.maskEntrada3.Leave += new System.EventHandler(this.validaHoraEntrada3);
            // 
            // labSaida3
            // 
            this.labSaida3.AutoSize = true;
            this.labSaida3.Location = new System.Drawing.Point(53, 12);
            this.labSaida3.Name = "labSaida3";
            this.labSaida3.Size = new System.Drawing.Size(37, 13);
            this.labSaida3.TabIndex = 10;
            this.labSaida3.Text = "Saida:";
            // 
            // labEntrada3
            // 
            this.labEntrada3.AutoSize = true;
            this.labEntrada3.Location = new System.Drawing.Point(3, 13);
            this.labEntrada3.Name = "labEntrada3";
            this.labEntrada3.Size = new System.Drawing.Size(47, 13);
            this.labEntrada3.TabIndex = 7;
            this.labEntrada3.Text = "Entrada:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(339, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // labColaborador
            // 
            this.labColaborador.AutoSize = true;
            this.labColaborador.Location = new System.Drawing.Point(454, 24);
            this.labColaborador.Name = "labColaborador";
            this.labColaborador.Size = new System.Drawing.Size(126, 13);
            this.labColaborador.TabIndex = 16;
            this.labColaborador.Text = "Selecione o Colaborador:";
            // 
            // comboColaborador
            // 
            this.comboColaborador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboColaborador.FormattingEnabled = true;
            this.comboColaborador.Location = new System.Drawing.Point(442, 39);
            this.comboColaborador.Name = "comboColaborador";
            this.comboColaborador.Size = new System.Drawing.Size(138, 21);
            this.comboColaborador.TabIndex = 5;
            this.comboColaborador.SelectedIndexChanged += new System.EventHandler(this.comboColaborador_SelectedIndexChanged_1);
            // 
            // butInserirAtividade
            // 
            this.butInserirAtividade.Location = new System.Drawing.Point(595, 73);
            this.butInserirAtividade.Name = "butInserirAtividade";
            this.butInserirAtividade.Size = new System.Drawing.Size(75, 23);
            this.butInserirAtividade.TabIndex = 17;
            this.butInserirAtividade.Text = "Inserir";
            this.butInserirAtividade.UseVisualStyleBackColor = true;
            this.butInserirAtividade.Click += new System.EventHandler(this.butInserirAtividade_Click);
            // 
            // butExcluirAtividade
            // 
            this.butExcluirAtividade.Location = new System.Drawing.Point(596, 102);
            this.butExcluirAtividade.Name = "butExcluirAtividade";
            this.butExcluirAtividade.Size = new System.Drawing.Size(75, 23);
            this.butExcluirAtividade.TabIndex = 18;
            this.butExcluirAtividade.Text = "Excluir";
            this.butExcluirAtividade.UseVisualStyleBackColor = true;
            // 
            // TextObservacao
            // 
            this.TextObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextObservacao.Location = new System.Drawing.Point(342, 80);
            this.TextObservacao.Name = "TextObservacao";
            this.TextObservacao.Size = new System.Drawing.Size(238, 74);
            this.TextObservacao.TabIndex = 19;
            this.TextObservacao.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cod. Colaborador:";
            // 
            // textCodColaborador
            // 
            this.textCodColaborador.Enabled = false;
            this.textCodColaborador.Location = new System.Drawing.Point(595, 40);
            this.textCodColaborador.Name = "textCodColaborador";
            this.textCodColaborador.Size = new System.Drawing.Size(76, 20);
            this.textCodColaborador.TabIndex = 6;
            // 
            // butAtualizar
            // 
            this.butAtualizar.Location = new System.Drawing.Point(596, 131);
            this.butAtualizar.Name = "butAtualizar";
            this.butAtualizar.Size = new System.Drawing.Size(75, 23);
            this.butAtualizar.TabIndex = 22;
            this.butAtualizar.Text = "Atualizar";
            this.butAtualizar.UseVisualStyleBackColor = true;
            this.butAtualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Observação:";
            // 
            // dataGridAtividades
            // 
            this.dataGridAtividades.AllowUserToAddRows = false;
            this.dataGridAtividades.AllowUserToDeleteRows = false;
            this.dataGridAtividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAtividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataAtividade,
            this.codAtividade,
            this.entrada1,
            this.saida1,
            this.entrada2,
            this.saida2,
            this.entrada3,
            this.saida3,
            this.totalMinutos,
            this.minutosExtras,
            this.codGerente,
            this.NomeGerente,
            this.codColaborador,
            this.NomeUsuario,
            this.codProjeto,
            this.nomeProjeto,
            this.obsAtividade});
            this.dataGridAtividades.Location = new System.Drawing.Point(12, 160);
            this.dataGridAtividades.Name = "dataGridAtividades";
            this.dataGridAtividades.ReadOnly = true;
            this.dataGridAtividades.Size = new System.Drawing.Size(658, 174);
            this.dataGridAtividades.TabIndex = 24;
            // 
            // DataAtividade
            // 
            this.DataAtividade.DataPropertyName = "DataAtividade";
            this.DataAtividade.HeaderText = "Data Atividade";
            this.DataAtividade.Name = "DataAtividade";
            this.DataAtividade.ReadOnly = true;
            // 
            // codAtividade
            // 
            this.codAtividade.DataPropertyName = "codAtividade";
            this.codAtividade.HeaderText = "Cod Atividade";
            this.codAtividade.Name = "codAtividade";
            this.codAtividade.ReadOnly = true;
            // 
            // entrada1
            // 
            this.entrada1.DataPropertyName = "entrada1";
            this.entrada1.HeaderText = "Entrada 1";
            this.entrada1.Name = "entrada1";
            this.entrada1.ReadOnly = true;
            // 
            // saida1
            // 
            this.saida1.DataPropertyName = "saida1";
            this.saida1.HeaderText = "Saida 1";
            this.saida1.Name = "saida1";
            this.saida1.ReadOnly = true;
            // 
            // entrada2
            // 
            this.entrada2.DataPropertyName = "entrada2";
            this.entrada2.HeaderText = "Entrada 2";
            this.entrada2.Name = "entrada2";
            this.entrada2.ReadOnly = true;
            // 
            // saida2
            // 
            this.saida2.DataPropertyName = "saida2";
            this.saida2.HeaderText = "Saida 2";
            this.saida2.Name = "saida2";
            this.saida2.ReadOnly = true;
            // 
            // entrada3
            // 
            this.entrada3.DataPropertyName = "entrada3";
            this.entrada3.HeaderText = "Entrada 3";
            this.entrada3.Name = "entrada3";
            this.entrada3.ReadOnly = true;
            // 
            // saida3
            // 
            this.saida3.DataPropertyName = "saida3";
            this.saida3.HeaderText = "Saida 3";
            this.saida3.Name = "saida3";
            this.saida3.ReadOnly = true;
            // 
            // totalMinutos
            // 
            this.totalMinutos.DataPropertyName = "totalMinutos";
            this.totalMinutos.HeaderText = "Horas Trabalhadas";
            this.totalMinutos.Name = "totalMinutos";
            this.totalMinutos.ReadOnly = true;
            // 
            // minutosExtras
            // 
            this.minutosExtras.DataPropertyName = "minutosExtras";
            this.minutosExtras.HeaderText = "Horas Extras";
            this.minutosExtras.Name = "minutosExtras";
            this.minutosExtras.ReadOnly = true;
            // 
            // codGerente
            // 
            this.codGerente.DataPropertyName = "codGerente";
            this.codGerente.HeaderText = "Cod Gerente";
            this.codGerente.Name = "codGerente";
            this.codGerente.ReadOnly = true;
            // 
            // NomeGerente
            // 
            this.NomeGerente.DataPropertyName = "NomeGerente";
            this.NomeGerente.HeaderText = "Nome Gerente";
            this.NomeGerente.Name = "NomeGerente";
            this.NomeGerente.ReadOnly = true;
            // 
            // codColaborador
            // 
            this.codColaborador.DataPropertyName = "codColaborador";
            this.codColaborador.HeaderText = "Cod Colaborador";
            this.codColaborador.Name = "codColaborador";
            this.codColaborador.ReadOnly = true;
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.DataPropertyName = "NomeUsuario";
            this.NomeUsuario.HeaderText = "Nome Usuario";
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.ReadOnly = true;
            // 
            // codProjeto
            // 
            this.codProjeto.DataPropertyName = "codProjeto";
            this.codProjeto.HeaderText = "Cod Projeto";
            this.codProjeto.Name = "codProjeto";
            this.codProjeto.ReadOnly = true;
            // 
            // nomeProjeto
            // 
            this.nomeProjeto.DataPropertyName = "nomeProjeto";
            this.nomeProjeto.HeaderText = "Nome Projeto";
            this.nomeProjeto.Name = "nomeProjeto";
            this.nomeProjeto.ReadOnly = true;
            // 
            // obsAtividade
            // 
            this.obsAtividade.DataPropertyName = "obsAtividade";
            this.obsAtividade.HeaderText = "Observações";
            this.obsAtividade.Name = "obsAtividade";
            this.obsAtividade.ReadOnly = true;
            // 
            // dataConnectBindingSource1
            // 
            this.dataConnectBindingSource1.DataSource = typeof(Atividades.DataConnect);
            // 
            // dataConnectBindingSource
            // 
            this.dataConnectBindingSource.DataSource = typeof(Atividades.DataConnect);
            // 
            // deslocamentosToolStripMenuItem
            // 
            this.deslocamentosToolStripMenuItem.Name = "deslocamentosToolStripMenuItem";
            this.deslocamentosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deslocamentosToolStripMenuItem.Text = "&Deslocamentos";
            // 
            // FormAtividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 385);
            this.Controls.Add(this.dataGridAtividades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butAtualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCodColaborador);
            this.Controls.Add(this.TextObservacao);
            this.Controls.Add(this.butExcluirAtividade);
            this.Controls.Add(this.butInserirAtividade);
            this.Controls.Add(this.labColaborador);
            this.Controls.Add(this.comboColaborador);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labCodProjeto);
            this.Controls.Add(this.textCodigoProjeto);
            this.Controls.Add(this.labProjeto);
            this.Controls.Add(this.comboProjeto);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormAtividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Atividades";
            this.Activated += new System.EventHandler(this.FormAtividades_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAtividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConnectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConnectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox comboProjeto;
        private System.Windows.Forms.Label labProjeto;
        private System.Windows.Forms.TextBox textCodigoProjeto;
        private System.Windows.Forms.Label labCodProjeto;
        private System.Windows.Forms.Label labEntrada1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labPeriodo1;
        private System.Windows.Forms.Label labSaida1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labPeriodo2;
        private System.Windows.Forms.Label labEntrada2;
        private System.Windows.Forms.Label labPeriodo3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labSaida3;
        private System.Windows.Forms.Label labEntrada3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Label labColaborador;
        private System.Windows.Forms.ComboBox comboColaborador;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeAtividadesToolStripMenuItem;
        private System.Windows.Forms.Button butInserirAtividade;
        private System.Windows.Forms.Button butExcluirAtividade;
        private System.Windows.Forms.RichTextBox TextObservacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCodColaborador;
        private System.Windows.Forms.TextBox maskSaida1;
        private System.Windows.Forms.TextBox maskEntrada1;
        private System.Windows.Forms.TextBox maskSaida2;
        private System.Windows.Forms.TextBox maskEntrada2;
        private System.Windows.Forms.TextBox maskSaida3;
        private System.Windows.Forms.TextBox maskEntrada3;
        private System.Windows.Forms.Button butAtualizar;
        private System.Windows.Forms.ToolStripStatusLabel statusAtividades;
        private System.Windows.Forms.BindingSource dataConnectBindingSource;
        private System.Windows.Forms.BindingSource dataConnectBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem cidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baixasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baixarFolgasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridAtividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada1;
        private System.Windows.Forms.DataGridViewTextBoxColumn saida1;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada2;
        private System.Windows.Forms.DataGridViewTextBoxColumn saida2;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada3;
        private System.Windows.Forms.DataGridViewTextBoxColumn saida3;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMinutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn minutosExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn codGerente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeGerente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsAtividade;
        private System.Windows.Forms.ToolStripMenuItem deslocamentosToolStripMenuItem;
    }
}

