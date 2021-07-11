
namespace Facturacion
{
    partial class frmClientes
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrarCliente = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.almacenTecnoDataSet3 = new Facturacion.Datos.AlmacenTecnoDataSet3();
            this.tblClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblClientesTableAdapter = new Facturacion.Datos.AlmacenTecnoDataSet3TableAdapters.tblClientesTableAdapter();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.grbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(469, 91);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 35);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnBorrarCliente
            // 
            this.btnBorrarCliente.Location = new System.Drawing.Point(275, 91);
            this.btnBorrarCliente.Name = "btnBorrarCliente";
            this.btnBorrarCliente.Size = new System.Drawing.Size(100, 35);
            this.btnBorrarCliente.TabIndex = 17;
            this.btnBorrarCliente.Text = "Borrar";
            this.btnBorrarCliente.UseVisualStyleBackColor = true;
            this.btnBorrarCliente.Click += new System.EventHandler(this.btnBorrarCliente_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(81, 91);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtgCliente
            // 
            this.dtgCliente.AutoGenerateColumns = false;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.numCedulaDataGridViewTextBoxColumn,
            this.primerNombreDataGridViewTextBoxColumn,
            this.primerApellidoDataGridViewTextBoxColumn});
            this.dtgCliente.DataSource = this.tblClientesBindingSource;
            this.dtgCliente.Location = new System.Drawing.Point(19, 151);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.Size = new System.Drawing.Size(649, 218);
            this.dtgCliente.TabIndex = 20;
            this.dtgCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCliente_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cedula";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(521, 43);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(136, 27);
            this.txtApellido.TabIndex = 12;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(275, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 27);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(81, 36);
            this.txtCedula.Mask = "000-000000-0000A";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(117, 27);
            this.txtCedula.TabIndex = 21;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.txtCedula);
            this.grbCliente.Controls.Add(this.dtgCliente);
            this.grbCliente.Controls.Add(this.btnEditar);
            this.grbCliente.Controls.Add(this.txtApellido);
            this.grbCliente.Controls.Add(this.label3);
            this.grbCliente.Controls.Add(this.btnBorrarCliente);
            this.grbCliente.Controls.Add(this.btnGuardar);
            this.grbCliente.Controls.Add(this.txtNombre);
            this.grbCliente.Controls.Add(this.label1);
            this.grbCliente.Controls.Add(this.label2);
            this.grbCliente.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCliente.Location = new System.Drawing.Point(25, 26);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(686, 412);
            this.grbCliente.TabIndex = 22;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Datos cliente";
            // 
            // almacenTecnoDataSet3
            // 
            this.almacenTecnoDataSet3.DataSetName = "AlmacenTecnoDataSet3";
            this.almacenTecnoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblClientesBindingSource
            // 
            this.tblClientesBindingSource.DataMember = "tblClientes";
            this.tblClientesBindingSource.DataSource = this.almacenTecnoDataSet3;
            // 
            // tblClientesTableAdapter
            // 
            this.tblClientesTableAdapter.ClearBeforeFill = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
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
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.grbCliente);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrarCliente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.GroupBox grbCliente;
        private Datos.AlmacenTecnoDataSet3 almacenTecnoDataSet3;
        private System.Windows.Forms.BindingSource tblClientesBindingSource;
        private Datos.AlmacenTecnoDataSet3TableAdapters.tblClientesTableAdapter tblClientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellidoDataGridViewTextBoxColumn;
    }
}