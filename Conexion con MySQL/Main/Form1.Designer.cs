namespace Conexion_Con_MySQL
{
    partial class FormProductos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxProductos = new System.Windows.Forms.GroupBox();
            this.btnCancInsert = new System.Windows.Forms.Button();
            this.btnAcepInsert = new System.Windows.Forms.Button();
            this.buttonCancelarActualizacion = new System.Windows.Forms.Button();
            this.buttonAceptarActualizacion = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelPrecioV = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelCantE = new System.Windows.Forms.Label();
            this.textBoxExit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelnombre = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.groupBoxProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProductos
            // 
            this.groupBoxProductos.Controls.Add(this.btnCancInsert);
            this.groupBoxProductos.Controls.Add(this.btnAcepInsert);
            this.groupBoxProductos.Controls.Add(this.buttonCancelarActualizacion);
            this.groupBoxProductos.Controls.Add(this.buttonAceptarActualizacion);
            this.groupBoxProductos.Controls.Add(this.buttonActualizar);
            this.groupBoxProductos.Controls.Add(this.buttonEliminar);
            this.groupBoxProductos.Controls.Add(this.buttonLimpiar);
            this.groupBoxProductos.Controls.Add(this.buttonBuscar);
            this.groupBoxProductos.Controls.Add(this.labelPrecioV);
            this.groupBoxProductos.Controls.Add(this.textBoxPrecio);
            this.groupBoxProductos.Controls.Add(this.labelCantE);
            this.groupBoxProductos.Controls.Add(this.textBoxExit);
            this.groupBoxProductos.Controls.Add(this.label1);
            this.groupBoxProductos.Controls.Add(this.textBoxDesc);
            this.groupBoxProductos.Controls.Add(this.labelnombre);
            this.groupBoxProductos.Controls.Add(this.textBoxCodigo);
            this.groupBoxProductos.Controls.Add(this.buttonInsertar);
            this.groupBoxProductos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProductos.Name = "groupBoxProductos";
            this.groupBoxProductos.Size = new System.Drawing.Size(336, 180);
            this.groupBoxProductos.TabIndex = 0;
            this.groupBoxProductos.TabStop = false;
            this.groupBoxProductos.Text = "Productos";
            // 
            // btnCancInsert
            // 
            this.btnCancInsert.Image = global::Conexion_con_MySQL.Properties.Resources.descartar;
            this.btnCancInsert.Location = new System.Drawing.Point(288, 50);
            this.btnCancInsert.Name = "btnCancInsert";
            this.btnCancInsert.Size = new System.Drawing.Size(27, 27);
            this.btnCancInsert.TabIndex = 9;
            this.btnCancInsert.UseVisualStyleBackColor = true;
            this.btnCancInsert.Visible = false;
            this.btnCancInsert.Click += new System.EventHandler(this.btnCancInsert_Click);
            // 
            // btnAcepInsert
            // 
            this.btnAcepInsert.Image = global::Conexion_con_MySQL.Properties.Resources.aceptar;
            this.btnAcepInsert.Location = new System.Drawing.Point(255, 51);
            this.btnAcepInsert.Name = "btnAcepInsert";
            this.btnAcepInsert.Size = new System.Drawing.Size(27, 27);
            this.btnAcepInsert.TabIndex = 9;
            this.btnAcepInsert.UseVisualStyleBackColor = true;
            this.btnAcepInsert.Visible = false;
            this.btnAcepInsert.Click += new System.EventHandler(this.btnAcepInsert_Click);
            // 
            // buttonCancelarActualizacion
            // 
            this.buttonCancelarActualizacion.Image = global::Conexion_con_MySQL.Properties.Resources.descartar;
            this.buttonCancelarActualizacion.Location = new System.Drawing.Point(288, 85);
            this.buttonCancelarActualizacion.Name = "buttonCancelarActualizacion";
            this.buttonCancelarActualizacion.Size = new System.Drawing.Size(27, 27);
            this.buttonCancelarActualizacion.TabIndex = 9;
            this.buttonCancelarActualizacion.UseVisualStyleBackColor = true;
            this.buttonCancelarActualizacion.Visible = false;
            this.buttonCancelarActualizacion.Click += new System.EventHandler(this.buttonCancelarActualizacion_Click);
            // 
            // buttonAceptarActualizacion
            // 
            this.buttonAceptarActualizacion.Image = global::Conexion_con_MySQL.Properties.Resources.aceptar;
            this.buttonAceptarActualizacion.Location = new System.Drawing.Point(255, 86);
            this.buttonAceptarActualizacion.Name = "buttonAceptarActualizacion";
            this.buttonAceptarActualizacion.Size = new System.Drawing.Size(27, 27);
            this.buttonAceptarActualizacion.TabIndex = 9;
            this.buttonAceptarActualizacion.UseVisualStyleBackColor = true;
            this.buttonAceptarActualizacion.Visible = false;
            this.buttonAceptarActualizacion.Click += new System.EventHandler(this.buttonAceptarActualizacion_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(250, 85);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(72, 28);
            this.buttonActualizar.TabIndex = 9;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(250, 119);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(72, 28);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(250, 153);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(72, 28);
            this.buttonLimpiar.TabIndex = 9;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(250, 20);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(72, 25);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelPrecioV
            // 
            this.labelPrecioV.AutoSize = true;
            this.labelPrecioV.Location = new System.Drawing.Point(32, 127);
            this.labelPrecioV.Name = "labelPrecioV";
            this.labelPrecioV.Size = new System.Drawing.Size(86, 13);
            this.labelPrecioV.TabIndex = 7;
            this.labelPrecioV.Text = "Precio de Venta:";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(130, 124);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(92, 20);
            this.textBoxPrecio.TabIndex = 6;
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // labelCantE
            // 
            this.labelCantE.AutoSize = true;
            this.labelCantE.Location = new System.Drawing.Point(6, 89);
            this.labelCantE.Name = "labelCantE";
            this.labelCantE.Size = new System.Drawing.Size(118, 13);
            this.labelCantE.TabIndex = 5;
            this.labelCantE.Text = "Cantidad en Existencia:";
            // 
            // textBoxExit
            // 
            this.textBoxExit.Location = new System.Drawing.Point(130, 86);
            this.textBoxExit.Name = "textBoxExit";
            this.textBoxExit.Size = new System.Drawing.Size(92, 20);
            this.textBoxExit.TabIndex = 4;
            this.textBoxExit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExit_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripción:";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(130, 50);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(92, 20);
            this.textBoxDesc.TabIndex = 2;
            this.textBoxDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDesc_KeyPress);
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(75, 20);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(43, 13);
            this.labelnombre.TabIndex = 1;
            this.labelnombre.Text = "Código:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(130, 17);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(92, 20);
            this.textBoxCodigo.TabIndex = 0;
            this.textBoxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigo_KeyPress);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(250, 50);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(72, 28);
            this.buttonInsertar.TabIndex = 10;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 208);
            this.Controls.Add(this.groupBoxProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualización de Productos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.groupBoxProductos.ResumeLayout(false);
            this.groupBoxProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProductos;
        private System.Windows.Forms.Label labelPrecioV;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelCantE;
        private System.Windows.Forms.TextBox textBoxExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonAceptarActualizacion;
        private System.Windows.Forms.Button buttonCancelarActualizacion;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button btnCancInsert;
        private System.Windows.Forms.Button btnAcepInsert;
    }
}

