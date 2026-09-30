using System.Globalization;
using ReparaLab.Application.Commands;
using ReparaLab.Application.Common;
using ReparaLab.Application.DTOs;
using ReparaLab.Application.Queries;
using ReparaLab.Domain.Enums;
using ReparaLab.Infrastructure.Logging;

namespace ReparaLab.WinForms;

public partial class FrmReparaciones : Form
{
    private readonly RegistrarOrdenUseCase _registrarOrden;
    private readonly CambiarEstadoOrdenUseCase _cambiarEstado;
    private readonly ListarOrdenesUseCase _listarOrdenes;
    private readonly ObtenerPlantillaUseCase _obtenerPlantilla;
    private readonly ConsultarBitacoraUseCase _consultarBitacora;

    public FrmReparaciones(
        RegistrarOrdenUseCase registrarOrden,
        CambiarEstadoOrdenUseCase cambiarEstado,
        ListarOrdenesUseCase listarOrdenes,
        ObtenerPlantillaUseCase obtenerPlantilla,
        ConsultarBitacoraUseCase consultarBitacora)
    {
        InitializeComponent();
        _registrarOrden = registrarOrden;
        _cambiarEstado = cambiarEstado;
        _listarOrdenes = listarOrdenes;
        _obtenerPlantilla = obtenerPlantilla;
        _consultarBitacora = consultarBitacora;
        CargarOpciones();
        ActualizarVista();
    }

    private void CargarOpciones()
    {
        cmbEquipo.DataSource = CatalogoOpciones.Equipos.ToList();
        cmbServicio.DataSource = CatalogoOpciones.Servicios.ToList();
        cmbPlan.DataSource = CatalogoOpciones.Planes.ToList();
        cmbNotificacion.DataSource = CatalogoOpciones.Notificaciones.ToList();
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        var resultado = _registrarOrden.Ejecutar(CrearSolicitud());
        MostrarResultado(resultado, "Registro de orden");

        if (resultado.Exito)
            LimpiarFormulario();

        ActualizarVista();
    }

    private void btnFinalizar_Click(object sender, EventArgs e)
    {
        CambiarEstadoSeleccionada(EstadoOrden.Finalizada);
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        CambiarEstadoSeleccionada(EstadoOrden.Cancelada);
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        LimpiarFormulario();
    }

    private void btnCargarPlantilla_Click(object sender, EventArgs e)
    {
        var plantilla = _obtenerPlantilla.Ejecutar(cmbServicio.Text);
        if (plantilla is null)
        {
            MessageBox.Show("Seleccione un servicio válido.", "Plantilla", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        txtTareas.Lines = plantilla.Tareas.ToArray();
        txtTareas.Focus();
    }

    private void btnVerificarBitacora_Click(object sender, EventArgs e)
    {
        var mismaInstancia = _consultarBitacora.ComparteInstanciaCon(Bitacora.Instancia);
        var eventos = _consultarBitacora.Ejecutar().Count;

        MessageBox.Show(
            $"Bitácora inyectada vs Bitacora.Instancia{Environment.NewLine}" +
            $"ReferenceEquals = {mismaInstancia}{Environment.NewLine}" +
            $"Eventos acumulados: {eventos}",
            "Verificación de bitácora",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtTareas.Clear();
    }

    private RegistrarOrdenRequest CrearSolicitud() => new()
    {
        Cliente = txtCliente.Text,
        Equipo = cmbEquipo.Text,
        Falla = txtFalla.Text,
        Servicio = cmbServicio.Text,
        Plan = cmbPlan.Text,
        Notificacion = cmbNotificacion.Text,
        Repuesto = chkRepuesto.Checked,
        Tareas = txtTareas.Lines
    };

    private void CambiarEstadoSeleccionada(EstadoOrden nuevoEstado)
    {
        if (dgvOrdenes.CurrentRow?.DataBoundItem is not OrdenDto orden)
        {
            MessageBox.Show("Seleccione una orden de la tabla.", "Cambio de estado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var resultado = _cambiarEstado.Ejecutar(orden.Id, nuevoEstado);
        MostrarResultado(resultado, "Cambio de estado");
        ActualizarVista();
    }

    private void ActualizarVista()
    {
        dgvOrdenes.DataSource = null;
        dgvOrdenes.DataSource = _listarOrdenes.Ejecutar().ToList();
        ConfigurarColumnas();

        txtBitacora.Lines = _consultarBitacora.Ejecutar().ToArray();
        txtBitacora.SelectionStart = txtBitacora.TextLength;
        txtBitacora.ScrollToCaret();
    }

    private void ConfigurarColumnas()
    {
        ConfigurarColumna(nameof(OrdenDto.Id), "Id", 35);
        ConfigurarColumna(nameof(OrdenDto.Cliente), "Cliente", 95);
        ConfigurarColumna(nameof(OrdenDto.Equipo), "Equipo", 70);
        ConfigurarColumna(nameof(OrdenDto.Servicio), "Servicio", 95);
        ConfigurarColumna(nameof(OrdenDto.Plan), "Plan", 65);
        ConfigurarColumna(nameof(OrdenDto.Tareas), "Tareas", 200);
        ConfigurarColumna(nameof(OrdenDto.Total), "Total ($)", 60);
        ConfigurarColumna(nameof(OrdenDto.GarantiaDias), "Garantía (días)", 70);
        ConfigurarColumna(nameof(OrdenDto.Estado), "Estado", 80);

        var total = dgvOrdenes.Columns[nameof(OrdenDto.Total)];
        if (total is null)
            return;

        total.DefaultCellStyle.Format = "0.00";
        total.DefaultCellStyle.FormatProvider = CultureInfo.InvariantCulture;
        total.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    }

    private void ConfigurarColumna(string nombre, string encabezado, float peso)
    {
        var columna = dgvOrdenes.Columns[nombre];
        if (columna is null)
            return;

        columna.HeaderText = encabezado;
        columna.FillWeight = peso;
    }

    private void LimpiarFormulario()
    {
        txtCliente.Clear();
        txtFalla.Clear();
        cmbEquipo.SelectedIndex = 0;
        cmbServicio.SelectedIndex = 0;
        cmbPlan.SelectedIndex = 0;
        cmbNotificacion.SelectedIndex = 0;
        chkRepuesto.Checked = false;
        txtTareas.Clear();
        txtCliente.Focus();
    }

    private static void MostrarResultado(ResultadoOperacion resultado, string titulo)
    {
        var icono = resultado.Exito ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
        MessageBox.Show(resultado.Mensaje, titulo, MessageBoxButtons.OK, icono);
    }
}
