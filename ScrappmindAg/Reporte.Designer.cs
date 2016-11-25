namespace ScrappmindAg
{
    partial class Reporte
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
            this.codcedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirpuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcamposregistraduriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scrappmindDataSet = new ScrappmindAg.ScrappmindDataSet();
            this.tblcampos_registraduriaTableAdapter = new ScrappmindAg.ScrappmindDataSetTableAdapters.tblcampos_registraduriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcamposregistraduriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrappmindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codcedDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.departamentoDataGridViewTextBoxColumn,
            this.municipioDataGridViewTextBoxColumn,
            this.puestoDataGridViewTextBoxColumn,
            this.dirpuestoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.mesaDataGridViewTextBoxColumn,
            this.fechaactDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblcamposregistraduriaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 438);
            this.dataGridView1.TabIndex = 0;
            
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // codcedDataGridViewTextBoxColumn
            // 
            this.codcedDataGridViewTextBoxColumn.DataPropertyName = "cod_ced";
            this.codcedDataGridViewTextBoxColumn.HeaderText = "cod_ced";
            this.codcedDataGridViewTextBoxColumn.Name = "codcedDataGridViewTextBoxColumn";
            this.codcedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // departamentoDataGridViewTextBoxColumn
            // 
            this.departamentoDataGridViewTextBoxColumn.DataPropertyName = "departamento";
            this.departamentoDataGridViewTextBoxColumn.HeaderText = "departamento";
            this.departamentoDataGridViewTextBoxColumn.Name = "departamentoDataGridViewTextBoxColumn";
            // 
            // municipioDataGridViewTextBoxColumn
            // 
            this.municipioDataGridViewTextBoxColumn.DataPropertyName = "municipio";
            this.municipioDataGridViewTextBoxColumn.HeaderText = "municipio";
            this.municipioDataGridViewTextBoxColumn.Name = "municipioDataGridViewTextBoxColumn";
            // 
            // puestoDataGridViewTextBoxColumn
            // 
            this.puestoDataGridViewTextBoxColumn.DataPropertyName = "puesto";
            this.puestoDataGridViewTextBoxColumn.HeaderText = "puesto";
            this.puestoDataGridViewTextBoxColumn.Name = "puestoDataGridViewTextBoxColumn";
            // 
            // dirpuestoDataGridViewTextBoxColumn
            // 
            this.dirpuestoDataGridViewTextBoxColumn.DataPropertyName = "dirpuesto";
            this.dirpuestoDataGridViewTextBoxColumn.HeaderText = "dirpuesto";
            this.dirpuestoDataGridViewTextBoxColumn.Name = "dirpuestoDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // mesaDataGridViewTextBoxColumn
            // 
            this.mesaDataGridViewTextBoxColumn.DataPropertyName = "mesa";
            this.mesaDataGridViewTextBoxColumn.HeaderText = "mesa";
            this.mesaDataGridViewTextBoxColumn.Name = "mesaDataGridViewTextBoxColumn";
            // 
            // fechaactDataGridViewTextBoxColumn
            // 
            this.fechaactDataGridViewTextBoxColumn.DataPropertyName = "fechaact";
            this.fechaactDataGridViewTextBoxColumn.HeaderText = "fechaact";
            this.fechaactDataGridViewTextBoxColumn.Name = "fechaactDataGridViewTextBoxColumn";
            // 
            // tblcamposregistraduriaBindingSource
            // 
            this.tblcamposregistraduriaBindingSource.DataMember = "tblcampos_registraduria";
            this.tblcamposregistraduriaBindingSource.DataSource = this.scrappmindDataSet;
            // 
            // scrappmindDataSet
            // 
            this.scrappmindDataSet.DataSetName = "ScrappmindDataSet";
            this.scrappmindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcampos_registraduriaTableAdapter
            // 
            this.tblcampos_registraduriaTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 438);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcamposregistraduriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrappmindDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ScrappmindDataSet scrappmindDataSet;
        private System.Windows.Forms.BindingSource tblcamposregistraduriaBindingSource;
        private ScrappmindDataSetTableAdapters.tblcampos_registraduriaTableAdapter tblcampos_registraduriaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirpuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaactDataGridViewTextBoxColumn;
    }
}