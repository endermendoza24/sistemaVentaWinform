namespace Facturacion
{
    partial class frmEmpleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgEmpleado = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBorrarEmpleado = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.grbDataClientes = new System.Windows.Forms.GroupBox();
            this.dtsetEmpleado = new Facturacion.Datos.dtsetEmpleado();
            this.catEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catEmpleadosTableAdapter = new Facturacion.Datos.dtsetEmpleadoTableAdapters.catEmpleadosTableAdapter();
            this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleado)).BeginInit();
            this.grbDataClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catEmpleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(445, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 27);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(118, 91);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(159, 27);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cedula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha";
            // 
            // dtgEmpleado
            // 
            this.dtgEmpleado.AllowUserToAddRows = false;
            this.dtgEmpleado.AutoGenerateColumns = false;
            this.dtgEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleadoDataGridViewTextBoxColumn,
            this.numCedulaDataGridViewTextBoxColumn,
            this.primerNombreDataGridViewTextBoxColumn,
            this.primerApellidoDataGridViewTextBoxColumn,
            this.fechaEntradaDataGridViewTextBoxColumn});
            this.dtgEmpleado.DataSource = this.catEmpleadosBindingSource;
            this.dtgEmpleado.Location = new System.Drawing.Point(15, 200);
            this.dtgEmpleado.Name = "dtgEmpleado";
            this.dtgEmpleado.Size = new System.Drawing.Size(684, 213);
            this.dtgEmpleado.TabIndex = 8;
            this.dtgEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmpleado_CellClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(73, 142);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 33);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(445, 93);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 27);
            this.dtFecha.TabIndex = 4;
            this.dtFecha.Value = new System.DateTime(2021, 7, 8, 14, 25, 16, 0);
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // btnBorrarEmpleado
            // 
            this.btnBorrarEmpleado.Location = new System.Drawing.Point(202, 142);
            this.btnBorrarEmpleado.Name = "btnBorrarEmpleado";
            this.btnBorrarEmpleado.Size = new System.Drawing.Size(87, 33);
            this.btnBorrarEmpleado.TabIndex = 5;
            this.btnBorrarEmpleado.Text = "Borrar";
            this.btnBorrarEmpleado.UseVisualStyleBackColor = true;
            this.btnBorrarEmpleado.Click += new System.EventHandler(this.btnBorrarEmpleado_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(323, 142);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 33);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(77, 45);
            this.txtCedula.Mask = "000-000000-0000A";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(200, 27);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // grbDataClientes
            // 
            this.grbDataClientes.Controls.Add(this.label3);
            this.grbDataClientes.Controls.Add(this.dtgEmpleado);
            this.grbDataClientes.Controls.Add(this.dtFecha);
            this.grbDataClientes.Controls.Add(this.btnEditar);
            this.grbDataClientes.Controls.Add(this.txtCedula);
            this.grbDataClientes.Controls.Add(this.label4);
            this.grbDataClientes.Controls.Add(this.btnBorrarEmpleado);
            this.grbDataClientes.Controls.Add(this.txtApellido);
            this.grbDataClientes.Controls.Add(this.label1);
            this.grbDataClientes.Controls.Add(this.btnGuardar);
            this.grbDataClientes.Controls.Add(this.txtNombre);
            this.grbDataClientes.Controls.Add(this.label2);
            this.grbDataClientes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDataClientes.Location = new System.Drawing.Point(13, 13);
            this.grbDataClientes.Name = "grbDataClientes";
            this.grbDataClientes.Size = new System.Drawing.Size(721, 419);
            this.grbDataClientes.TabIndex = 10;
            this.grbDataClientes.TabStop = false;
            this.grbDataClientes.Text = "Datos empleado";
            // 
            // dtsetEmpleado
            // 
            this.dtsetEmpleado.DataSetName = "dtsetEmpleado";
            this.dtsetEmpleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catEmpleadosBindingSource
            // 
            this.catEmpleadosBindingSource.DataMember = "catEmpleados";
            this.catEmpleadosBindingSource.DataSource = this.dtsetEmpleado;
            // 
            // catEmpleadosTableAdapter
            // 
            this.catEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            this.idEmpleadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "idEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            this.idEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numCedulaDataGridViewTextBoxColumn
            // 
            this.numCedulaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numCedulaDataGridViewTextBoxColumn.DataPropertyName = "numCedula";
            this.numCedulaDataGridViewTextBoxColumn.HeaderText = "numCedula";
            this.numCedulaDataGridViewTextBoxColumn.Name = "numCedulaDataGridViewTextBoxColumn";
            // 
            // primerNombreDataGridViewTextBoxColumn
            // 
            this.primerNombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.primerNombreDataGridViewTextBoxColumn.DataPropertyName = "primerNombre";
            this.primerNombreDataGridViewTextBoxColumn.HeaderText = "primerNombre";
            this.primerNombreDataGridViewTextBoxColumn.Name = "primerNombreDataGridViewTextBoxColumn";
            // 
            // primerApellidoDataGridViewTextBoxColumn
            // 
            this.primerApellidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.primerApellidoDataGridViewTextBoxColumn.DataPropertyName = "primerApellido";
            this.primerApellidoDataGridViewTextBoxColumn.HeaderText = "primerApellido";
            this.primerApellidoDataGridViewTextBoxColumn.Name = "primerApellidoDataGridViewTextBoxColumn";
            // 
            // fechaEntradaDataGridViewTextBoxColumn
            // 
            this.fechaEntradaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaEntradaDataGridViewTextBoxColumn.DataPropertyName = "fechaEntrada";
            this.fechaEntradaDataGridViewTextBoxColumn.HeaderText = "fechaEntrada";
            this.fechaEntradaDataGridViewTextBoxColumn.Name = "fechaEntradaDataGridViewTextBoxColumn";
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 464);
            this.Controls.Add(this.grbDataClientes);
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmpleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleado)).EndInit();
            this.grbDataClientes.ResumeLayout(false);
            this.grbDataClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catEmpleadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgEmpleado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Button btnBorrarEmpleado;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.GroupBox grbDataClientes;
        private Datos.dtsetEmpleado dtsetEmpleado;
        private System.Windows.Forms.BindingSource catEmpleadosBindingSource;
        private Datos.dtsetEmpleadoTableAdapters.catEmpleadosTableAdapter catEmpleadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntradaDataGridViewTextBoxColumn;
    }
}