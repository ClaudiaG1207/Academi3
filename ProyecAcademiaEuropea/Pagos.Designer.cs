﻿namespace ProyecAcademiaEuropea
{
    partial class Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LbEstuantesR = new System.Windows.Forms.Label();
            this.TxtTipoPa = new System.Windows.Forms.ComboBox();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtEstudiantes = new System.Windows.Forms.DataGridView();
            this.space1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.FechaPago = new System.Windows.Forms.DateTimePicker();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEstudiantes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(730, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // LbEstuantesR
            // 
            this.LbEstuantesR.AutoSize = true;
            this.LbEstuantesR.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEstuantesR.ForeColor = System.Drawing.Color.Gold;
            this.LbEstuantesR.Location = new System.Drawing.Point(364, 48);
            this.LbEstuantesR.Name = "LbEstuantesR";
            this.LbEstuantesR.Size = new System.Drawing.Size(105, 34);
            this.LbEstuantesR.TabIndex = 41;
            this.LbEstuantesR.Text = "Pagos:";
            // 
            // TxtTipoPa
            // 
            this.TxtTipoPa.FormattingEnabled = true;
            this.TxtTipoPa.Items.AddRange(new object[] {
            "Nicaragua",
            "Panamá",
            "El salvador ",
            "Costa Rica",
            "México",
            "Argentina"});
            this.TxtTipoPa.Location = new System.Drawing.Point(218, 105);
            this.TxtTipoPa.Name = "TxtTipoPa";
            this.TxtTipoPa.Size = new System.Drawing.Size(143, 24);
            this.TxtTipoPa.TabIndex = 50;
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(218, 152);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(99, 22);
            this.TxtMonto.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(110, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 22);
            this.label9.TabIndex = 46;
            this.label9.Text = "Monto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "Tipo de Pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 43;
            this.label2.Text = "Fecha Pago :";
            // 
            // dtEstudiantes
            // 
            this.dtEstudiantes.AllowUserToAddRows = false;
            this.dtEstudiantes.AllowUserToDeleteRows = false;
            this.dtEstudiantes.AllowUserToResizeRows = false;
            this.dtEstudiantes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.space1,
            this.Eliminar,
            this.Editar});
            this.dtEstudiantes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtEstudiantes.Location = new System.Drawing.Point(0, 421);
            this.dtEstudiantes.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dtEstudiantes.Name = "dtEstudiantes";
            this.dtEstudiantes.ReadOnly = true;
            this.dtEstudiantes.RowHeadersWidth = 82;
            this.dtEstudiantes.RowTemplate.Height = 33;
            this.dtEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtEstudiantes.ShowCellToolTips = false;
            this.dtEstudiantes.ShowEditingIcon = false;
            this.dtEstudiantes.Size = new System.Drawing.Size(790, 231);
            this.dtEstudiantes.TabIndex = 51;
            // 
            // space1
            // 
            this.space1.HeaderText = "";
            this.space1.MinimumWidth = 10;
            this.space1.Name = "space1";
            this.space1.ReadOnly = true;
            this.space1.Width = 200;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::ProyecAcademiaEuropea.Properties.Resources.borrar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.MinimumWidth = 10;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 200;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = global::ProyecAcademiaEuropea.Properties.Resources.boligrafo;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.MinimumWidth = 10;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 200;
            // 
            // FechaPago
            // 
            this.FechaPago.CalendarFont = new System.Drawing.Font("Modern No. 20", 13.8F);
            this.FechaPago.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaPago.Location = new System.Drawing.Point(218, 61);
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.Size = new System.Drawing.Size(323, 29);
            this.FechaPago.TabIndex = 53;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Gold;
            this.BtnEditar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.Navy;
            this.BtnEditar.Location = new System.Drawing.Point(375, 177);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(91, 34);
            this.BtnEditar.TabIndex = 68;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Gold;
            this.BtnGuardar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Navy;
            this.BtnGuardar.Location = new System.Drawing.Point(472, 177);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(91, 34);
            this.BtnGuardar.TabIndex = 67;
            this.BtnGuardar.Text = "Guadar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 69;
            this.label1.Text = "Nombre Estudiante:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 22);
            this.textBox1.TabIndex = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnEditar);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.FechaPago);
            this.groupBox1.Controls.Add(this.TxtTipoPa);
            this.groupBox1.Controls.Add(this.TxtMonto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(68, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 233);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(790, 652);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtEstudiantes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LbEstuantesR);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagos";
            this.Text = "Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEstudiantes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbEstuantesR;
        private System.Windows.Forms.ComboBox TxtTipoPa;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn space1;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DateTimePicker FechaPago;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}