namespace Toma_de_decisiones
{
    partial class Def_objetivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Def_objetivos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbOptimo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvValor = new System.Windows.Forms.DataGridView();
            this.clmValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstbObjetivos = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGenerarMatriz = new System.Windows.Forms.Button();
            this.panelMatriz = new System.Windows.Forms.Panel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelResultados = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValor)).BeginInit();
            this.SuspendLayout();
            System.ComponentModel.ComponentResourceManager resForm1 = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.BackgroundImage = ((System.Drawing.Image)(resForm1.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.label2.Location = new System.Drawing.Point(246, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "OBJETIVOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.label3.Location = new System.Drawing.Point(34, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prioridad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.label4.Location = new System.Drawing.Point(184, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.label5.Location = new System.Drawing.Point(184, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Optimo";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(38, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(118, 31);
            this.txtNombre.TabIndex = 5;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrioridad.BackColor = System.Drawing.Color.White;
            this.cmbPrioridad.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.cmbPrioridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(38, 145);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(118, 31);
            this.cmbPrioridad.TabIndex = 6;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.BackColor = System.Drawing.Color.White;
            this.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(187, 85);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(129, 31);
            this.cmbTipo.TabIndex = 7;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // cmbOptimo
            // 
            this.cmbOptimo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOptimo.BackColor = System.Drawing.Color.White;
            this.cmbOptimo.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.cmbOptimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOptimo.FormattingEnabled = true;
            this.cmbOptimo.Location = new System.Drawing.Point(187, 145);
            this.cmbOptimo.Name = "cmbOptimo";
            this.cmbOptimo.Size = new System.Drawing.Size(129, 31);
            this.cmbOptimo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.label6.Location = new System.Drawing.Point(360, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor Cualitativo";
            // 
            // dgvValor
            // 
            this.dgvValor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmValor,
            this.clmDescripcion});
            this.dgvValor.Enabled = false;
            this.dgvValor.Location = new System.Drawing.Point(359, 59);
            this.dgvValor.Name = "dgvValor";
            this.dgvValor.Size = new System.Drawing.Size(225, 76);
            this.dgvValor.TabIndex = 10;
            this.dgvValor.BackgroundColor = System.Drawing.Color.FromArgb(239, 239, 239);
            this.dgvValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvValor.GridColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.dgvValor.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvValor.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.dgvValor.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvValor.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(10, 37, 64);
            this.dgvValor.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvValor.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(10, 37, 64);
            this.dgvValor.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvValor.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvValor.EnableHeadersVisualStyles = false;
            // 
            // clmValor
            // 
            this.clmValor.HeaderText = "Valor";
            this.clmValor.Name = "clmValor";
            this.clmValor.Width = 35;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.HeaderText = "Descripcion";
            this.clmDescripcion.Name = "clmDescripcion";
            // 
            // lstbObjetivos
            // 
            this.lstbObjetivos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbObjetivos.BackColor = System.Drawing.Color.White;
            this.lstbObjetivos.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lstbObjetivos.FormattingEnabled = true;
            this.lstbObjetivos.HorizontalScrollbar = true;
            this.lstbObjetivos.ItemHeight = 23;
            this.lstbObjetivos.Location = new System.Drawing.Point(38, 215);
            this.lstbObjetivos.Name = "lstbObjetivos";
            this.lstbObjetivos.ScrollAlwaysVisible = true;
            this.lstbObjetivos.Size = new System.Drawing.Size(661, 96);
            this.lstbObjetivos.TabIndex = 11;
            this.lstbObjetivos.SelectedIndexChanged += new System.EventHandler(this.lstbObjetivos_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(590, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 33);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(10, 37, 64);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnGenerarMatriz
            // 
            this.btnGenerarMatriz.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarMatriz.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarMatriz.Location = new System.Drawing.Point(305, 321);
            this.btnGenerarMatriz.Name = "btnGenerarMatriz";
            this.btnGenerarMatriz.Size = new System.Drawing.Size(109, 33);
            this.btnGenerarMatriz.TabIndex = 13;
            this.btnGenerarMatriz.Text = "Aceptar";
            this.btnGenerarMatriz.UseVisualStyleBackColor = false;
            this.btnGenerarMatriz.BackColor = System.Drawing.Color.FromArgb(10, 37, 64);
            this.btnGenerarMatriz.ForeColor = System.Drawing.Color.White;
            this.btnGenerarMatriz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarMatriz.FlatAppearance.BorderSize = 0;
            this.btnGenerarMatriz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarMatriz.Click += new System.EventHandler(this.btnGenerarMatriz_Click);
            // 
            // panelMatriz
            // 
            this.panelMatriz.BackColor = System.Drawing.Color.FromArgb(239, 239, 239);
            this.panelMatriz.Location = new System.Drawing.Point(47, 378);
            this.panelMatriz.Name = "panelMatriz";
            this.panelMatriz.Size = new System.Drawing.Size(236, 252);
            this.panelMatriz.TabIndex = 14;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.Location = new System.Drawing.Point(99, 636);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(109, 33);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Aceptar";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(10, 37, 64);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.label7.Location = new System.Drawing.Point(34, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lista de Objetivos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.label8.Location = new System.Drawing.Point(55, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Matriz de Comparacion";
            // 
            // panelResultados
            // 
            this.panelResultados.BackColor = System.Drawing.Color.FromArgb(239, 239, 239);
            this.panelResultados.Location = new System.Drawing.Point(298, 378);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Size = new System.Drawing.Size(238, 252);
            this.panelResultados.TabIndex = 15;
            this.panelResultados.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.label9.Location = new System.Drawing.Point(319, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Importancia Relativa";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(362, 636);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 33);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(10, 37, 64);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Location = new System.Drawing.Point(360, 157);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(224, 31);
            this.txtValor.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.label10.Location = new System.Drawing.Point(359, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Valor Cualitativo";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(554, 478);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(157, 46);
            this.btnSiguiente.TabIndex = 22;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(10, 37, 64);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Def_objetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.ClientSize = new System.Drawing.Size(736, 681);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panelResultados);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panelMatriz);
            this.Controls.Add(this.btnGenerarMatriz);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstbObjetivos);
            this.Controls.Add(this.dgvValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbOptimo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Def_objetivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE OBJETIVOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbOptimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvValor;
        private System.Windows.Forms.ListBox lstbObjetivos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGenerarMatriz;
        private System.Windows.Forms.Panel panelMatriz;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelResultados;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSiguiente;
    }
}