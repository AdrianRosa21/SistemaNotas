namespace SistemaNotas
{
    partial class GestionDeInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDeInventario));
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            cmbSucursales = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cmbSecciones = new ComboBox();
            label5 = new Label();
            cmbProductos = new ComboBox();
            btnIngresar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 438);
            label1.Name = "label1";
            label1.Size = new Size(706, 125);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(551, 9);
            label2.Name = "label2";
            label2.Size = new Size(281, 38);
            label2.TabIndex = 1;
            label2.Text = "Gestión de inventario";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(cmbProductos);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbSecciones);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbSucursales);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(24, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 365);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingreso de datos";
            // 
            // cmbSucursales
            // 
            cmbSucursales.FormattingEnabled = true;
            cmbSucursales.Location = new Point(147, 58);
            cmbSucursales.Name = "cmbSucursales";
            cmbSucursales.Size = new Size(408, 40);
            cmbSucursales.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 61);
            label3.Name = "label3";
            label3.Size = new Size(125, 32);
            label3.TabIndex = 0;
            label3.Text = "Sucursales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 139);
            label4.Name = "label4";
            label4.Size = new Size(119, 32);
            label4.TabIndex = 2;
            label4.Text = "Secciones";
            // 
            // cmbSecciones
            // 
            cmbSecciones.FormattingEnabled = true;
            cmbSecciones.Location = new Point(147, 136);
            cmbSecciones.Name = "cmbSecciones";
            cmbSecciones.Size = new Size(408, 40);
            cmbSecciones.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 218);
            label5.Name = "label5";
            label5.Size = new Size(120, 32);
            label5.TabIndex = 4;
            label5.Text = "Productos";
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(147, 215);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(408, 40);
            cmbProductos.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(237, 295);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(127, 46);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // GestionDeInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 628);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionDeInventario";
            Text = "GestionDeInventario";
            Load += GestionDeInventario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private ComboBox cmbSucursales;
        private Label label3;
        private ComboBox cmbSecciones;
        private Label label4;
        private ComboBox cmbProductos;
        private Label label5;
        private Button btnIngresar;
    }
}