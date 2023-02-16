namespace TechGeneric
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
            this.txbCod = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbSexo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSalario = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.lboCodigo = new System.Windows.Forms.ListBox();
            this.lboNome = new System.Windows.Forms.ListBox();
            this.lboEndereco = new System.Windows.Forms.ListBox();
            this.lboSexo = new System.Windows.Forms.ListBox();
            this.lboSalario = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txbCod
            // 
            this.txbCod.Location = new System.Drawing.Point(74, 10);
            this.txbCod.Name = "txbCod";
            this.txbCod.Size = new System.Drawing.Size(100, 20);
            this.txbCod.TabIndex = 0;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(74, 112);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 1;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(74, 148);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(100, 20);
            this.txbEndereco.TabIndex = 2;
            // 
            // txbSexo
            // 
            this.txbSexo.Location = new System.Drawing.Point(74, 183);
            this.txbSexo.Name = "txbSexo";
            this.txbSexo.Size = new System.Drawing.Size(100, 20);
            this.txbSexo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endereco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Salário";
            // 
            // txbSalario
            // 
            this.txbSalario.Location = new System.Drawing.Point(74, 219);
            this.txbSalario.Name = "txbSalario";
            this.txbSalario.Size = new System.Drawing.Size(100, 20);
            this.txbSalario.TabIndex = 4;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 276);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Adicionar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(110, 276);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 11;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnRemover
            // 
            this.BtnRemover.Location = new System.Drawing.Point(12, 324);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(75, 23);
            this.BtnRemover.TabIndex = 12;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(110, 324);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 13;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // lboCodigo
            // 
            this.lboCodigo.FormattingEnabled = true;
            this.lboCodigo.Location = new System.Drawing.Point(242, 13);
            this.lboCodigo.Name = "lboCodigo";
            this.lboCodigo.Size = new System.Drawing.Size(29, 329);
            this.lboCodigo.TabIndex = 14;
            this.lboCodigo.SelectedIndexChanged += new System.EventHandler(this.lboCodigo_SelectedIndexChanged);
            // 
            // lboNome
            // 
            this.lboNome.FormattingEnabled = true;
            this.lboNome.Location = new System.Drawing.Point(277, 13);
            this.lboNome.Name = "lboNome";
            this.lboNome.Size = new System.Drawing.Size(117, 329);
            this.lboNome.TabIndex = 15;
            // 
            // lboEndereco
            // 
            this.lboEndereco.FormattingEnabled = true;
            this.lboEndereco.Location = new System.Drawing.Point(400, 13);
            this.lboEndereco.Name = "lboEndereco";
            this.lboEndereco.Size = new System.Drawing.Size(122, 329);
            this.lboEndereco.TabIndex = 16;
            // 
            // lboSexo
            // 
            this.lboSexo.FormattingEnabled = true;
            this.lboSexo.Location = new System.Drawing.Point(528, 13);
            this.lboSexo.Name = "lboSexo";
            this.lboSexo.Size = new System.Drawing.Size(90, 329);
            this.lboSexo.TabIndex = 17;
            // 
            // lboSalario
            // 
            this.lboSalario.FormattingEnabled = true;
            this.lboSalario.Location = new System.Drawing.Point(624, 13);
            this.lboSalario.Name = "lboSalario";
            this.lboSalario.Size = new System.Drawing.Size(149, 329);
            this.lboSalario.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lboSalario);
            this.Controls.Add(this.lboSexo);
            this.Controls.Add(this.lboEndereco);
            this.Controls.Add(this.lboNome);
            this.Controls.Add(this.lboCodigo);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSalario);
            this.Controls.Add(this.txbSexo);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbCod);
            this.Name = "Form1";
            this.Text = "TechGeneric";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCod;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbSexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSalario;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.ListBox lboCodigo;
        private System.Windows.Forms.ListBox lboNome;
        private System.Windows.Forms.ListBox lboEndereco;
        private System.Windows.Forms.ListBox lboSexo;
        private System.Windows.Forms.ListBox lboSalario;
    }
}

