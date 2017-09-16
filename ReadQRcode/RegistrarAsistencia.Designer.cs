namespace ReadQRcode
{
    partial class RegistrarAsistencia
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
            this.lblCue = new System.Windows.Forms.Label();
            this.lblColegio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvInscriptos = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowDocente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RowVoucher = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscriptos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCue
            // 
            this.lblCue.AutoSize = true;
            this.lblCue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCue.Location = new System.Drawing.Point(121, 67);
            this.lblCue.Name = "lblCue";
            this.lblCue.Size = new System.Drawing.Size(84, 25);
            this.lblCue.TabIndex = 14;
            this.lblCue.Text = "nombre";
            // 
            // lblColegio
            // 
            this.lblColegio.AutoSize = true;
            this.lblColegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColegio.Location = new System.Drawing.Point(121, 27);
            this.lblColegio.Name = "lblColegio";
            this.lblColegio.Size = new System.Drawing.Size(84, 25);
            this.lblColegio.TabIndex = 13;
            this.lblColegio.Text = "nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "CUE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Colegio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblCue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblColegio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Colegio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvInscriptos);
            this.groupBox2.Location = new System.Drawing.Point(16, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 290);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inscriptos";
            // 
            // dgvInscriptos
            // 
            this.dgvInscriptos.AllowUserToAddRows = false;
            this.dgvInscriptos.AllowUserToDeleteRows = false;
            this.dgvInscriptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscriptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk,
            this.RowId,
            this.RowNombre,
            this.RowDni,
            this.RowDocente,
            this.RowVoucher});
            this.dgvInscriptos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInscriptos.Location = new System.Drawing.Point(3, 16);
            this.dgvInscriptos.Name = "dgvInscriptos";
            this.dgvInscriptos.RowHeadersVisible = false;
            this.dgvInscriptos.Size = new System.Drawing.Size(605, 271);
            this.dgvInscriptos.TabIndex = 0;
            this.dgvInscriptos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvInscriptos_DataBindingComplete);
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.Name = "chk";
            this.chk.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chk.Width = 50;
            // 
            // RowId
            // 
            this.RowId.DataPropertyName = "id";
            this.RowId.HeaderText = "Id";
            this.RowId.Name = "RowId";
            this.RowId.Visible = false;
            // 
            // RowNombre
            // 
            this.RowNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RowNombre.DataPropertyName = "nombre";
            this.RowNombre.HeaderText = "Nombre";
            this.RowNombre.Name = "RowNombre";
            this.RowNombre.ReadOnly = true;
            // 
            // RowDni
            // 
            this.RowDni.DataPropertyName = "dni";
            this.RowDni.HeaderText = "DNI";
            this.RowDni.Name = "RowDni";
            this.RowDni.ReadOnly = true;
            // 
            // RowDocente
            // 
            this.RowDocente.DataPropertyName = "es_docente";
            this.RowDocente.HeaderText = "Docente";
            this.RowDocente.Name = "RowDocente";
            this.RowDocente.ReadOnly = true;
            this.RowDocente.Width = 80;
            // 
            // RowVoucher
            // 
            this.RowVoucher.DataPropertyName = "recibe_voucher";
            this.RowVoucher.HeaderText = "Recibe Voucher";
            this.RowVoucher.Name = "RowVoucher";
            this.RowVoucher.ReadOnly = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnRegistrar.Location = new System.Drawing.Point(215, 437);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(215, 50);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "Registrar Asistencia";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSalir.Location = new System.Drawing.Point(436, 437);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(185, 50);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(466, 118);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(155, 23);
            this.btnInscribir.TabIndex = 19;
            this.btnInscribir.Text = "Inscribir Persona Faltante";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(168, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total Inscriptos:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotal.Location = new System.Drawing.Point(303, 118);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 24);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "*";
            // 
            // RegistrarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 495);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarAsistencia";
            this.Text = "Registrar Asistencia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscriptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCue;
        private System.Windows.Forms.Label lblColegio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvInscriptos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowDni;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RowDocente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RowVoucher;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
    }
}