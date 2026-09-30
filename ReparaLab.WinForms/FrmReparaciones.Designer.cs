namespace ReparaLab.WinForms
{
    partial class FrmReparaciones
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblEquipo = new Label();
            cmbEquipo = new ComboBox();
            lblFalla = new Label();
            txtFalla = new TextBox();
            lblServicio = new Label();
            cmbServicio = new ComboBox();
            lblPlan = new Label();
            cmbPlan = new ComboBox();
            lblNotificacion = new Label();
            cmbNotificacion = new ComboBox();
            chkRepuesto = new CheckBox();
            btnCargarPlantilla = new Button();
            lblTareas = new Label();
            txtTareas = new TextBox();
            btnRegistrar = new Button();
            btnFinalizar = new Button();
            btnCancelar = new Button();
            btnLimpiar = new Button();
            lblOrdenes = new Label();
            dgvOrdenes = new DataGridView();
            lblBitacora = new Label();
            btnVerificarBitacora = new Button();
            txtBitacora = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).BeginInit();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 64, 175);
            lblTitulo.Location = new Point(18, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(363, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ReparaLab | Órdenes de reparación";
            //
            // lblSubtitulo
            //
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.ForeColor = Color.FromArgb(71, 85, 105);
            lblSubtitulo.Location = new Point(21, 44);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(300, 15);
            lblSubtitulo.TabIndex = 0;
            lblSubtitulo.Text = "Registro de equipos LAPTOP, CELULAR y TABLET";
            //
            // lblCliente
            //
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCliente.ForeColor = Color.FromArgb(30, 41, 59);
            lblCliente.Location = new Point(20, 70);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            //
            // txtCliente
            //
            txtCliente.Location = new Point(20, 90);
            txtCliente.MaxLength = 80;
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(300, 23);
            txtCliente.TabIndex = 1;
            //
            // lblEquipo
            //
            lblEquipo.AutoSize = true;
            lblEquipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEquipo.ForeColor = Color.FromArgb(30, 41, 59);
            lblEquipo.Location = new Point(350, 70);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(45, 15);
            lblEquipo.TabIndex = 0;
            lblEquipo.Text = "Equipo";
            //
            // cmbEquipo
            //
            cmbEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipo.FormattingEnabled = true;
            cmbEquipo.Location = new Point(350, 90);
            cmbEquipo.Name = "cmbEquipo";
            cmbEquipo.Size = new Size(300, 23);
            cmbEquipo.TabIndex = 2;
            //
            // lblFalla
            //
            lblFalla.AutoSize = true;
            lblFalla.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFalla.ForeColor = Color.FromArgb(30, 41, 59);
            lblFalla.Location = new Point(680, 70);
            lblFalla.Name = "lblFalla";
            lblFalla.Size = new Size(89, 15);
            lblFalla.TabIndex = 0;
            lblFalla.Text = "Falla reportada";
            //
            // txtFalla
            //
            txtFalla.Location = new Point(680, 90);
            txtFalla.MaxLength = 150;
            txtFalla.Name = "txtFalla";
            txtFalla.Size = new Size(300, 23);
            txtFalla.TabIndex = 3;
            //
            // lblServicio
            //
            lblServicio.AutoSize = true;
            lblServicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblServicio.ForeColor = Color.FromArgb(30, 41, 59);
            lblServicio.Location = new Point(20, 125);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(50, 15);
            lblServicio.TabIndex = 0;
            lblServicio.Text = "Servicio";
            //
            // cmbServicio
            //
            cmbServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(20, 145);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(300, 23);
            cmbServicio.TabIndex = 4;
            cmbServicio.SelectedIndexChanged += cmbServicio_SelectedIndexChanged;
            //
            // lblPlan
            //
            lblPlan.AutoSize = true;
            lblPlan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPlan.ForeColor = Color.FromArgb(30, 41, 59);
            lblPlan.Location = new Point(350, 125);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(29, 15);
            lblPlan.TabIndex = 0;
            lblPlan.Text = "Plan";
            //
            // cmbPlan
            //
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Location = new Point(350, 145);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(300, 23);
            cmbPlan.TabIndex = 5;
            //
            // lblNotificacion
            //
            lblNotificacion.AutoSize = true;
            lblNotificacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNotificacion.ForeColor = Color.FromArgb(30, 41, 59);
            lblNotificacion.Location = new Point(680, 125);
            lblNotificacion.Name = "lblNotificacion";
            lblNotificacion.Size = new Size(88, 15);
            lblNotificacion.TabIndex = 0;
            lblNotificacion.Text = "Aviso simulado";
            //
            // cmbNotificacion
            //
            cmbNotificacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNotificacion.FormattingEnabled = true;
            cmbNotificacion.Location = new Point(680, 145);
            cmbNotificacion.Name = "cmbNotificacion";
            cmbNotificacion.Size = new Size(300, 23);
            cmbNotificacion.TabIndex = 6;
            //
            // chkRepuesto
            //
            chkRepuesto.AutoSize = true;
            chkRepuesto.ForeColor = Color.FromArgb(30, 41, 59);
            chkRepuesto.Location = new Point(20, 204);
            chkRepuesto.Name = "chkRepuesto";
            chkRepuesto.Size = new Size(171, 19);
            chkRepuesto.TabIndex = 7;
            chkRepuesto.Text = "Agregar repuesto fijo ($15)";
            chkRepuesto.UseVisualStyleBackColor = true;
            //
            // btnCargarPlantilla
            //
            btnCargarPlantilla.BackColor = Color.FromArgb(14, 116, 144);
            btnCargarPlantilla.Cursor = Cursors.Hand;
            btnCargarPlantilla.FlatAppearance.BorderSize = 0;
            btnCargarPlantilla.FlatStyle = FlatStyle.Flat;
            btnCargarPlantilla.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCargarPlantilla.ForeColor = Color.White;
            btnCargarPlantilla.Location = new Point(350, 198);
            btnCargarPlantilla.Name = "btnCargarPlantilla";
            btnCargarPlantilla.Size = new Size(200, 30);
            btnCargarPlantilla.TabIndex = 8;
            btnCargarPlantilla.Text = "Cargar plantilla del servicio";
            btnCargarPlantilla.UseVisualStyleBackColor = false;
            btnCargarPlantilla.Click += btnCargarPlantilla_Click;
            //
            // lblTareas
            //
            lblTareas.AutoSize = true;
            lblTareas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTareas.ForeColor = Color.FromArgb(30, 41, 59);
            lblTareas.Location = new Point(680, 180);
            lblTareas.Name = "lblTareas";
            lblTareas.Size = new Size(213, 15);
            lblTareas.TabIndex = 0;
            lblTareas.Text = "Tareas de la plantilla (una por línea)";
            //
            // txtTareas
            //
            txtTareas.AcceptsReturn = true;
            txtTareas.Location = new Point(680, 200);
            txtTareas.Multiline = true;
            txtTareas.Name = "txtTareas";
            txtTareas.ScrollBars = ScrollBars.Vertical;
            txtTareas.Size = new Size(300, 80);
            txtTareas.TabIndex = 9;
            //
            // btnRegistrar
            //
            btnRegistrar.BackColor = Color.FromArgb(30, 64, 175);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(20, 292);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 34);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar orden";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            //
            // btnFinalizar
            //
            btnFinalizar.BackColor = Color.FromArgb(21, 128, 61);
            btnFinalizar.Cursor = Cursors.Hand;
            btnFinalizar.FlatAppearance.BorderSize = 0;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFinalizar.ForeColor = Color.White;
            btnFinalizar.Location = new Point(180, 292);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(170, 34);
            btnFinalizar.TabIndex = 11;
            btnFinalizar.Text = "Finalizar seleccionada";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            //
            // btnCancelar
            //
            btnCancelar.BackColor = Color.FromArgb(185, 28, 28);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(360, 292);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(170, 34);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar seleccionada";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            //
            // btnLimpiar
            //
            btnLimpiar.BackColor = Color.FromArgb(100, 116, 139);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(540, 292);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 34);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            //
            // lblOrdenes
            //
            lblOrdenes.AutoSize = true;
            lblOrdenes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOrdenes.ForeColor = Color.FromArgb(30, 64, 175);
            lblOrdenes.Location = new Point(20, 338);
            lblOrdenes.Name = "lblOrdenes";
            lblOrdenes.Size = new Size(139, 19);
            lblOrdenes.TabIndex = 0;
            lblOrdenes.Text = "Órdenes registradas";
            //
            // dgvOrdenes
            //
            dgvOrdenes.AllowUserToAddRows = false;
            dgvOrdenes.AllowUserToDeleteRows = false;
            dgvOrdenes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(239, 246, 255);
            dgvOrdenes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrdenes.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 64, 175);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 64, 175);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvOrdenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvOrdenes.ColumnHeadersHeight = 30;
            dgvOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(191, 219, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvOrdenes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvOrdenes.EnableHeadersVisualStyles = false;
            dgvOrdenes.GridColor = Color.FromArgb(226, 232, 240);
            dgvOrdenes.Location = new Point(20, 362);
            dgvOrdenes.MultiSelect = false;
            dgvOrdenes.Name = "dgvOrdenes";
            dgvOrdenes.ReadOnly = true;
            dgvOrdenes.RowHeadersVisible = false;
            dgvOrdenes.RowTemplate.Height = 25;
            dgvOrdenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrdenes.Size = new Size(960, 190);
            dgvOrdenes.TabIndex = 14;
            //
            // lblBitacora
            //
            lblBitacora.AutoSize = true;
            lblBitacora.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBitacora.ForeColor = Color.FromArgb(30, 64, 175);
            lblBitacora.Location = new Point(20, 566);
            lblBitacora.Name = "lblBitacora";
            lblBitacora.Size = new Size(352, 19);
            lblBitacora.TabIndex = 0;
            lblBitacora.Text = "Bitácora de eventos y notificaciones simuladas";
            //
            // btnVerificarBitacora
            //
            btnVerificarBitacora.BackColor = Color.FromArgb(71, 85, 105);
            btnVerificarBitacora.Cursor = Cursors.Hand;
            btnVerificarBitacora.FlatAppearance.BorderSize = 0;
            btnVerificarBitacora.FlatStyle = FlatStyle.Flat;
            btnVerificarBitacora.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVerificarBitacora.ForeColor = Color.White;
            btnVerificarBitacora.Location = new Point(830, 560);
            btnVerificarBitacora.Name = "btnVerificarBitacora";
            btnVerificarBitacora.Size = new Size(150, 28);
            btnVerificarBitacora.TabIndex = 15;
            btnVerificarBitacora.Text = "Verificar bitácora";
            btnVerificarBitacora.UseVisualStyleBackColor = false;
            btnVerificarBitacora.Click += btnVerificarBitacora_Click;
            //
            // txtBitacora
            //
            txtBitacora.BackColor = Color.White;
            txtBitacora.Font = new Font("Consolas", 9F);
            txtBitacora.Location = new Point(20, 594);
            txtBitacora.Multiline = true;
            txtBitacora.Name = "txtBitacora";
            txtBitacora.ReadOnly = true;
            txtBitacora.ScrollBars = ScrollBars.Vertical;
            txtBitacora.Size = new Size(960, 95);
            txtBitacora.TabIndex = 16;
            //
            // FrmReparaciones
            //
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1000, 705);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblCliente);
            Controls.Add(txtCliente);
            Controls.Add(lblEquipo);
            Controls.Add(cmbEquipo);
            Controls.Add(lblFalla);
            Controls.Add(txtFalla);
            Controls.Add(lblServicio);
            Controls.Add(cmbServicio);
            Controls.Add(lblPlan);
            Controls.Add(cmbPlan);
            Controls.Add(lblNotificacion);
            Controls.Add(cmbNotificacion);
            Controls.Add(chkRepuesto);
            Controls.Add(btnCargarPlantilla);
            Controls.Add(lblTareas);
            Controls.Add(txtTareas);
            Controls.Add(btnRegistrar);
            Controls.Add(btnFinalizar);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(lblOrdenes);
            Controls.Add(dgvOrdenes);
            Controls.Add(lblBitacora);
            Controls.Add(btnVerificarBitacora);
            Controls.Add(txtBitacora);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmReparaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReparaLab - Gestión de reparaciones";
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblCliente;
        private TextBox txtCliente;
        private Label lblEquipo;
        private ComboBox cmbEquipo;
        private Label lblFalla;
        private TextBox txtFalla;
        private Label lblServicio;
        private ComboBox cmbServicio;
        private Label lblPlan;
        private ComboBox cmbPlan;
        private Label lblNotificacion;
        private ComboBox cmbNotificacion;
        private CheckBox chkRepuesto;
        private Button btnCargarPlantilla;
        private Label lblTareas;
        private TextBox txtTareas;
        private Button btnRegistrar;
        private Button btnFinalizar;
        private Button btnCancelar;
        private Button btnLimpiar;
        private Label lblOrdenes;
        private DataGridView dgvOrdenes;
        private Label lblBitacora;
        private Button btnVerificarBitacora;
        private TextBox txtBitacora;
    }
}
