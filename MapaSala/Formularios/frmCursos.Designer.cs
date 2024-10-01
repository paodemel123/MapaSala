
namespace MapaSala.Formularios
{
    partial class frmCursos
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
            this.btneditar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtGridCursos = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtturno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.chkativo = new System.Windows.Forms.CheckBox();
            this.txtPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            this.SuspendLayout();
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.LightCoral;
            this.btneditar.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(799, 61);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(113, 31);
            this.btneditar.TabIndex = 21;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.LightCoral;
            this.btnexcluir.Location = new System.Drawing.Point(678, 99);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(113, 31);
            this.btnexcluir.TabIndex = 20;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightCoral;
            this.btnLimpar.Location = new System.Drawing.Point(675, 60);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(113, 31);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dtGridCursos
            // 
            this.dtGridCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridCursos.BackgroundColor = System.Drawing.Color.Pink;
            this.dtGridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCursos.Location = new System.Drawing.Point(16, 174);
            this.dtGridCursos.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dtGridCursos.Name = "dtGridCursos";
            this.dtGridCursos.RowHeadersWidth = 51;
            this.dtGridCursos.Size = new System.Drawing.Size(816, 300);
            this.dtGridCursos.TabIndex = 18;
            this.dtGridCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCursos_CellClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightCoral;
            this.btnSalvar.Location = new System.Drawing.Point(549, 60);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 31);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Turno";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtturno
            // 
            this.txtturno.Location = new System.Drawing.Point(325, 69);
            this.txtturno.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtturno.Name = "txtturno";
            this.txtturno.Size = new System.Drawing.Size(140, 22);
            this.txtturno.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(171, 69);
            this.txtNome.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(140, 22);
            this.txtNome.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id";
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(16, 69);
            this.numId.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(141, 22);
            this.numId.TabIndex = 11;
            // 
            // chkativo
            // 
            this.chkativo.AutoSize = true;
            this.chkativo.Location = new System.Drawing.Point(479, 71);
            this.chkativo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.chkativo.Name = "chkativo";
            this.chkativo.Size = new System.Drawing.Size(57, 20);
            this.chkativo.TabIndex = 22;
            this.chkativo.Text = "Ativo";
            this.chkativo.UseVisualStyleBackColor = true;
            this.chkativo.CheckedChanged += new System.EventHandler(this.chkIsLab_CheckedChanged);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.AutoSize = true;
            this.txtPesquisar.Location = new System.Drawing.Point(13, 124);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(69, 16);
            this.txtPesquisar.TabIndex = 23;
            this.txtPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(16, 143);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(325, 22);
            this.txtPesquisa.TabIndex = 24;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.chkativo);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dtGridCursos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtturno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dtGridCursos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtturno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.CheckBox chkativo;
        private System.Windows.Forms.Label txtPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}