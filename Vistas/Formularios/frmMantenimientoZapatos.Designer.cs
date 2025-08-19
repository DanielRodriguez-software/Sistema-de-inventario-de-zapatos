namespace Vistas.Formularios
{
    partial class frmMantenimientoZapatos
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
            this.RegistrarZappatos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.gbProductosAlmacen = new System.Windows.Forms.GroupBox();
            this.dgvAlmacen = new System.Windows.Forms.DataGridView();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnActualizarRegistro = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.gbProductosActualizar = new System.Windows.Forms.GroupBox();
            this.dgvAlmacenActualizar = new System.Windows.Forms.DataGridView();
            this.gbInfoActualizar = new System.Windows.Forms.GroupBox();
            this.cbCategoriaActualizar = new System.Windows.Forms.ComboBox();
            this.dtpFechaActualizar = new System.Windows.Forms.DateTimePicker();
            this.txtPrecioActualizar = new System.Windows.Forms.TextBox();
            this.txtNombreActualizar = new System.Windows.Forms.TextBox();
            this.lblCategoriaActualizar = new System.Windows.Forms.Label();
            this.lblFechaActualizar = new System.Windows.Forms.Label();
            this.lblPrecioActualizar = new System.Windows.Forms.Label();
            this.lblNombreActualizar = new System.Windows.Forms.Label();
            this.RegistrarZappatos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.gbProductosAlmacen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbProductosActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacenActualizar)).BeginInit();
            this.gbInfoActualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistrarZappatos
            // 
            this.RegistrarZappatos.Controls.Add(this.tabPage1);
            this.RegistrarZappatos.Controls.Add(this.tabPage2);
            this.RegistrarZappatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegistrarZappatos.Location = new System.Drawing.Point(0, 0);
            this.RegistrarZappatos.Name = "RegistrarZappatos";
            this.RegistrarZappatos.SelectedIndex = 0;
            this.RegistrarZappatos.Size = new System.Drawing.Size(800, 450);
            this.RegistrarZappatos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnRegistrar);
            this.tabPage1.Controls.Add(this.btnAñadir);
            this.tabPage1.Controls.Add(this.pbImagen);
            this.tabPage1.Controls.Add(this.gbProductosAlmacen);
            this.tabPage1.Controls.Add(this.gbInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar Zapatos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(598, 229);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(598, 187);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(584, 138);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(105, 23);
            this.btnAñadir.TabIndex = 3;
            this.btnAñadir.Text = "Añadir Imagen";
            this.btnAñadir.UseVisualStyleBackColor = true;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(540, 10);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(209, 98);
            this.pbImagen.TabIndex = 2;
            this.pbImagen.TabStop = false;
            // 
            // gbProductosAlmacen
            // 
            this.gbProductosAlmacen.Controls.Add(this.dgvAlmacen);
            this.gbProductosAlmacen.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbProductosAlmacen.Location = new System.Drawing.Point(4, 258);
            this.gbProductosAlmacen.Name = "gbProductosAlmacen";
            this.gbProductosAlmacen.Size = new System.Drawing.Size(780, 163);
            this.gbProductosAlmacen.TabIndex = 1;
            this.gbProductosAlmacen.TabStop = false;
            this.gbProductosAlmacen.Text = "Productos de Almacen :";
            // 
            // dgvAlmacen
            // 
            this.dgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlmacen.Location = new System.Drawing.Point(3, 24);
            this.dgvAlmacen.Name = "dgvAlmacen";
            this.dgvAlmacen.Size = new System.Drawing.Size(774, 136);
            this.dgvAlmacen.TabIndex = 0;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.cbCategoria);
            this.gbInfo.Controls.Add(this.dtpFechaRegistro);
            this.gbInfo.Controls.Add(this.txtPrecio);
            this.gbInfo.Controls.Add(this.txtNombre);
            this.gbInfo.Controls.Add(this.lblCategoria);
            this.gbInfo.Controls.Add(this.lblFechaRegistro);
            this.gbInfo.Controls.Add(this.lblPrecio);
            this.gbInfo.Controls.Add(this.lblNombre);
            this.gbInfo.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(4, 7);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(489, 222);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info.Zapato";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(96, 178);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(213, 25);
            this.cbCategoria.TabIndex = 7;
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(153, 125);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(314, 28);
            this.dtpFechaRegistro.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(94, 73);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(242, 28);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 28);
            this.txtNombre.TabIndex = 4;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(4, 178);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(85, 17);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria :";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(2, 125);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(144, 17);
            this.lblFechaRegistro.TabIndex = 2;
            this.lblFechaRegistro.Text = "Fecha de Registro :";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(4, 76);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 17);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(74, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnActualizarRegistro);
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Controls.Add(this.txtBuscar);
            this.tabPage2.Controls.Add(this.lblBuscar);
            this.tabPage2.Controls.Add(this.gbProductosActualizar);
            this.tabPage2.Controls.Add(this.gbInfoActualizar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actualizar Informacion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnActualizarRegistro
            // 
            this.btnActualizarRegistro.Location = new System.Drawing.Point(567, 185);
            this.btnActualizarRegistro.Name = "btnActualizarRegistro";
            this.btnActualizarRegistro.Size = new System.Drawing.Size(100, 43);
            this.btnActualizarRegistro.TabIndex = 6;
            this.btnActualizarRegistro.Text = "Actualizar Registro";
            this.btnActualizarRegistro.UseVisualStyleBackColor = true;
            this.btnActualizarRegistro.Click += new System.EventHandler(this.btnActualizarRegistro_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(708, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(501, 50);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(196, 20);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.Location = new System.Drawing.Point(516, 19);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(52, 17);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Buscar";
            // 
            // gbProductosActualizar
            // 
            this.gbProductosActualizar.Controls.Add(this.dgvAlmacenActualizar);
            this.gbProductosActualizar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbProductosActualizar.Location = new System.Drawing.Point(6, 253);
            this.gbProductosActualizar.Name = "gbProductosActualizar";
            this.gbProductosActualizar.Size = new System.Drawing.Size(780, 163);
            this.gbProductosActualizar.TabIndex = 2;
            this.gbProductosActualizar.TabStop = false;
            this.gbProductosActualizar.Text = "Productos de Almacen :";
            // 
            // dgvAlmacenActualizar
            // 
            this.dgvAlmacenActualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacenActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlmacenActualizar.Location = new System.Drawing.Point(3, 24);
            this.dgvAlmacenActualizar.Name = "dgvAlmacenActualizar";
            this.dgvAlmacenActualizar.Size = new System.Drawing.Size(774, 136);
            this.dgvAlmacenActualizar.TabIndex = 0;
            this.dgvAlmacenActualizar.DoubleClick += new System.EventHandler(this.dgvAlmacenActualizar_DoubleClick);
            // 
            // gbInfoActualizar
            // 
            this.gbInfoActualizar.Controls.Add(this.cbCategoriaActualizar);
            this.gbInfoActualizar.Controls.Add(this.dtpFechaActualizar);
            this.gbInfoActualizar.Controls.Add(this.txtPrecioActualizar);
            this.gbInfoActualizar.Controls.Add(this.txtNombreActualizar);
            this.gbInfoActualizar.Controls.Add(this.lblCategoriaActualizar);
            this.gbInfoActualizar.Controls.Add(this.lblFechaActualizar);
            this.gbInfoActualizar.Controls.Add(this.lblPrecioActualizar);
            this.gbInfoActualizar.Controls.Add(this.lblNombreActualizar);
            this.gbInfoActualizar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoActualizar.Location = new System.Drawing.Point(6, 6);
            this.gbInfoActualizar.Name = "gbInfoActualizar";
            this.gbInfoActualizar.Size = new System.Drawing.Size(489, 222);
            this.gbInfoActualizar.TabIndex = 1;
            this.gbInfoActualizar.TabStop = false;
            this.gbInfoActualizar.Text = "Info.Zapato";
            // 
            // cbCategoriaActualizar
            // 
            this.cbCategoriaActualizar.FormattingEnabled = true;
            this.cbCategoriaActualizar.Location = new System.Drawing.Point(96, 178);
            this.cbCategoriaActualizar.Name = "cbCategoriaActualizar";
            this.cbCategoriaActualizar.Size = new System.Drawing.Size(213, 25);
            this.cbCategoriaActualizar.TabIndex = 7;
            // 
            // dtpFechaActualizar
            // 
            this.dtpFechaActualizar.Location = new System.Drawing.Point(153, 125);
            this.dtpFechaActualizar.Name = "dtpFechaActualizar";
            this.dtpFechaActualizar.Size = new System.Drawing.Size(314, 28);
            this.dtpFechaActualizar.TabIndex = 6;
            // 
            // txtPrecioActualizar
            // 
            this.txtPrecioActualizar.Location = new System.Drawing.Point(94, 73);
            this.txtPrecioActualizar.Name = "txtPrecioActualizar";
            this.txtPrecioActualizar.Size = new System.Drawing.Size(242, 28);
            this.txtPrecioActualizar.TabIndex = 5;
            // 
            // txtNombreActualizar
            // 
            this.txtNombreActualizar.Location = new System.Drawing.Point(103, 25);
            this.txtNombreActualizar.Name = "txtNombreActualizar";
            this.txtNombreActualizar.Size = new System.Drawing.Size(233, 28);
            this.txtNombreActualizar.TabIndex = 4;
            // 
            // lblCategoriaActualizar
            // 
            this.lblCategoriaActualizar.AutoSize = true;
            this.lblCategoriaActualizar.Location = new System.Drawing.Point(4, 178);
            this.lblCategoriaActualizar.Name = "lblCategoriaActualizar";
            this.lblCategoriaActualizar.Size = new System.Drawing.Size(85, 17);
            this.lblCategoriaActualizar.TabIndex = 3;
            this.lblCategoriaActualizar.Text = "Categoria :";
            // 
            // lblFechaActualizar
            // 
            this.lblFechaActualizar.AutoSize = true;
            this.lblFechaActualizar.Location = new System.Drawing.Point(2, 125);
            this.lblFechaActualizar.Name = "lblFechaActualizar";
            this.lblFechaActualizar.Size = new System.Drawing.Size(144, 17);
            this.lblFechaActualizar.TabIndex = 2;
            this.lblFechaActualizar.Text = "Fecha de Registro :";
            // 
            // lblPrecioActualizar
            // 
            this.lblPrecioActualizar.AutoSize = true;
            this.lblPrecioActualizar.Location = new System.Drawing.Point(4, 76);
            this.lblPrecioActualizar.Name = "lblPrecioActualizar";
            this.lblPrecioActualizar.Size = new System.Drawing.Size(64, 17);
            this.lblPrecioActualizar.TabIndex = 1;
            this.lblPrecioActualizar.Text = "Precio :";
            // 
            // lblNombreActualizar
            // 
            this.lblNombreActualizar.AutoSize = true;
            this.lblNombreActualizar.Location = new System.Drawing.Point(7, 28);
            this.lblNombreActualizar.Name = "lblNombreActualizar";
            this.lblNombreActualizar.Size = new System.Drawing.Size(74, 17);
            this.lblNombreActualizar.TabIndex = 0;
            this.lblNombreActualizar.Text = "Nombre :";
            // 
            // frmMantenimientoZapatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegistrarZappatos);
            this.Name = "frmMantenimientoZapatos";
            this.Text = "frmMantenimientoZapatos";
            this.Load += new System.EventHandler(this.frmMantenimientoZapatos_Load);
            this.RegistrarZappatos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.gbProductosAlmacen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbProductosActualizar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacenActualizar)).EndInit();
            this.gbInfoActualizar.ResumeLayout(false);
            this.gbInfoActualizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl RegistrarZappatos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbProductosAlmacen;
        private System.Windows.Forms.DataGridView dgvAlmacen;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.GroupBox gbInfoActualizar;
        private System.Windows.Forms.ComboBox cbCategoriaActualizar;
        private System.Windows.Forms.DateTimePicker dtpFechaActualizar;
        private System.Windows.Forms.TextBox txtPrecioActualizar;
        private System.Windows.Forms.TextBox txtNombreActualizar;
        private System.Windows.Forms.Label lblCategoriaActualizar;
        private System.Windows.Forms.Label lblFechaActualizar;
        private System.Windows.Forms.Label lblPrecioActualizar;
        private System.Windows.Forms.Label lblNombreActualizar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.GroupBox gbProductosActualizar;
        private System.Windows.Forms.DataGridView dgvAlmacenActualizar;
        private System.Windows.Forms.Button btnActualizarRegistro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}