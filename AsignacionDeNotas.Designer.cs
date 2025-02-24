namespace SistemaNotas
{
    partial class AsignacionDeNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDocente = new Label();
            lblGrado = new Label();
            lblSeccion = new Label();
            lblAlumno = new Label();
            lblNota = new Label();
            lblInfo = new Label();
            cmbGrado = new ComboBox();
            cmbSeccion = new ComboBox();
            cmbAlumno = new ComboBox();
            txtNota = new TextBox();
            btnAsignarNota = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            listBox1 = new ListBox();
            btnEstudiantes = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblDocente
            // 
            lblDocente.AutoSize = true;
            lblDocente.Location = new Point(66, 30);
            lblDocente.Margin = new Padding(4, 0, 4, 0);
            lblDocente.Name = "lblDocente";
            lblDocente.Size = new Size(84, 21);
            lblDocente.TabIndex = 0;
            lblDocente.Text = "lblDocente";
            // 
            // lblGrado
            // 
            lblGrado.AutoSize = true;
            lblGrado.Location = new Point(66, 82);
            lblGrado.Margin = new Padding(4, 0, 4, 0);
            lblGrado.Name = "lblGrado";
            lblGrado.Size = new Size(70, 21);
            lblGrado.TabIndex = 1;
            lblGrado.Text = "lblGrado";
            // 
            // lblSeccion
            // 
            lblSeccion.AutoSize = true;
            lblSeccion.Location = new Point(66, 133);
            lblSeccion.Margin = new Padding(4, 0, 4, 0);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(80, 21);
            lblSeccion.TabIndex = 2;
            lblSeccion.Text = "lblSeccion";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new Point(66, 184);
            lblAlumno.Margin = new Padding(4, 0, 4, 0);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(82, 21);
            lblAlumno.TabIndex = 3;
            lblAlumno.Text = "lblAlumno";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(66, 237);
            lblNota.Margin = new Padding(4, 0, 4, 0);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(61, 21);
            lblNota.TabIndex = 4;
            lblNota.Text = "lblNota";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(683, 82);
            lblInfo.Margin = new Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(54, 21);
            lblInfo.TabIndex = 5;
            lblInfo.Text = "lblInfo";
            // 
            // cmbGrado
            // 
            cmbGrado.FormattingEnabled = true;
            cmbGrado.Location = new Point(292, 74);
            cmbGrado.Name = "cmbGrado";
            cmbGrado.Size = new Size(364, 29);
            cmbGrado.TabIndex = 6;
            cmbGrado.SelectedIndexChanged += cmbGrado_SelectedIndexChanged;
            // 
            // cmbSeccion
            // 
            cmbSeccion.FormattingEnabled = true;
            cmbSeccion.Location = new Point(292, 133);
            cmbSeccion.Name = "cmbSeccion";
            cmbSeccion.Size = new Size(364, 29);
            cmbSeccion.TabIndex = 7;
            cmbSeccion.SelectedIndexChanged += cmbSeccion_SelectedIndexChanged;
            // 
            // cmbAlumno
            // 
            cmbAlumno.FormattingEnabled = true;
            cmbAlumno.Location = new Point(292, 184);
            cmbAlumno.Name = "cmbAlumno";
            cmbAlumno.Size = new Size(364, 29);
            cmbAlumno.TabIndex = 8;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(375, 238);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(109, 29);
            txtNota.TabIndex = 9;
            // 
            // btnAsignarNota
            // 
            btnAsignarNota.Location = new Point(508, 237);
            btnAsignarNota.Name = "btnAsignarNota";
            btnAsignarNota.Size = new Size(148, 30);
            btnAsignarNota.TabIndex = 10;
            btnAsignarNota.Text = "btnAsignarNota";
            btnAsignarNota.UseVisualStyleBackColor = true;
            btnAsignarNota.Click += btnAsignarNota_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(683, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(583, 455);
            dataGridView1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 316);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 12;
            label1.Text = "lblListaNotas";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(142, 360);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(514, 256);
            listBox1.TabIndex = 13;
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.Location = new Point(168, 637);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Size = new Size(113, 37);
            btnEstudiantes.TabIndex = 14;
            btnEstudiantes.Text = "btnEstudiantes";
            btnEstudiantes.UseVisualStyleBackColor = true;
            btnEstudiantes.Click += btnEstudiantes_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(508, 637);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(113, 37);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "btnSalir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // AsignacionDeNotas
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 706);
            Controls.Add(btnSalir);
            Controls.Add(btnEstudiantes);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAsignarNota);
            Controls.Add(txtNota);
            Controls.Add(cmbAlumno);
            Controls.Add(cmbSeccion);
            Controls.Add(cmbGrado);
            Controls.Add(lblInfo);
            Controls.Add(lblNota);
            Controls.Add(lblAlumno);
            Controls.Add(lblSeccion);
            Controls.Add(lblGrado);
            Controls.Add(lblDocente);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "AsignacionDeNotas";
            Text = "AsignacionDeNotas";
            Load += AsignacionDeNotas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDocente;
        private Label lblGrado;
        private Label lblSeccion;
        private Label lblAlumno;
        private Label lblNota;
        private Label lblInfo;
        private ComboBox cmbGrado;
        private ComboBox cmbSeccion;
        private ComboBox cmbAlumno;
        private TextBox txtNota;
        private Button btnAsignarNota;
        private DataGridView dataGridView1;
        private Label label1;
        private ListBox listBox1;
        private Button btnEstudiantes;
        private Button btnSalir;
    }
}