namespace PrimerParcialLaboratorio2023
{
    partial class FormVenta
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            labelDineroIngresado = new Label();
            dataGridViewListaProductos = new DataGridView();
            comboBoxTipo = new ComboBox();
            comboBoxTipoProducto = new ComboBox();
            buttonAgregarProducto = new Button();
            buttonEliminar = new Button();
            numericUpDownKilos = new NumericUpDown();
            labelCarritoTotal = new Label();
            buttonFinalizarCompra = new Button();
            labelCarritoVacio = new Label();
            labelProducto = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelDineroIngresado
            // 
            labelDineroIngresado.AutoSize = true;
            labelDineroIngresado.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDineroIngresado.Location = new Point(429, 9);
            labelDineroIngresado.Name = "labelDineroIngresado";
            labelDineroIngresado.Size = new Size(297, 25);
            labelDineroIngresado.TabIndex = 0;
            labelDineroIngresado.Text = "User:                 Dinero:       ";
            // 
            // dataGridViewListaProductos
            // 
            dataGridViewListaProductos.BackgroundColor = Color.LightSkyBlue;
            dataGridViewListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 128);
            dataGridViewCellStyle1.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewListaProductos.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewListaProductos.GridColor = Color.Black;
            dataGridViewListaProductos.Location = new Point(355, 42);
            dataGridViewListaProductos.Name = "dataGridViewListaProductos";
            dataGridViewListaProductos.RowTemplate.Height = 25;
            dataGridViewListaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListaProductos.Size = new Size(433, 378);
            dataGridViewListaProductos.TabIndex = 1;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.BackColor = Color.Gold;
            comboBoxTipo.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(12, 156);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(142, 29);
            comboBoxTipo.TabIndex = 2;
            comboBoxTipo.SelectionChangeCommitted += comboBoxTipo_SelectionChangeCommitted;
            // 
            // comboBoxTipoProducto
            // 
            comboBoxTipoProducto.BackColor = Color.Gold;
            comboBoxTipoProducto.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTipoProducto.ForeColor = Color.Black;
            comboBoxTipoProducto.FormattingEnabled = true;
            comboBoxTipoProducto.Location = new Point(175, 156);
            comboBoxTipoProducto.Name = "comboBoxTipoProducto";
            comboBoxTipoProducto.Size = new Size(146, 29);
            comboBoxTipoProducto.TabIndex = 3;
            // 
            // buttonAgregarProducto
            // 
            buttonAgregarProducto.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregarProducto.Location = new Point(100, 259);
            buttonAgregarProducto.Name = "buttonAgregarProducto";
            buttonAgregarProducto.Size = new Size(112, 39);
            buttonAgregarProducto.TabIndex = 4;
            buttonAgregarProducto.Text = "Agregar";
            buttonAgregarProducto.UseVisualStyleBackColor = true;
            buttonAgregarProducto.Click += buttonAgregarProducto_Click;
            buttonAgregarProducto.MouseEnter += buttonAgregarProducto_MouseEnter;
            buttonAgregarProducto.MouseLeave += buttonAgregarProducto_MouseLeave;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(236, 386);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(113, 34);
            buttonEliminar.TabIndex = 5;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            buttonEliminar.MouseEnter += buttonEliminar_MouseEnter;
            buttonEliminar.MouseLeave += buttonEliminar_MouseLeave;
            // 
            // numericUpDownKilos
            // 
            numericUpDownKilos.BackColor = Color.Gold;
            numericUpDownKilos.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownKilos.Location = new Point(100, 209);
            numericUpDownKilos.Name = "numericUpDownKilos";
            numericUpDownKilos.Size = new Size(120, 28);
            numericUpDownKilos.TabIndex = 6;
            // 
            // labelCarritoTotal
            // 
            labelCarritoTotal.AutoSize = true;
            labelCarritoTotal.Font = new Font("Modern No. 20", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            labelCarritoTotal.Location = new Point(355, 422);
            labelCarritoTotal.Name = "labelCarritoTotal";
            labelCarritoTotal.Size = new Size(61, 21);
            labelCarritoTotal.TabIndex = 7;
            labelCarritoTotal.Text = "Total: ";
            // 
            // buttonFinalizarCompra
            // 
            buttonFinalizarCompra.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFinalizarCompra.Location = new Point(681, 422);
            buttonFinalizarCompra.Name = "buttonFinalizarCompra";
            buttonFinalizarCompra.Size = new Size(107, 30);
            buttonFinalizarCompra.TabIndex = 8;
            buttonFinalizarCompra.Text = "Listo!";
            buttonFinalizarCompra.UseVisualStyleBackColor = true;
            buttonFinalizarCompra.Click += buttonFinalizarCompra_Click;
            buttonFinalizarCompra.MouseEnter += buttonFinalizarCompra_MouseEnter;
            buttonFinalizarCompra.MouseLeave += buttonFinalizarCompra_MouseLeave;
            // 
            // labelCarritoVacio
            // 
            labelCarritoVacio.AutoSize = true;
            labelCarritoVacio.Font = new Font("Mongolian Baiti", 24F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            labelCarritoVacio.Location = new Point(442, 181);
            labelCarritoVacio.Name = "labelCarritoVacio";
            labelCarritoVacio.Size = new Size(264, 34);
            labelCarritoVacio.TabIndex = 9;
            labelCarritoVacio.Text = "CARRITO VACIO";
            // 
            // labelProducto
            // 
            labelProducto.AutoSize = true;
            labelProducto.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelProducto.Location = new Point(87, 94);
            labelProducto.Name = "labelProducto";
            labelProducto.Size = new Size(170, 25);
            labelProducto.TabIndex = 10;
            labelProducto.Text = "PRODUCTOS:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Vaquita1;
            pictureBox1.Location = new Point(100, 340);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(804, 457);
            Controls.Add(pictureBox1);
            Controls.Add(labelProducto);
            Controls.Add(labelCarritoVacio);
            Controls.Add(buttonFinalizarCompra);
            Controls.Add(labelCarritoTotal);
            Controls.Add(numericUpDownKilos);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregarProducto);
            Controls.Add(comboBoxTipoProducto);
            Controls.Add(comboBoxTipo);
            Controls.Add(dataGridViewListaProductos);
            Controls.Add(labelDineroIngresado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta";
            FormClosing += FormVenta_FormClosing;
            FormClosed += FormVenta_FormClosed;
            Load += FormVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDineroIngresado;
        private DataGridView dataGridViewListaProductos;
        private ComboBox comboBoxTipo;
        private ComboBox comboBoxTipoProducto;
        private Button buttonAgregarProducto;
        private Button buttonEliminar;
        private NumericUpDown numericUpDownKilos;
        private Label labelCarritoTotal;
        private Button buttonFinalizarCompra;
        private Label labelCarritoVacio;
        private Label labelProducto;
        private PictureBox pictureBox1;
    }
}