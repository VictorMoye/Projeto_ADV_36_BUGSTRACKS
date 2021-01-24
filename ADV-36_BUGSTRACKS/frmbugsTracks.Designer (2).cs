namespace ADV_36_BUGSTRACKS
{
    partial class frmbugsTracks
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSetores = new System.Windows.Forms.ComboBox();
            this.setoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugstracksDataSet = new ADV_36_BUGSTRACKS.BugstracksDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbComputadores = new System.Windows.Forms.ComboBox();
            this.computadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.bugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvBugs = new System.Windows.Forms.DataGridView();
            this.idBugsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraBugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewBugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugstracksDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computadoresBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBugsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSetores);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setores";
            // 
            // cmbSetores
            // 
            this.cmbSetores.DataSource = this.setoresBindingSource;
            this.cmbSetores.DisplayMember = "setor";
            this.cmbSetores.FormattingEnabled = true;
            this.cmbSetores.Location = new System.Drawing.Point(20, 32);
            this.cmbSetores.Name = "cmbSetores";
            this.cmbSetores.Size = new System.Drawing.Size(185, 21);
            this.cmbSetores.TabIndex = 0;
            this.cmbSetores.ValueMember = "id";
            // 
            // setoresBindingSource
            // 
            this.setoresBindingSource.DataMember = "setores";
            this.setoresBindingSource.DataSource = this.bugstracksDataSet;
            // 
            // bugstracksDataSet
            // 
            this.bugstracksDataSet.DataSetName = "BugstracksDataSet";
            this.bugstracksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbComputadores);
            this.groupBox2.Location = new System.Drawing.Point(274, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Computadores";
            // 
            // cmbComputadores
            // 
            this.cmbComputadores.DataSource = this.computadoresBindingSource;
            this.cmbComputadores.DisplayMember = "computador ";
            this.cmbComputadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComputadores.FormattingEnabled = true;
            this.cmbComputadores.Location = new System.Drawing.Point(6, 33);
            this.cmbComputadores.Name = "cmbComputadores";
            this.cmbComputadores.Size = new System.Drawing.Size(231, 21);
            this.cmbComputadores.TabIndex = 0;
            this.cmbComputadores.ValueMember = "id ";
            this.cmbComputadores.SelectedIndexChanged += new System.EventHandler(this.cmbComputadores_SelectedIndexChanged);
            // 
            // computadoresBindingSource
            // 
            this.computadoresBindingSource.DataMember = "computadores";
            this.computadoresBindingSource.DataSource = this.bugstracksDataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbUsuarios);
            this.groupBox3.Location = new System.Drawing.Point(550, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 76);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bug reportado por";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DataSource = this.bugsBindingSource;
            this.cmbUsuarios.DisplayMember = "idUsuario";
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(6, 32);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(223, 21);
            this.cmbUsuarios.TabIndex = 0;
            this.cmbUsuarios.ValueMember = "idUsuario";
            // 
            // bugsBindingSource
            // 
            this.bugsBindingSource.DataMember = "bugs ";
            this.bugsBindingSource.DataSource = this.bugstracksDataSet;
            // 
            // dgvBugs
            // 
            this.dgvBugs.AllowUserToAddRows = false;
            this.dgvBugs.AutoGenerateColumns = false;
            this.dgvBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBugsDataGridViewTextBoxColumn,
            this.setorDataGridViewTextBoxColumn,
            this.computadorDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.dataHoraBugDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dgvBugs.DataSource = this.viewBugsBindingSource;
            this.dgvBugs.Location = new System.Drawing.Point(13, 189);
            this.dgvBugs.Name = "dgvBugs";
            this.dgvBugs.Size = new System.Drawing.Size(772, 247);
            this.dgvBugs.TabIndex = 3;
            // 
            // idBugsDataGridViewTextBoxColumn
            // 
            this.idBugsDataGridViewTextBoxColumn.DataPropertyName = "idBugs";
            this.idBugsDataGridViewTextBoxColumn.HeaderText = "idBugs";
            this.idBugsDataGridViewTextBoxColumn.Name = "idBugsDataGridViewTextBoxColumn";
            // 
            // setorDataGridViewTextBoxColumn
            // 
            this.setorDataGridViewTextBoxColumn.DataPropertyName = "setor";
            this.setorDataGridViewTextBoxColumn.HeaderText = "setor";
            this.setorDataGridViewTextBoxColumn.Name = "setorDataGridViewTextBoxColumn";
            // 
            // computadorDataGridViewTextBoxColumn
            // 
            this.computadorDataGridViewTextBoxColumn.DataPropertyName = "computador";
            this.computadorDataGridViewTextBoxColumn.HeaderText = "computador";
            this.computadorDataGridViewTextBoxColumn.Name = "computadorDataGridViewTextBoxColumn";
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // dataHoraBugDataGridViewTextBoxColumn
            // 
            this.dataHoraBugDataGridViewTextBoxColumn.DataPropertyName = "dataHoraBug";
            this.dataHoraBugDataGridViewTextBoxColumn.HeaderText = "dataHoraBug";
            this.dataHoraBugDataGridViewTextBoxColumn.Name = "dataHoraBugDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // viewBugsBindingSource
            // 
            this.viewBugsBindingSource.DataMember = "viewBugs";
            this.viewBugsBindingSource.DataSource = this.bugstracksDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bugs cadastrados:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(708, 106);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 72);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descrição do bug:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(274, 106);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(405, 72);
            this.txtDescricao.TabIndex = 7;
            // 
            // frmbugsTracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 470);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBugs);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmbugsTracks";
            this.Text = "Bugs Tracks";
            this.Load += new System.EventHandler(this.frmbugsTracks_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugstracksDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.computadoresBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBugsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSetores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbComputadores;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.DataGridView dgvBugs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.BindingSource setoresBindingSource;
        private BugstracksDataSet bugstracksDataSet;
        private System.Windows.Forms.BindingSource computadoresBindingSource;
        private System.Windows.Forms.BindingSource bugsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBugsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraBugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewBugsBindingSource;
    }
}

