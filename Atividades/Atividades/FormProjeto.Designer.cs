namespace Atividades
{
    partial class FormProjeto
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
            this.comboGerente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNomeProjeto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCodProjeto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridProjetos = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.butAtualizar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboUF = new System.Windows.Forms.ComboBox();
            this.comboCidade = new System.Windows.Forms.ComboBox();
            this.textCodGerente = new System.Windows.Forms.TextBox();
            this.textCodCidade = new System.Windows.Forms.TextBox();
            this.codProjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codGerente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeGerente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjetos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboGerente
            // 
            this.comboGerente.FormattingEnabled = true;
            this.comboGerente.Location = new System.Drawing.Point(12, 73);
            this.comboGerente.Name = "comboGerente";
            this.comboGerente.Size = new System.Drawing.Size(275, 21);
            this.comboGerente.TabIndex = 3;
            this.comboGerente.SelectedIndexChanged += new System.EventHandler(this.comboGerente_SelectedIndexChanged);
            this.comboGerente.Leave += new System.EventHandler(this.comboGerente_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Projeto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNomeProjeto
            // 
            this.textNomeProjeto.Location = new System.Drawing.Point(12, 36);
            this.textNomeProjeto.Name = "textNomeProjeto";
            this.textNomeProjeto.Size = new System.Drawing.Size(275, 20);
            this.textNomeProjeto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gerente do Projeto:";
            // 
            // textCodProjeto
            // 
            this.textCodProjeto.AccessibleDescription = "";
            this.textCodProjeto.Location = new System.Drawing.Point(301, 36);
            this.textCodProjeto.MaxLength = 7;
            this.textCodProjeto.Name = "textCodProjeto";
            this.textCodProjeto.Size = new System.Drawing.Size(89, 20);
            this.textCodProjeto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código do Projeto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "UF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cidade:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridProjetos
            // 
            this.dataGridProjetos.AllowUserToAddRows = false;
            this.dataGridProjetos.AllowUserToDeleteRows = false;
            this.dataGridProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProjetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProjeto,
            this.nomeProjeto,
            this.codGerente,
            this.nomeGerente,
            this.codUf,
            this.codCidade});
            this.dataGridProjetos.Location = new System.Drawing.Point(15, 140);
            this.dataGridProjetos.Name = "dataGridProjetos";
            this.dataGridProjetos.ReadOnly = true;
            this.dataGridProjetos.Size = new System.Drawing.Size(377, 109);
            this.dataGridProjetos.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // butAtualizar
            // 
            this.butAtualizar.Location = new System.Drawing.Point(304, 85);
            this.butAtualizar.Name = "butAtualizar";
            this.butAtualizar.Size = new System.Drawing.Size(75, 23);
            this.butAtualizar.TabIndex = 16;
            this.butAtualizar.Text = "Atualizar";
            this.butAtualizar.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.cidadeToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.pessoasToolStripMenuItem.Text = "&Pessoas";
            this.pessoasToolStripMenuItem.Click += new System.EventHandler(this.pessoasToolStripMenuItem_Click);
            // 
            // cidadeToolStripMenuItem
            // 
            this.cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            this.cidadeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.cidadeToolStripMenuItem.Text = "&Cidade";
            this.cidadeToolStripMenuItem.Click += new System.EventHandler(this.cidadeToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            // 
            // comboUF
            // 
            this.comboUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboUF.FormattingEnabled = true;
            this.comboUF.Location = new System.Drawing.Point(13, 113);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(72, 21);
            this.comboUF.TabIndex = 4;
            this.comboUF.SelectedIndexChanged += new System.EventHandler(this.comboUF_SelectedIndexChanged);
            // 
            // comboCidade
            // 
            this.comboCidade.FormattingEnabled = true;
            this.comboCidade.Location = new System.Drawing.Point(100, 113);
            this.comboCidade.Name = "comboCidade";
            this.comboCidade.Size = new System.Drawing.Size(187, 21);
            this.comboCidade.TabIndex = 5;
            // 
            // textCodGerente
            // 
            this.textCodGerente.AccessibleDescription = "";
            this.textCodGerente.Location = new System.Drawing.Point(254, 10);
            this.textCodGerente.MaxLength = 7;
            this.textCodGerente.Name = "textCodGerente";
            this.textCodGerente.Size = new System.Drawing.Size(41, 20);
            this.textCodGerente.TabIndex = 0;
            this.textCodGerente.Visible = false;
            // 
            // textCodCidade
            // 
            this.textCodCidade.AccessibleDescription = "";
            this.textCodCidade.Location = new System.Drawing.Point(206, 10);
            this.textCodCidade.MaxLength = 7;
            this.textCodCidade.Name = "textCodCidade";
            this.textCodCidade.Size = new System.Drawing.Size(42, 20);
            this.textCodCidade.TabIndex = 0;
            this.textCodCidade.Visible = false;
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
            this.nomeProjeto.HeaderText = "Projeto";
            this.nomeProjeto.Name = "nomeProjeto";
            this.nomeProjeto.ReadOnly = true;
            // 
            // codGerente
            // 
            this.codGerente.DataPropertyName = "codGerente";
            this.codGerente.HeaderText = "cod Gerente";
            this.codGerente.Name = "codGerente";
            this.codGerente.ReadOnly = true;
            // 
            // nomeGerente
            // 
            this.nomeGerente.DataPropertyName = "nomeGerente";
            this.nomeGerente.HeaderText = "Gerente";
            this.nomeGerente.Name = "nomeGerente";
            this.nomeGerente.ReadOnly = true;
            // 
            // codUf
            // 
            this.codUf.DataPropertyName = "codUf";
            this.codUf.HeaderText = "UF";
            this.codUf.Name = "codUf";
            this.codUf.ReadOnly = true;
            // 
            // codCidade
            // 
            this.codCidade.DataPropertyName = "codCidade";
            this.codCidade.HeaderText = "Cidade";
            this.codCidade.Name = "codCidade";
            this.codCidade.ReadOnly = true;
            // 
            // FormProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.textCodCidade);
            this.Controls.Add(this.textCodGerente);
            this.Controls.Add(this.comboCidade);
            this.Controls.Add(this.comboUF);
            this.Controls.Add(this.butAtualizar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridProjetos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCodProjeto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNomeProjeto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboGerente);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormProjeto";
            this.Text = "Cadastro de Projeto";
            this.Activated += new System.EventHandler(this.FormProjeto_Activated);
            this.Load += new System.EventHandler(this.FormProjeto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjetos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboGerente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNomeProjeto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCodProjeto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridProjetos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button butAtualizar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboUF;
        private System.Windows.Forms.ToolStripMenuItem cidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboCidade;
        private System.Windows.Forms.TextBox textCodGerente;
        private System.Windows.Forms.TextBox textCodCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codGerente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeGerente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUf;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCidade;
    }
}