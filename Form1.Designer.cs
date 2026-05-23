namespace Santiago_Herrera__Miguel_Salazar_LAB_05
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbSedan = new System.Windows.Forms.RadioButton();
            this.rbSUV = new System.Windows.Forms.RadioButton();
            this.rbPickUp = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPickUp = new System.Windows.Forms.PictureBox();
            this.pbSedan = new System.Windows.Forms.PictureBox();
            this.pbSUV = new System.Windows.Forms.PictureBox();
            this.cbAspirado = new System.Windows.Forms.CheckBox();
            this.cbEncerado = new System.Windows.Forms.CheckBox();
            this.cbMotor = new System.Windows.Forms.CheckBox();
            this.cbAromatizante = new System.Windows.Forms.CheckBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPickUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSedan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSUV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lavautp Kuchau";
            // 
            // rbSedan
            // 
            this.rbSedan.AutoSize = true;
            this.rbSedan.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSedan.Location = new System.Drawing.Point(76, 162);
            this.rbSedan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSedan.Name = "rbSedan";
            this.rbSedan.Size = new System.Drawing.Size(199, 33);
            this.rbSedan.TabIndex = 1;
            this.rbSedan.Text = "Sedan B/. 6.00 ";
            this.rbSedan.UseVisualStyleBackColor = true;
            this.rbSedan.CheckedChanged += new System.EventHandler(this.rbSedan_CheckedChanged);
            // 
            // rbSUV
            // 
            this.rbSUV.AutoSize = true;
            this.rbSUV.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSUV.Location = new System.Drawing.Point(76, 206);
            this.rbSUV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSUV.Name = "rbSUV";
            this.rbSUV.Size = new System.Drawing.Size(177, 33);
            this.rbSUV.TabIndex = 2;
            this.rbSUV.Text = "SUV B/. 8.00 ";
            this.rbSUV.UseVisualStyleBackColor = true;
            this.rbSUV.CheckedChanged += new System.EventHandler(this.rbSUV_CheckedChanged);
            // 
            // rbPickUp
            // 
            this.rbPickUp.AutoSize = true;
            this.rbPickUp.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPickUp.Location = new System.Drawing.Point(76, 244);
            this.rbPickUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPickUp.Name = "rbPickUp";
            this.rbPickUp.Size = new System.Drawing.Size(229, 33);
            this.rbPickUp.TabIndex = 3;
            this.rbPickUp.Text = "Pick-up B/. 10.00 ";
            this.rbPickUp.UseVisualStyleBackColor = true;
            this.rbPickUp.CheckedChanged += new System.EventHandler(this.rbPickUp_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccionar el tipo de vehículo";
            // 
            // pbPickUp
            // 
            this.pbPickUp.Image = global::Santiago_Herrera__Miguel_Salazar_LAB_05.Properties.Resources.pick_up;
            this.pbPickUp.Location = new System.Drawing.Point(451, 139);
            this.pbPickUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPickUp.Name = "pbPickUp";
            this.pbPickUp.Size = new System.Drawing.Size(297, 170);
            this.pbPickUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPickUp.TabIndex = 5;
            this.pbPickUp.TabStop = false;
            this.pbPickUp.Visible = false;
            // 
            // pbSedan
            // 
            this.pbSedan.Image = global::Santiago_Herrera__Miguel_Salazar_LAB_05.Properties.Resources.sedan;
            this.pbSedan.Location = new System.Drawing.Point(451, 139);
            this.pbSedan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSedan.Name = "pbSedan";
            this.pbSedan.Size = new System.Drawing.Size(299, 169);
            this.pbSedan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSedan.TabIndex = 6;
            this.pbSedan.TabStop = false;
            this.pbSedan.Visible = false;
            // 
            // pbSUV
            // 
            this.pbSUV.Image = global::Santiago_Herrera__Miguel_Salazar_LAB_05.Properties.Resources.suv;
            this.pbSUV.Location = new System.Drawing.Point(451, 139);
            this.pbSUV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSUV.Name = "pbSUV";
            this.pbSUV.Size = new System.Drawing.Size(300, 168);
            this.pbSUV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSUV.TabIndex = 7;
            this.pbSUV.TabStop = false;
            this.pbSUV.Visible = false;
            // 
            // cbAspirado
            // 
            this.cbAspirado.AutoSize = true;
            this.cbAspirado.Location = new System.Drawing.Point(38, 390);
            this.cbAspirado.Name = "cbAspirado";
            this.cbAspirado.Size = new System.Drawing.Size(179, 20);
            this.cbAspirado.TabIndex = 8;
            this.cbAspirado.Text = "Aspirado interior: B/. 2.00 ";
            this.cbAspirado.UseVisualStyleBackColor = true;
            // 
            // cbEncerado
            // 
            this.cbEncerado.AutoSize = true;
            this.cbEncerado.Location = new System.Drawing.Point(266, 390);
            this.cbEncerado.Name = "cbEncerado";
            this.cbEncerado.Size = new System.Drawing.Size(140, 20);
            this.cbEncerado.TabIndex = 9;
            this.cbEncerado.Text = "Encerado: B/. 4.00 ";
            this.cbEncerado.UseVisualStyleBackColor = true;
            // 
            // cbMotor
            // 
            this.cbMotor.AutoSize = true;
            this.cbMotor.Location = new System.Drawing.Point(451, 390);
            this.cbMotor.Name = "cbMotor";
            this.cbMotor.Size = new System.Drawing.Size(183, 20);
            this.cbMotor.TabIndex = 10;
            this.cbMotor.Text = "Lavado de motor: B/. 5.00 ";
            this.cbMotor.UseVisualStyleBackColor = true;
            // 
            // cbAromatizante
            // 
            this.cbAromatizante.AutoSize = true;
            this.cbAromatizante.Location = new System.Drawing.Point(667, 390);
            this.cbAromatizante.Name = "cbAromatizante";
            this.cbAromatizante.Size = new System.Drawing.Size(159, 20);
            this.cbAromatizante.TabIndex = 11;
            this.cbAromatizante.Text = "Aromatizante: B/. 1.50 ";
            this.cbAromatizante.UseVisualStyleBackColor = true;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.Location = new System.Drawing.Point(141, 323);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(112, 36);
            this.btLimpiar.TabIndex = 12;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 468);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.cbAromatizante);
            this.Controls.Add(this.cbMotor);
            this.Controls.Add(this.cbEncerado);
            this.Controls.Add(this.cbAspirado);
            this.Controls.Add(this.pbSUV);
            this.Controls.Add(this.pbSedan);
            this.Controls.Add(this.pbPickUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbPickUp);
            this.Controls.Add(this.rbSUV);
            this.Controls.Add(this.rbSedan);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPickUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSedan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSUV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSedan;
        private System.Windows.Forms.RadioButton rbSUV;
        private System.Windows.Forms.RadioButton rbPickUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbPickUp;
        private System.Windows.Forms.PictureBox pbSedan;
        private System.Windows.Forms.PictureBox pbSUV;
        private System.Windows.Forms.CheckBox cbAspirado;
        private System.Windows.Forms.CheckBox cbEncerado;
        private System.Windows.Forms.CheckBox cbMotor;
        private System.Windows.Forms.CheckBox cbAromatizante;
        private System.Windows.Forms.Button btLimpiar;
    }
}

