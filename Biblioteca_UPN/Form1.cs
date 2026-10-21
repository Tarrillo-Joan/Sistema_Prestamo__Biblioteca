using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Biblioteca_UPN
{
    public partial class Form1 : Form
    {
        private GestorBiblioteca gestor = new GestorBiblioteca();
        private Color fondo = Color.FromArgb(243, 246, 250);

        public Form1()
        {
            InitializeComponent();

            Size = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Normal;
            AutoSize = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackColor = fondo;
            AutoScaleMode = AutoScaleMode.None;

            tabContenido.Appearance = TabAppearance.FlatButtons;
            tabContenido.ItemSize = new Size(0, 1);
            tabContenido.SizeMode = TabSizeMode.Fixed;

            gestor.CargarLibrosIniciales();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x1328)
            {
                m.Result = (IntPtr)1;
                return;
            }

            base.WndProc(ref m);
        }
        private bool ValidarCodigoEstudiante(string codigo)
        {
            if (codigo.Length != 9)
            {
                return false;
            }

            if (!codigo.StartsWith("N00"))
            {
                return false;
            }

            for (int i = 3; i < codigo.Length; i++)
            {
                if (codigo[i] < '0' || codigo[i] > '9')
                {
                    return false;
                }
            }

            return true;
        }
        private bool ValidarNombreApellido(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return false;
            }

            foreach (char letra in texto)
            {
                if (!char.IsLetter(letra) && letra != ' ')
                {
                    return false;
                }
            }

            return true;
        }
        private void btnRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoEstudiante.Text;
            string nombre = txtNombreEstudiante.Text;
            string apellidos = txtApellidosEstudiante.Text;

            if (!ValidarCodigoEstudiante(codigo))
            {
                MessageBox.Show(
                    "El código debe comenzar con N00 y tener 6 dígitos adicionales.",
                    "Código inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!ValidarNombreApellido(nombre))
            {
                MessageBox.Show(
                    "El nombre debe contener solo letras.",
                    "Nombre inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!ValidarNombreApellido(apellidos))
            {
                MessageBox.Show(
                    "El apellido debe contener solo letras.",
                    "Apellido inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string estado = cboEstadoMatricula.Text;

            string mensaje = gestor.RegistrarEstudiante(
                codigo, nombre, apellidos, estado);

            MessageBox.Show(mensaje, "Registro exitoso");

            if (mensaje == "Estudiante registrado correctamente y guardado.")
            {
                txtCodigoEstudiante.Clear();
                txtNombreEstudiante.Clear();
                txtApellidosEstudiante.Clear();
                cboEstadoMatricula.SelectedIndex = -1;
            }
        }

        private void btnMostrarEstudiantes_Click(object sender, EventArgs e)
        {
            dgvEstudiantes.Rows.Clear();

            int cantidad = gestor.ObtenerCantidadEstudiantes();

            if (cantidad == 0)
            {
                MessageBox.Show("No hay estudiantes registrados.");
                return;
            }

            for (int i = 0; i < cantidad; i++)
            {
                Estudiante estudiante = gestor.ObtenerEstudiantePorIndice(i);

                dgvEstudiantes.Rows.Add(
                    estudiante.Codigo,
                    estudiante.Nombre,
                    estudiante.Apellidos,
                    estudiante.EstadoMatricula
                );
            }

        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoEstudiante.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Ingrese el código del estudiante.");
                txtCodigoEstudiante.Focus();
                return;
            }

            Estudiante estudiante = gestor.BuscarEstudiante(codigo);

            if (estudiante == null)
            {
                MessageBox.Show("No se encontró al estudiante.");
                return;
            }

            txtNombreEstudiante.Text = estudiante.Nombre;
            txtApellidosEstudiante.Text = estudiante.Apellidos;
            cboEstadoMatricula.Text = estudiante.EstadoMatricula;

            MessageBox.Show("Estudiante encontrado correctamente.");
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            tabContenido.SelectedTab = tabEstudiantes;
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            tabContenido.SelectedTab = tabLibros;
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            tabContenido.SelectedTab = tabPrestamos;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            tabContenido.SelectedTab = tabConsultas;
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            tabContenido.SelectedTab = tabDevoluciones;
        }

        private void btnRegistrarLibro_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloLibro.Text.Trim();
            string area = txtAreaLibro.Text.Trim();
            string codigoUL = txtCodigoUL.Text.Trim();

            string mensaje = gestor.RegistrarLibro(
                "", titulo, area, codigoUL);

            MessageBox.Show(mensaje);

            if (mensaje.Contains("correctamente"))
            {
                txtTituloLibro.Clear();
                txtAreaLibro.Clear();
                txtCodigoUL.Clear();

                // Actualizar automáticamente la tabla.
                dgvLibros.Rows.Clear();

                int cantidad = gestor.ObtenerCantidadLibros();

                for (int i = 0; i < cantidad; i++)
                {
                    Libro libro = gestor.ObtenerLibroPorIndice(i);

                    for (int j = 0;
                         j < libro.ObtenerCantidadEjemplares();
                         j++)
                    {
                        Ejemplar ejemplar =
                            libro.ObtenerEjemplarPorIndice(j);

                        dgvLibros.Rows.Add(
                            libro.CodigoLibro,
                            libro.Titulo,
                            libro.Area,
                            ejemplar.CodigoUL
                        );
                    }
                }

                dgvLibros.ClearSelection();
            }
        }

        private void btnMostrarLibros_Click(object sender, EventArgs e)
        {
            dgvLibros.Rows.Clear();

            int cantidad = gestor.ObtenerCantidadLibros();

            if (cantidad == 0)
            {
                MessageBox.Show("No hay libros registrados.");
                return;
            }

            for (int i = 0; i < cantidad; i++)
            {
                Libro libro = gestor.ObtenerLibroPorIndice(i);

                for (int j = 0; j < libro.ObtenerCantidadEjemplares(); j++)
                {
                    Ejemplar ejemplar = libro.ObtenerEjemplarPorIndice(j);

                    dgvLibros.Rows.Add(
                        libro.CodigoLibro,
                        libro.Titulo,
                        libro.Area,
                        ejemplar.CodigoUL
                    );
                }
            }
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            string codigoUL = txtCodigoUL.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigoUL))
            {
                MessageBox.Show("Ingrese el código UL del ejemplar.");
                txtCodigoUL.Focus();
                return;
            }

            Libro libro = gestor.BuscarLibroPorUL(codigoUL);

            if (libro == null)
            {
                MessageBox.Show("No se encontró ningún libro con ese código UL.");
                return;
            }

            dgvLibros.Rows.Clear();

            Ejemplar ejemplar = libro.BuscarEjemplar(codigoUL);

            if (ejemplar != null)
            {
                dgvLibros.Rows.Add(
                    libro.CodigoLibro,
                    libro.Titulo,
                    libro.Area,
                    ejemplar.CodigoUL
                );

                MessageBox.Show("Libro encontrado correctamente.");
            }
        }

        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            string codigoEstudiante = txtCodigoEstudiantePrestamo.Text.Trim();
            string codigoUL = txtCodigoULPrestamo.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigoEstudiante) ||
                string.IsNullOrWhiteSpace(codigoUL))
            {
                MessageBox.Show("Ingrese el código del estudiante y el código UL.");
                return;
            }

            string mensaje = gestor.RegistrarPrestamo(
                codigoEstudiante, codigoUL);

            MessageBox.Show(mensaje);

            if (mensaje.Contains("correctamente"))
            {
                txtCodigoEstudiantePrestamo.Clear();
                txtCodigoULPrestamo.Clear();
            }
        }

        private void btnMostrarPrestamos_Click(object sender, EventArgs e)
        {
            dgvPrestamos.Rows.Clear();

            for (int i = 0; i < gestor.ObtenerCantidadPrestamos(); i++)
            {
                Prestamo prestamo = gestor.ObtenerPrestamoPorIndice(i);

                if (prestamo != null && prestamo.Activo)
                {
                    dgvPrestamos.Rows.Add(
                        prestamo.CodigoEstudiante,
                        prestamo.CodigoUL,
                        prestamo.FechaPrestamo.ToString("dd/MM/yyyy"),
                        prestamo.FechaDevolucion.ToString("dd/MM/yyyy"),
                        "Pendiente"
                    );
                }
            }

            if (dgvPrestamos.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No hay préstamos activos.",
                    "Préstamos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            dgvPrestamos.Rows.Clear();

            for (int i = 0; i < gestor.ObtenerCantidadPrestamos(); i++)
            {
                Prestamo prestamo = gestor.ObtenerPrestamoPorIndice(i);

                if (prestamo != null && !prestamo.Activo)
                {
                    dgvPrestamos.Rows.Add(
                        prestamo.CodigoEstudiante,
                        prestamo.CodigoUL,
                        prestamo.FechaPrestamo.ToString("dd/MM/yyyy"),
                        prestamo.FechaDevolucion.ToString("dd/MM/yyyy"),
                        "Devuelto"
                    );
                }
            }

            if (dgvPrestamos.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Todavía no hay préstamos devueltos.",
                    "Historial de préstamos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
        private void btnConsultarEstudiante_Click(object sender, EventArgs e)
        {
            string codigo = txtConsultaEstudiante.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Ingrese el código del estudiante.");
                txtConsultaEstudiante.Focus();
                return;
            }

            string resultado = gestor.ConsultarEstudiante(codigo);

            txtResultadoConsulta.Text = resultado;
        }

        private void btnConsultarLibro_Click(object sender, EventArgs e)
        {
            string codigoUL = txtConsultaUL.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigoUL))
            {
                MessageBox.Show("Ingrese el código UL del ejemplar.");
                txtConsultaUL.Focus();
                return;
            }

            string resultado = gestor.ConsultarLibro(codigoUL);

            txtResultadoConsulta.Text = resultado;
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            string codigoUL = txtCodigoULDevolucion.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigoUL))
            {
                txtResultadoDevolucion.Text =
                    "Ingrese el código UL del ejemplar.";
                return;
            }

            Libro libro = gestor.BuscarLibroPorUL(codigoUL);
            Prestamo prestamo = null;

            for (int i = 0; i < gestor.ObtenerCantidadPrestamos(); i++)
            {
                Prestamo actual = gestor.ObtenerPrestamoPorIndice(i);

                if (actual != null &&
                    actual.Activo &&
                    string.Equals(
                        actual.CodigoUL,
                        codigoUL,
                        StringComparison.OrdinalIgnoreCase))
                {
                    prestamo = actual;
                    break;
                }
            }

            if (prestamo == null)
            {
                txtResultadoDevolucion.Text =
                    gestor.DevolverLibro(codigoUL);
                return;
            }

            Estudiante estudiante =
                gestor.BuscarEstudiante(prestamo.CodigoEstudiante);

            string mensaje = gestor.DevolverLibro(codigoUL);

            if (mensaje.Contains("correctamente"))
            {
                string nombreEstudiante = estudiante != null
                    ? estudiante.Nombre + " " + estudiante.Apellidos
                    : "No disponible";

                txtResultadoDevolucion.Text =
                    "DEVOLUCIÓN REGISTRADA CORRECTAMENTE" +
                    Environment.NewLine +
                    "----------------------------------" +
                    Environment.NewLine +
                    "DATOS DEL LIBRO" + Environment.NewLine +
                    "Código del libro: " + libro.CodigoLibro +
                    Environment.NewLine +
                    "Título: " + libro.Titulo +
                    Environment.NewLine +
                    "Área: " + libro.Area +
                    Environment.NewLine +
                    "Código UL: " + prestamo.CodigoUL +
                    Environment.NewLine + Environment.NewLine +
                    "DATOS DEL PRÉSTAMO" + Environment.NewLine +
                    "Código del estudiante: " +
                    prestamo.CodigoEstudiante +
                    Environment.NewLine +
                    "Nombre del estudiante: " + nombreEstudiante +
                    Environment.NewLine +
                    "Fecha del préstamo: " +
                    prestamo.FechaPrestamo.ToString("dd/MM/yyyy") +
                    Environment.NewLine +
                    "Fecha prevista de devolución: " +
                    prestamo.FechaDevolucion.ToString("dd/MM/yyyy") +
                    Environment.NewLine +
                    "Estado: Devuelto";

                txtCodigoULDevolucion.Clear();
            }
            else
            {
                txtResultadoDevolucion.Text = mensaje;
            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow == null ||
        dgvLibros.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un libro de la tabla.");
                return;
            }

            object valor = dgvLibros.CurrentRow.Cells[0].Value;

            if (valor == null)
            {
                MessageBox.Show("No se pudo obtener el código del libro.");
                return;
            }

            string codigo = valor.ToString();

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar el libro con código " + codigo + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
                return;

            string mensaje = gestor.EliminarLibro(codigo);

            MessageBox.Show(mensaje);

            if (mensaje == "Libro eliminado correctamente.")
            {
                dgvLibros.Rows.Clear();

                int cantidad = gestor.ObtenerCantidadLibros();

                for (int i = 0; i < cantidad; i++)
                {
                    Libro libro = gestor.ObtenerLibroPorIndice(i);

                    for (int j = 0;
                         j < libro.ObtenerCantidadEjemplares();
                         j++)
                    {
                        Ejemplar ejemplar =
                            libro.ObtenerEjemplarPorIndice(j);

                        dgvLibros.Rows.Add(
                            libro.CodigoLibro,
                            libro.Titulo,
                            libro.Area,
                            ejemplar.CodigoUL
                        );
                    }
                }

                dgvLibros.ClearSelection();
            }
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.CurrentRow == null ||
                dgvEstudiantes.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un estudiante de la tabla.");
                return;
            }

            object valor = dgvEstudiantes.CurrentRow.Cells[0].Value;

            if (valor == null)
            {
                MessageBox.Show("Seleccione un estudiante válido.");
                return;
            }

            string codigo = valor.ToString();

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar al estudiante con código "
                + codigo + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
                return;

            string mensaje = gestor.EliminarEstudiante(codigo);

            MessageBox.Show(mensaje);

            if (mensaje.Contains("correctamente"))
            {
                btnMostrarEstudiantes_Click(sender, e);
            }
        }

        private void btnOrdenarBurbuja_Click(object sender, EventArgs e)
        {
            gestor.OrdenarBurbujaEstudiantes();
            btnMostrarEstudiantes_Click(sender, e);
        }

        private void btnOrdenarSeleccion_Click(object sender, EventArgs e)
        {
            gestor.OrdenarSeleccionEstudiantes();
            btnMostrarEstudiantes_Click(sender, e);
        }
    }
}