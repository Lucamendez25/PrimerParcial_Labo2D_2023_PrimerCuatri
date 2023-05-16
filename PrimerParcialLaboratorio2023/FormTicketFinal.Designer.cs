namespace PrimerParcialLaboratorio2023
{
    partial class FormTicketFinal
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTicketFinal));
            groupBoxMetodoDePago = new GroupBox();
            radioButtonDebito = new RadioButton();
            radioButtonCredito = new RadioButton();
            dataGridViewCarritoFinal = new DataGridView();
            labelTotalCarrito = new Label();
            buttonFinalizarCompra = new Button();
            labelMensajeError = new Label();
            labelDineroCliente = new Label();
            pictureBox1 = new PictureBox();
            groupBoxMetodoDePago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarritoFinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxMetodoDePago
            // 
            groupBoxMetodoDePago.Controls.Add(radioButtonDebito);
            groupBoxMetodoDePago.Controls.Add(radioButtonCredito);
            groupBoxMetodoDePago.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxMetodoDePago.Location = new Point(551, 96);
            groupBoxMetodoDePago.Name = "groupBoxMetodoDePago";
            groupBoxMetodoDePago.Size = new Size(187, 103);
            groupBoxMetodoDePago.TabIndex = 0;
            groupBoxMetodoDePago.TabStop = false;
            groupBoxMetodoDePago.Text = "Metodo de Pago: ";
            // 
            // radioButtonDebito
            // 
            radioButtonDebito.AutoSize = true;
            radioButtonDebito.Location = new Point(3, 58);
            radioButtonDebito.Name = "radioButtonDebito";
            radioButtonDebito.Size = new Size(80, 25);
            radioButtonDebito.TabIndex = 1;
            radioButtonDebito.TabStop = true;
            radioButtonDebito.Text = "Debito";
            radioButtonDebito.UseVisualStyleBackColor = true;
            // 
            // radioButtonCredito
            // 
            radioButtonCredito.AutoSize = true;
            radioButtonCredito.Location = new Point(3, 27);
            radioButtonCredito.Name = "radioButtonCredito";
            radioButtonCredito.Size = new Size(182, 25);
            radioButtonCredito.TabIndex = 0;
            radioButtonCredito.TabStop = true;
            radioButtonCredito.Text = "Credito(Recarga 5%)";
            radioButtonCredito.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCarritoFinal
            // 
            dataGridViewCarritoFinal.AllowUserToAddRows = false;
            dataGridViewCarritoFinal.AllowUserToDeleteRows = false;
            dataGridViewCarritoFinal.AllowUserToResizeColumns = false;
            dataGridViewCarritoFinal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Yellow;
            dataGridViewCellStyle1.Font = new Font("Modern No. 20", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCarritoFinal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCarritoFinal.BackgroundColor = Color.LightSkyBlue;
            dataGridViewCarritoFinal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Yellow;
            dataGridViewCellStyle2.Font = new Font("Modern No. 20", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCarritoFinal.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCarritoFinal.Enabled = false;
            dataGridViewCarritoFinal.Location = new Point(12, 32);
            dataGridViewCarritoFinal.MultiSelect = false;
            dataGridViewCarritoFinal.Name = "dataGridViewCarritoFinal";
            dataGridViewCarritoFinal.RowTemplate.Height = 25;
            dataGridViewCarritoFinal.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewCarritoFinal.Size = new Size(491, 387);
            dataGridViewCarritoFinal.TabIndex = 2;
            dataGridViewCarritoFinal.TabStop = false;
            // 
            // labelTotalCarrito
            // 
            labelTotalCarrito.AutoSize = true;
            labelTotalCarrito.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalCarrito.ForeColor = SystemColors.ControlText;
            labelTotalCarrito.Location = new Point(548, 54);
            labelTotalCarrito.Name = "labelTotalCarrito";
            labelTotalCarrito.Size = new Size(125, 21);
            labelTotalCarrito.TabIndex = 3;
            labelTotalCarrito.Text = "Total a Pagar: ";
            // 
            // buttonFinalizarCompra
            // 
            buttonFinalizarCompra.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFinalizarCompra.Location = new Point(548, 219);
            buttonFinalizarCompra.Name = "buttonFinalizarCompra";
            buttonFinalizarCompra.Size = new Size(183, 38);
            buttonFinalizarCompra.TabIndex = 4;
            buttonFinalizarCompra.Text = "Finalizar Compra";
            buttonFinalizarCompra.UseVisualStyleBackColor = true;
            buttonFinalizarCompra.Click += buttonFinalizarCompra_Click;
            buttonFinalizarCompra.MouseEnter += buttonFinalizarCompra_MouseEnter;
            buttonFinalizarCompra.MouseLeave += buttonFinalizarCompra_MouseLeave;
            // 
            // labelMensajeError
            // 
            labelMensajeError.AutoSize = true;
            labelMensajeError.Location = new Point(494, 210);
            labelMensajeError.Name = "labelMensajeError";
            labelMensajeError.Size = new Size(0, 15);
            labelMensajeError.TabIndex = 5;
            labelMensajeError.Visible = false;
            // 
            // labelDineroCliente
            // 
            labelDineroCliente.AutoSize = true;
            labelDineroCliente.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDineroCliente.Location = new Point(551, 21);
            labelDineroCliente.Name = "labelDineroCliente";
            labelDineroCliente.Size = new Size(102, 23);
            labelDineroCliente.TabIndex = 6;
            labelDineroCliente.Text = "Mi banco: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Vaquita1;
            pictureBox1.Location = new Point(548, 263);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormTicketFinal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(labelDineroCliente);
            Controls.Add(labelMensajeError);
            Controls.Add(buttonFinalizarCompra);
            Controls.Add(labelTotalCarrito);
            Controls.Add(dataGridViewCarritoFinal);
            Controls.Add(groupBoxMetodoDePago);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormTicketFinal";
            Text = "Ticket Final";
            FormClosed += FormTicketFinal_FormClosed;
            Load += FormTicketFinal_Load;
            groupBoxMetodoDePago.ResumeLayout(false);
            groupBoxMetodoDePago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarritoFinal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxMetodoDePago;
        private RadioButton radioButtonDebito;
        private RadioButton radioButtonCredito;
        private DataGridView dataGridViewCarritoFinal;
        private Label labelTotalCarrito;
        private Button buttonFinalizarCompra;
        private Label labelMensajeError;
        private Label labelDineroCliente;
        private PictureBox pictureBox1;
    }
}