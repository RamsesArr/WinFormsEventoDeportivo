

namespace WinFormsEventoDeportivo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConsultar = new Button();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvInfo = new DataGridView();
            txtID = new TextBox();
            txtNombreEvento = new TextBox();
            txtTipoEvento = new TextBox();
            txtFecha = new TextBox();
            txtLugar = new TextBox();
            txtNoParticipantes = new TextBox();
            txtCostoInscripcion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInfo).BeginInit();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(410, 305);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(504, 305);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(604, 305);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(701, 305);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvInfo
            // 
            dgvInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfo.Location = new Point(277, 12);
            dgvInfo.Name = "dgvInfo";
            dgvInfo.Size = new Size(511, 260);
            dgvInfo.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(138, 15);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 5;
            // 
            // txtNombreEvento
            // 
            txtNombreEvento.Location = new Point(138, 44);
            txtNombreEvento.Name = "txtNombreEvento";
            txtNombreEvento.Size = new Size(100, 23);
            txtNombreEvento.TabIndex = 6;
            // 
            // txtTipoEvento
            // 
            txtTipoEvento.Location = new Point(138, 75);
            txtTipoEvento.Name = "txtTipoEvento";
            txtTipoEvento.Size = new Size(100, 23);
            txtTipoEvento.TabIndex = 7;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(138, 104);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(100, 23);
            txtFecha.TabIndex = 8;
            // 
            // txtLugar
            // 
            txtLugar.Location = new Point(138, 133);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(100, 23);
            txtLugar.TabIndex = 9;
            // 
            // txtNoParticipantes
            // 
            txtNoParticipantes.Location = new Point(138, 165);
            txtNoParticipantes.Name = "txtNoParticipantes";
            txtNoParticipantes.Size = new Size(100, 23);
            txtNoParticipantes.TabIndex = 10;
            // 
            // txtCostoInscripcion
            // 
            txtCostoInscripcion.Location = new Point(138, 194);
            txtCostoInscripcion.Name = "txtCostoInscripcion";
            txtCostoInscripcion.Size = new Size(100, 23);
            txtCostoInscripcion.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 15);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 12;
            label1.Text = "ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 44);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 13;
            label2.Text = "Nombre Evento :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 14;
            label3.Text = "Tipo Evento :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 104);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 15;
            label4.Text = "Fecha :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 133);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 16;
            label5.Text = "Lugar :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 162);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 17;
            label6.Text = "No.Participantes :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 194);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 18;
            label7.Text = "Costo Inscripción :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCostoInscripcion);
            Controls.Add(txtNoParticipantes);
            Controls.Add(txtLugar);
            Controls.Add(txtFecha);
            Controls.Add(txtTipoEvento);
            Controls.Add(txtNombreEvento);
            Controls.Add(txtID);
            Controls.Add(dgvInfo);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(btnConsultar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultar;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dgvInfo;
        private TextBox txtID;
        private TextBox txtNombreEvento;
        private TextBox txtTipoEvento;
        private TextBox txtFecha;
        private TextBox txtLugar;
        private TextBox txtNoParticipantes;
        private TextBox txtCostoInscripcion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
