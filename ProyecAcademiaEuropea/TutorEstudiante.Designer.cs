namespace ProyecAcademiaEuropea
{
    partial class TutorEstudiante
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CBNacionalidad = new System.Windows.Forms.ComboBox();
            this.TxtCelTutor = new System.Windows.Forms.TextBox();
            this.TxtCorreoTutor = new System.Windows.Forms.TextBox();
            this.TxtDirecTutor = new System.Windows.Forms.TextBox();
            this.TxtEdadTutor = new System.Windows.Forms.TextBox();
            this.TxtNomTutor = new System.Windows.Forms.TextBox();
            this.TxtCedTutor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dtTutor = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTutor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.CBNacionalidad);
            this.groupBox1.Controls.Add(this.TxtCelTutor);
            this.groupBox1.Controls.Add(this.TxtCorreoTutor);
            this.groupBox1.Controls.Add(this.TxtDirecTutor);
            this.groupBox1.Controls.Add(this.TxtEdadTutor);
            this.groupBox1.Controls.Add(this.TxtNomTutor);
            this.groupBox1.Controls.Add(this.TxtCedTutor);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Location = new System.Drawing.Point(36, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1824, 484);
            this.groupBox1.TabIndex = 646;
            this.groupBox1.TabStop = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Gold;
            this.BtnGuardar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Navy;
            this.BtnGuardar.Location = new System.Drawing.Point(1272, 397);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(196, 58);
            this.BtnGuardar.TabIndex = 67;
            this.BtnGuardar.Text = "Guadar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CBNacionalidad
            // 
            this.CBNacionalidad.FormattingEnabled = true;
            this.CBNacionalidad.Items.AddRange(new object[] {
            "Nicaragua",
            "Panamá",
            "El salvador ",
            "Costa Rica",
            "México",
            "Argentina"});
            this.CBNacionalidad.Location = new System.Drawing.Point(1402, 300);
            this.CBNacionalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBNacionalidad.Name = "CBNacionalidad";
            this.CBNacionalidad.Size = new System.Drawing.Size(199, 33);
            this.CBNacionalidad.TabIndex = 34;
            // 
            // TxtCelTutor
            // 
            this.TxtCelTutor.Location = new System.Drawing.Point(1346, 222);
            this.TxtCelTutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCelTutor.MaxLength = 8;
            this.TxtCelTutor.Name = "TxtCelTutor";
            this.TxtCelTutor.Size = new System.Drawing.Size(122, 31);
            this.TxtCelTutor.TabIndex = 33;
            // 
            // TxtCorreoTutor
            // 
            this.TxtCorreoTutor.Location = new System.Drawing.Point(270, 291);
            this.TxtCorreoTutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCorreoTutor.Name = "TxtCorreoTutor";
            this.TxtCorreoTutor.Size = new System.Drawing.Size(559, 31);
            this.TxtCorreoTutor.TabIndex = 32;
            // 
            // TxtDirecTutor
            // 
            this.TxtDirecTutor.Location = new System.Drawing.Point(270, 222);
            this.TxtDirecTutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDirecTutor.Name = "TxtDirecTutor";
            this.TxtDirecTutor.Size = new System.Drawing.Size(559, 31);
            this.TxtDirecTutor.TabIndex = 31;
            // 
            // TxtEdadTutor
            // 
            this.TxtEdadTutor.Location = new System.Drawing.Point(1346, 150);
            this.TxtEdadTutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEdadTutor.Name = "TxtEdadTutor";
            this.TxtEdadTutor.Size = new System.Drawing.Size(91, 31);
            this.TxtEdadTutor.TabIndex = 30;
            // 
            // TxtNomTutor
            // 
            this.TxtNomTutor.Location = new System.Drawing.Point(406, 148);
            this.TxtNomTutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNomTutor.Name = "TxtNomTutor";
            this.TxtNomTutor.Size = new System.Drawing.Size(422, 31);
            this.TxtNomTutor.TabIndex = 29;
            // 
            // TxtCedTutor
            // 
            this.TxtCedTutor.Location = new System.Drawing.Point(1346, 86);
            this.TxtCedTutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCedTutor.Name = "TxtCedTutor";
            this.TxtCedTutor.Size = new System.Drawing.Size(264, 31);
            this.TxtCedTutor.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1184, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 38);
            this.label9.TabIndex = 27;
            this.label9.Text = "Celular :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1138, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 38);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nacionalidad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1184, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 38);
            this.label8.TabIndex = 25;
            this.label8.Text = "Edad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 38);
            this.label4.TabIndex = 24;
            this.label4.Text = "Correo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 38);
            this.label3.TabIndex = 23;
            this.label3.Text = "Dirección :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1191, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 38);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cédula :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre y Apellidos :";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Gold;
            this.btnActualizar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Navy;
            this.btnActualizar.Location = new System.Drawing.Point(1478, 397);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(196, 58);
            this.btnActualizar.TabIndex = 68;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Visible = false;
            // 
            // dtTutor
            // 
            this.dtTutor.AllowUserToAddRows = false;
            this.dtTutor.AllowUserToDeleteRows = false;
            this.dtTutor.AllowUserToResizeRows = false;
            this.dtTutor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.Eliminar,
            this.Editar});
            this.dtTutor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtTutor.Location = new System.Drawing.Point(0, 661);
            this.dtTutor.Margin = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.dtTutor.Name = "dtTutor";
            this.dtTutor.ReadOnly = true;
            this.dtTutor.RowHeadersWidth = 82;
            this.dtTutor.RowTemplate.Height = 33;
            this.dtTutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtTutor.ShowCellToolTips = false;
            this.dtTutor.ShowEditingIcon = false;
            this.dtTutor.Size = new System.Drawing.Size(1915, 436);
            this.dtTutor.TabIndex = 647;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 10;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 200;
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
            // TutorEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1915, 1097);
            this.Controls.Add(this.dtTutor);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TutorEstudiante";
            this.Text = "TutorEstudiante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CBNacionalidad;
        private System.Windows.Forms.TextBox TxtCelTutor;
        private System.Windows.Forms.TextBox TxtCorreoTutor;
        private System.Windows.Forms.TextBox TxtDirecTutor;
        private System.Windows.Forms.TextBox TxtEdadTutor;
        private System.Windows.Forms.TextBox TxtNomTutor;
        private System.Windows.Forms.TextBox TxtCedTutor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dtTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}