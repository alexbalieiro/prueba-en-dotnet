using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Windows_2
{
    public partial class FrmAplicacion : Form
    {
        public FrmAplicacion()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string Nombre ="";
            string Apellido ="";
            string Direccion = "";
            int Edad =0;
            bool Ok=true;
            if (TbApellido.Text=="")
            {
                TbApellido.BackColor = Color.Red;
                Ok=false;
            }
            else
            {
               Apellido = TbApellido.Text;
            }
            if (TbNombre.Text == "")
            {
                TbNombre.BackColor = Color.Red;
                Ok = false;
            }
            else
            {
                Nombre = TbNombre.Text;
            }
            if (TbEdad.Text == "")
            {
                TbEdad.BackColor = Color.Red;
                Ok = false;
            } else
            {
                Edad = Int32.Parse(TbEdad.Text);
            }
            if (TbDireccion.Text == "")
            {
                TbDireccion.BackColor = Color.Red;
                Ok = false;
            }
            else
            {
                Direccion = TbDireccion.Text;
            }

            if (Ok )
            {
                RtbResultado.Text = $"Apellido y Nombre: {Apellido} {Nombre}\r\nEdad: {Edad}\r\nDirección: {Direccion}";
            }
        }

        private void TbApellido_Click(object sender, EventArgs e)
        {
            TbApellido.BackColor = SystemColors.Window;
        }

        private void TbApellido_Enter(object sender, EventArgs e)
        {
            TbApellido.BackColor = SystemColors.Window;
        }

        private void TbNombre_Click(object sender, EventArgs e)
        {
            TbNombre.BackColor = SystemColors.Window;
        }

        private void TbNombre_Enter(object sender, EventArgs e)
        {
            TbNombre.BackColor = SystemColors.Window;
        }
        private void TbEdad_Click(object sender, EventArgs e)
        {
            TbEdad.BackColor = SystemColors.Window;
        }

        private void TbEdad_Enter(object sender, EventArgs e)
        {
            TbEdad.BackColor = SystemColors.Window;
        }

        private void TbDireccion_Click(object sender, EventArgs e)
        {
            TbDireccion.BackColor = SystemColors.Window;
        }

        private void TbDireccion_Enter(object sender, EventArgs e)
        {
            TbDireccion.BackColor = SystemColors.Window;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void FrmAplicacion_Load(object sender, EventArgs e)
        {

        }
    }
}
