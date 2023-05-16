namespace PrimerParcialLaboratorio2023
{
    partial class FormDineroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDineroCliente));
            labelDineroCliente = new Label();
            textBoxDineroCliente = new TextBox();
            buttonDineroCliente = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelDineroCliente
            // 
            labelDineroCliente.AutoSize = true;
            labelDineroCliente.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDineroCliente.Location = new Point(89, 28);
            labelDineroCliente.Name = "labelDineroCliente";
            labelDineroCliente.Size = new Size(203, 46);
            labelDineroCliente.TabIndex = 0;
            labelDineroCliente.Text = "Cuanto dinero tiene \r\npensado gastar? :)\r\n";
            // 
            // textBoxDineroCliente
            // 
            textBoxDineroCliente.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDineroCliente.Location = new Point(99, 91);
            textBoxDineroCliente.Name = "textBoxDineroCliente";
            textBoxDineroCliente.Size = new Size(154, 28);
            textBoxDineroCliente.TabIndex = 1;
            // 
            // buttonDineroCliente
            // 
            buttonDineroCliente.Font = new Font("Modern No. 20", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDineroCliente.Location = new Point(110, 143);
            buttonDineroCliente.Name = "buttonDineroCliente";
            buttonDineroCliente.Size = new Size(128, 33);
            buttonDineroCliente.TabIndex = 2;
            buttonDineroCliente.Text = "Confirmar";
            buttonDineroCliente.UseVisualStyleBackColor = true;
            buttonDineroCliente.Click += buttonDineroCliente_Click;
            buttonDineroCliente.MouseEnter += buttonDineroCliente_MouseEnter;
            buttonDineroCliente.MouseLeave += buttonDineroCliente_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Vaquita1;
            pictureBox1.Location = new Point(266, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormDineroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(378, 230);
            Controls.Add(pictureBox1);
            Controls.Add(buttonDineroCliente);
            Controls.Add(textBoxDineroCliente);
            Controls.Add(labelDineroCliente);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormDineroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dinero Cliente";
            FormClosed += FormDineroCliente_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDineroCliente;
        private TextBox textBoxDineroCliente;
        private Button buttonDineroCliente;
        private PictureBox pictureBox1;
    }
}