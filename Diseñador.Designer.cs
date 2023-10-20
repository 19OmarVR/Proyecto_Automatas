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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TB_Propiedades_Nombre = new TextBox();
            CB_Propiedades_Color = new ComboBox();
            TB_Propiedades_Radio = new TextBox();
            BT_Propiedades_Guardar = new Button();
            Pizzarra = new Panel();
            Menu_Pizzarra = new StatusStrip();
            Pizzarra_Menu_Seleccionar = new ToolStripStatusLabel();
            Pizzarra_Menu_Agregar = new ToolStripStatusLabel();
            Pizzarra_Menu_Conectar = new ToolStripStatusLabel();
            Pizzarra_Menu_Eliminar = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            Tabla_Propiedades.SuspendLayout();
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
            statusStrip1.Size = new Size(990, 22);
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
            Tabla_Propiedades.ColumnCount = 2;
            Tabla_Propiedades.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            Tabla_Propiedades.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            Tabla_Propiedades.Controls.Add(label1, 0, 0);
            Tabla_Propiedades.Controls.Add(label2, 0, 1);
            Tabla_Propiedades.Controls.Add(label3, 0, 2);
            Tabla_Propiedades.Controls.Add(label4, 0, 3);
            Tabla_Propiedades.Controls.Add(TB_Propiedades_Nombre, 1, 1);
            Tabla_Propiedades.Controls.Add(CB_Propiedades_Color, 1, 2);
            Tabla_Propiedades.Controls.Add(TB_Propiedades_Radio, 1, 3);
            Tabla_Propiedades.Controls.Add(BT_Propiedades_Guardar, 1, 4);
            Tabla_Propiedades.Dock = DockStyle.Right;
            Tabla_Propiedades.Location = new Point(729, 22);
            Tabla_Propiedades.Name = "Tabla_Propiedades";
            Tabla_Propiedades.RowCount = 6;
            Tabla_Propiedades.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            Tabla_Propiedades.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            Tabla_Propiedades.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            Tabla_Propiedades.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            Tabla_Propiedades.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            Tabla_Propiedades.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tabla_Propiedades.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tabla_Propiedades.Size = new Size(261, 515);
            Tabla_Propiedades.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(5, 5, 5, 0);
            label1.Size = new Size(120, 30);
            label1.TabIndex = 0;
            label1.Text = "Propiedades";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(3, 30);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(120, 30);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(3, 60);
            label3.Name = "label3";
            label3.Padding = new Padding(5);
            label3.Size = new Size(120, 30);
            label3.TabIndex = 2;
            label3.Text = "Color:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(3, 90);
            label4.Name = "label4";
            label4.Padding = new Padding(5);
            label4.Size = new Size(120, 30);
            label4.TabIndex = 3;
            label4.Text = "Radio:";
            // 
            // TB_Propiedades_Nombre
            // 
            TB_Propiedades_Nombre.Dock = DockStyle.Fill;
            TB_Propiedades_Nombre.Enabled = false;
            TB_Propiedades_Nombre.Location = new Point(129, 33);
            TB_Propiedades_Nombre.Name = "TB_Propiedades_Nombre";
            TB_Propiedades_Nombre.Size = new Size(129, 23);
            TB_Propiedades_Nombre.TabIndex = 4;
            // 
            // CB_Propiedades_Color
            // 
            CB_Propiedades_Color.Dock = DockStyle.Fill;
            CB_Propiedades_Color.Enabled = false;
            CB_Propiedades_Color.FormattingEnabled = true;
            CB_Propiedades_Color.Items.AddRange(new object[] { "Gold", "LightGreen", "IndianRed", "LightGray", "LightBlue" });
            CB_Propiedades_Color.Location = new Point(129, 63);
            CB_Propiedades_Color.Name = "CB_Propiedades_Color";
            CB_Propiedades_Color.Size = new Size(129, 23);
            CB_Propiedades_Color.TabIndex = 5;
            // 
            // TB_Propiedades_Radio
            // 
            TB_Propiedades_Radio.Dock = DockStyle.Fill;
            TB_Propiedades_Radio.Enabled = false;
            TB_Propiedades_Radio.Location = new Point(129, 93);
            TB_Propiedades_Radio.Name = "TB_Propiedades_Radio";
            TB_Propiedades_Radio.Size = new Size(129, 23);
            TB_Propiedades_Radio.TabIndex = 6;
            // 
            // BT_Propiedades_Guardar
            // 
            BT_Propiedades_Guardar.Dock = DockStyle.Fill;
            BT_Propiedades_Guardar.Enabled = false;
            BT_Propiedades_Guardar.Location = new Point(129, 123);
            BT_Propiedades_Guardar.Name = "BT_Propiedades_Guardar";
            BT_Propiedades_Guardar.Size = new Size(129, 24);
            BT_Propiedades_Guardar.TabIndex = 7;
            BT_Propiedades_Guardar.Text = "Guardar Cambios";
            BT_Propiedades_Guardar.UseVisualStyleBackColor = true;
            BT_Propiedades_Guardar.Click += BT_Propiedades_Guardar_Click;
            // 
            // Pizzarra
            // 
            Pizzarra.BackColor = Color.White;
            Pizzarra.Controls.Add(Menu_Pizzarra);
            Pizzarra.Dock = DockStyle.Fill;
            Pizzarra.Location = new Point(0, 22);
            Pizzarra.Name = "Pizzarra";
            Pizzarra.Size = new Size(729, 515);
            Pizzarra.TabIndex = 2;
            Pizzarra.MouseClick += Pizzarra_MouseClick;
            // 
            // Menu_Pizzarra
            // 
            Menu_Pizzarra.Dock = DockStyle.Top;
            Menu_Pizzarra.Items.AddRange(new ToolStripItem[] { Pizzarra_Menu_Seleccionar, Pizzarra_Menu_Agregar, Pizzarra_Menu_Conectar, Pizzarra_Menu_Eliminar });
            Menu_Pizzarra.Location = new Point(0, 0);
            Menu_Pizzarra.Name = "Menu_Pizzarra";
            Menu_Pizzarra.Size = new Size(729, 22);
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
            ClientSize = new Size(990, 537);
            Controls.Add(Pizzarra);
            Controls.Add(Tabla_Propiedades);
            Controls.Add(statusStrip1);
            Name = "Diseñador";
            Text = "Diseñador";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            Tabla_Propiedades.ResumeLayout(false);
            Tabla_Propiedades.PerformLayout();
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TB_Propiedades_Nombre;
        private ComboBox CB_Propiedades_Color;
        private TextBox TB_Propiedades_Radio;
        private Button BT_Propiedades_Guardar;
    }
}