
namespace Facturacion.Formularios
{
    partial class frmVentas
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
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.catArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsetArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsetArticulos = new Facturacion.Datos.dtsetArticulos();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.catEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsetEmpleado = new Facturacion.Datos.dtsetEmpleado();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.tblClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsetCliente = new Facturacion.Datos.AlmacenTecnoDataSet3();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tblClientesTableAdapter = new Facturacion.Datos.AlmacenTecnoDataSet3TableAdapters.tblClientesTableAdapter();
            this.catEmpleadosTableAdapter = new Facturacion.Datos.dtsetEmpleadoTableAdapters.catEmpleadosTableAdapter();
            this.catArticulosTableAdapter = new Facturacion.Datos.dtsetArticulosTableAdapters.catArticulosTableAdapter();
            this.dtgVentas = new System.Windows.Forms.DataGridView();
            this.idVentasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsetVentas = new Facturacion.Datos.dtsetVentas();
            this.tblVentasTableAdapter = new Facturacion.Datos.dtsetVentasTableAdapters.tblVentasTableAdapter();
            this.grbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.btnBorrar);
            this.grbDatos.Controls.Add(this.btnEditar);
            this.grbDatos.Controls.Add(this.btnGuardar);
            this.grbDatos.Controls.Add(this.txtTotal);
            this.grbDatos.Controls.Add(this.label9);
            this.grbDatos.Controls.Add(this.txtDescuento);
            this.grbDatos.Controls.Add(this.label8);
            this.grbDatos.Controls.Add(this.txtIva);
            this.grbDatos.Controls.Add(this.label7);
            this.grbDatos.Controls.Add(this.txtPrecio);
            this.grbDatos.Controls.Add(this.label6);
            this.grbDatos.Controls.Add(this.txtCantidad);
            this.grbDatos.Controls.Add(this.label5);
            this.grbDatos.Controls.Add(this.cmbArticulo);
            this.grbDatos.Controls.Add(this.label4);
            this.grbDatos.Controls.Add(this.cmbEmpleado);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.cmbCliente);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.dtpFechaVenta);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatos.Location = new System.Drawing.Point(13, 13);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(788, 248);
            this.grbDatos.TabIndex = 0;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Registro de ventas";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(654, 185);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(84, 45);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(416, 191);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 45);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(118, 185);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 45);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(654, 152);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 27);
            this.txtTotal.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(583, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(418, 152);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(121, 27);
            this.txtDescuento.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(335, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Descuento";
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(118, 152);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(200, 27);
            this.txtIva.TabIndex = 13;
            this.txtIva.TextChanged += new System.EventHandler(this.txtIva_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "I.V.A";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(654, 101);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 27);
            this.txtPrecio.TabIndex = 11;
            this.txtPrecio.Text = "0.00";
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Precio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(416, 101);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 27);
            this.txtCantidad.TabIndex = 9;
            this.txtCantidad.Text = "0";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad";
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.DataSource = this.catArticulosBindingSource;
            this.cmbArticulo.DisplayMember = "nombreArticulo";
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Location = new System.Drawing.Point(118, 101);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(200, 27);
            this.cmbArticulo.TabIndex = 7;
            this.cmbArticulo.ValueMember = "idArticulo";
            // 
            // catArticulosBindingSource
            // 
            this.catArticulosBindingSource.DataMember = "catArticulos";
            this.catArticulosBindingSource.DataSource = this.dtsetArticulosBindingSource;
            // 
            // dtsetArticulosBindingSource
            // 
            this.dtsetArticulosBindingSource.DataSource = this.dtsetArticulos;
            this.dtsetArticulosBindingSource.Position = 0;
            // 
            // dtsetArticulos
            // 
            this.dtsetArticulos.DataSetName = "dtsetArticulos";
            this.dtsetArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id artículo";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DataSource = this.catEmpleadosBindingSource;
            this.cmbEmpleado.DisplayMember = "primerNombre";
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(654, 49);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 27);
            this.cmbEmpleado.TabIndex = 5;
            this.cmbEmpleado.ValueMember = "idEmpleado";
            // 
            // catEmpleadosBindingSource
            // 
            this.catEmpleadosBindingSource.DataMember = "catEmpleados";
            this.catEmpleadosBindingSource.DataSource = this.dtsetEmpleado;
            // 
            // dtsetEmpleado
            // 
            this.dtsetEmpleado.DataSetName = "dtsetEmpleado";
            this.dtsetEmpleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id empleado";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataSource = this.tblClientesBindingSource;
            this.cmbCliente.DisplayMember = "primerNombre";
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(416, 49);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 27);
            this.cmbCliente.TabIndex = 3;
            this.cmbCliente.ValueMember = "idCliente";
            // 
            // tblClientesBindingSource
            // 
            this.tblClientesBindingSource.DataMember = "tblClientes";
            this.tblClientesBindingSource.DataSource = this.dtsetCliente;
            // 
            // dtsetCliente
            // 
            this.dtsetCliente.DataSetName = "AlmacenTecnoDataSet3";
            this.dtsetCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id cliente";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.Location = new System.Drawing.Point(118, 49);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaVenta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha venta";
            // 
            // tblClientesTableAdapter
            // 
            this.tblClientesTableAdapter.ClearBeforeFill = true;
            // 
            // catEmpleadosTableAdapter
            // 
            this.catEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // catArticulosTableAdapter
            // 
            this.catArticulosTableAdapter.ClearBeforeFill = true;
            // 
            // dtgVentas
            // 
            this.dtgVentas.AutoGenerateColumns = false;
            this.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVentasDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.idEmpleadoDataGridViewTextBoxColumn,
            this.idArticuloDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.ivaDataGridViewTextBoxColumn,
            this.descuentoDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dtgVentas.DataSource = this.tblVentasBindingSource;
            this.dtgVentas.Location = new System.Drawing.Point(13, 267);
            this.dtgVentas.Name = "dtgVentas";
            this.dtgVentas.Size = new System.Drawing.Size(788, 150);
            this.dtgVentas.TabIndex = 1;
            this.dtgVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVentas_CellClick);
            // 
            // idVentasDataGridViewTextBoxColumn
            // 
            this.idVentasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idVentasDataGridViewTextBoxColumn.DataPropertyName = "idVentas";
            this.idVentasDataGridViewTextBoxColumn.HeaderText = "idVentas";
            this.idVentasDataGridViewTextBoxColumn.Name = "idVentasDataGridViewTextBoxColumn";
            this.idVentasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            this.idEmpleadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "idEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            // 
            // idArticuloDataGridViewTextBoxColumn
            // 
            this.idArticuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idArticuloDataGridViewTextBoxColumn.DataPropertyName = "idArticulo";
            this.idArticuloDataGridViewTextBoxColumn.HeaderText = "idArticulo";
            this.idArticuloDataGridViewTextBoxColumn.Name = "idArticuloDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // ivaDataGridViewTextBoxColumn
            // 
            this.ivaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ivaDataGridViewTextBoxColumn.DataPropertyName = "iva";
            this.ivaDataGridViewTextBoxColumn.HeaderText = "iva";
            this.ivaDataGridViewTextBoxColumn.Name = "ivaDataGridViewTextBoxColumn";
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            this.descuentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descuentoDataGridViewTextBoxColumn.DataPropertyName = "descuento";
            this.descuentoDataGridViewTextBoxColumn.HeaderText = "descuento";
            this.descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // tblVentasBindingSource
            // 
            this.tblVentasBindingSource.DataMember = "tblVentas";
            this.tblVentasBindingSource.DataSource = this.dtsetVentas;
            // 
            // dtsetVentas
            // 
            this.dtsetVentas.DataSetName = "dtsetVentas";
            this.dtsetVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblVentasTableAdapter
            // 
            this.tblVentasTableAdapter.ClearBeforeFill = true;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.dtgVentas);
            this.Controls.Add(this.grbDatos);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label label1;
        private Datos.AlmacenTecnoDataSet3 dtsetCliente;
        private System.Windows.Forms.BindingSource tblClientesBindingSource;
        private Datos.AlmacenTecnoDataSet3TableAdapters.tblClientesTableAdapter tblClientesTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label3;
        private Datos.dtsetEmpleado dtsetEmpleado;
        private System.Windows.Forms.BindingSource catEmpleadosBindingSource;
        private Datos.dtsetEmpleadoTableAdapters.catEmpleadosTableAdapter catEmpleadosTableAdapter;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.BindingSource dtsetArticulosBindingSource;
        private Datos.dtsetArticulos dtsetArticulos;
        private System.Windows.Forms.BindingSource catArticulosBindingSource;
        private Datos.dtsetArticulosTableAdapters.catArticulosTableAdapter catArticulosTableAdapter;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dtgVentas;
        private Datos.dtsetVentas dtsetVentas;
        private System.Windows.Forms.BindingSource tblVentasBindingSource;
        private Datos.dtsetVentasTableAdapters.tblVentasTableAdapter tblVentasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}