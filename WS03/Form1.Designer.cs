namespace WS03
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
            this.btnLocalizarQuarto = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.cbxTipoQuarto = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroQuarto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeDoutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLocalizarQuarto
            // 
            this.btnLocalizarQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLocalizarQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocalizarQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarQuarto.Location = new System.Drawing.Point(451, 161);
            this.btnLocalizarQuarto.Name = "btnLocalizarQuarto";
            this.btnLocalizarQuarto.Size = new System.Drawing.Size(159, 28);
            this.btnLocalizarQuarto.TabIndex = 35;
            this.btnLocalizarQuarto.Text = "Localizar Quarto";
            this.btnLocalizarQuarto.UseVisualStyleBackColor = false;
            this.btnLocalizarQuarto.Click += new System.EventHandler(this.btnLocalizarQuarto_Click_1);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.Location = new System.Drawing.Point(142, 28);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(159, 28);
            this.btnLocalizar.TabIndex = 34;
            this.btnLocalizar.Text = "Localizar Paciente";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // cbxTipoQuarto
            // 
            this.cbxTipoQuarto.FormattingEnabled = true;
            this.cbxTipoQuarto.Items.AddRange(new object[] {
            "Solteiro",
            "Duplo",
            "Triplo"});
            this.cbxTipoQuarto.Location = new System.Drawing.Point(21, 165);
            this.cbxTipoQuarto.Name = "cbxTipoQuarto";
            this.cbxTipoQuarto.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoQuarto.TabIndex = 33;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(663, 208);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(113, 42);
            this.btnSair.TabIndex = 32;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(663, 114);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(113, 42);
            this.btnExcluir.TabIndex = 31;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(663, 66);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 42);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Número do Quarto";
            // 
            // txtNumeroQuarto
            // 
            this.txtNumeroQuarto.Location = new System.Drawing.Point(315, 166);
            this.txtNumeroQuarto.Name = "txtNumeroQuarto";
            this.txtNumeroQuarto.Size = new System.Drawing.Size(130, 20);
            this.txtNumeroQuarto.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tipo do quarto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nome do Doutor";
            // 
            // txtNomeDoutor
            // 
            this.txtNomeDoutor.Location = new System.Drawing.Point(21, 123);
            this.txtNomeDoutor.Name = "txtNomeDoutor";
            this.txtNomeDoutor.Size = new System.Drawing.Size(260, 20);
            this.txtNomeDoutor.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nome do Paciente";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(21, 78);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(260, 20);
            this.txtNomePaciente.TabIndex = 23;
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.AllowUserToAddRows = false;
            this.dgvPaciente.AllowUserToDeleteRows = false;
            this.dgvPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaciente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Location = new System.Drawing.Point(12, 267);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.ReadOnly = true;
            this.dgvPaciente.Size = new System.Drawing.Size(776, 169);
            this.dgvPaciente.TabIndex = 22;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(18, 17);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(20, 16);
            this.lbl1.TabIndex = 21;
            this.lbl1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(21, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 20;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(663, 14);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(113, 42);
            this.btnInserir.TabIndex = 19;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLocalizarQuarto);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.cbxTipoQuarto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumeroQuarto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeDoutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.dgvPaciente);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnInserir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizarQuarto;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.ComboBox cbxTipoQuarto;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroQuarto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeDoutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnInserir;
    }
}

