namespace Proyecto_Automatas
{
    partial class Diseñador
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            toolStripStatusLabel6 = new ToolStripStatusLabel();
            General_Menu_Regresar = new ToolStripStatusLabel();
            Tabla_Propiedades = new TableLayoutPanel();
            Pizzarra = new Panel();
            Menu_Pizzarra = new StatusStrip();
            Pizzarra_Menu_Seleccionar = new ToolStripStatusLabel();
            Pizzarra_Menu_Agregar = new ToolStripStatusLabel();
            Pizzarra_Menu_Conectar = new ToolStripStatusLabel();
            Pizzarra_Menu_Eliminar = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            Pizzarra.SuspendLayout();
            Menu_Pizzarra.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.Top;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel5, toolStripStatusLabel6, General_Menu_Regresar });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Image = Properties.Resources.Archivo;
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(64, 17);
            toolStripStatusLabel5.Text = "Archivo";
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Image = Properties.Resources.Probar;
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new Size(58, 17);
            toolStripStatusLabel6.Text = "Probar";
            // 
            // General_Menu_Regresar
            // 
            General_Menu_Regresar.Image = Properties.Resources.Salir;
            General_Menu_Regresar.Name = "General_Menu_Regresar";
            General_Menu_Regresar.Size = new Size(68, 17);
            General_Menu_Regresar.Text = "Regresar";
            General_Menu_Regresar.Click += General_Menu_Regresar_Click;
            // 
            // Tabla_Propiedades
            // 
            Tabla_Propiedades.BackColor = Color.Gainsboro;
            Tabla_Propiedades.ColumnCount = 1;
            Tabla_Propiedades.ColumnStyles.Add(new ColumnStyle());
            Tabla_Propiedades.Dock = DockStyle.Right;
            Tabla_Propiedades.Location = new Point(622, 22);
            Tabla_Propiedades.Name = "Tabla_Propiedades";
            Tabla_Propiedades.RowCount = 1;
            Tabla_Propiedades.RowStyles.Add(new RowStyle());
            Tabla_Propiedades.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tabla_Propiedades.Size = new Size(178, 428);
            Tabla_Propiedades.TabIndex = 1;
            // 
            // Pizzarra
            // 
            Pizzarra.BackColor = Color.White;
            Pizzarra.Controls.Add(Menu_Pizzarra);
            Pizzarra.Dock = DockStyle.Fill;
            Pizzarra.Location = new Point(0, 22);
            Pizzarra.Name = "Pizzarra";
            Pizzarra.Size = new Size(622, 428);
            Pizzarra.TabIndex = 2;
            Pizzarra.MouseClick += Pizzarra_MouseClick;
            // 
            // Menu_Pizzarra
            // 
            Menu_Pizzarra.Dock = DockStyle.Top;
            Menu_Pizzarra.Items.AddRange(new ToolStripItem[] { Pizzarra_Menu_Seleccionar, Pizzarra_Menu_Agregar, Pizzarra_Menu_Conectar, Pizzarra_Menu_Eliminar });
            Menu_Pizzarra.Location = new Point(0, 0);
            Menu_Pizzarra.Name = "Menu_Pizzarra";
            Menu_Pizzarra.Size = new Size(622, 22);
            Menu_Pizzarra.TabIndex = 0;
            Menu_Pizzarra.Text = "statusStrip2";
            // 
            // Pizzarra_Menu_Seleccionar
            // 
            Pizzarra_Menu_Seleccionar.Image = Properties.Resources.Seleccionar;
            Pizzarra_Menu_Seleccionar.Name = "Pizzarra_Menu_Seleccionar";
            Pizzarra_Menu_Seleccionar.Size = new Size(83, 17);
            Pizzarra_Menu_Seleccionar.Text = "Seleccionar";
            Pizzarra_Menu_Seleccionar.Click += Pizzarra_Menu_Seleccionar_Click;
            // 
            // Pizzarra_Menu_Agregar
            // 
            Pizzarra_Menu_Agregar.Image = Properties.Resources.Agregar;
            Pizzarra_Menu_Agregar.Name = "Pizzarra_Menu_Agregar";
            Pizzarra_Menu_Agregar.Size = new Size(65, 17);
            Pizzarra_Menu_Agregar.Text = "Agregar";
            Pizzarra_Menu_Agregar.Click += Pizzarra_Menu_Agregar_Click;
            // 
            // Pizzarra_Menu_Conectar
            // 
            Pizzarra_Menu_Conectar.Image = Properties.Resources.Conectar;
            Pizzarra_Menu_Conectar.Name = "Pizzarra_Menu_Conectar";
            Pizzarra_Menu_Conectar.Size = new Size(71, 17);
            Pizzarra_Menu_Conectar.Text = "Conectar";
            Pizzarra_Menu_Conectar.Click += Pizzarra_Menu_Conectar_Click;
            // 
            // Pizzarra_Menu_Eliminar
            // 
            Pizzarra_Menu_Eliminar.Image = Properties.Resources.Eliminar;
            Pizzarra_Menu_Eliminar.Name = "Pizzarra_Menu_Eliminar";
            Pizzarra_Menu_Eliminar.Size = new Size(66, 17);
            Pizzarra_Menu_Eliminar.Text = "Eliminar";
            Pizzarra_Menu_Eliminar.Click += Pizzarra_Menu_Eliminar_Click;
            // 
            // Diseñador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Pizzarra);
            Controls.Add(Tabla_Propiedades);
            Controls.Add(statusStrip1);
            Name = "Diseñador";
            Text = "Diseñador";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            Pizzarra.ResumeLayout(false);
            Pizzarra.PerformLayout();
            Menu_Pizzarra.ResumeLayout(false);
            Menu_Pizzarra.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private TableLayoutPanel Tabla_Propiedades;
        private Panel Pizzarra;
        private StatusStrip Menu_Pizzarra;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel Pizzarra_Menu_Seleccionar;
        private ToolStripStatusLabel Pizzarra_Menu_Agregar;
        private ToolStripStatusLabel Pizzarra_Menu_Conectar;
        private ToolStripStatusLabel Pizzarra_Menu_Eliminar;
        private ToolStripStatusLabel General_Menu_Regresar;
    }
}