
namespace Vista
{
    partial class Form1
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
            this.groupPersonas = new System.Windows.Forms.GroupBox();
            this.DGVpersonas = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupDatos = new System.Windows.Forms.GroupBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVpersonas)).BeginInit();
            this.groupDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPersonas
            // 
            this.groupPersonas.Controls.Add(this.DGVpersonas);
            this.groupPersonas.Controls.Add(this.btnModificar);
            this.groupPersonas.Controls.Add(this.btnEliminar);
            this.groupPersonas.Controls.Add(this.btnConsultar);
            this.groupPersonas.Controls.Add(this.btnCerrar);
            this.groupPersonas.Controls.Add(this.btnAgregar);
            this.groupPersonas.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupPersonas.Location = new System.Drawing.Point(6, 14);
            this.groupPersonas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupPersonas.Name = "groupPersonas";
            this.groupPersonas.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupPersonas.Size = new System.Drawing.Size(574, 466);
            this.groupPersonas.TabIndex = 2;
            this.groupPersonas.TabStop = false;
            this.groupPersonas.Text = "Lista de personas";
            // 
            // DGVpersonas
            // 
            this.DGVpersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVpersonas.Location = new System.Drawing.Point(50, 31);
            this.DGVpersonas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGVpersonas.Name = "DGVpersonas";
            this.DGVpersonas.Size = new System.Drawing.Size(448, 361);
            this.DGVpersonas.TabIndex = 6;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(106, 429);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 30);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(205, 429);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 30);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(304, 429);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(92, 30);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(474, 429);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(92, 30);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(7, 429);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 30);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupDatos
            // 
            this.groupDatos.Controls.Add(this.txtTel);
            this.groupDatos.Controls.Add(this.label5);
            this.groupDatos.Controls.Add(this.txtNombre);
            this.groupDatos.Controls.Add(this.label4);
            this.groupDatos.Controls.Add(this.txtFecha);
            this.groupDatos.Controls.Add(this.label3);
            this.groupDatos.Controls.Add(this.txtApellido);
            this.groupDatos.Controls.Add(this.label2);
            this.groupDatos.Controls.Add(this.txtDNI);
            this.groupDatos.Controls.Add(this.label1);
            this.groupDatos.Controls.Add(this.btnCancelar);
            this.groupDatos.Controls.Add(this.button4);
            this.groupDatos.Controls.Add(this.btnGuardar);
            this.groupDatos.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupDatos.Location = new System.Drawing.Point(608, 14);
            this.groupDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupDatos.Size = new System.Drawing.Size(364, 466);
            this.groupDatos.TabIndex = 8;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "Registro de persona";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(89, 222);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(267, 22);
            this.txtTel.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefono:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 88);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(277, 22);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre: ";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(161, 175);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(195, 22);
            this.txtFecha.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de nacimiento: ";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(96, 131);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(263, 22);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido: ";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(61, 46);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(295, 22);
            this.txtDNI.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "DNI: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(265, 429);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(666, 429);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 30);
            this.button4.TabIndex = 2;
            this.button4.Text = "Cerrar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(7, 429);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 30);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 505);
            this.Controls.Add(this.groupDatos);
            this.Controls.Add(this.groupPersonas);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personas ingresadas en Argentina";
            this.groupPersonas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVpersonas)).EndInit();
            this.groupDatos.ResumeLayout(false);
            this.groupDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPersonas;
        private System.Windows.Forms.DataGridView DGVpersonas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupDatos;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnGuardar;
    }
}

