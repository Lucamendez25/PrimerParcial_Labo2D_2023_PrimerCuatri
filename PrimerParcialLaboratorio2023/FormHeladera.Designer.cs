namespace PrimerParcialLaboratorio2023
{
    partial class FormHeladera
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHeladera));
            dataGridViewListaProductos = new DataGridView();
            buttonInformacionProducto = new Button();
            buttonVenderACliente = new Button();
            dataGridViewListaClientes = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewListaProductos
            // 
            dataGridViewListaProductos.AllowUserToAddRows = false;
            dataGridViewListaProductos.AllowUserToDeleteRows = false;
            dataGridViewListaProductos.AllowUserToResizeColumns = false;
            dataGridViewListaProductos.AllowUserToResizeRows = false;
            dataGridViewListaProductos.BackgroundColor = Color.SkyBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewListaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewListaProductos.GridColor = SystemColors.ActiveCaptionText;
            dataGridViewListaProductos.Location = new Point(127, 14);
            dataGridViewListaProductos.Margin = new Padding(4, 3, 4, 3);
            dataGridViewListaProductos.MultiSelect = false;
            dataGridViewListaProductos.Name = "dataGridViewListaProductos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Blue;
            dataGridViewCellStyle3.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewListaProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewListaProductos.RowTemplate.Height = 25;
            dataGridViewListaProductos.Size = new Size(192, 373);
            dataGridViewListaProductos.TabIndex = 0;
            dataGridViewListaProductos.TabStop = false;
            // 
            // buttonInformacionProducto
            // 
            buttonInformacionProducto.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInformacionProducto.Location = new Point(13, 148);
            buttonInformacionProducto.Margin = new Padding(4, 3, 4, 3);
            buttonInformacionProducto.Name = "buttonInformacionProducto";
            buttonInformacionProducto.Size = new Size(106, 63);
            buttonInformacionProducto.TabIndex = 1;
            buttonInformacionProducto.Text = "Informacion\r\nProducto\r\n";
            buttonInformacionProducto.UseVisualStyleBackColor = true;
            buttonInformacionProducto.Click += buttonInformacionProducto_Click;
            // 
            // buttonVenderACliente
            // 
            buttonVenderACliente.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVenderACliente.Location = new Point(372, 167);
            buttonVenderACliente.Margin = new Padding(4, 3, 4, 3);
            buttonVenderACliente.Name = "buttonVenderACliente";
            buttonVenderACliente.Size = new Size(112, 44);
            buttonVenderACliente.TabIndex = 2;
            buttonVenderACliente.Text = "VENDER A \r\nUSUARIO\r\n\r\n";
            buttonVenderACliente.UseVisualStyleBackColor = true;
            buttonVenderACliente.Click += buttonVenderACliente_Click;
            // 
            // dataGridViewListaClientes
            // 
            dataGridViewListaClientes.BackgroundColor = Color.Khaki;
            dataGridViewListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Yellow;
            dataGridViewCellStyle5.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewListaClientes.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewListaClientes.GridColor = Color.Black;
            dataGridViewListaClientes.Location = new Point(492, 14);
            dataGridViewListaClientes.Margin = new Padding(4, 3, 4, 3);
            dataGridViewListaClientes.Name = "dataGridViewListaClientes";
            dataGridViewListaClientes.RowTemplate.Height = 25;
            dataGridViewListaClientes.Size = new Size(694, 373);
            dataGridViewListaClientes.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Vaquita1;
            pictureBox1.Location = new Point(354, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormHeladera
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1199, 467);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewListaClientes);
            Controls.Add(buttonVenderACliente);
            Controls.Add(buttonInformacionProducto);
            Controls.Add(dataGridViewListaProductos);
            Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormHeladera";
            Text = "Heladera";
            FormClosed += FormHeladera_FormClosed;
            Load += FormHeladera_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewListaProductos;
        private Button buttonInformacionProducto;
        private Button buttonVenderACliente;
        private DataGridView dataGridViewListaClientes;
        private PictureBox pictureBox1;
    }
}