namespace Atividades
{
    partial class FormCidades
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
            this.comboCadatroUF = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCadastroCidade = new System.Windows.Forms.TextBox();
            this.Inserir = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridCidades = new System.Windows.Forms.DataGridView();
            this.codCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // comboCadatroUF
            // 
            this.comboCadatroUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboCadatroUF.FormattingEnabled = true;
            this.comboCadatroUF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboCadatroUF.Location = new System.Drawing.Point(13, 50);
            this.comboCadatroUF.MaxLength = 2;
            this.comboCadatroUF.Name = "comboCadatroUF";
            this.comboCadatroUF.Size = new System.Drawing.Size(121, 21);
            this.comboCadatroUF.TabIndex = 0;
            this.comboCadatroUF.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione uma UF:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textCadastroCidade
            // 
            this.textCadastroCidade.Location = new System.Drawing.Point(172, 50);
            this.textCadastroCidade.Name = "textCadastroCidade";
            this.textCadastroCidade.Size = new System.Drawing.Size(218, 20);
            this.textCadastroCidade.TabIndex = 2;
            // 
            // Inserir
            // 
            this.Inserir.Location = new System.Drawing.Point(315, 99);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(75, 23);
            this.Inserir.TabIndex = 3;
            this.Inserir.Text = "Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(157, 99);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(75, 23);
            this.Atualizar.TabIndex = 4;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(16, 99);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 5;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cidade:";
            // 
            // dataGridCidades
            // 
            this.dataGridCidades.AllowUserToAddRows = false;
            this.dataGridCidades.AllowUserToDeleteRows = false;
            this.dataGridCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCidade,
            this.codUf,
            this.nomeCidade});
            this.dataGridCidades.Location = new System.Drawing.Point(16, 128);
            this.dataGridCidades.Name = "dataGridCidades";
            this.dataGridCidades.ReadOnly = true;
            this.dataGridCidades.Size = new System.Drawing.Size(374, 121);
            this.dataGridCidades.TabIndex = 8;
            // 
            // codCidade
            // 
            this.codCidade.DataPropertyName = "codCidade";
            this.codCidade.HeaderText = "Cod.";
            this.codCidade.Name = "codCidade";
            this.codCidade.ReadOnly = true;
            this.codCidade.Width = 80;
            // 
            // codUf
            // 
            this.codUf.DataPropertyName = "codUf";
            this.codUf.HeaderText = "UF";
            this.codUf.Name = "codUf";
            this.codUf.ReadOnly = true;
            this.codUf.Width = 70;
            // 
            // nomeCidade
            // 
            this.nomeCidade.DataPropertyName = "nomeCidade";
            this.nomeCidade.HeaderText = "Cidade";
            this.nomeCidade.Name = "nomeCidade";
            this.nomeCidade.ReadOnly = true;
            this.nomeCidade.Width = 170;
            // 
            // FormCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.dataGridCidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.textCadastroCidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCadatroUF);
            this.Name = "FormCidades";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro Cidades";
            this.Load += new System.EventHandler(this.FormCidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCadatroUF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCadastroCidade;
        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridCidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCidade;
    }
}