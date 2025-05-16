namespace Formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagem = new System.Windows.Forms.PictureBox();
            this.nome = new System.Windows.Forms.Label();
            this.nota1 = new System.Windows.Forms.Label();
            this.nota2 = new System.Windows.Forms.Label();
            this.fazSPA = new System.Windows.Forms.Label();
            this.disciplina = new System.Windows.Forms.Label();
            this.notaSPA = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_nota1 = new System.Windows.Forms.TextBox();
            this.tb_nota2 = new System.Windows.Forms.TextBox();
            this.tb_notaSPA = new System.Windows.Forms.TextBox();
            this.rb_nao = new System.Windows.Forms.RadioButton();
            this.rb_sim = new System.Windows.Forms.RadioButton();
            this.tb_disciplina = new System.Windows.Forms.ComboBox();
            this.box = new System.Windows.Forms.ListBox();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // imagem
            // 
            this.imagem.Image = global::Formulario.Properties.Resources.Logo_FHO_Horizontal;
            this.imagem.Location = new System.Drawing.Point(138, 12);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(505, 91);
            this.imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagem.TabIndex = 0;
            this.imagem.TabStop = false;
            this.imagem.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(112, 144);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(38, 13);
            this.nome.TabIndex = 2;
            this.nome.Text = "Nome:";
            // 
            // nota1
            // 
            this.nota1.AutoSize = true;
            this.nota1.Location = new System.Drawing.Point(112, 170);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(50, 13);
            this.nota1.TabIndex = 3;
            this.nota1.Text = "Nota N1:";
            this.nota1.Click += new System.EventHandler(this.nota1_Click);
            // 
            // nota2
            // 
            this.nota2.AutoSize = true;
            this.nota2.Location = new System.Drawing.Point(112, 196);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(50, 13);
            this.nota2.TabIndex = 4;
            this.nota2.Text = "Nota N2:";
            // 
            // fazSPA
            // 
            this.fazSPA.AutoSize = true;
            this.fazSPA.Location = new System.Drawing.Point(112, 229);
            this.fazSPA.Name = "fazSPA";
            this.fazSPA.Size = new System.Drawing.Size(54, 13);
            this.fazSPA.TabIndex = 5;
            this.fazSPA.Text = "Faz SPA?";
            // 
            // disciplina
            // 
            this.disciplina.AutoSize = true;
            this.disciplina.Location = new System.Drawing.Point(112, 261);
            this.disciplina.Name = "disciplina";
            this.disciplina.Size = new System.Drawing.Size(55, 13);
            this.disciplina.TabIndex = 6;
            this.disciplina.Text = "Disciplina:";
            // 
            // notaSPA
            // 
            this.notaSPA.AutoSize = true;
            this.notaSPA.Location = new System.Drawing.Point(341, 234);
            this.notaSPA.Name = "notaSPA";
            this.notaSPA.Size = new System.Drawing.Size(57, 13);
            this.notaSPA.TabIndex = 7;
            this.notaSPA.Text = "Nota SPA:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(169, 141);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 20);
            this.tb_nome.TabIndex = 8;
            // 
            // tb_nota1
            // 
            this.tb_nota1.Location = new System.Drawing.Point(169, 170);
            this.tb_nota1.Name = "tb_nota1";
            this.tb_nota1.Size = new System.Drawing.Size(100, 20);
            this.tb_nota1.TabIndex = 9;
            // 
            // tb_nota2
            // 
            this.tb_nota2.Location = new System.Drawing.Point(169, 196);
            this.tb_nota2.Name = "tb_nota2";
            this.tb_nota2.Size = new System.Drawing.Size(100, 20);
            this.tb_nota2.TabIndex = 10;
            // 
            // tb_notaSPA
            // 
            this.tb_notaSPA.Location = new System.Drawing.Point(404, 231);
            this.tb_notaSPA.Name = "tb_notaSPA";
            this.tb_notaSPA.Size = new System.Drawing.Size(100, 20);
            this.tb_notaSPA.TabIndex = 11;
            // 
            // rb_nao
            // 
            this.rb_nao.AutoSize = true;
            this.rb_nao.Location = new System.Drawing.Point(169, 227);
            this.rb_nao.Name = "rb_nao";
            this.rb_nao.Size = new System.Drawing.Size(45, 17);
            this.rb_nao.TabIndex = 12;
            this.rb_nao.TabStop = true;
            this.rb_nao.Text = "Não";
            this.rb_nao.UseVisualStyleBackColor = true;
            this.rb_nao.CheckedChanged += new System.EventHandler(this.rb_nao_CheckedChanged);
            // 
            // rb_sim
            // 
            this.rb_sim.AutoSize = true;
            this.rb_sim.Location = new System.Drawing.Point(220, 227);
            this.rb_sim.Name = "rb_sim";
            this.rb_sim.Size = new System.Drawing.Size(42, 17);
            this.rb_sim.TabIndex = 13;
            this.rb_sim.TabStop = true;
            this.rb_sim.Text = "Sim";
            this.rb_sim.UseVisualStyleBackColor = true;
            this.rb_sim.CheckedChanged += new System.EventHandler(this.rb_sim_CheckedChanged);
            // 
            // tb_disciplina
            // 
            this.tb_disciplina.FormattingEnabled = true;
            this.tb_disciplina.Items.AddRange(new object[] {
            "Linguagem de Programação ll",
            "Engenharia de Software l",
            "Desenvolvimento WEB ll",
            "Redes de Computadores ll",
            "Metodologia de Pesquisa",
            "Sistemas Operacionais ll"});
            this.tb_disciplina.Location = new System.Drawing.Point(169, 258);
            this.tb_disciplina.Name = "tb_disciplina";
            this.tb_disciplina.Size = new System.Drawing.Size(121, 21);
            this.tb_disciplina.TabIndex = 14;
            // 
            // box
            // 
            this.box.FormattingEnabled = true;
            this.box.Location = new System.Drawing.Point(115, 319);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(408, 95);
            this.box.TabIndex = 15;
            this.box.SelectedIndexChanged += new System.EventHandler(this.box_SelectedIndexChanged);
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(115, 285);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(99, 28);
            this.bt_calcular.TabIndex = 16;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.Location = new System.Drawing.Point(543, 325);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_remover.Size = new System.Drawing.Size(85, 34);
            this.bt_remover.TabIndex = 17;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(543, 365);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(85, 37);
            this.bt_limpar.TabIndex = 18;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.box);
            this.Controls.Add(this.tb_disciplina);
            this.Controls.Add(this.rb_sim);
            this.Controls.Add(this.rb_nao);
            this.Controls.Add(this.tb_notaSPA);
            this.Controls.Add(this.tb_nota2);
            this.Controls.Add(this.tb_nota1);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.notaSPA);
            this.Controls.Add(this.disciplina);
            this.Controls.Add(this.fazSPA);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.nota1);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.imagem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagem;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label nota1;
        private System.Windows.Forms.Label nota2;
        private System.Windows.Forms.Label fazSPA;
        private System.Windows.Forms.Label disciplina;
        private System.Windows.Forms.Label notaSPA;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_nota1;
        private System.Windows.Forms.TextBox tb_nota2;
        private System.Windows.Forms.TextBox tb_notaSPA;
        private System.Windows.Forms.RadioButton rb_nao;
        private System.Windows.Forms.RadioButton rb_sim;
        private System.Windows.Forms.ComboBox tb_disciplina;
        private System.Windows.Forms.ListBox box;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Button bt_limpar;
    }
}

