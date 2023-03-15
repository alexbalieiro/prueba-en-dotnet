namespace Aplicacion_Windows_2
{
    partial class FrmAplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAplicacion));
            this.TbApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RtbResultado = new System.Windows.Forms.RichTextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbApellido
            // 
            this.TbApellido.BackColor = System.Drawing.SystemColors.Window;
            this.TbApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbApellido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TbApellido.Location = new System.Drawing.Point(102, 24);
            this.TbApellido.MaxLength = 50;
            this.TbApellido.Name = "TbApellido";
            this.TbApellido.Size = new System.Drawing.Size(324, 20);
            this.TbApellido.TabIndex = 0;
            this.TbApellido.Click += new System.EventHandler(this.TbApellido_Click);
            this.TbApellido.Enter += new System.EventHandler(this.TbApellido_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "APELLIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE";
            // 
            // TbNombre
            // 
            this.TbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbNombre.Location = new System.Drawing.Point(102, 50);
            this.TbNombre.MaxLength = 50;
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(324, 20);
            this.TbNombre.TabIndex = 2;
            this.TbNombre.Click += new System.EventHandler(this.TbNombre_Click);
            this.TbNombre.Enter += new System.EventHandler(this.TbNombre_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "EDAD";
            // 
            // TbEdad
            // 
            this.TbEdad.Location = new System.Drawing.Point(102, 76);
            this.TbEdad.MaxLength = 3;
            this.TbEdad.Name = "TbEdad";
            this.TbEdad.Size = new System.Drawing.Size(38, 20);
            this.TbEdad.TabIndex = 4;
            this.TbEdad.Click += new System.EventHandler(this.TbEdad_Click);
            this.TbEdad.Enter += new System.EventHandler(this.TbEdad_Enter);
            this.TbEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbEdad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DIRECCIÓN";
            // 
            // TbDireccion
            // 
            this.TbDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbDireccion.Location = new System.Drawing.Point(102, 102);
            this.TbDireccion.MaxLength = 60;
            this.TbDireccion.Name = "TbDireccion";
            this.TbDireccion.Size = new System.Drawing.Size(324, 20);
            this.TbDireccion.TabIndex = 6;
            this.TbDireccion.Click += new System.EventHandler(this.TbDireccion_Click);
            this.TbDireccion.Enter += new System.EventHandler(this.TbDireccion_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "RESULTADO";
            // 
            // RtbResultado
            // 
            this.RtbResultado.Location = new System.Drawing.Point(33, 151);
            this.RtbResultado.Name = "RtbResultado";
            this.RtbResultado.Size = new System.Drawing.Size(393, 118);
            this.RtbResultado.TabIndex = 9;
            this.RtbResultado.Text = "";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(132, 281);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 10;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(244, 281);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 322);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.RtbResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.Load += new System.EventHandler(this.FrmAplicacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RtbResultado;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}

