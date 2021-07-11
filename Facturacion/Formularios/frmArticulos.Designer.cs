
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
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.catMarcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almacenTecnoDataSet1 = new Facturacion.Datos.AlmacenTecnoDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.catProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almacenTecnoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almacenTecnoDataSet = new Facturacion.Datos.AlmacenTecnoDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.catProveedoresTableAdapter = new Facturacion.Datos.AlmacenTecnoDataSetTableAdapters.catProveedoresTableAdapter();
            this.almacenTecnoDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.catMarcasTableAdapter = new Facturacion.Datos.AlmacenTecnoDataSet1TableAdapters.catMarcasTableAdapter();
            this.dtsetArticulos = new Facturacion.Datos.dtsetArticulos();
            this.catArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catArticulosTableAdapter = new Facturacion.Datos.dtsetArticulosTableAdapters.catArticulosTableAdapter();
            this.almacenTecnoDataSet2 = new Facturacion.Datos.AlmacenTecnoDataSet2();
            this.catArticulosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.catArticulosTableAdapter1 = new Facturacion.Datos.AlmacenTecnoDataSet2TableAdapters.catArticulosTableAdapter();
            this.dtgArticulos = new System.Windows.Forms.DataGridView();
            this.idArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catMarcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catArticulosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.cmbCategoria);
            this.grpDatos.Controls.Add(this.btnBorrar);
            this.grpDatos.Controls.Add(this.btnEditar);
            this.grpDatos.Controls.Add(this.btnGuardar);
            this.grpDatos.Controls.Add(this.cmbMarca);
            this.grpDatos.Controls.Add(this.label4);
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
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "PC",
            "Laptops",
            "Celulares",
            "Tablets",
            "Dispositivos de lectura",
            "Teclados",
            "Bocinas",
            "Lasers",
            "Pizarras",
            "Proyector",
            "iPads",
            "Cables usb",
            "Cable vga",
            "Cable tipo C",
            "Mouse",
            "Memorias",
            "Disco duros",
            "SSD",
            "Pantallas"});
            this.cmbCategoria.Location = new System.Drawing.Point(467, 48);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 27);
            this.cmbCategoria.TabIndex = 8;
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
            // cmbMarca
            // 
            this.cmbMarca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.catMarcasBindingSource, "idMarca", true));
            this.cmbMarca.DataSource = this.catMarcasBindingSource;
            this.cmbMarca.DisplayMember = "nombreMarca";
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(467, 132);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 27);
            this.cmbMarca.TabIndex = 4;
            this.cmbMarca.ValueMember = "idMarca";
            // 
            // catMarcasBindingSource
            // 
            this.catMarcasBindingSource.DataMember = "catMarcas";
            this.catMarcasBindingSource.DataSource = this.almacenTecnoDataSet1;
            // 
            // almacenTecnoDataSet1
            // 
            this.almacenTecnoDataSet1.DataSetName = "AlmacenTecnoDataSet1";
            this.almacenTecnoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.catProveedoresBindingSource, "idProveedor", true));
            this.cmbProveedor.DataSource = this.catProveedoresBindingSource;
            this.cmbProveedor.DisplayMember = "nombreProveedor";
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(153, 129);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(167, 27);
            this.cmbProveedor.TabIndex = 3;
            this.cmbProveedor.ValueMember = "idProveedor";
            // 
            // catProveedoresBindingSource
            // 
            this.catProveedoresBindingSource.DataMember = "catProveedores";
            this.catProveedoresBindingSource.DataSource = this.almacenTecnoDataSetBindingSource;
            // 
            // almacenTecnoDataSetBindingSource
            // 
            this.almacenTecnoDataSetBindingSource.DataSource = this.almacenTecnoDataSet;
            this.almacenTecnoDataSetBindingSource.Position = 0;
            // 
            // almacenTecnoDataSet
            // 
            this.almacenTecnoDataSet.DataSetName = "AlmacenTecnoDataSet";
            this.almacenTecnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(150, 48);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(100, 27);
            this.txtArticulo.TabIndex = 1;
            this.txtArticulo.TextChanged += new System.EventHandler(this.txtArticulo_TextChanged);
            this.txtArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArticulo_KeyPress);
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
            // catProveedoresTableAdapter
            // 
            this.catProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // almacenTecnoDataSetBindingSource1
            // 
            this.almacenTecnoDataSetBindingSource1.DataSource = this.almacenTecnoDataSet;
            this.almacenTecnoDataSetBindingSource1.Position = 0;
            // 
            // catMarcasTableAdapter
            // 
            this.catMarcasTableAdapter.ClearBeforeFill = true;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArticulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catMarcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSetBindingSource1)).EndInit();
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
        private Datos.AlmacenTecnoDataSet almacenTecnoDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource catProveedoresBindingSource;
        private Datos.AlmacenTecnoDataSetTableAdapters.catProveedoresTableAdapter catProveedoresTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.BindingSource almacenTecnoDataSetBindingSource1;
        private System.Windows.Forms.Label label4;
        private Datos.AlmacenTecnoDataSet1 almacenTecnoDataSet1;
        private System.Windows.Forms.BindingSource catMarcasBindingSource;
        private Datos.AlmacenTecnoDataSet1TableAdapters.catMarcasTableAdapter catMarcasTableAdapter;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private Datos.dtsetArticulos dtsetArticulos;
        private System.Windows.Forms.BindingSource catArticulosBindingSource;
        private Datos.dtsetArticulosTableAdapters.catArticulosTableAdapter catArticulosTableAdapter;
        private Datos.AlmacenTecnoDataSet2 almacenTecnoDataSet2;
        private System.Windows.Forms.BindingSource catArticulosBindingSource1;
        private Datos.AlmacenTecnoDataSet2TableAdapters.catArticulosTableAdapter catArticulosTableAdapter1;
        private System.Windows.Forms.DataGridView dtgArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbCategoria;
    }
}