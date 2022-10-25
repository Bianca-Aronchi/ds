namespace bigui
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.grpAlunos = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblN4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRa = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(51, 87);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(36, 140);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(39, 13);
            this.lblN1.TabIndex = 1;
            this.lblN1.Text = "Nota 1";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(54, 223);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(220, 49);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // grpAlunos
            // 
            this.grpAlunos.Controls.Add(this.txtRA);
            this.grpAlunos.Controls.Add(this.lblRa);
            this.grpAlunos.Controls.Add(this.lblN4);
            this.grpAlunos.Controls.Add(this.lblN3);
            this.grpAlunos.Controls.Add(this.lblN2);
            this.grpAlunos.Controls.Add(this.txtN4);
            this.grpAlunos.Controls.Add(this.txtN3);
            this.grpAlunos.Controls.Add(this.txtN2);
            this.grpAlunos.Controls.Add(this.txtN1);
            this.grpAlunos.Controls.Add(this.txtNome);
            this.grpAlunos.Controls.Add(this.btnEnviar);
            this.grpAlunos.Controls.Add(this.lblN1);
            this.grpAlunos.Controls.Add(this.lblNome);
            this.grpAlunos.Location = new System.Drawing.Point(23, 29);
            this.grpAlunos.Name = "grpAlunos";
            this.grpAlunos.Size = new System.Drawing.Size(332, 296);
            this.grpAlunos.TabIndex = 3;
            this.grpAlunos.TabStop = false;
            this.grpAlunos.Text = "Alunos";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(120, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(39, 166);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(45, 20);
            this.txtN1.TabIndex = 4;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(115, 166);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(40, 20);
            this.txtN2.TabIndex = 5;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(183, 166);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(39, 20);
            this.txtN3.TabIndex = 6;
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(255, 166);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(40, 20);
            this.txtN4.TabIndex = 7;
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(112, 140);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(42, 13);
            this.lblN2.TabIndex = 9;
            this.lblN2.Text = "Nota 2 ";
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Location = new System.Drawing.Point(180, 140);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(42, 13);
            this.lblN3.TabIndex = 10;
            this.lblN3.Text = "Nota 3 ";
            // 
            // lblN4
            // 
            this.lblN4.AutoSize = true;
            this.lblN4.Location = new System.Drawing.Point(252, 140);
            this.lblN4.Name = "lblN4";
            this.lblN4.Size = new System.Drawing.Size(39, 13);
            this.lblN4.TabIndex = 11;
            this.lblN4.Text = "Nota 4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(372, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(689, 290);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // lblRa
            // 
            this.lblRa.AutoSize = true;
            this.lblRa.Location = new System.Drawing.Point(51, 31);
            this.lblRa.Name = "lblRa";
            this.lblRa.Size = new System.Drawing.Size(25, 13);
            this.lblRa.TabIndex = 13;
            this.lblRa.Text = "RA:";
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(120, 28);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(100, 20);
            this.txtRA.TabIndex = 14;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "RA";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome:";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "nota 1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "nota 2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "nota 3";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "nota 4";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "média ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "situação";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 581);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpAlunos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpAlunos.ResumeLayout(false);
            this.grpAlunos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.GroupBox grpAlunos;
        private System.Windows.Forms.Label lblN4;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.TextBox txtN4;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.Label lblRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

