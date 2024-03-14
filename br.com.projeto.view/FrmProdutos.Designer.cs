namespace Projeto_Controle_de_Vendas.br.com.projeto.view
{
    partial class FrmProdutos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProdutos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbfornecedor = new System.Windows.Forms.ComboBox();
            this.txtfornecedor = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.preco = new System.Windows.Forms.Label();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.quantidade = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.labelcodigo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabelaProdutos = new System.Windows.Forms.DataGridView();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.textpesquisa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabProdutos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 101);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.tabPage1);
            this.tabProdutos.Controls.Add(this.tabPage2);
            this.tabProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProdutos.Location = new System.Drawing.Point(19, 102);
            this.tabProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(899, 429);
            this.tabProdutos.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbfornecedor);
            this.tabPage1.Controls.Add(this.txtfornecedor);
            this.tabPage1.Controls.Add(this.txtpreco);
            this.tabPage1.Controls.Add(this.preco);
            this.tabPage1.Controls.Add(this.txtqtd);
            this.tabPage1.Controls.Add(this.quantidade);
            this.tabPage1.Controls.Add(this.txtdesc);
            this.tabPage1.Controls.Add(this.desc);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.labelcodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(891, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbfornecedor
            // 
            this.cbfornecedor.FormattingEnabled = true;
            this.cbfornecedor.Location = new System.Drawing.Point(121, 156);
            this.cbfornecedor.Name = "cbfornecedor";
            this.cbfornecedor.Size = new System.Drawing.Size(256, 28);
            this.cbfornecedor.TabIndex = 16;
            // 
            // txtfornecedor
            // 
            this.txtfornecedor.AutoSize = true;
            this.txtfornecedor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtfornecedor.Location = new System.Drawing.Point(14, 164);
            this.txtfornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtfornecedor.Name = "txtfornecedor";
            this.txtfornecedor.Size = new System.Drawing.Size(91, 20);
            this.txtfornecedor.TabIndex = 14;
            this.txtfornecedor.Text = "Fornecedor";
            // 
            // txtpreco
            // 
            this.txtpreco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtpreco.Location = new System.Drawing.Point(594, 70);
            this.txtpreco.Margin = new System.Windows.Forms.Padding(4);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(92, 26);
            this.txtpreco.TabIndex = 13;
            // 
            // preco
            // 
            this.preco.AutoSize = true;
            this.preco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.preco.Location = new System.Drawing.Point(509, 73);
            this.preco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(85, 20);
            this.preco.TabIndex = 12;
            this.preco.Text = "Preço (R$)";
            // 
            // txtqtd
            // 
            this.txtqtd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtqtd.Location = new System.Drawing.Point(121, 111);
            this.txtqtd.Margin = new System.Windows.Forms.Padding(4);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(98, 26);
            this.txtqtd.TabIndex = 11;
            // 
            // quantidade
            // 
            this.quantidade.AutoSize = true;
            this.quantidade.ForeColor = System.Drawing.SystemColors.Highlight;
            this.quantidade.Location = new System.Drawing.Point(14, 117);
            this.quantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(99, 20);
            this.quantidade.TabIndex = 10;
            this.quantidade.Text = "Qtd Estoque";
            // 
            // txtdesc
            // 
            this.txtdesc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtdesc.Location = new System.Drawing.Point(121, 70);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(380, 26);
            this.txtdesc.TabIndex = 9;
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.desc.Location = new System.Drawing.Point(30, 76);
            this.desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(75, 20);
            this.desc.TabIndex = 8;
            this.desc.Text = "Descição";
            // 
            // txtcodigo
            // 
            this.txtcodigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtcodigo.Location = new System.Drawing.Point(121, 27);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(116, 26);
            this.txtcodigo.TabIndex = 7;
            // 
            // labelcodigo
            // 
            this.labelcodigo.AutoSize = true;
            this.labelcodigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelcodigo.Location = new System.Drawing.Point(46, 33);
            this.labelcodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcodigo.Name = "labelcodigo";
            this.labelcodigo.Size = new System.Drawing.Size(59, 20);
            this.labelcodigo.TabIndex = 6;
            this.labelcodigo.Text = "Código";
            this.labelcodigo.Click += new System.EventHandler(this.txtcodigo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabelaProdutos);
            this.tabPage2.Controls.Add(this.btnpesquisar);
            this.tabPage2.Controls.Add(this.textpesquisa);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(891, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabelaProdutos
            // 
            this.tabelaProdutos.AllowUserToAddRows = false;
            this.tabelaProdutos.AllowUserToDeleteRows = false;
            this.tabelaProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabelaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaProdutos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabelaProdutos.Location = new System.Drawing.Point(4, 102);
            this.tabelaProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.tabelaProdutos.Name = "tabelaProdutos";
            this.tabelaProdutos.ReadOnly = true;
            this.tabelaProdutos.Size = new System.Drawing.Size(869, 282);
            this.tabelaProdutos.TabIndex = 12;
            this.tabelaProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaProdutos_CellClick);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnpesquisar.Location = new System.Drawing.Point(507, 25);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(131, 32);
            this.btnpesquisar.TabIndex = 6;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // textpesquisa
            // 
            this.textpesquisa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textpesquisa.Location = new System.Drawing.Point(104, 25);
            this.textpesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.textpesquisa.Name = "textpesquisa";
            this.textpesquisa.Size = new System.Drawing.Size(380, 26);
            this.textpesquisa.TabIndex = 11;
            this.textpesquisa.TextChanged += new System.EventHandler(this.textpesquisa_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(15, 32);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "Nome";
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btneditar.Location = new System.Drawing.Point(696, 535);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(131, 55);
            this.btneditar.TabIndex = 9;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnexcluir.Location = new System.Drawing.Point(519, 535);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(131, 55);
            this.btnexcluir.TabIndex = 8;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsalvar.Location = new System.Drawing.Point(332, 535);
            this.btnsalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(131, 55);
            this.btnsalvar.TabIndex = 7;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnnovo.Location = new System.Drawing.Point(162, 535);
            this.btnnovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(131, 55);
            this.btnnovo.TabIndex = 6;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 595);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.tabProdutos);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabProdutos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabProdutos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView tabelaProdutos;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox textpesquisa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbfornecedor;
        private System.Windows.Forms.Label txtfornecedor;
        private System.Windows.Forms.Label preco;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.Label quantidade;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label labelcodigo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.TextBox txtpreco;
    }
}