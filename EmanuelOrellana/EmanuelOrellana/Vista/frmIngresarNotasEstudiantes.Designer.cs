namespace EmanuelOrellana.Vista
{
    partial class frmIngresarNotasEstudiantes
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
            this.lblIdNotas = new System.Windows.Forms.Label();
            this.lblIdEstudiante = new System.Windows.Forms.Label();
            this.lblIdMateria = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtIdNotas = new System.Windows.Forms.TextBox();
            this.txtIdEstudiantes = new System.Windows.Forms.TextBox();
            this.txtIdMateria = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.dtvNotas = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.IdNotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdNotas
            // 
            this.lblIdNotas.AutoSize = true;
            this.lblIdNotas.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNotas.Location = new System.Drawing.Point(40, 43);
            this.lblIdNotas.Name = "lblIdNotas";
            this.lblIdNotas.Size = new System.Drawing.Size(74, 19);
            this.lblIdNotas.TabIndex = 0;
            this.lblIdNotas.Text = "Id Notas";
            // 
            // lblIdEstudiante
            // 
            this.lblIdEstudiante.AutoSize = true;
            this.lblIdEstudiante.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEstudiante.Location = new System.Drawing.Point(238, 43);
            this.lblIdEstudiante.Name = "lblIdEstudiante";
            this.lblIdEstudiante.Size = new System.Drawing.Size(112, 19);
            this.lblIdEstudiante.TabIndex = 1;
            this.lblIdEstudiante.Text = "Id Estudiante";
            // 
            // lblIdMateria
            // 
            this.lblIdMateria.AutoSize = true;
            this.lblIdMateria.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMateria.Location = new System.Drawing.Point(448, 43);
            this.lblIdMateria.Name = "lblIdMateria";
            this.lblIdMateria.Size = new System.Drawing.Size(85, 19);
            this.lblIdMateria.TabIndex = 2;
            this.lblIdMateria.Text = "Id Materia";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(671, 43);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(46, 19);
            this.lblNota.TabIndex = 3;
            this.lblNota.Text = "Nota";
            // 
            // txtIdNotas
            // 
            this.txtIdNotas.Location = new System.Drawing.Point(44, 75);
            this.txtIdNotas.Name = "txtIdNotas";
            this.txtIdNotas.Size = new System.Drawing.Size(143, 22);
            this.txtIdNotas.TabIndex = 4;
            // 
            // txtIdEstudiantes
            // 
            this.txtIdEstudiantes.Location = new System.Drawing.Point(242, 75);
            this.txtIdEstudiantes.Name = "txtIdEstudiantes";
            this.txtIdEstudiantes.Size = new System.Drawing.Size(143, 22);
            this.txtIdEstudiantes.TabIndex = 5;
            // 
            // txtIdMateria
            // 
            this.txtIdMateria.Location = new System.Drawing.Point(452, 75);
            this.txtIdMateria.Name = "txtIdMateria";
            this.txtIdMateria.Size = new System.Drawing.Size(143, 22);
            this.txtIdMateria.TabIndex = 6;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(675, 75);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(143, 22);
            this.txtNota.TabIndex = 7;
            // 
            // dtvNotas
            // 
            this.dtvNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdNotas,
            this.NombreEstudiante,
            this.NombreMateria,
            this.Nota,
            this.IDM,
            this.IdEstudiante});
            this.dtvNotas.Location = new System.Drawing.Point(12, 158);
            this.dtvNotas.Name = "dtvNotas";
            this.dtvNotas.RowHeadersWidth = 51;
            this.dtvNotas.RowTemplate.Height = 24;
            this.dtvNotas.Size = new System.Drawing.Size(837, 212);
            this.dtvNotas.TabIndex = 8;
            this.dtvNotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvNotas_CellClick);
            this.dtvNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvNotas_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(865, 158);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(143, 35);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(865, 233);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(143, 35);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(865, 305);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(143, 35);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // IdNotas
            // 
            this.IdNotas.HeaderText = "IdNotas";
            this.IdNotas.MinimumWidth = 6;
            this.IdNotas.Name = "IdNotas";
            // 
            // NombreEstudiante
            // 
            this.NombreEstudiante.HeaderText = "NombreEstudiante";
            this.NombreEstudiante.MinimumWidth = 6;
            this.NombreEstudiante.Name = "NombreEstudiante";
            // 
            // NombreMateria
            // 
            this.NombreMateria.HeaderText = "NombreMateria";
            this.NombreMateria.MinimumWidth = 6;
            this.NombreMateria.Name = "NombreMateria";
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.MinimumWidth = 6;
            this.Nota.Name = "Nota";
            // 
            // IDM
            // 
            this.IDM.HeaderText = "IDM";
            this.IDM.MinimumWidth = 6;
            this.IDM.Name = "IDM";
            this.IDM.Visible = false;
            // 
            // IdEstudiante
            // 
            this.IdEstudiante.HeaderText = "IdEstudiante";
            this.IdEstudiante.MinimumWidth = 6;
            this.IdEstudiante.Name = "IdEstudiante";
            this.IdEstudiante.Visible = false;
            // 
            // frmIngresarNotasEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 454);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtvNotas);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtIdMateria);
            this.Controls.Add(this.txtIdEstudiantes);
            this.Controls.Add(this.txtIdNotas);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblIdMateria);
            this.Controls.Add(this.lblIdEstudiante);
            this.Controls.Add(this.lblIdNotas);
            this.Name = "frmIngresarNotasEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngresarNotasEstudiantes";
            this.Load += new System.EventHandler(this.frmIngresarNotasEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdNotas;
        private System.Windows.Forms.Label lblIdEstudiante;
        private System.Windows.Forms.Label lblIdMateria;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtIdNotas;
        private System.Windows.Forms.TextBox txtIdEstudiantes;
        private System.Windows.Forms.TextBox txtIdMateria;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.DataGridView dtvNotas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstudiante;
    }
}