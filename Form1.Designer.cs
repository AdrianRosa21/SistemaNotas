namespace SistemaNotas
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
            lblUsuario = new Label();
            lbllContra = new Label();
            txtUsuario = new TextBox();
            txtContra = new TextBox();
            logo = new PictureBox();
            lbtitulo = new Label();
            checkcontra = new CheckBox();
            btningresar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.Location = new Point(98, 128);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(81, 21);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "lblUsuario";
            // 
            // lbllContra
            // 
            lbllContra.AutoSize = true;
            lbllContra.Font = new Font("Segoe UI", 12F);
            lbllContra.Location = new Point(98, 190);
            lbllContra.Name = "lbllContra";
            lbllContra.Size = new Size(78, 21);
            lbllContra.TabIndex = 1;
            lbllContra.Text = "lbllContra";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(194, 128);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(211, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(194, 190);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(211, 23);
            txtContra.TabIndex = 3;
            // 
            // logo
            // 
            logo.Location = new Point(253, 12);
            logo.Name = "logo";
            logo.Size = new Size(110, 92);
            logo.TabIndex = 4;
            logo.TabStop = false;
            // 
            // lbtitulo
            // 
            lbtitulo.AutoSize = true;
            lbtitulo.Font = new Font("Segoe UI", 12F);
            lbtitulo.Location = new Point(194, 89);
            lbtitulo.Name = "lbtitulo";
            lbtitulo.Size = new Size(59, 21);
            lbtitulo.TabIndex = 5;
            lbtitulo.Text = "lbtitulo";
            // 
            // checkcontra
            // 
            checkcontra.AutoSize = true;
            checkcontra.Location = new Point(194, 219);
            checkcontra.Name = "checkcontra";
            checkcontra.Size = new Size(91, 19);
            checkcontra.TabIndex = 6;
            checkcontra.Text = "checkcontra";
            checkcontra.UseVisualStyleBackColor = true;
            checkcontra.CheckStateChanged += checkcontra_CheckStateChanged;
            // 
            // btningresar
            // 
            btningresar.Font = new Font("Segoe UI", 12F);
            btningresar.Location = new Point(225, 259);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(126, 34);
            btningresar.TabIndex = 7;
            btningresar.Text = "btningresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F);
            btnSalir.Location = new Point(225, 309);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(126, 34);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "btnSalir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 377);
            Controls.Add(btnSalir);
            Controls.Add(btningresar);
            Controls.Add(checkcontra);
            Controls.Add(lbtitulo);
            Controls.Add(logo);
            Controls.Add(txtContra);
            Controls.Add(txtUsuario);
            Controls.Add(lbllContra);
            Controls.Add(lblUsuario);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lbllContra;
        private TextBox txtUsuario;
        private TextBox txtContra;
        private PictureBox logo;
        private Label lbtitulo;
        private CheckBox checkcontra;
        private Button btningresar;
        private Button btnSalir;
    }
}
