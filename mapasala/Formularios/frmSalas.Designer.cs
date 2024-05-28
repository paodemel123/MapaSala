
namespace mapasala.Formularios
{
    partial class frmSalas
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
            this.NomeSalas = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.NumComputadores = new System.Windows.Forms.NumericUpDown();
            this.NumCadei = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.islab = new System.Windows.Forms.CheckBox();
            this.Disponivel = new System.Windows.Forms.CheckBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.dtGridSalas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.NumComputadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCadei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeSalas
            // 
            this.NomeSalas.Location = new System.Drawing.Point(79, 66);
            this.NomeSalas.Name = "NomeSalas";
            this.NomeSalas.Size = new System.Drawing.Size(100, 20);
            this.NomeSalas.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(35, 66);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(24, 20);
            this.Id.TabIndex = 1;
            // 
            // NumComputadores
            // 
            this.NumComputadores.Location = new System.Drawing.Point(207, 66);
            this.NumComputadores.Name = "NumComputadores";
            this.NumComputadores.Size = new System.Drawing.Size(120, 20);
            this.NumComputadores.TabIndex = 2;
            // 
            // NumCadei
            // 
            this.NumCadei.Location = new System.Drawing.Point(348, 66);
            this.NumCadei.Name = "NumCadei";
            this.NumCadei.Size = new System.Drawing.Size(120, 20);
            this.NumCadei.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome da Sala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero de computadores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero de cadeiras";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // islab
            // 
            this.islab.AutoSize = true;
            this.islab.Location = new System.Drawing.Point(474, 68);
            this.islab.Name = "islab";
            this.islab.Size = new System.Drawing.Size(91, 17);
            this.islab.TabIndex = 9;
            this.islab.Text = "É laboratório?";
            this.islab.UseVisualStyleBackColor = true;
            // 
            // Disponivel
            // 
            this.Disponivel.AutoSize = true;
            this.Disponivel.Location = new System.Drawing.Point(561, 69);
            this.Disponivel.Name = "Disponivel";
            this.Disponivel.Size = new System.Drawing.Size(77, 17);
            this.Disponivel.TabIndex = 10;
            this.Disponivel.Text = "Disponível";
            this.Disponivel.UseVisualStyleBackColor = true;
            this.Disponivel.CheckedChanged += new System.EventHandler(this.isDisp_CheckedChanged);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(654, 66);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 11;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // dtGridSalas
            // 
            this.dtGridSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSalas.Location = new System.Drawing.Point(35, 132);
            this.dtGridSalas.Name = "dtGridSalas";
            this.dtGridSalas.Size = new System.Drawing.Size(486, 205);
            this.dtGridSalas.TabIndex = 12;
            // 
            // frmSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridSalas);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.Disponivel);
            this.Controls.Add(this.islab);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumCadei);
            this.Controls.Add(this.NumComputadores);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.NomeSalas);
            this.Name = "frmSalas";
            this.Text = "frmSalas";
            ((System.ComponentModel.ISupportInitialize)(this.NumComputadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCadei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeSalas;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.NumericUpDown NumComputadores;
        private System.Windows.Forms.NumericUpDown NumCadei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox islab;
        private System.Windows.Forms.CheckBox Disponivel;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.DataGridView dados;
        private System.Windows.Forms.DataGridView dtGridSalas;
    }
}