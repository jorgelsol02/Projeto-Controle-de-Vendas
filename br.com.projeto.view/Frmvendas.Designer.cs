namespace Projeto_Controle_de_Vendas.br.com.projeto.view
{
    partial class Frmvendas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.brnremover = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.preco = new System.Windows.Forms.Label();
            this.quantidade = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.labelcodigo = new System.Windows.Forms.Label();
            this.tabelaProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnpagamento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(278, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tela de Vendas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 101);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdata);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcpf);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtdata.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtdata.Location = new System.Drawing.Point(78, 20);
            this.txtdata.Margin = new System.Windows.Forms.Padding(4);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(123, 26);
            this.txtdata.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(19, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Data";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtnome.Location = new System.Drawing.Point(79, 101);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(292, 26);
            this.txtnome.TabIndex = 21;
            this.txtnome.TextChanged += new System.EventHandler(this.textnome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(20, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nome";
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtcpf.Location = new System.Drawing.Point(79, 65);
            this.txtcpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtcpf.Mask = "###,###,###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(122, 26);
            this.txtcpf.TabIndex = 19;
            this.txtcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtcpf_MaskInputRejected);
            this.txtcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcpf_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(19, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "CPF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.brnremover);
            this.groupBox2.Controls.Add(this.btnadd);
            this.groupBox2.Controls.Add(this.txtpreco);
            this.groupBox2.Controls.Add(this.txtqtd);
            this.groupBox2.Controls.Add(this.preco);
            this.groupBox2.Controls.Add(this.quantidade);
            this.groupBox2.Controls.Add(this.txtdesc);
            this.groupBox2.Controls.Add(this.desc);
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.labelcodigo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(12, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 205);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // brnremover
            // 
            this.brnremover.BackColor = System.Drawing.SystemColors.Highlight;
            this.brnremover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnremover.Location = new System.Drawing.Point(211, 162);
            this.brnremover.Margin = new System.Windows.Forms.Padding(4);
            this.brnremover.Name = "brnremover";
            this.brnremover.Size = new System.Drawing.Size(131, 33);
            this.brnremover.TabIndex = 16;
            this.brnremover.Text = "Remover Item";
            this.brnremover.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(35, 162);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(131, 33);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Adicionar Item";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // txtpreco
            // 
            this.txtpreco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtpreco.Location = new System.Drawing.Point(94, 112);
            this.txtpreco.Margin = new System.Windows.Forms.Padding(4);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(92, 26);
            this.txtpreco.TabIndex = 15;
            this.txtpreco.TextChanged += new System.EventHandler(this.txtpreco_TextChanged);
            // 
            // txtqtd
            // 
            this.txtqtd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtqtd.Location = new System.Drawing.Point(273, 112);
            this.txtqtd.Margin = new System.Windows.Forms.Padding(4);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(98, 26);
            this.txtqtd.TabIndex = 13;
            this.txtqtd.TextChanged += new System.EventHandler(this.txtqtd_TextChanged);
            // 
            // preco
            // 
            this.preco.AutoSize = true;
            this.preco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.preco.Location = new System.Drawing.Point(7, 115);
            this.preco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(85, 20);
            this.preco.TabIndex = 14;
            this.preco.Text = "Preço (R$)";
            this.preco.Click += new System.EventHandler(this.preco_Click);
            // 
            // quantidade
            // 
            this.quantidade.AutoSize = true;
            this.quantidade.ForeColor = System.Drawing.SystemColors.Highlight;
            this.quantidade.Location = new System.Drawing.Point(230, 115);
            this.quantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(39, 20);
            this.quantidade.TabIndex = 12;
            this.quantidade.Text = "Qtd:";
            this.quantidade.Click += new System.EventHandler(this.quantidade_Click);
            // 
            // txtdesc
            // 
            this.txtdesc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtdesc.Location = new System.Drawing.Point(94, 60);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(277, 26);
            this.txtdesc.TabIndex = 11;
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.desc.Location = new System.Drawing.Point(11, 66);
            this.desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(75, 20);
            this.desc.TabIndex = 10;
            this.desc.Text = "Descição";
            this.desc.Click += new System.EventHandler(this.desc_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtcodigo.Location = new System.Drawing.Point(94, 20);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(61, 26);
            this.txtcodigo.TabIndex = 9;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // labelcodigo
            // 
            this.labelcodigo.AutoSize = true;
            this.labelcodigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelcodigo.Location = new System.Drawing.Point(10, 26);
            this.labelcodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcodigo.Name = "labelcodigo";
            this.labelcodigo.Size = new System.Drawing.Size(59, 20);
            this.labelcodigo.TabIndex = 8;
            this.labelcodigo.Text = "Código";
            // 
            // tabelaProdutos
            // 
            this.tabelaProdutos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabelaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaProdutos.Location = new System.Drawing.Point(448, 108);
            this.tabelaProdutos.Name = "tabelaProdutos";
            this.tabelaProdutos.Size = new System.Drawing.Size(449, 367);
            this.tabelaProdutos.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(448, 481);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 73);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.Location = new System.Drawing.Point(128, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 26);
            this.textBox1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total (R$):";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(710, 561);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(153, 50);
            this.btncancelar.TabIndex = 18;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnpagamento
            // 
            this.btnpagamento.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnpagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagamento.Location = new System.Drawing.Point(509, 561);
            this.btnpagamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnpagamento.Name = "btnpagamento";
            this.btnpagamento.Size = new System.Drawing.Size(148, 50);
            this.btnpagamento.TabIndex = 17;
            this.btnpagamento.Text = "Pagamento";
            this.btnpagamento.UseVisualStyleBackColor = false;
            // 
            // Frmvendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 614);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnpagamento);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabelaProdutos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frmvendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Vendas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label labelcodigo;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label preco;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.Label quantidade;
        private System.Windows.Forms.Button brnremover;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView tabelaProdutos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnpagamento;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Label label4;
    }
}