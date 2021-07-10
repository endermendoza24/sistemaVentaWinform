
namespace Facturacion
{
    partial class frmArticulos
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.almacenTecnoDataSet = new Facturacion.AlmacenTecnoDataSet();
            this.almacenTecnoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catProveedoresTableAdapter = new Facturacion.AlmacenTecnoDataSetTableAdapters.catProveedoresTableAdapter();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.almacenTecnoDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.almacenTecnoDataSet1 = new Facturacion.AlmacenTecnoDataSet1();
            this.catMarcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catMarcasTableAdapter = new Facturacion.AlmacenTecnoDataSet1TableAdapters.catMarcasTableAdapter();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dtsetArticulos = new Facturacion.dtsetArticulos();
            this.catArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catArticulosTableAdapter = new Facturacion.dtsetArticulosTableAdapters.catArticulosTableAdapter();
            this.almacenTecnoDataSet2 = new Facturacion.AlmacenTecnoDataSet2();
            this.catArticulosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.catArticulosTableAdapter1 = new Facturacion.AlmacenTecnoDataSet2TableAdapters.catArticulosTableAdapter();
            this.dtgArticulos = new System.Windows.Forms.DataGridView();
            this.idArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catMarcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catArticulosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.btnBorrar);
            this.grpDatos.Controls.Add(this.btnEditar);
            this.grpDatos.Controls.Add(this.btnGuardar);
            this.grpDatos.Controls.Add(this.cmbMarca);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.txtCategoria);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.cmbProveedor);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.txtArticulo);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.Location = new System.Drawing.Point(13, 13);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(661, 249);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Obtener datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre articulo";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(150, 48);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(100, 27);
            this.txtArticulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id proveedor";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.catProveedoresBindingSource, "idProveedor", true));
            this.cmbProveedor.DataSource = this.catProveedoresBindingSource;
            this.cmbProveedor.DisplayMember = "nombreProveedor";
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(153, 129);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(167, 27);
            this.cmbProveedor.TabIndex = 3;
            this.cmbProveedor.ValueMember = "idProveedor";
            // 
            // almacenTecnoDataSet
            // 
            this.almacenTecnoDataSet.DataSetName = "AlmacenTecnoDataSet";
            this.almacenTecnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // almacenTecnoDataSetBindingSource
            // 
            this.almacenTecnoDataSetBindingSource.DataSource = this.almacenTecnoDataSet;
            this.almacenTecnoDataSetBindingSource.Position = 0;
            // 
            // catProveedoresBindingSource
            // 
            this.catProveedoresBindingSource.DataMember = "catProveedores";
            this.catProveedoresBindingSource.DataSource = this.almacenTecnoDataSetBindingSource;
            // 
            // catProveedoresTableAdapter
            // 
            this.catProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(467, 48);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 27);
            this.txtCategoria.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.catMarcasBindingSource, "idMarca", true));
            this.cmbMarca.DataSource = this.catMarcasBindingSource;
            this.cmbMarca.DisplayMember = "nombreMarca";
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(467, 132);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 27);
            this.cmbMarca.TabIndex = 4;
            this.cmbMarca.ValueMember = "idMarca";
            // 
            // almacenTecnoDataSetBindingSource1
            // 
            this.almacenTecnoDataSetBindingSource1.DataSource = this.almacenTecnoDataSet;
            this.almacenTecnoDataSetBindingSource1.Position = 0;
            // 
            // almacenTecnoDataSet1
            // 
            this.almacenTecnoDataSet1.DataSetName = "AlmacenTecnoDataSet1";
            this.almacenTecnoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catMarcasBindingSource
            // 
            this.catMarcasBindingSource.DataMember = "catMarcas";
            this.catMarcasBindingSource.DataSource = this.almacenTecnoDataSet1;
            // 
            // catMarcasTableAdapter
            // 
            this.catMarcasTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(71, 201);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 35);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(195, 201);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 35);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(320, 201);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(89, 35);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dtsetArticulos
            // 
            this.dtsetArticulos.DataSetName = "dtsetArticulos";
            this.dtsetArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catArticulosBindingSource
            // 
            this.catArticulosBindingSource.DataMember = "catArticulos";
            this.catArticulosBindingSource.DataSource = this.dtsetArticulos;
            // 
            // catArticulosTableAdapter
            // 
            this.catArticulosTableAdapter.ClearBeforeFill = true;
            // 
            // almacenTecnoDataSet2
            // 
            this.almacenTecnoDataSet2.DataSetName = "AlmacenTecnoDataSet2";
            this.almacenTecnoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catArticulosBindingSource1
            // 
            this.catArticulosBindingSource1.DataMember = "catArticulos";
            this.catArticulosBindingSource1.DataSource = this.almacenTecnoDataSet2;
            // 
            // catArticulosTableAdapter1
            // 
            this.catArticulosTableAdapter1.ClearBeforeFill = true;
            // 
            // dtgArticulos
            // 
            this.dtgArticulos.AutoGenerateColumns = false;
            this.dtgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticuloDataGridViewTextBoxColumn,
            this.nombreArticuloDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.idProveedoresDataGridViewTextBoxColumn,
            this.idMarcaDataGridViewTextBoxColumn});
            this.dtgArticulos.DataSource = this.catArticulosBindingSource;
            this.dtgArticulos.Location = new System.Drawing.Point(35, 301);
            this.dtgArticulos.Name = "dtgArticulos";
            this.dtgArticulos.Size = new System.Drawing.Size(639, 150);
            this.dtgArticulos.TabIndex = 1;
            this.dtgArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgArticulos_CellClick);
            // 
            // idArticuloDataGridViewTextBoxColumn
            // 
            this.idArticuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idArticuloDataGridViewTextBoxColumn.DataPropertyName = "idArticulo";
            this.idArticuloDataGridViewTextBoxColumn.HeaderText = "idArticulo";
            this.idArticuloDataGridViewTextBoxColumn.Name = "idArticuloDataGridViewTextBoxColumn";
            this.idArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreArticuloDataGridViewTextBoxColumn
            // 
            this.nombreArticuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreArticuloDataGridViewTextBoxColumn.DataPropertyName = "nombreArticulo";
            this.nombreArticuloDataGridViewTextBoxColumn.HeaderText = "nombreArticulo";
            this.nombreArticuloDataGridViewTextBoxColumn.Name = "nombreArticuloDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // idProveedoresDataGridViewTextBoxColumn
            // 
            this.idProveedoresDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idProveedoresDataGridViewTextBoxColumn.DataPropertyName = "idProveedores";
            this.idProveedoresDataGridViewTextBoxColumn.HeaderText = "idProveedores";
            this.idProveedoresDataGridViewTextBoxColumn.Name = "idProveedoresDataGridViewTextBoxColumn";
            // 
            // idMarcaDataGridViewTextBoxColumn
            // 
            this.idMarcaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idMarcaDataGridViewTextBoxColumn.DataPropertyName = "idMarca";
            this.idMarcaDataGridViewTextBoxColumn.HeaderText = "idMarca";
            this.idMarcaDataGridViewTextBoxColumn.Name = "idMarcaDataGridViewTextBoxColumn";
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgArticulos);
            this.Controls.Add(this.grpDatos);
            this.Name = "frmArticulos";
            this.Text = "frmArticulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catMarcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catArticulosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.BindingSource almacenTecnoDataSetBindingSource;
        private AlmacenTecnoDataSet almacenTecnoDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource catProveedoresBindingSource;
        private AlmacenTecnoDataSetTableAdapters.catProveedoresTableAdapter catProveedoresTableAdapter;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.BindingSource almacenTecnoDataSetBindingSource1;
        private System.Windows.Forms.Label label4;
        private AlmacenTecnoDataSet1 almacenTecnoDataSet1;
        private System.Windows.Forms.BindingSource catMarcasBindingSource;
        private AlmacenTecnoDataSet1TableAdapters.catMarcasTableAdapter catMarcasTableAdapter;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private dtsetArticulos dtsetArticulos;
        private System.Windows.Forms.BindingSource catArticulosBindingSource;
        private dtsetArticulosTableAdapters.catArticulosTableAdapter catArticulosTableAdapter;
        private AlmacenTecnoDataSet2 almacenTecnoDataSet2;
        private System.Windows.Forms.BindingSource catArticulosBindingSource1;
        private AlmacenTecnoDataSet2TableAdapters.catArticulosTableAdapter catArticulosTableAdapter1;
        private System.Windows.Forms.DataGridView dtgArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarcaDataGridViewTextBoxColumn;
    }
}