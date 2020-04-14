namespace EmanuelOrellana.Vista
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresoDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNotasEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeEstudiantesToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.ingresoDeNotasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresoDeEstudiantesToolStripMenuItem
            // 
            this.ingresoDeEstudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosEstudiantesToolStripMenuItem});
            this.ingresoDeEstudiantesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoDeEstudiantesToolStripMenuItem.Name = "ingresoDeEstudiantesToolStripMenuItem";
            this.ingresoDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(242, 28);
            this.ingresoDeEstudiantesToolStripMenuItem.Text = "Ingreso de Estudiantes";
            // 
            // datosEstudiantesToolStripMenuItem
            // 
            this.datosEstudiantesToolStripMenuItem.Name = "datosEstudiantesToolStripMenuItem";
            this.datosEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(267, 28);
            this.datosEstudiantesToolStripMenuItem.Text = "Datos Estudiantes";
            this.datosEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.datosEstudiantesToolStripMenuItem_Click);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeMateriasToolStripMenuItem});
            this.materiasToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(105, 28);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // mantenimientoDeMateriasToolStripMenuItem
            // 
            this.mantenimientoDeMateriasToolStripMenuItem.Name = "mantenimientoDeMateriasToolStripMenuItem";
            this.mantenimientoDeMateriasToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.mantenimientoDeMateriasToolStripMenuItem.Text = "Mantenimiento de materias";
            this.mantenimientoDeMateriasToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeMateriasToolStripMenuItem_Click);
            // 
            // ingresoDeNotasToolStripMenuItem
            // 
            this.ingresoDeNotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNotasEstudiantesToolStripMenuItem});
            this.ingresoDeNotasToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoDeNotasToolStripMenuItem.Name = "ingresoDeNotasToolStripMenuItem";
            this.ingresoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.ingresoDeNotasToolStripMenuItem.Text = "Ingreso de Notas";
            // 
            // ingresarNotasEstudiantesToolStripMenuItem
            // 
            this.ingresarNotasEstudiantesToolStripMenuItem.Name = "ingresarNotasEstudiantesToolStripMenuItem";
            this.ingresarNotasEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.ingresarNotasEstudiantesToolStripMenuItem.Text = "Ingresar notas Estudiantes";
            this.ingresarNotasEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.ingresarNotasEstudiantesToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNotasEstudiantesToolStripMenuItem;
    }
}