namespace Atividades
{
    partial class FormPessoas
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
            this.labNomePessoa = new System.Windows.Forms.Label();
            this.textNomePessoa = new System.Windows.Forms.TextBox();
            this.butInserirPessoa = new System.Windows.Forms.Button();
            this.butExcluirPessoa = new System.Windows.Forms.Button();
            this.dataGridPessoas = new System.Windows.Forms.DataGridView();
            this.NomePessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gerente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.butAtualizaPessoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioGerente = new System.Windows.Forms.RadioButton();
            this.radioUsuarioPadrao = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPessoas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labNomePessoa
            // 
            this.labNomePessoa.AutoSize = true;
            this.labNomePessoa.Location = new System.Drawing.Point(13, 25);
            this.labNomePessoa.Name = "labNomePessoa";
            this.labNomePessoa.Size = new System.Drawing.Size(38, 13);
            this.labNomePessoa.TabIndex = 0;
            this.labNomePessoa.Text = "Nome:";
            // 
            // textNomePessoa
            // 
            this.textNomePessoa.Location = new System.Drawing.Point(13, 42);
            this.textNomePessoa.Name = "textNomePessoa";
            this.textNomePessoa.Size = new System.Drawing.Size(263, 20);
            this.textNomePessoa.TabIndex = 1;
            // 
            // butInserirPessoa
            // 
            this.butInserirPessoa.Location = new System.Drawing.Point(317, 81);
            this.butInserirPessoa.Name = "butInserirPessoa";
            this.butInserirPessoa.Size = new System.Drawing.Size(75, 23);
            this.butInserirPessoa.TabIndex = 2;
            this.butInserirPessoa.Text = "Inserir";
            this.butInserirPessoa.UseVisualStyleBackColor = true;
            this.butInserirPessoa.Click += new System.EventHandler(this.butInserirPessoa_Click);
            // 
            // butExcluirPessoa
            // 
            this.butExcluirPessoa.Location = new System.Drawing.Point(16, 81);
            this.butExcluirPessoa.Name = "butExcluirPessoa";
            this.butExcluirPessoa.Size = new System.Drawing.Size(75, 23);
            this.butExcluirPessoa.TabIndex = 5;
            this.butExcluirPessoa.Text = "Excluir";
            this.butExcluirPessoa.UseVisualStyleBackColor = true;
            // 
            // dataGridPessoas
            // 
            this.dataGridPessoas.AllowUserToAddRows = false;
            this.dataGridPessoas.AllowUserToDeleteRows = false;
            this.dataGridPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomePessoa,
            this.Gerente,
            this.colaborador});
            this.dataGridPessoas.Location = new System.Drawing.Point(12, 110);
            this.dataGridPessoas.Name = "dataGridPessoas";
            this.dataGridPessoas.ReadOnly = true;
            this.dataGridPessoas.Size = new System.Drawing.Size(380, 126);
            this.dataGridPessoas.TabIndex = 6;
            // 
            // NomePessoa
            // 
            this.NomePessoa.DataPropertyName = "NomePessoa";
            this.NomePessoa.HeaderText = "Nome Pessoa";
            this.NomePessoa.Name = "NomePessoa";
            this.NomePessoa.ReadOnly = true;
            this.NomePessoa.Width = 140;
            // 
            // Gerente
            // 
            this.Gerente.DataPropertyName = "Gerente";
            this.Gerente.HeaderText = "É Gerente?";
            this.Gerente.Name = "Gerente";
            this.Gerente.ReadOnly = true;
            this.Gerente.Width = 75;
            // 
            // colaborador
            // 
            this.colaborador.DataPropertyName = "colaborador";
            this.colaborador.HeaderText = "É Colaborador?";
            this.colaborador.Name = "colaborador";
            this.colaborador.ReadOnly = true;
            this.colaborador.Width = 105;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(404, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // butAtualizaPessoa
            // 
            this.butAtualizaPessoa.Location = new System.Drawing.Point(164, 81);
            this.butAtualizaPessoa.Name = "butAtualizaPessoa";
            this.butAtualizaPessoa.Size = new System.Drawing.Size(75, 23);
            this.butAtualizaPessoa.TabIndex = 8;
            this.butAtualizaPessoa.Text = "Atualizar";
            this.butAtualizaPessoa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioGerente);
            this.groupBox1.Controls.Add(this.radioUsuarioPadrao);
            this.groupBox1.Location = new System.Drawing.Point(282, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 50);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // radioGerente
            // 
            this.radioGerente.AutoSize = true;
            this.radioGerente.Location = new System.Drawing.Point(7, 25);
            this.radioGerente.Name = "radioGerente";
            this.radioGerente.Size = new System.Drawing.Size(63, 17);
            this.radioGerente.TabIndex = 1;
            this.radioGerente.TabStop = true;
            this.radioGerente.Text = "Gerente";
            this.radioGerente.UseVisualStyleBackColor = true;
            // 
            // radioUsuarioPadrao
            // 
            this.radioUsuarioPadrao.AutoSize = true;
            this.radioUsuarioPadrao.Location = new System.Drawing.Point(7, 6);
            this.radioUsuarioPadrao.Name = "radioUsuarioPadrao";
            this.radioUsuarioPadrao.Size = new System.Drawing.Size(98, 17);
            this.radioUsuarioPadrao.TabIndex = 0;
            this.radioUsuarioPadrao.TabStop = true;
            this.radioUsuarioPadrao.Text = "Usuario Padrao";
            this.radioUsuarioPadrao.UseVisualStyleBackColor = true;
            this.radioUsuarioPadrao.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FormPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butAtualizaPessoa);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridPessoas);
            this.Controls.Add(this.butExcluirPessoa);
            this.Controls.Add(this.butInserirPessoa);
            this.Controls.Add(this.textNomePessoa);
            this.Controls.Add(this.labNomePessoa);
            this.HelpButton = true;
            this.Name = "FormPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.FormPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPessoas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNomePessoa;
        private System.Windows.Forms.TextBox textNomePessoa;
        private System.Windows.Forms.Button butInserirPessoa;
        private System.Windows.Forms.Button butExcluirPessoa;
        private System.Windows.Forms.DataGridView dataGridPessoas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button butAtualizaPessoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioGerente;
        private System.Windows.Forms.RadioButton radioUsuarioPadrao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gerente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaborador;
    }
}