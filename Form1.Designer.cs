namespace wfa_SistemaGestao
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
            this.components = new System.ComponentModel.Container();
            this.lblcdp = new System.Windows.Forms.Label();
            this.rbPessoaf = new System.Windows.Forms.RadioButton();
            this.rbPessoaj = new System.Windows.Forms.RadioButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.tbxCidade = new System.Windows.Forms.TextBox();
            this.lblSalarioFaturamento = new System.Windows.Forms.Label();
            this.tbxSalarioFaturamento = new System.Windows.Forms.TextBox();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblFilhosFuncionarios = new System.Windows.Forms.Label();
            this.lblNomeF = new System.Windows.Forms.Label();
            this.tbxFilhosFuncionarios = new System.Windows.Forms.TextBox();
            this.tbxNomeF = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mtbCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lvPf = new System.Windows.Forms.ListView();
            this.lvPj = new System.Windows.Forms.ListView();
            this.btnSalvarCSV = new System.Windows.Forms.Button();
            this.btnAbrirCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcdp
            // 
            this.lblcdp.AutoSize = true;
            this.lblcdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcdp.Location = new System.Drawing.Point(283, 9);
            this.lblcdp.Name = "lblcdp";
            this.lblcdp.Size = new System.Drawing.Size(270, 32);
            this.lblcdp.TabIndex = 1;
            this.lblcdp.Text = "Cadastro de Pessoa";
            // 
            // rbPessoaf
            // 
            this.rbPessoaf.AutoSize = true;
            this.rbPessoaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPessoaf.Location = new System.Drawing.Point(192, 58);
            this.rbPessoaf.Name = "rbPessoaf";
            this.rbPessoaf.Size = new System.Drawing.Size(136, 24);
            this.rbPessoaf.TabIndex = 2;
            this.rbPessoaf.TabStop = true;
            this.rbPessoaf.Text = "Pessoa Física";
            this.rbPessoaf.UseVisualStyleBackColor = true;
            this.rbPessoaf.CheckedChanged += new System.EventHandler(this.rbPessoaf_CheckedChanged);
            // 
            // rbPessoaj
            // 
            this.rbPessoaj.AutoSize = true;
            this.rbPessoaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPessoaj.Location = new System.Drawing.Point(452, 58);
            this.rbPessoaj.Name = "rbPessoaj";
            this.rbPessoaj.Size = new System.Drawing.Size(150, 24);
            this.rbPessoaj.TabIndex = 3;
            this.rbPessoaj.TabStop = true;
            this.rbPessoaj.Text = "Pessoa Jurídica";
            this.rbPessoaj.UseVisualStyleBackColor = true;
            this.rbPessoaj.CheckedChanged += new System.EventHandler(this.rbPessoaj_CheckedChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 125);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 16);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome :";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(27, 165);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(57, 16);
            this.lblCidade.TabIndex = 5;
            this.lblCidade.Text = "Cidade :";
            // 
            // tbxCidade
            // 
            this.tbxCidade.Location = new System.Drawing.Point(113, 162);
            this.tbxCidade.Name = "tbxCidade";
            this.tbxCidade.Size = new System.Drawing.Size(285, 22);
            this.tbxCidade.TabIndex = 6;
            this.tbxCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCidade_KeyPress);
            this.tbxCidade.Leave += new System.EventHandler(this.tbxCidade_Leave);
            // 
            // lblSalarioFaturamento
            // 
            this.lblSalarioFaturamento.AutoSize = true;
            this.lblSalarioFaturamento.Location = new System.Drawing.Point(21, 203);
            this.lblSalarioFaturamento.Name = "lblSalarioFaturamento";
            this.lblSalarioFaturamento.Size = new System.Drawing.Size(56, 16);
            this.lblSalarioFaturamento.TabIndex = 7;
            this.lblSalarioFaturamento.Text = "Salário :";
            // 
            // tbxSalarioFaturamento
            // 
            this.tbxSalarioFaturamento.Location = new System.Drawing.Point(113, 200);
            this.tbxSalarioFaturamento.Name = "tbxSalarioFaturamento";
            this.tbxSalarioFaturamento.Size = new System.Drawing.Size(285, 22);
            this.tbxSalarioFaturamento.TabIndex = 8;
            this.tbxSalarioFaturamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSalarioFaturamento_KeyPress);
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(494, 125);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(39, 16);
            this.lblCpfCnpj.TabIndex = 9;
            this.lblCpfCnpj.Text = "CPF :";
            // 
            // lblFilhosFuncionarios
            // 
            this.lblFilhosFuncionarios.AutoSize = true;
            this.lblFilhosFuncionarios.Location = new System.Drawing.Point(437, 168);
            this.lblFilhosFuncionarios.Name = "lblFilhosFuncionarios";
            this.lblFilhosFuncionarios.Size = new System.Drawing.Size(80, 16);
            this.lblFilhosFuncionarios.TabIndex = 10;
            this.lblFilhosFuncionarios.Text = "Qntd Filhos :";
            // 
            // lblNomeF
            // 
            this.lblNomeF.AutoSize = true;
            this.lblNomeF.Location = new System.Drawing.Point(437, 203);
            this.lblNomeF.Name = "lblNomeF";
            this.lblNomeF.Size = new System.Drawing.Size(105, 16);
            this.lblNomeF.TabIndex = 11;
            this.lblNomeF.Text = "Nome Fantasia :";
            // 
            // tbxFilhosFuncionarios
            // 
            this.tbxFilhosFuncionarios.Location = new System.Drawing.Point(563, 165);
            this.tbxFilhosFuncionarios.Name = "tbxFilhosFuncionarios";
            this.tbxFilhosFuncionarios.Size = new System.Drawing.Size(285, 22);
            this.tbxFilhosFuncionarios.TabIndex = 13;
            this.tbxFilhosFuncionarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFilhosFuncionarios_KeyPress);
            // 
            // tbxNomeF
            // 
            this.tbxNomeF.Location = new System.Drawing.Point(563, 203);
            this.tbxNomeF.Name = "tbxNomeF";
            this.tbxNomeF.Size = new System.Drawing.Size(285, 22);
            this.tbxNomeF.TabIndex = 14;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(30, 265);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(136, 46);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(256, 265);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(142, 46);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(113, 122);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(285, 22);
            this.tbxNome.TabIndex = 19;
            this.tbxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNome_KeyPress);
            this.tbxNome.Leave += new System.EventHandler(this.tbxNome_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mtbCpfCnpj
            // 
            this.mtbCpfCnpj.Location = new System.Drawing.Point(563, 122);
            this.mtbCpfCnpj.Name = "mtbCpfCnpj";
            this.mtbCpfCnpj.Size = new System.Drawing.Size(285, 22);
            this.mtbCpfCnpj.TabIndex = 21;
            // 
            // lvPf
            // 
            this.lvPf.HideSelection = false;
            this.lvPf.Location = new System.Drawing.Point(30, 333);
            this.lvPf.Name = "lvPf";
            this.lvPf.Size = new System.Drawing.Size(818, 101);
            this.lvPf.TabIndex = 22;
            this.lvPf.UseCompatibleStateImageBehavior = false;
            // 
            // lvPj
            // 
            this.lvPj.HideSelection = false;
            this.lvPj.Location = new System.Drawing.Point(30, 453);
            this.lvPj.Name = "lvPj";
            this.lvPj.Size = new System.Drawing.Size(818, 97);
            this.lvPj.TabIndex = 23;
            this.lvPj.UseCompatibleStateImageBehavior = false;
            // 
            // btnSalvarCSV
            // 
            this.btnSalvarCSV.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalvarCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCSV.Location = new System.Drawing.Point(497, 264);
            this.btnSalvarCSV.Name = "btnSalvarCSV";
            this.btnSalvarCSV.Size = new System.Drawing.Size(136, 46);
            this.btnSalvarCSV.TabIndex = 15;
            this.btnSalvarCSV.Text = "Salvar Dados";
            this.btnSalvarCSV.UseVisualStyleBackColor = false;
            this.btnSalvarCSV.Click += new System.EventHandler(this.btnSalvarCSV_Click);
            // 
            // btnAbrirCSV
            // 
            this.btnAbrirCSV.BackColor = System.Drawing.SystemColors.Control;
            this.btnAbrirCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCSV.Location = new System.Drawing.Point(706, 265);
            this.btnAbrirCSV.Name = "btnAbrirCSV";
            this.btnAbrirCSV.Size = new System.Drawing.Size(142, 46);
            this.btnAbrirCSV.TabIndex = 16;
            this.btnAbrirCSV.Text = "Abrir Dados Salvos";
            this.btnAbrirCSV.UseVisualStyleBackColor = false;
            this.btnAbrirCSV.Click += new System.EventHandler(this.btnAbrirCSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 580);
            this.Controls.Add(this.lvPj);
            this.Controls.Add(this.lvPf);
            this.Controls.Add(this.mtbCpfCnpj);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.btnAbrirCSV);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvarCSV);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tbxNomeF);
            this.Controls.Add(this.tbxFilhosFuncionarios);
            this.Controls.Add(this.lblNomeF);
            this.Controls.Add(this.lblFilhosFuncionarios);
            this.Controls.Add(this.lblCpfCnpj);
            this.Controls.Add(this.tbxSalarioFaturamento);
            this.Controls.Add(this.lblSalarioFaturamento);
            this.Controls.Add(this.tbxCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.rbPessoaj);
            this.Controls.Add(this.rbPessoaf);
            this.Controls.Add(this.lblcdp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcdp;
        private System.Windows.Forms.RadioButton rbPessoaf;
        private System.Windows.Forms.RadioButton rbPessoaj;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox tbxCidade;
        private System.Windows.Forms.Label lblSalarioFaturamento;
        private System.Windows.Forms.TextBox tbxSalarioFaturamento;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.Label lblFilhosFuncionarios;
        private System.Windows.Forms.Label lblNomeF;
        private System.Windows.Forms.TextBox tbxFilhosFuncionarios;
        private System.Windows.Forms.TextBox tbxNomeF;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MaskedTextBox mtbCpfCnpj;
        private System.Windows.Forms.ListView lvPf;
        private System.Windows.Forms.ListView lvPj;
        private System.Windows.Forms.Button btnSalvarCSV;
        private System.Windows.Forms.Button btnAbrirCSV;
    }
}

