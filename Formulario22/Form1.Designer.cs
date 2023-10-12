namespace Formulario22
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
            this.grpTipoPersona = new System.Windows.Forms.GroupBox();
            this.radEstudiante = new System.Windows.Forms.RadioButton();
            this.radProfesor = new System.Windows.Forms.RadioButton();
            this.grpDatosPersona = new System.Windows.Forms.GroupBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtgListaDatos = new System.Windows.Forms.DataGridView();
            this.btnCapturarDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.grpTipoPersona.SuspendLayout();
            this.grpDatosPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTipoPersona
            // 
            this.grpTipoPersona.Controls.Add(this.radEstudiante);
            this.grpTipoPersona.Controls.Add(this.radProfesor);
            this.grpTipoPersona.Location = new System.Drawing.Point(41, 57);
            this.grpTipoPersona.Name = "grpTipoPersona";
            this.grpTipoPersona.Size = new System.Drawing.Size(113, 100);
            this.grpTipoPersona.TabIndex = 0;
            this.grpTipoPersona.TabStop = false;
            this.grpTipoPersona.Text = "Tipo persona";
            this.grpTipoPersona.Enter += new System.EventHandler(this.grpTipoPersona_Enter);
            // 
            // radEstudiante
            // 
            this.radEstudiante.AutoSize = true;
            this.radEstudiante.Location = new System.Drawing.Point(19, 57);
            this.radEstudiante.Name = "radEstudiante";
            this.radEstudiante.Size = new System.Drawing.Size(75, 17);
            this.radEstudiante.TabIndex = 1;
            this.radEstudiante.TabStop = true;
            this.radEstudiante.Text = "Estudiante";
            this.radEstudiante.UseVisualStyleBackColor = true;
            this.radEstudiante.CheckedChanged += new System.EventHandler(this.radEstudiante_CheckedChanged);
            // 
            // radProfesor
            // 
            this.radProfesor.AutoSize = true;
            this.radProfesor.Location = new System.Drawing.Point(19, 34);
            this.radProfesor.Name = "radProfesor";
            this.radProfesor.Size = new System.Drawing.Size(64, 17);
            this.radProfesor.TabIndex = 0;
            this.radProfesor.TabStop = true;
            this.radProfesor.Text = "Profesor";
            this.radProfesor.UseVisualStyleBackColor = true;
            this.radProfesor.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grpDatosPersona
            // 
            this.grpDatosPersona.Controls.Add(this.txtCalificacion);
            this.grpDatosPersona.Controls.Add(this.txtSueldo);
            this.grpDatosPersona.Controls.Add(this.txtNombre);
            this.grpDatosPersona.Controls.Add(this.lblCalificacion);
            this.grpDatosPersona.Controls.Add(this.lblSueldo);
            this.grpDatosPersona.Controls.Add(this.lblNombre);
            this.grpDatosPersona.Location = new System.Drawing.Point(12, 198);
            this.grpDatosPersona.Name = "grpDatosPersona";
            this.grpDatosPersona.Size = new System.Drawing.Size(327, 154);
            this.grpDatosPersona.TabIndex = 1;
            this.grpDatosPersona.TabStop = false;
            this.grpDatosPersona.Text = "Datos de la persona";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(100, 104);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(100, 20);
            this.txtCalificacion.TabIndex = 5;
            this.txtCalificacion.TextChanged += new System.EventHandler(this.txtCalificacion_TextChanged);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(94, 68);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(183, 20);
            this.txtSueldo.TabIndex = 4;
            this.txtSueldo.TextChanged += new System.EventHandler(this.txtSueldo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(19, 111);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(61, 13);
            this.lblCalificacion.TabIndex = 2;
            this.lblCalificacion.Text = "Calificacion";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(19, 71);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 1;
            this.lblSueldo.Text = "Sueldo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // dtgListaDatos
            // 
            this.dtgListaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaDatos.Location = new System.Drawing.Point(361, 12);
            this.dtgListaDatos.Name = "dtgListaDatos";
            this.dtgListaDatos.Size = new System.Drawing.Size(440, 358);
            this.dtgListaDatos.TabIndex = 2;
            this.dtgListaDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListaDatos_CellContentClick);
            // 
            // btnCapturarDatos
            // 
            this.btnCapturarDatos.Location = new System.Drawing.Point(218, 57);
            this.btnCapturarDatos.Name = "btnCapturarDatos";
            this.btnCapturarDatos.Size = new System.Drawing.Size(100, 51);
            this.btnCapturarDatos.TabIndex = 3;
            this.btnCapturarDatos.Text = "Capturar datos";
            this.btnCapturarDatos.UseVisualStyleBackColor = true;
            this.btnCapturarDatos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(218, 134);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(100, 44);
            this.btnMostrarDatos.TabIndex = 4;
            this.btnMostrarDatos.Text = "Mostrar datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 404);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCapturarDatos);
            this.Controls.Add(this.dtgListaDatos);
            this.Controls.Add(this.grpDatosPersona);
            this.Controls.Add(this.grpTipoPersona);
            this.Name = "Form1";
            this.Text = "PERSONAS DE UNA ESCUELA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpTipoPersona.ResumeLayout(false);
            this.grpTipoPersona.PerformLayout();
            this.grpDatosPersona.ResumeLayout(false);
            this.grpDatosPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTipoPersona;
        private System.Windows.Forms.GroupBox grpDatosPersona;
        private System.Windows.Forms.RadioButton radEstudiante;
        private System.Windows.Forms.RadioButton radProfesor;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dtgListaDatos;
        private System.Windows.Forms.Button btnCapturarDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
    }
}

