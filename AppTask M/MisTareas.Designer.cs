namespace AppTask_M
{
    partial class MisTareas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tAREASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPPTASKDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPPTASKDataSet = new AppTask_M.APPTASKDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.tAREASTableAdapter = new AppTask_M.APPTASKDataSetTableAdapters.TAREASTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tITULODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTIQUETADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAFINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uLTIMAMODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMPORTANCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAREASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPTASKDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPTASKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tITULODataGridViewTextBoxColumn,
            this.fECHAINDataGridViewTextBoxColumn,
            this.eTIQUETADataGridViewTextBoxColumn,
            this.fECHAFINDataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.uLTIMAMODDataGridViewTextBoxColumn,
            this.iMPORTANCIADataGridViewTextBoxColumn,
            this.iDUSUARIODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tAREASBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(54, 137);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(689, 173);
            this.dataGridView1.TabIndex = 8;
            // 
            // tAREASBindingSource
            // 
            this.tAREASBindingSource.DataMember = "TAREAS";
            this.tAREASBindingSource.DataSource = this.aPPTASKDataSetBindingSource;
            // 
            // aPPTASKDataSetBindingSource
            // 
            this.aPPTASKDataSetBindingSource.DataSource = this.aPPTASKDataSet;
            this.aPPTASKDataSetBindingSource.Position = 0;
            // 
            // aPPTASKDataSet
            // 
            this.aPPTASKDataSet.DataSetName = "APPTASKDataSet";
            this.aPPTASKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tareas pendientes";
            // 
            // tAREASTableAdapter
            // 
            this.tAREASTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(334, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cmbDate
            // 
            this.cmbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(426, 70);
            this.cmbDate.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(146, 21);
            this.cmbDate.TabIndex = 7;
            this.cmbDate.Text = "Fechas de entrega";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(661, 69);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // tITULODataGridViewTextBoxColumn
            // 
            this.tITULODataGridViewTextBoxColumn.DataPropertyName = "TITULO";
            this.tITULODataGridViewTextBoxColumn.HeaderText = "TITULO";
            this.tITULODataGridViewTextBoxColumn.Name = "tITULODataGridViewTextBoxColumn";
            // 
            // fECHAINDataGridViewTextBoxColumn
            // 
            this.fECHAINDataGridViewTextBoxColumn.DataPropertyName = "FECHAIN";
            this.fECHAINDataGridViewTextBoxColumn.HeaderText = "FECHAIN";
            this.fECHAINDataGridViewTextBoxColumn.Name = "fECHAINDataGridViewTextBoxColumn";
            // 
            // eTIQUETADataGridViewTextBoxColumn
            // 
            this.eTIQUETADataGridViewTextBoxColumn.DataPropertyName = "ETIQUETA";
            this.eTIQUETADataGridViewTextBoxColumn.HeaderText = "ETIQUETA";
            this.eTIQUETADataGridViewTextBoxColumn.Name = "eTIQUETADataGridViewTextBoxColumn";
            // 
            // fECHAFINDataGridViewTextBoxColumn
            // 
            this.fECHAFINDataGridViewTextBoxColumn.DataPropertyName = "FECHAFIN";
            this.fECHAFINDataGridViewTextBoxColumn.HeaderText = "FECHAFIN";
            this.fECHAFINDataGridViewTextBoxColumn.Name = "fECHAFINDataGridViewTextBoxColumn";
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            // 
            // uLTIMAMODDataGridViewTextBoxColumn
            // 
            this.uLTIMAMODDataGridViewTextBoxColumn.DataPropertyName = "ULTIMAMOD";
            this.uLTIMAMODDataGridViewTextBoxColumn.HeaderText = "ULTIMAMOD";
            this.uLTIMAMODDataGridViewTextBoxColumn.Name = "uLTIMAMODDataGridViewTextBoxColumn";
            // 
            // iMPORTANCIADataGridViewTextBoxColumn
            // 
            this.iMPORTANCIADataGridViewTextBoxColumn.DataPropertyName = "IMPORTANCIA";
            this.iMPORTANCIADataGridViewTextBoxColumn.HeaderText = "IMPORTANCIA";
            this.iMPORTANCIADataGridViewTextBoxColumn.Name = "iMPORTANCIADataGridViewTextBoxColumn";
            // 
            // iDUSUARIODataGridViewTextBoxColumn
            // 
            this.iDUSUARIODataGridViewTextBoxColumn.DataPropertyName = "ID_USUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.HeaderText = "ID_USUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.Name = "iDUSUARIODataGridViewTextBoxColumn";
            // 
            // MisTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "MisTareas";
            this.Text = "MisTareas";
            this.Load += new System.EventHandler(this.MisTareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAREASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPTASKDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPTASKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource aPPTASKDataSetBindingSource;
        private APPTASKDataSet aPPTASKDataSet;
        private System.Windows.Forms.BindingSource tAREASBindingSource;
        private APPTASKDataSetTableAdapters.TAREASTableAdapter tAREASTableAdapter;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox cmbDate;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITULODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTIQUETADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAFINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uLTIMAMODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPORTANCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSUARIODataGridViewTextBoxColumn;
    }
}