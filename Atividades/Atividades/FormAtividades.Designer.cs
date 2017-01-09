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
            this.comboProjeto = new System.Windows.Forms.ComboBox();
            this.labProjeto = new System.Windows.Forms.Label();
            this.textCodigoProjeto = new System.Windows.Forms.TextBox();
            this.labCodProjeto = new System.Windows.Forms.Label();
            this.labEntrada1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.labSaida1 = new System.Windows.Forms.Label();
            this.labPeriodo1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labPeriodo2 = new System.Windows.Forms.Label();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.labEntrada2 = new System.Windows.Forms.Label();
            this.labPeriodo3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.labSaida3 = new System.Windows.Forms.Label();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.labEntrada3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labColaborador = new System.Windows.Forms.Label();
            this.comboColaborador = new System.Windows.Forms.ComboBox();
            this.butInserirAtividade = new System.Windows.Forms.Button();
            this.butExcluirAtividade = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 363);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(688, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // comboProjeto
            // 
            this.comboProjeto.FormattingEnabled = true;
            this.comboProjeto.Location = new System.Drawing.Point(12, 40);
            this.comboProjeto.Name = "comboProjeto";
            this.comboProjeto.Size = new System.Drawing.Size(214, 21);
            this.comboProjeto.TabIndex = 2;
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
            this.textCodigoProjeto.Name = "textCodigoProjeto";
            this.textCodigoProjeto.Size = new System.Drawing.Size(76, 20);
            this.textCodigoProjeto.TabIndex = 4;
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 29);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(36, 20);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maskedTextBox2);
            this.panel1.Controls.Add(this.labSaida1);
            this.panel1.Controls.Add(this.labPeriodo1);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.labEntrada1);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 53);
            this.panel1.TabIndex = 8;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(56, 28);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(36, 20);
            this.maskedTextBox2.TabIndex = 9;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
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
            this.panel2.Controls.Add(this.maskedTextBox3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labPeriodo2);
            this.panel2.Controls.Add(this.maskedTextBox4);
            this.panel2.Controls.Add(this.labEntrada2);
            this.panel2.Location = new System.Drawing.Point(123, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 53);
            this.panel2.TabIndex = 11;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(56, 28);
            this.maskedTextBox3.Mask = "00:00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(36, 20);
            this.maskedTextBox3.TabIndex = 9;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
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
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(6, 29);
            this.maskedTextBox4.Mask = "00:00";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(36, 20);
            this.maskedTextBox4.TabIndex = 6;
            this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
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
            this.panel3.Controls.Add(this.maskedTextBox5);
            this.panel3.Controls.Add(this.labSaida3);
            this.panel3.Controls.Add(this.labPeriodo3);
            this.panel3.Controls.Add(this.maskedTextBox6);
            this.panel3.Controls.Add(this.labEntrada3);
            this.panel3.Location = new System.Drawing.Point(232, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 53);
            this.panel3.TabIndex = 12;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(56, 28);
            this.maskedTextBox5.Mask = "00:00";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(36, 20);
            this.maskedTextBox5.TabIndex = 9;
            this.maskedTextBox5.ValidatingType = typeof(System.DateTime);
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
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(6, 29);
            this.maskedTextBox6.Mask = "00:00";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(36, 20);
            this.maskedTextBox6.TabIndex = 6;
            this.maskedTextBox6.ValidatingType = typeof(System.DateTime);
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
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 137);
            this.dataGridView1.TabIndex = 14;
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
            this.comboColaborador.Location = new System.Drawing.Point(457, 43);
            this.comboColaborador.Name = "comboColaborador";
            this.comboColaborador.Size = new System.Drawing.Size(214, 21);
            this.comboColaborador.TabIndex = 15;
            // 
            // butInserirAtividade
            // 
            this.butInserirAtividade.Location = new System.Drawing.Point(596, 75);
            this.butInserirAtividade.Name = "butInserirAtividade";
            this.butInserirAtividade.Size = new System.Drawing.Size(75, 23);
            this.butInserirAtividade.TabIndex = 17;
            this.butInserirAtividade.Text = "Inserir";
            this.butInserirAtividade.UseVisualStyleBackColor = true;
            // 
            // butExcluirAtividade
            // 
            this.butExcluirAtividade.Location = new System.Drawing.Point(596, 118);
            this.butExcluirAtividade.Name = "butExcluirAtividade";
            this.butExcluirAtividade.Size = new System.Drawing.Size(75, 23);
            this.butExcluirAtividade.TabIndex = 18;
            this.butExcluirAtividade.Text = "Excluir";
            this.butExcluirAtividade.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(342, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(238, 68);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // FormAtividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 385);
            this.Controls.Add(this.richTextBox1);
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labPeriodo1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label labSaida1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labPeriodo2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label labEntrada2;
        private System.Windows.Forms.Label labPeriodo3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.Label labSaida3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
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
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

