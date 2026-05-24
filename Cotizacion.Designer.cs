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
            this.lvCotizacion = new System.Windows.Forms.ListView();
            this.clTipoVehiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clServicios = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPrecioBase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btCerrar = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvCotizacion
            // 
            this.lvCotizacion.AutoArrange = false;
            this.lvCotizacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clTipoVehiculo,
            this.clServicios,
            this.clPrecioBase,
            this.clTotal});
            this.lvCotizacion.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCotizacion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCotizacion.HideSelection = false;
            this.lvCotizacion.Location = new System.Drawing.Point(41, 43);
            this.lvCotizacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvCotizacion.Name = "lvCotizacion";
            this.lvCotizacion.Size = new System.Drawing.Size(834, 262);
            this.lvCotizacion.TabIndex = 0;
            this.lvCotizacion.UseCompatibleStateImageBehavior = false;
            this.lvCotizacion.View = System.Windows.Forms.View.Details;
            this.lvCotizacion.SelectedIndexChanged += new System.EventHandler(this.Cotizacion_Load);
            // 
            // clTipoVehiculo
            // 
            this.clTipoVehiculo.Text = "Tipo de vehiculo";
            this.clTipoVehiculo.Width = 165;
            // 
            // clServicios
            // 
            this.clServicios.Text = "Servicios adicionales";
            this.clServicios.Width = 442;
            // 
            // clPrecioBase
            // 
            this.clPrecioBase.Text = "Precio base";
            this.clPrecioBase.Width = 130;
            // 
            // clTotal
            // 
            this.clTotal.Text = "Total";
            this.clTotal.Width = 90;
            // 
            // btCerrar
            // 
            this.btCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCerrar.Location = new System.Drawing.Point(642, 329);
            this.btCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(96, 46);
            this.btCerrar.TabIndex = 1;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(151, 329);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(112, 46);
            this.btRegresar.TabIndex = 2;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(911, 400);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.lvCotizacion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cotizacion";
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.Cotizacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCotizacion;
        private System.Windows.Forms.ColumnHeader clTipoVehiculo;
        private System.Windows.Forms.ColumnHeader clServicios;
        private System.Windows.Forms.ColumnHeader clPrecioBase;
        private System.Windows.Forms.ColumnHeader clTotal;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Button btRegresar;
    }
}