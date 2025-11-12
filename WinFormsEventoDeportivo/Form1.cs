using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsEventoDeportivo.Controller;
using WinFormsEventoDeportivo.Model;

namespace WinFormsEventoDeportivo
{
    public partial class Form1 : Form
    {
        private readonly APIController _api = new APIController();
        private List<EventoDeportivoModel> _eventos = new List<EventoDeportivoModel>();

        public Form1()
        {
            InitializeComponent();
        }

        // ======= FORM LOAD =======
        private async void Form1_Load(object sender, EventArgs e)
        {
            await CargarEventosAsync();
        }

        // ======= MÉTODO PARA CARGAR EVENTOS =======
        private async Task CargarEventosAsync()
        {
            try
            {
                _eventos = await _api.GetEventosDeportivosAsync();
                dgvInfo.DataSource = null;
                dgvInfo.DataSource = _eventos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los eventos: {ex.Message}");
            }
        }

        // ======= EVENTO AL SELECCIONAR UNA FILA =======
        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvInfo.Rows[e.RowIndex].DataBoundItem as EventoDeportivoModel;
                if (fila != null)
                {
                    txtID.Text = fila.Id.ToString();
                    txtNombreEvento.Text = fila.NombreEvento;
                    txtTipoEvento.Text = fila.Tipo;
                    txtFecha.Text = fila.Fecha.ToString("yyyy-MM-dd");
                    txtLugar.Text = fila.Lugar;
                    txtNoParticipantes.Text = fila.Participantes.ToString();
                    txtCostoInscripcion.Text = fila.CostoInscripción.ToString();
                }
            }
        }

        // ======= MÉTODO PARA LIMPIAR CAMPOS =======
        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombreEvento.Clear();
            txtTipoEvento.Clear();
            txtFecha.Clear();
            txtLugar.Clear();
            txtNoParticipantes.Clear();
            txtCostoInscripcion.Clear();
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            await CargarEventosAsync();
        }

        private async void k(object sender, EventArgs e)
        {
            try
            {
                var nuevoEvento = new EventoDeportivoModel
                {
                    NombreEvento = txtNombreEvento.Text,
                    Tipo = txtTipoEvento.Text,
                    Fecha = DateTime.Parse(txtFecha.Text),
                    Lugar = txtLugar.Text,
                    Participantes = int.Parse(txtNoParticipantes.Text),
                    CostoInscripción = decimal.Parse(txtCostoInscripcion.Text)
                };

                var creado = await _api.PostEventosDeportivosAsync(nuevoEvento);
                if (creado != null)
                {
                    MessageBox.Show("✅ Evento agregado correctamente.");
                    await CargarEventosAsync();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("❌ No se pudo agregar el evento.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar: {ex.Message}");
            }
        }
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoEvento = new EventoDeportivoModel
                {
                    NombreEvento = txtNombreEvento.Text,
                    Tipo = txtTipoEvento.Text,
                    Fecha = DateTime.Parse(txtFecha.Text),
                    Lugar = txtLugar.Text,
                    Participantes = int.Parse(txtNoParticipantes.Text),
                    CostoInscripción = decimal.Parse(txtCostoInscripcion.Text)
                };

                var creado = await _api.PostEventosDeportivosAsync(nuevoEvento);
                if (creado != null)
                {
                    MessageBox.Show("✅ Evento agregado correctamente.");
                    await CargarEventosAsync();
                }
                else
                {
                    MessageBox.Show("❌ No se pudo agregar el evento.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtID.Text, out int id))
                {
                    MessageBox.Show("Debes ingresar un ID válido.");
                    return;
                }

                var eventoActualizado = new EventoDeportivoModel
                {
                    Id = id,
                    NombreEvento = txtNombreEvento.Text,
                    Tipo = txtTipoEvento.Text,
                    Fecha = DateTime.Parse(txtFecha.Text),
                    Lugar = txtLugar.Text,
                    Participantes = int.Parse(txtNoParticipantes.Text),
                    CostoInscripción = decimal.Parse(txtCostoInscripcion.Text)
                };

                bool exito = await _api.PutEventosDeportivosAsync(id, eventoActualizado);
                if (exito)
                {
                    MessageBox.Show("✅ Evento actualizado correctamente.");
                    await CargarEventosAsync();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("❌ No se pudo actualizar el evento.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}");
            }
        }

      
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int id))
            {
                MessageBox.Show("Debes ingresar un ID válido para eliminar.");
                return;
            }

            var confirm = MessageBox.Show("¿Seguro que deseas eliminar este evento?",
                                          "Confirmar eliminación",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bool exito = await _api.DeleteEventosDeportivosAsync(id);
                if (exito)
                {
                    MessageBox.Show("🗑️ Evento eliminado correctamente.");
                    await CargarEventosAsync();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("❌ No se pudo eliminar el evento.");
                }
            }
        }
    }
}
