
namespace MapaSala.Formularios
{
    partial class frmCursoDisciplinacs
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
            this.Disciplinas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCursos = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbPeriodos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDisciplinas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Disciplinas
            // 
            this.Disciplinas.AutoSize = true;
            this.Disciplinas.Location = new System.Drawing.Point(25, 36);
            this.Disciplinas.Name = "Disciplinas";
            this.Disciplinas.Size = new System.Drawing.Size(57, 13);
            this.Disciplinas.TabIndex = 2;
            this.Disciplinas.Text = "Disciplinas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curso";
            // 
            // cbxCursos
            // 
            this.cbxCursos.FormattingEnabled = true;
            this.cbxCursos.Items.AddRange(new object[] {
            "Desenvolvimento de Sistemas(integrado)",
            "Desenvolvimento de Sistemas(noturno)"});
            this.cbxCursos.Location = new System.Drawing.Point(186, 63);
            this.cbxCursos.Name = "cbxCursos";
            this.cbxCursos.Size = new System.Drawing.Size(108, 21);
            this.cbxCursos.TabIndex = 4;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(28, 127);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Adicionar";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 290);
            this.dataGridView1.TabIndex = 6;
            // 
            // cbPeriodos
            // 
            this.cbPeriodos.FormattingEnabled = true;
            this.cbPeriodos.Items.AddRange(new object[] {
            "1º Ano",
            "2º Ano",
            "3ºAno",
            "1º Módulo",
            "2º Módulo",
            "3º Módulo"});
            this.cbPeriodos.Location = new System.Drawing.Point(323, 63);
            this.cbPeriodos.Name = "cbPeriodos";
            this.cbPeriodos.Size = new System.Drawing.Size(109, 21);
            this.cbPeriodos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Períodos";
            // 
            // cbDisciplinas
            // 
            this.cbDisciplinas.FormattingEnabled = true;
            this.cbDisciplinas.Items.AddRange(new object[] {
            "PWI",
            "Ética",
            "Desenvolvimento de sistemas"});
            this.cbDisciplinas.Location = new System.Drawing.Point(28, 63);
            this.cbDisciplinas.Name = "cbDisciplinas";
            this.cbDisciplinas.Size = new System.Drawing.Size(121, 21);
            this.cbDisciplinas.TabIndex = 9;
            // 
            // frmCursoDisciplinacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 490);
            this.Controls.Add(this.cbDisciplinas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPeriodos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbxCursos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Disciplinas);
            this.Name = "frmCursoDisciplinacs";
            this.Text = "frmCursoDisciplinacs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Disciplinas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCursos;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbPeriodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDisciplinas;
    }
}