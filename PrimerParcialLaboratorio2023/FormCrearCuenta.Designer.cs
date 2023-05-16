namespace PrimerParcialLaboratorio2023
{
    partial class FormCrearCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearCuenta));
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxDni = new TextBox();
            textBoxNombreUsuario = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            labelNombre = new Label();
            labelApellido = new Label();
            labelDni = new Label();
            labelNombreUsuario = new Label();
            labelEmail = new Label();
            labelPassword = new Label();
            buttonConfirmar = new Button();
            TipoUsuario = new ListBox();
            radioButtonCliente = new RadioButton();
            radioButtonVendedor = new RadioButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(137, 48);
            textBoxNombre.Margin = new Padding(5, 4, 5, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(154, 28);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(137, 122);
            textBoxApellido.Margin = new Padding(5, 4, 5, 4);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(154, 28);
            textBoxApellido.TabIndex = 1;
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(137, 196);
            textBoxDni.Margin = new Padding(5, 4, 5, 4);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(154, 28);
            textBoxDni.TabIndex = 2;
            // 
            // textBoxNombreUsuario
            // 
            textBoxNombreUsuario.Location = new Point(137, 273);
            textBoxNombreUsuario.Margin = new Padding(5, 4, 5, 4);
            textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            textBoxNombreUsuario.Size = new Size(154, 28);
            textBoxNombreUsuario.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(137, 351);
            textBoxEmail.Margin = new Padding(5, 4, 5, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(154, 28);
            textBoxEmail.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(137, 421);
            textBoxPassword.Margin = new Padding(5, 4, 5, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(154, 28);
            textBoxPassword.TabIndex = 5;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(181, 24);
            labelNombre.Margin = new Padding(5, 0, 5, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(70, 21);
            labelNombre.TabIndex = 6;
            labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(174, 94);
            labelApellido.Margin = new Padding(5, 0, 5, 0);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(76, 21);
            labelApellido.TabIndex = 7;
            labelApellido.Text = "Apellido";
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Location = new Point(188, 172);
            labelDni.Margin = new Padding(5, 0, 5, 0);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(40, 21);
            labelDni.TabIndex = 8;
            labelDni.Text = "Dni";
            // 
            // labelNombreUsuario
            // 
            labelNombreUsuario.AutoSize = true;
            labelNombreUsuario.Location = new Point(137, 248);
            labelNombreUsuario.Margin = new Padding(5, 0, 5, 0);
            labelNombreUsuario.Name = "labelNombreUsuario";
            labelNombreUsuario.Size = new Size(158, 21);
            labelNombreUsuario.TabIndex = 9;
            labelNombreUsuario.Text = "Nombre de Usuario";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(181, 326);
            labelEmail.Margin = new Padding(5, 0, 5, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(58, 21);
            labelEmail.TabIndex = 10;
            labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(158, 396);
            labelPassword.Margin = new Padding(5, 0, 5, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(95, 21);
            labelPassword.TabIndex = 11;
            labelPassword.Text = "Contraseña";
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Location = new Point(158, 531);
            buttonConfirmar.Margin = new Padding(5, 4, 5, 4);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(117, 31);
            buttonConfirmar.TabIndex = 12;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // TipoUsuario
            // 
            TipoUsuario.BackColor = Color.DeepSkyBlue;
            TipoUsuario.ForeColor = Color.Black;
            TipoUsuario.FormattingEnabled = true;
            TipoUsuario.ItemHeight = 21;
            TipoUsuario.Location = new Point(86, 456);
            TipoUsuario.Margin = new Padding(5, 4, 5, 4);
            TipoUsuario.Name = "TipoUsuario";
            TipoUsuario.Size = new Size(280, 67);
            TipoUsuario.TabIndex = 13;
            // 
            // radioButtonCliente
            // 
            radioButtonCliente.AutoSize = true;
            radioButtonCliente.Location = new Point(95, 486);
            radioButtonCliente.Margin = new Padding(5, 4, 5, 4);
            radioButtonCliente.Name = "radioButtonCliente";
            radioButtonCliente.Size = new Size(82, 25);
            radioButtonCliente.TabIndex = 14;
            radioButtonCliente.TabStop = true;
            radioButtonCliente.Text = "Cliente";
            radioButtonCliente.UseVisualStyleBackColor = true;
            // 
            // radioButtonVendedor
            // 
            radioButtonVendedor.AutoSize = true;
            radioButtonVendedor.Location = new Point(208, 486);
            radioButtonVendedor.Margin = new Padding(5, 4, 5, 4);
            radioButtonVendedor.Name = "radioButtonVendedor";
            radioButtonVendedor.Size = new Size(101, 25);
            radioButtonVendedor.TabIndex = 15;
            radioButtonVendedor.TabStop = true;
            radioButtonVendedor.Text = "Vendedor";
            radioButtonVendedor.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Vaquita1;
            pictureBox1.Location = new Point(348, 172);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // FormCrearCuenta
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(518, 577);
            Controls.Add(pictureBox1);
            Controls.Add(radioButtonVendedor);
            Controls.Add(radioButtonCliente);
            Controls.Add(TipoUsuario);
            Controls.Add(buttonConfirmar);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelNombreUsuario);
            Controls.Add(labelDni);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNombreUsuario);
            Controls.Add(textBoxDni);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormCrearCuenta";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxDni;
        private TextBox textBoxNombreUsuario;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Label labelNombre;
        private Label labelApellido;
        private Label labelDni;
        private Label labelNombreUsuario;
        private Label labelEmail;
        private Label labelPassword;
        private Button buttonConfirmar;
        private ListBox TipoUsuario;
        private RadioButton radioButtonCliente;
        private RadioButton radioButtonVendedor;
        private PictureBox pictureBox1;
    }
}