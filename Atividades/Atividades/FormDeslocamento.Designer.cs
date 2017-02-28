namespace Atividades
{
    partial class FormDeslocamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.textObsInicio = new System.Windows.Forms.TextBox();
            this.comboUfOrigem = new System.Windows.Forms.ComboBox();
            this.comboCidadeOrigem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textHoraInicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textHoraTermino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCidadeDestino = new System.Windows.Forms.ComboBox();
            this.comboUfDestino = new System.Windows.Forms.ComboBox();
            this.textObsTermino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboProjetoVinculado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.projetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.comboUsuario = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Obs.";
            // 
            // textObsInicio
            // 
            this.textObsInicio.Location = new System.Drawing.Point(151, 48);
            this.textObsInicio.Name = "textObsInicio";
            this.textObsInicio.Size = new System.Drawing.Size(146, 20);
            this.textObsInicio.TabIndex = 2;
            // 
            // comboUfOrigem
            // 
            this.comboUfOrigem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboUfOrigem.FormattingEnabled = true;
            this.comboUfOrigem.Location = new System.Drawing.Point(59, 21);
            this.comboUfOrigem.Name = "comboUfOrigem";
            this.comboUfOrigem.Size = new System.Drawing.Size(59, 21);
            this.comboUfOrigem.TabIndex = 3;
            this.comboUfOrigem.SelectedIndexChanged += new System.EventHandler(this.comboUfOrigem_SelectedIndexChanged);
            // 
            // comboCidadeOrigem
            // 
            this.comboCidadeOrigem.FormattingEnabled = true;
            this.comboCidadeOrigem.Location = new System.Drawing.Point(126, 21);
            this.comboCidadeOrigem.Name = "comboCidadeOrigem";
            this.comboCidadeOrigem.Size = new System.Drawing.Size(171, 21);
            this.comboCidadeOrigem.TabIndex = 4;
            this.comboCidadeOrigem.SelectedIndexChanged += new System.EventHandler(this.comboCidadeOrigem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Origem";
            // 
            // textHoraInicio
            // 
            this.textHoraInicio.Location = new System.Drawing.Point(59, 48);
            this.textHoraInicio.Name = "textHoraInicio";
            this.textHoraInicio.Size = new System.Drawing.Size(59, 20);
            this.textHoraInicio.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Início";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Término";
            // 
            // textHoraTermino
            // 
            this.textHoraTermino.Location = new System.Drawing.Point(59, 108);
            this.textHoraTermino.Name = "textHoraTermino";
            this.textHoraTermino.Size = new System.Drawing.Size(59, 20);
            this.textHoraTermino.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Obs.";
            // 
            // comboCidadeDestino
            // 
            this.comboCidadeDestino.FormattingEnabled = true;
            this.comboCidadeDestino.Location = new System.Drawing.Point(126, 78);
            this.comboCidadeDestino.Name = "comboCidadeDestino";
            this.comboCidadeDestino.Size = new System.Drawing.Size(171, 21);
            this.comboCidadeDestino.TabIndex = 11;
            this.comboCidadeDestino.SelectedIndexChanged += new System.EventHandler(this.comboCidadeDestino_SelectedIndexChanged);
            // 
            // comboUfDestino
            // 
            this.comboUfDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboUfDestino.FormattingEnabled = true;
            this.comboUfDestino.Location = new System.Drawing.Point(59, 78);
            this.comboUfDestino.Name = "comboUfDestino";
            this.comboUfDestino.Size = new System.Drawing.Size(59, 21);
            this.comboUfDestino.TabIndex = 10;
            this.comboUfDestino.SelectedIndexChanged += new System.EventHandler(this.comboUfDestino_SelectedIndexChanged);
            // 
            // textObsTermino
            // 
            this.textObsTermino.Location = new System.Drawing.Point(151, 108);
            this.textObsTermino.Name = "textObsTermino";
            this.textObsTermino.Size = new System.Drawing.Size(146, 20);
            this.textObsTermino.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Destino";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 88);
            this.dataGridView1.TabIndex = 15;
            // 
            // comboProjetoVinculado
            // 
            this.comboProjetoVinculado.FormattingEnabled = true;
            this.comboProjetoVinculado.Location = new System.Drawing.Point(109, 134);
            this.comboProjetoVinculado.Name = "comboProjetoVinculado";
            this.comboProjetoVinculado.Size = new System.Drawing.Size(188, 21);
            this.comboProjetoVinculado.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Projeto Vinculado";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projetosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(413, 24);
            this.menuStrip.TabIndex = 18;
            this.menuStrip.Text = "menuStrip2";
            // 
            // projetosToolStripMenuItem
            // 
            this.projetosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cidadesToolStripMenuItem,
            this.pessoasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.projetosToolStripMenuItem.Name = "projetosToolStripMenuItem";
            this.projetosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.projetosToolStripMenuItem.Text = "&Cadastro";
            // 
            // cidadesToolStripMenuItem
            // 
            this.cidadesToolStripMenuItem.Name = "cidadesToolStripMenuItem";
            this.cidadesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.cidadesToolStripMenuItem.Text = "&Projeto";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pessoasToolStripMenuItem.Text = "&Cidades";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(318, 134);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 19;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(318, 86);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 20;
            this.buttonInsert.Text = "Inserir";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(318, 110);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 21;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            // 
            // comboUsuario
            // 
            this.comboUsuario.FormattingEnabled = true;
            this.comboUsuario.Location = new System.Drawing.Point(318, 59);
            this.comboUsuario.Name = "comboUsuario";
            this.comboUsuario.Size = new System.Drawing.Size(75, 21);
            this.comboUsuario.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Usuário";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(303, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(90, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // FormDeslocamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboUsuario);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboProjetoVinculado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textHoraTermino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboCidadeDestino);
            this.Controls.Add(this.comboUfDestino);
            this.Controls.Add(this.textObsTermino);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textHoraInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboCidadeOrigem);
            this.Controls.Add(this.comboUfOrigem);
            this.Controls.Add(this.textObsInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.MaximizeBox = false;
            this.Name = "FormDeslocamento";
            this.Text = "Informe Deslocamentos";
            this.Load += new System.EventHandler(this.FormDeslocamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textObsInicio;
        private System.Windows.Forms.ComboBox comboUfOrigem;
        private System.Windows.Forms.ComboBox comboCidadeOrigem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textHoraInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textHoraTermino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboCidadeDestino;
        private System.Windows.Forms.ComboBox comboUfDestino;
        private System.Windows.Forms.TextBox textObsTermino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboProjetoVinculado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem projetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.ComboBox comboUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}