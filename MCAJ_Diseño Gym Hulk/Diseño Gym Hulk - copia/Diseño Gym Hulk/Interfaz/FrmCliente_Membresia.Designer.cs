﻿namespace Diseño_Gym_Hulk
{
    partial class FrmCliente_Membresia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente_Membresia));
            this.button1 = new System.Windows.Forms.Button();
            this.TbLVerCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.LblIdClientev = new System.Windows.Forms.Label();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.TbLVerCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TbLVerCliente
            // 
            this.TbLVerCliente.AllowUserToAddRows = false;
            this.TbLVerCliente.AllowUserToDeleteRows = false;
            this.TbLVerCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TbLVerCliente.Location = new System.Drawing.Point(50, 36);
            this.TbLVerCliente.Name = "TbLVerCliente";
            this.TbLVerCliente.ReadOnly = true;
            this.TbLVerCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TbLVerCliente.Size = new System.Drawing.Size(454, 105);
            this.TbLVerCliente.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Número de cliente:";
            // 
            // LblIdClientev
            // 
            this.LblIdClientev.AutoSize = true;
            this.LblIdClientev.Location = new System.Drawing.Point(152, 17);
            this.LblIdClientev.Name = "LblIdClientev";
            this.LblIdClientev.Size = new System.Drawing.Size(13, 13);
            this.LblIdClientev.TabIndex = 19;
            this.LblIdClientev.Text = "0";
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.CustomFormat = "yyyy/MM/dd";
            this.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaInicio.Location = new System.Drawing.Point(304, 12);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaInicio.TabIndex = 24;
            // 
            // FrmCliente_Membresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 256);
            this.Controls.Add(this.DtpFechaInicio);
            this.Controls.Add(this.LblIdClientev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbLVerCliente);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCliente_Membresia";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.FrmCliente_Membresia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TbLVerCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView TbLVerCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblIdClientev;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
    }
}