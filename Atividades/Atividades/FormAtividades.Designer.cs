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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenteDeProjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataAtividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saida1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saida2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saida3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodGerente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeGerente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasTrabalhadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labColaborador = new System.Windows.Forms.Label();
            this.comboColaborador = new System.Windows.Forms.ComboBox();
            this.butInserirAtividade = new System.Windows.Forms.Button();
            this.butExcluirAtividade = new System.Windows.Forms.Button();
            this.TextObservacao = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCodColaborador = new System.Windows.Forms.TextBox();
            this.butAtualizar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
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
            this.projetoToolStripMenuItem,
            this.colaboradorToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // projetoToolStripMenuItem
            // 
            this.projetoToolStripMenuItem.Name = "projetoToolStripMenuItem";
            this.projetoToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.projetoToolStripMenuItem.Text = "&Projeto";
            // 
            // colaboradorToolStripMenuItem
            // 
            this.colaboradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaboradorToolStripMenuItem1,
            this.gerenteDeProjetoToolStripMenuItem});
            this.colaboradorToolStripMenuItem.Name = "colaboradorToolStripMenuItem";
            this.colaboradorToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.colaboradorToolStripMenuItem.Text = "P&essoas";
            // 
            // colaboradorToolStripMenuItem1
            // 
            this.colaboradorToolStripMenuItem1.Name = "colaboradorToolStripMenuItem1";
            this.colaboradorToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.colaboradorToolStripMenuItem1.Text = "C&olaborador";
            // 
            // gerenteDeProjetoToolStripMenuItem
            // 
            this.gerenteDeProjetoToolStripMenuItem.Name = "gerenteDeProjetoToolStripMenuItem";
            this.gerenteDeProjetoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gerenteDeProjetoToolStripMenuItem.Text = "&Gerente de Projeto";
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
            this.comboProjeto.FormattingEnabled = true;
            this.comboProjeto.Location = new System.Drawing.Point(12, 40);
            this.comboProjeto.Name = "comboProjeto";
            this.comboProjeto.Size = new System.Drawing.Size(214, 21);
            this.comboProjeto.TabIndex = 2;
            this.comboProjeto.SelectedIndexChanged += new System.EventHandler(this.comboProjeto_SelectedIndexChanged);
            // 
            // labProjeto
            // 
            this.labProjeto.AutoSize = true;
            this.labProjeto.Location = new System.Drawing.Point(13, 21);
            this.labProjeto.Name = "labProjeto";
            this.labProjeto.Size = new System.Drawing.Size(102, 13);
            this.labProjeto.TabIndex = 3;
            this.labProjeto.Text = "Selecione o Projeto:";
            this.labProjeto.Click += new System.EventHandler(this.label1_Click);
            // 
            // textCodigoProjeto
            // 
            this.textCodigoProjeto.Location = new System.Drawing.Point(245, 40);
            this.textCodigoProjeto.MaxLength = 8;
            this.textCodigoProjeto.Name = "textCodigoProjeto";
            this.textCodigoProjeto.Size = new System.Drawing.Size(76, 20);
            this.textCodigoProjeto.TabIndex = 3;
            // 
            // labCodProjeto
            // 
            this.labCodProjeto.AutoSize = true;
            this.labCodProjeto.Location = new System.Drawing.Point(242, 24);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataAtividade,
            this.Entrada1,
            this.Entrada2,
            this.Entrada3,
            this.Saida1,
            this.Saida2,
            this.Saida3,
            this.Observacao,
            this.CodGerente,
            this.CodProjeto,
            this.NomeProjeto,
            this.NomeGerente,
            this.CodUsuario,
            this.NomeUsuario,
            this.HorasTrabalhadas,
            this.HorasExtras});
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(659, 137);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DataAtividade
            // 
            this.DataAtividade.HeaderText = "Data";
            this.DataAtividade.Name = "DataAtividade";
            this.DataAtividade.ReadOnly = true;
            // 
            // Entrada1
            // 
            this.Entrada1.HeaderText = "Entrada1";
            this.Entrada1.Name = "Entrada1";
            this.Entrada1.ReadOnly = true;
            // 
            // Entrada2
            // 
            this.Entrada2.HeaderText = "Entrada2";
            this.Entrada2.Name = "Entrada2";
            this.Entrada2.ReadOnly = true;
            // 
            // Entrada3
            // 
            this.Entrada3.HeaderText = "Entrada3";
            this.Entrada3.Name = "Entrada3";
            this.Entrada3.ReadOnly = true;
            // 
            // Saida1
            // 
            this.Saida1.HeaderText = "Saida1";
            this.Saida1.Name = "Saida1";
            this.Saida1.ReadOnly = true;
            // 
            // Saida2
            // 
            this.Saida2.HeaderText = "Saida2";
            this.Saida2.Name = "Saida2";
            this.Saida2.ReadOnly = true;
            // 
            // Saida3
            // 
            this.Saida3.HeaderText = "Saida3";
            this.Saida3.Name = "Saida3";
            this.Saida3.ReadOnly = true;
            // 
            // Observacao
            // 
            this.Observacao.HeaderText = "Observacao";
            this.Observacao.Name = "Observacao";
            this.Observacao.ReadOnly = true;
            // 
            // CodGerente
            // 
            this.CodGerente.HeaderText = "CodGerente";
            this.CodGerente.Name = "CodGerente";
            this.CodGerente.ReadOnly = true;
            // 
            // CodProjeto
            // 
            this.CodProjeto.HeaderText = "CodProjeto";
            this.CodProjeto.Name = "CodProjeto";
            this.CodProjeto.ReadOnly = true;
            // 
            // NomeProjeto
            // 
            this.NomeProjeto.HeaderText = "NomeProjeto";
            this.NomeProjeto.Name = "NomeProjeto";
            this.NomeProjeto.ReadOnly = true;
            // 
            // NomeGerente
            // 
            this.NomeGerente.HeaderText = "NomeGerente";
            this.NomeGerente.Name = "NomeGerente";
            this.NomeGerente.ReadOnly = true;
            // 
            // CodUsuario
            // 
            this.CodUsuario.HeaderText = "CodUsuario";
            this.CodUsuario.Name = "CodUsuario";
            this.CodUsuario.ReadOnly = true;
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.HeaderText = "NomeUsuario";
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.ReadOnly = true;
            // 
            // HorasTrabalhadas
            // 
            this.HorasTrabalhadas.HeaderText = "HorasTrabalhadas";
            this.HorasTrabalhadas.Name = "HorasTrabalhadas";
            this.HorasTrabalhadas.ReadOnly = true;
            // 
            // HorasExtras
            // 
            this.HorasExtras.HeaderText = "HorasExtras";
            this.HorasExtras.Name = "HorasExtras";
            this.HorasExtras.ReadOnly = true;
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
            this.comboColaborador.FormattingEnabled = true;
            this.comboColaborador.Location = new System.Drawing.Point(442, 39);
            this.comboColaborador.Name = "comboColaborador";
            this.comboColaborador.Size = new System.Drawing.Size(138, 21);
            this.comboColaborador.TabIndex = 5;
            // 
            // butInserirAtividade
            // 
            this.butInserirAtividade.Location = new System.Drawing.Point(595, 73);
            this.butInserirAtividade.Name = "butInserirAtividade";
            this.butInserirAtividade.Size = new System.Drawing.Size(75, 23);
            this.butInserirAtividade.TabIndex = 17;
            this.butInserirAtividade.Text = "Gravar";
            this.butInserirAtividade.UseVisualStyleBackColor = true;
            this.butInserirAtividade.Click += new System.EventHandler(this.butInserirAtividade_Click);
            // 
            // butExcluirAtividade
            // 
            this.butExcluirAtividade.Location = new System.Drawing.Point(596, 109);
            this.butExcluirAtividade.Name = "butExcluirAtividade";
            this.butExcluirAtividade.Size = new System.Drawing.Size(75, 23);
            this.butExcluirAtividade.TabIndex = 18;
            this.butExcluirAtividade.Text = "Excluir";
            this.butExcluirAtividade.UseVisualStyleBackColor = true;
            // 
            // TextObservacao
            // 
            this.TextObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextObservacao.Location = new System.Drawing.Point(342, 73);
            this.TextObservacao.Name = "TextObservacao";
            this.TextObservacao.Size = new System.Drawing.Size(238, 68);
            this.TextObservacao.TabIndex = 19;
            this.TextObservacao.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cod. Colaborador:";
            // 
            // textCodColaborador
            // 
            this.textCodColaborador.Location = new System.Drawing.Point(595, 40);
            this.textCodColaborador.Name = "textCodColaborador";
            this.textCodColaborador.Size = new System.Drawing.Size(76, 20);
            this.textCodColaborador.TabIndex = 6;
            // 
            // butAtualizar
            // 
            this.butAtualizar.Location = new System.Drawing.Point(595, 325);
            this.butAtualizar.Name = "butAtualizar";
            this.butAtualizar.Size = new System.Drawing.Size(75, 23);
            this.butAtualizar.TabIndex = 22;
            this.butAtualizar.Text = "Atualizar";
            this.butAtualizar.UseVisualStyleBackColor = true;
            this.butAtualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAtividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 385);
            this.Controls.Add(this.butAtualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCodColaborador);
            this.Controls.Add(this.TextObservacao);
            this.Controls.Add(this.butExcluirAtividade);
            this.Controls.Add(this.butInserirAtividade);
            this.Controls.Add(this.labColaborador);
            this.Controls.Add(this.comboColaborador);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "FormAtividades";
            this.Text = "Registro de Atividades";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labColaborador;
        private System.Windows.Forms.ComboBox comboColaborador;
        private System.Windows.Forms.ToolStripMenuItem colaboradorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerenteDeProjetoToolStripMenuItem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saida1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saida2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saida3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodGerente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeGerente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasTrabalhadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasExtras;
        private System.Windows.Forms.ToolStripStatusLabel statusAtividades;
    }
}

