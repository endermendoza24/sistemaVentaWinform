
namespace Facturacion
{
    partial class frmMarcas
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
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dtgMarca = new System.Windows.Forms.DataGridView();
            this.idMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catMarcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almacenTecnoDataSet1 = new Facturacion.Datos.AlmacenTecnoDataSet1();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.catMarcasTableAdapter = new Facturacion.Datos.AlmacenTecnoDataSet1TableAdapters.catMarcasTableAdapter();
            this.mdiDato = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catàlogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiònToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catMarcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSet1)).BeginInit();
            this.grbDatos.SuspendLayout();
            this.mdiDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Location = new System.Drawing.Point(216, 49);
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(252, 27);
            this.txtNombreMarca.TabIndex = 0;
            this.txtNombreMarca.TextChanged += new System.EventHandler(this.txtNombreMarca_TextChanged);
            this.txtNombreMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMarca_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de marca";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(35, 101);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 41);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(140, 101);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 41);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(238, 101);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(92, 41);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dtgMarca
            // 
            this.dtgMarca.AllowUserToAddRows = false;
            this.dtgMarca.AutoGenerateColumns = false;
            this.dtgMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMarcaDataGridViewTextBoxColumn,
            this.nombreMarcaDataGridViewTextBoxColumn});
            this.dtgMarca.DataSource = this.catMarcasBindingSource;
            this.dtgMarca.Location = new System.Drawing.Point(35, 163);
            this.dtgMarca.Name = "dtgMarca";
            this.dtgMarca.Size = new System.Drawing.Size(433, 193);
            this.dtgMarca.TabIndex = 5;
            this.dtgMarca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMarca_CellClick);
            this.dtgMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMarca_CellContentClick);
            // 
            // idMarcaDataGridViewTextBoxColumn
            // 
            this.idMarcaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idMarcaDataGridViewTextBoxColumn.DataPropertyName = "idMarca";
            this.idMarcaDataGridViewTextBoxColumn.HeaderText = "idMarca";
            this.idMarcaDataGridViewTextBoxColumn.Name = "idMarcaDataGridViewTextBoxColumn";
            this.idMarcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreMarcaDataGridViewTextBoxColumn
            // 
            this.nombreMarcaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreMarcaDataGridViewTextBoxColumn.DataPropertyName = "nombreMarca";
            this.nombreMarcaDataGridViewTextBoxColumn.HeaderText = "nombreMarca";
            this.nombreMarcaDataGridViewTextBoxColumn.Name = "nombreMarcaDataGridViewTextBoxColumn";
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
            // grbDatos
            // 
            this.grbDatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbDatos.Controls.Add(this.txtNombreMarca);
            this.grbDatos.Controls.Add(this.dtgMarca);
            this.grbDatos.Controls.Add(this.btnModificar);
            this.grbDatos.Controls.Add(this.btnBorrar);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Controls.Add(this.btnAgregar);
            this.grbDatos.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatos.Location = new System.Drawing.Point(12, 27);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(508, 405);
            this.grbDatos.TabIndex = 6;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // catMarcasTableAdapter
            // 
            this.catMarcasTableAdapter.ClearBeforeFill = true;
            // 
            // mdiDato
            // 
            this.mdiDato.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.catàlogosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.cerrarSesiònToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mdiDato.Location = new System.Drawing.Point(0, 0);
            this.mdiDato.MdiWindowListItem = this.catàlogosToolStripMenuItem;
            this.mdiDato.Name = "mdiDato";
            this.mdiDato.Size = new System.Drawing.Size(546, 24);
            this.mdiDato.TabIndex = 12;
            this.mdiDato.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // catàlogosToolStripMenuItem
            // 
            this.catàlogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.clientesToolStripMenuItem1,
            this.clientesToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.catàlogosToolStripMenuItem.Name = "catàlogosToolStripMenuItem";
            this.catàlogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.catàlogosToolStripMenuItem.Text = "Catálogos";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click_1);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clientesToolStripMenuItem.Text = "Empleado";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // cerrarSesiònToolStripMenuItem
            // 
            this.cerrarSesiònToolStripMenuItem.Name = "cerrarSesiònToolStripMenuItem";
            this.cerrarSesiònToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesiònToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiònToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiònToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.mdiDato);
            this.Controls.Add(this.grbDatos);
            this.Name = "frmMarcas";
            this.Text = "frmMarcas";
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catMarcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenTecnoDataSet1)).EndInit();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.mdiDato.ResumeLayout(false);
            this.mdiDato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridView dtgMarca;
        private System.Windows.Forms.GroupBox grbDatos;
        private Datos.AlmacenTecnoDataSet1 almacenTecnoDataSet1;
        private System.Windows.Forms.BindingSource catMarcasBindingSource;
        private Datos.AlmacenTecnoDataSet1TableAdapters.catMarcasTableAdapter catMarcasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip mdiDato;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catàlogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiònToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}