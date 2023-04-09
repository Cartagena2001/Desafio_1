using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESAFIO_1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            miArbol = new Arbol();
        }

        private Arbol miArbol;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void agregarPaciente(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || cmbGenero.SelectedIndex == -1 || cmbTipoSangre.SelectedIndex == -1 || cmbPresionArterial.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                string nombre = txtNombre.Text;
                string genero = cmbGenero.SelectedItem.ToString();
                string tipoSangre = cmbTipoSangre.SelectedItem.ToString();
                string presionArterial = cmbPresionArterial.SelectedItem.ToString();

                Paciente paciente = new Paciente(nombre, genero, tipoSangre, presionArterial);

                miArbol.AgregarPaciente(paciente);

                MessageBox.Show("El paciente ha sido agregado correctamente.");

                //limpiar todos los textbox
                LimpiarCampos();

                //mostrar en la tabla
                ActualizarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el paciente." + ex);
            }

        }

        private void eliminarPaciente(object sender, EventArgs e)
        {
            // Obtener el nombre del paciente a eliminar
            string nombre = txtNombre.Text;

            // Llamar al método EliminarPaciente del árbol para eliminar el paciente
            bool eliminado = miArbol.EliminarPaciente(nombre);

            // Verificar si el paciente fue eliminado
            if (eliminado)
            {
                MessageBox.Show("Paciente eliminado correctamente.");

                // Actualizar la tabla de pacientes
                ActualizarTabla();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se encontró ningún paciente con el nombre especificado.");
            }

        }

        private void tbPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtenemos la fila seleccionada
            DataGridViewRow filaSeleccionada = tbPacientes.Rows[e.RowIndex];

            // Asignamos los valores de la fila a los TextBox correspondientes
            txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            cmbGenero.Text = filaSeleccionada.Cells["Genero"].Value.ToString();
            cmbTipoSangre.Text = filaSeleccionada.Cells["TipoSangre"].Value.ToString();
            cmbPresionArterial.Text = filaSeleccionada.Cells["PresionArterial"].Value.ToString();

        }

        private void tbPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActualizarTabla()
        {
            // Limpiar la tabla de pacientes
            tbPacientes.Rows.Clear();

            // Recorrer todos los pacientes del árbol
            foreach (Paciente paciente in miArbol.ObtenerPacientes())
            {
                // Agregar el paciente a la tabla
                tbPacientes.Rows.Add(paciente.Nombre, paciente.Genero, paciente.TipoSangre, paciente.PresionArterial);
            }
        }
        private void ActualizarTablaFiltrada(List<Paciente> pacientes)
        {
            var pacientesFiltrados = pacientes.Where(p => p.Nombre.ToLower().Contains(txtNombre.Text.ToLower()));

            var pacienteEncontrado = pacientesFiltrados.FirstOrDefault();

            if (pacienteEncontrado != null)
            {
                // Asignar los valores a los controles de formulario correspondientes
                txtNombre.Text = pacienteEncontrado.Nombre;
                cmbGenero.SelectedItem = pacienteEncontrado.Genero;
                cmbTipoSangre.SelectedItem = pacienteEncontrado.TipoSangre;
                cmbPresionArterial.SelectedItem = pacienteEncontrado.PresionArterial;
            }
            else
            {
                MessageBox.Show("No se encontró ningún paciente con el nombre buscado.");
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            cmbGenero.SelectedIndex = -1;
            cmbTipoSangre.SelectedIndex = -1;
            cmbPresionArterial.SelectedIndex = -1;
        }

        private void Form1_load(object sender, EventArgs e)
        {
            tbPacientes.Columns.Add("Nombre", "Nombre");
            tbPacientes.Columns.Add("Genero", "Genero");
            tbPacientes.Columns.Add("TipoSangre", "Tipo de Sangre");
            tbPacientes.Columns.Add("PresionArterial", "Presión Arterial");
        }

        private void tbPacientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < miArbol.Pacientes.Count)
            {
                Paciente paciente = miArbol.Pacientes[e.RowIndex];
                if (e.ColumnIndex == 0)
                {
                    e.Value = paciente.Nombre;
                }
                else if (e.ColumnIndex == 1)
                {
                    e.Value = paciente.Genero;
                }
                else if (e.ColumnIndex == 2)
                {
                    e.Value = paciente.TipoSangre;
                }
                else if (e.ColumnIndex == 3)
                {
                    e.Value = paciente.PresionArterial;
                }
            }
        }

        private void txtBusqueda_Click(object sender, EventArgs e)
        {
            string nombreBuscado = txtNombre.Text;

            // Validar si el nombre buscado existe en la tabla
            if (miArbol.BuscarPaciente(nombreBuscado) == null)
            {
                MessageBox.Show("No se encontraron resultados para el nombre buscado.");
                return;
            }

            List<Paciente> pacientesCoincidentes = miArbol.BuscarPacientesNombre(nombreBuscado);

            ActualizarTablaFiltrada(pacientesCoincidentes);
        }

        private void pacienteRiesgo(object sender, EventArgs e)
        {
            pacienteRiesgo ptRiesgo = new pacienteRiesgo();
            Home hm = new Home();
            ptRiesgo.Location = new Point(0, 0);
            ptRiesgo.Size = new Size(500, 500);
            ptRiesgo.BackColor = Color.White;
            this.Controls.Add(ptRiesgo);

            // Agregar cualquier control o formulario dentro del panel secundario

            // Mostrar el panel secundario
            ptRiesgo.Visible = true;
        }

        private void limpiarForm_click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            cmbGenero.SelectedIndex = -1;
            cmbTipoSangre.SelectedIndex = -1;
            cmbPresionArterial.SelectedIndex = -1;
        }

        private void porcentajes_Click(object sender, EventArgs e)
        {

        }
    }
}
