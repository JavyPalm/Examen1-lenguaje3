namespace examen1_lenguaje3
{
    partial class PrestamoForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.prestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicioAlAzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TasaprestamotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MontoprestamoTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TiempoTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(432, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamoToolStripMenuItem,
            this.descuentoToolStripMenuItem,
            this.ejercicioAlAzarToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(432, 28);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // prestamoToolStripMenuItem
            // 
            this.prestamoToolStripMenuItem.Name = "prestamoToolStripMenuItem";
            this.prestamoToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.prestamoToolStripMenuItem.Text = "Ejercicio Prestamo";
            // 
            // descuentoToolStripMenuItem
            // 
            this.descuentoToolStripMenuItem.Name = "descuentoToolStripMenuItem";
            this.descuentoToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.descuentoToolStripMenuItem.Text = "Ejercicio Descuento";
            this.descuentoToolStripMenuItem.Click += new System.EventHandler(this.descuentoToolStripMenuItem_Click);
            // 
            // ejercicioAlAzarToolStripMenuItem
            // 
            this.ejercicioAlAzarToolStripMenuItem.Name = "ejercicioAlAzarToolStripMenuItem";
            this.ejercicioAlAzarToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.ejercicioAlAzarToolStripMenuItem.Text = "Ejercicio al azar";
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(146, 217);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(102, 49);
            this.CalcularButton.TabIndex = 18;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tiempo en meses:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tasa de interes:";
            // 
            // TasaprestamotextBox
            // 
            this.TasaprestamotextBox.Location = new System.Drawing.Point(148, 118);
            this.TasaprestamotextBox.Name = "TasaprestamotextBox";
            this.TasaprestamotextBox.ReadOnly = true;
            this.TasaprestamotextBox.Size = new System.Drawing.Size(100, 22);
            this.TasaprestamotextBox.TabIndex = 13;
            this.TasaprestamotextBox.Text = "0.015";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Monto del prestamo:";
            // 
            // MontoprestamoTextBox
            // 
            this.MontoprestamoTextBox.Location = new System.Drawing.Point(148, 70);
            this.MontoprestamoTextBox.Name = "MontoprestamoTextBox";
            this.MontoprestamoTextBox.Size = new System.Drawing.Size(100, 22);
            this.MontoprestamoTextBox.TabIndex = 11;
            // 
            // listBox1
            // 
            this.listBox1.FormatString = "C2";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(268, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(148, 196);
            this.listBox1.TabIndex = 19;
            // 
            // TiempoTextBox
            // 
            this.TiempoTextBox.Location = new System.Drawing.Point(148, 173);
            this.TiempoTextBox.Name = "TiempoTextBox";
            this.TiempoTextBox.Size = new System.Drawing.Size(100, 22);
            this.TiempoTextBox.TabIndex = 20;
            // 
            // PrestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 300);
            this.Controls.Add(this.TiempoTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TasaprestamotextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MontoprestamoTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "PrestamoForm";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem prestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descuentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicioAlAzarToolStripMenuItem;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TasaprestamotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MontoprestamoTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox TiempoTextBox;
    }
}

