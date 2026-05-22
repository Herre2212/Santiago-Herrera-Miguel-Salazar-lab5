namespace Santiago_Herrera__Miguel_Salazar_LAB_05
{
    partial class Cotizacion
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.clTipoVehiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clServicios = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPrecioBase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clTipoVehiculo,
            this.clServicios,
            this.clPrecioBase,
            this.clTotal});
            this.listView1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(55, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(610, 325);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clTipoVehiculo
            // 
            this.clTipoVehiculo.Text = "Tipo de vehiculo";
            // 
            // clServicios
            // 
            this.clServicios.Text = "Servicios adicionales";
            // 
            // clPrecioBase
            // 
            this.clPrecioBase.Text = "Precio base";
            // 
            // clTotal
            // 
            this.clTotal.Text = "Total";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(287, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Cotizacion";
            this.Text = "Cotizacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clTipoVehiculo;
        private System.Windows.Forms.ColumnHeader clServicios;
        private System.Windows.Forms.ColumnHeader clPrecioBase;
        private System.Windows.Forms.ColumnHeader clTotal;
        private System.Windows.Forms.Button button1;
    }
}