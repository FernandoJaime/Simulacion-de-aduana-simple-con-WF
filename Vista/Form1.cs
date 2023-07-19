using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form1 : Form
    {
        // variables temporales para crear objetos del modelo
        private Modelo.Aduana oAduana;
        private Modelo.Persona oPersona;

        private string groups; // variable para habilitar/deshabilitar groups
        public Form1()
        {
            InitializeComponent();
            oAduana = new Modelo.Aduana(); // creo lista vacia en memoria
            ModoGrilla();
        }
        private void ModoGrilla() // habilito el group del DGV
        {
            groupDatos.Enabled = false;
            groupPersonas.Enabled = true;
        }
        private void ArmarGrilla()
        {
            DGVpersonas.DataSource = null; // limpio fuente de datos antes de cagar
            DGVpersonas.DataSource = oAduana.Personas; // enlazo lista como fuente de datos del DGV
        }
        private void ModoDatos() // habilito el group de datos
        {
            groupDatos.Enabled = true;
            groupPersonas.Enabled = false;
            if (groups == "C") // "C" = conultar 
            {
                btnGuardar.Enabled = false; // deshabilito el boton guardar
            }
            else
            {
                btnGuardar.Enabled = true; // habilito
            }
        }
        private void Clean() // limpio txt
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFecha.Text = "";
            txtTel.Text = "";
        }

        // boton agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            oPersona = new Modelo.Persona(); // creo objeto persona

            groups = "A"; // "A" = agregar

            ModoDatos(); // manejo de groups
        }

        // boton modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (DGVpersonas.CurrentRow == null) // si no selecciono nada
            {
                MessageBox.Show("Debe seleccionar a una persona de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // completo
            oPersona = (Modelo.Persona)DGVpersonas.CurrentRow.DataBoundItem; // asigno a la variable el objeto Persona correspondiente a la fila seleccionada
            txtDNI.Text = oPersona.getDNI().ToString();
            txtNombre.Text = oPersona.Nombre;
            txtApellido.Text = oPersona.Apellido;
            txtFecha.Text = oPersona.getNacimiento();
            txtTel.Text = oPersona.getTelefono().ToString();

            groups = "M"; // "M" = modificar

            ModoDatos(); // manejo de groups
        }

        // boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGVpersonas.CurrentRow == null) 
            {
                MessageBox.Show("Debe seleccionar a una persona de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            oPersona = (Modelo.Persona)DGVpersonas.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confima que desea eliminar al " + oPersona.Nacionalidad + ", " + oPersona.Nombre + " " + oPersona.Apellido + " de la lista?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                oAduana.Personas.Remove(oPersona); // elimino objeto de la lista
                ArmarGrilla(); // update grilla
            }
        }

        // boton consular
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (DGVpersonas.CurrentRow == null) 
            {
                MessageBox.Show("Debe seleccionar a una persona de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // completo
            oPersona = (Modelo.Persona)DGVpersonas.CurrentRow.DataBoundItem;
            txtDNI.Text = oPersona.getDNI().ToString();
            txtNombre.Text = oPersona.Nombre;
            txtApellido.Text = oPersona.Apellido;
            txtFecha.Text = oPersona.getNacimiento();
            txtTel.Text = oPersona.getTelefono().ToString();

            groups = "C"; // "C" = consulta

            ModoDatos(); // manejo de groups
        }

        // boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (txtDNI.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtFecha.Text == "" || txtTel.Text == "")
            {
                MessageBox.Show("Hay campos vacios, debe completarlos para continuar...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int dni;
            if (!int.TryParse(txtDNI.Text, out dni)) // Si no ingresa un número
            {
                MessageBox.Show("Ingrese un número de DNI valido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime Fecha;
            if (!DateTime.TryParse(txtFecha.Text, out Fecha)) // valido formato de fecha
            {
                MessageBox.Show("Ingrese la fecha de nacimiento correctamente...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("La fecha de nacimiento debe tener formato de fecha (xx-xx-xxxx)", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int Telefono;
            if (!int.TryParse(txtTel.Text, out Telefono)) // Si no ingresa un número
            {
                MessageBox.Show("Ingrese un número de telefono valido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            // asigno a los atributos del objeto
            oPersona.setDNI(dni);
            oPersona.Nombre = txtNombre.Text;
            oPersona.Apellido = txtApellido.Text;
            oPersona.setNacimiento(Fecha);
            oPersona.setTelefono(Telefono);

            if (groups == "A") // agrego la persona a la aduana, si el groups esta en agregar
            {
                oAduana.Personas.Add(oPersona);
            }

            ArmarGrilla();
            ModoGrilla();
            Clean();
        }

        // boton cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clean();
            ModoGrilla();
        }

        // eventos de los txt que no permiten numeros 
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puedes ingresar números en el nombre...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puedes ingresar números en el apellido...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}