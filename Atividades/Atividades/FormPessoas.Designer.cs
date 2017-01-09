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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butInserirPessoa = new System.Windows.Forms.Button();
            this.checkPessoaPadrao = new System.Windows.Forms.CheckBox();
            this.checkPessoaGerente = new System.Windows.Forms.CheckBox();
            this.butExcluirPessoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 1;
            // 
            // butInserirPessoa
            // 
            this.butInserirPessoa.Location = new System.Drawing.Point(13, 81);
            this.butInserirPessoa.Name = "butInserirPessoa";
            this.butInserirPessoa.Size = new System.Drawing.Size(75, 23);
            this.butInserirPessoa.TabIndex = 2;
            this.butInserirPessoa.Text = "Inserir";
            this.butInserirPessoa.UseVisualStyleBackColor = true;
            // 
            // checkPessoaPadrao
            // 
            this.checkPessoaPadrao.AutoSize = true;
            this.checkPessoaPadrao.Location = new System.Drawing.Point(192, 32);
            this.checkPessoaPadrao.Name = "checkPessoaPadrao";
            this.checkPessoaPadrao.Size = new System.Drawing.Size(99, 17);
            this.checkPessoaPadrao.TabIndex = 3;
            this.checkPessoaPadrao.Text = "Usuario Padrao";
            this.checkPessoaPadrao.UseVisualStyleBackColor = true;
            // 
            // checkPessoaGerente
            // 
            this.checkPessoaGerente.AutoSize = true;
            this.checkPessoaGerente.Location = new System.Drawing.Point(192, 55);
            this.checkPessoaGerente.Name = "checkPessoaGerente";
            this.checkPessoaGerente.Size = new System.Drawing.Size(64, 17);
            this.checkPessoaGerente.TabIndex = 4;
            this.checkPessoaGerente.Text = "Gerente";
            this.checkPessoaGerente.UseVisualStyleBackColor = true;
            // 
            // butExcluirPessoa
            // 
            this.butExcluirPessoa.Location = new System.Drawing.Point(181, 81);
            this.butExcluirPessoa.Name = "butExcluirPessoa";
            this.butExcluirPessoa.Size = new System.Drawing.Size(75, 23);
            this.butExcluirPessoa.TabIndex = 5;
            this.butExcluirPessoa.Text = "Excluir";
            this.butExcluirPessoa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(279, 126);
            this.dataGridView1.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(308, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FormPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butExcluirPessoa);
            this.Controls.Add(this.checkPessoaGerente);
            this.Controls.Add(this.checkPessoaPadrao);
            this.Controls.Add(this.butInserirPessoa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labNomePessoa);
            this.HelpButton = true;
            this.Name = "FormPessoas";
            this.Text = "Cadastro de Pessoas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNomePessoa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butInserirPessoa;
        private System.Windows.Forms.CheckBox checkPessoaPadrao;
        private System.Windows.Forms.CheckBox checkPessoaGerente;
        private System.Windows.Forms.Button butExcluirPessoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}