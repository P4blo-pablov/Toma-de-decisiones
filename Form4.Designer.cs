namespace Toma_de_decisiones
{
    partial class ingreso_Estrategias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingreso_Estrategias));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEstrategias = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.txtDecision = new System.Windows.Forms.TextBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.flowMatrices = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstrategias)).BeginInit();
            this.SuspendLayout();
            System.ComponentModel.ComponentResourceManager resForm1 = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.BackgroundImage = ((System.Drawing.Image)(resForm1.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.label2.Location = new System.Drawing.Point(193, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "ESTRATEGIAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEstrategias
            // 
            this.dgvEstrategias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstrategias.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(10, 37, 64);
            this.dgvEstrategias.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEstrategias.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvEstrategias.EnableHeadersVisualStyles = false;
            this.dgvEstrategias.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstrategias.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.dgvEstrategias.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(10, 37, 64);
            this.dgvEstrategias.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEstrategias.Location = new System.Drawing.Point(34, 48);
            this.dgvEstrategias.Name = "dgvEstrategias";
            this.dgvEstrategias.Size = new System.Drawing.Size(555, 150);
            this.dgvEstrategias.TabIndex = 5;
            this.dgvEstrategias.BackgroundColor = System.Drawing.Color.FromArgb(239, 239, 239);
            this.dgvEstrategias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(118, 208);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(116, 33);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(10, 37, 64);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // btnMatriz
            // 
            this.btnMatriz.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatriz.Location = new System.Drawing.Point(381, 208);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(125, 33);
            this.btnMatriz.TabIndex = 7;
            this.btnMatriz.Text = "COMPARAR";
            this.btnMatriz.UseVisualStyleBackColor = false;
            this.btnMatriz.BackColor = System.Drawing.Color.FromArgb(10, 37, 64);
            this.btnMatriz.ForeColor = System.Drawing.Color.White;
            this.btnMatriz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatriz.FlatAppearance.BorderSize = 0;
            this.btnMatriz.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // txtDecision
            // 
            this.txtDecision.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecision.Location = new System.Drawing.Point(34, 498);
            this.txtDecision.Multiline = true;
            this.txtDecision.Name = "txtDecision";
            this.txtDecision.Size = new System.Drawing.Size(555, 57);
            this.txtDecision.TabIndex = 9;
            this.txtDecision.BackColor = System.Drawing.Color.White;
            this.txtDecision.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtDecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(169, 562);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(298, 33);
            this.btnGenerarReporte.TabIndex = 10;
            this.btnGenerarReporte.Text = "GENERAR REPORTE";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(10, 37, 64);
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.FlatAppearance.BorderSize = 0;
            this.btnGenerarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // flowMatrices
            // 
            this.flowMatrices.AutoScroll = true;
            this.flowMatrices.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMatrices.Location = new System.Drawing.Point(34, 247);
            this.flowMatrices.Name = "flowMatrices";
            this.flowMatrices.Size = new System.Drawing.Size(555, 245);
            this.flowMatrices.TabIndex = 11;
            this.flowMatrices.WrapContents = false;
            this.flowMatrices.BackColor = System.Drawing.Color.FromArgb(239, 239, 239);
            // 
            // ingreso_Estrategias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.ClientSize = new System.Drawing.Size(631, 607);
            this.Controls.Add(this.flowMatrices);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.txtDecision);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvEstrategias);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ingreso_Estrategias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE ESTRATEGIAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstrategias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEstrategias;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.TextBox txtDecision;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.FlowLayoutPanel flowMatrices;
    }
}