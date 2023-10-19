﻿namespace Proyecto_Automatas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            statusStrip1 = new StatusStrip();
            Barra_Archivo = new ToolStripSplitButton();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            Barra_Probar = new ToolStripSplitButton();
            TabEditor = new TabPage();
            Pizarra = new Panel();
            Barra_Editor = new StatusStrip();
            Editor_Seleccionar = new ToolStripDropDownButton();
            Editor_Agregar = new ToolStripDropDownButton();
            Editor_Eliminar = new ToolStripDropDownButton();
            Editor_Conectar = new ToolStripDropDownButton();
            Tab = new TabControl();
            statusStrip1.SuspendLayout();
            TabEditor.SuspendLayout();
            Barra_Editor.SuspendLayout();
            Tab.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.Top;
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { Barra_Archivo, Barra_Probar });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(993, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "Archivo";
            // 
            // Barra_Archivo
            // 
            Barra_Archivo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Barra_Archivo.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, guardarToolStripMenuItem });
            Barra_Archivo.Image = (Image)resources.GetObject("Barra_Archivo.Image");
            Barra_Archivo.ImageTransparentColor = Color.Magenta;
            Barra_Archivo.Name = "Barra_Archivo";
            Barra_Archivo.Size = new Size(64, 20);
            Barra_Archivo.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(116, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(116, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(116, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // Barra_Probar
            // 
            Barra_Probar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Barra_Probar.Image = (Image)resources.GetObject("Barra_Probar.Image");
            Barra_Probar.ImageTransparentColor = Color.Magenta;
            Barra_Probar.Name = "Barra_Probar";
            Barra_Probar.Size = new Size(58, 20);
            Barra_Probar.Text = "Probar";
            // 
            // TabEditor
            // 
            TabEditor.Controls.Add(Pizarra);
            TabEditor.Controls.Add(Barra_Editor);
            TabEditor.Location = new Point(4, 24);
            TabEditor.Name = "TabEditor";
            TabEditor.Padding = new Padding(3, 3, 3, 3);
            TabEditor.Size = new Size(985, 479);
            TabEditor.TabIndex = 0;
            TabEditor.Text = "Editor";
            TabEditor.UseVisualStyleBackColor = true;
            // 
            // Pizarra
            // 
            Pizarra.Dock = DockStyle.Fill;
            Pizarra.Location = new Point(3, 25);
            Pizarra.Name = "Pizarra";
            Pizarra.Size = new Size(979, 451);
            Pizarra.TabIndex = 1;
            Pizarra.Paint += Pizarra_Paint;
            Pizarra.MouseClick += Pizarra_MouseClick;
            Pizarra.MouseDown += Pizarra_MouseDown;
            Pizarra.MouseMove += Pizarra_MouseMove;
            Pizarra.MouseUp += Pizarra_MouseUp;
            // 
            // Barra_Editor
            // 
            Barra_Editor.Dock = DockStyle.Top;
            Barra_Editor.ImageScalingSize = new Size(24, 24);
            Barra_Editor.Items.AddRange(new ToolStripItem[] { Editor_Seleccionar, Editor_Agregar, Editor_Eliminar, Editor_Conectar });
            Barra_Editor.Location = new Point(3, 3);
            Barra_Editor.Name = "Barra_Editor";
            Barra_Editor.RenderMode = ToolStripRenderMode.Professional;
            Barra_Editor.Size = new Size(979, 22);
            Barra_Editor.TabIndex = 0;
            Barra_Editor.Text = "Barra_Editor";
            // 
            // Editor_Seleccionar
            // 
            Editor_Seleccionar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Editor_Seleccionar.Image = (Image)resources.GetObject("Editor_Seleccionar.Image");
            Editor_Seleccionar.ImageTransparentColor = Color.Magenta;
            Editor_Seleccionar.Name = "Editor_Seleccionar";
            Editor_Seleccionar.ShowDropDownArrow = false;
            Editor_Seleccionar.Size = new Size(71, 20);
            Editor_Seleccionar.Text = "Seleccionar";
            Editor_Seleccionar.Click += Editor_Seleccionar_Click;
            // 
            // Editor_Agregar
            // 
            Editor_Agregar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Editor_Agregar.Image = (Image)resources.GetObject("Editor_Agregar.Image");
            Editor_Agregar.ImageTransparentColor = Color.Magenta;
            Editor_Agregar.Name = "Editor_Agregar";
            Editor_Agregar.ShowDropDownArrow = false;
            Editor_Agregar.Size = new Size(53, 20);
            Editor_Agregar.Text = "Agregar";
            Editor_Agregar.Click += Editor_Agregar_Click;
            // 
            // Editor_Eliminar
            // 
            Editor_Eliminar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Editor_Eliminar.Image = (Image)resources.GetObject("Editor_Eliminar.Image");
            Editor_Eliminar.ImageTransparentColor = Color.Magenta;
            Editor_Eliminar.Name = "Editor_Eliminar";
            Editor_Eliminar.ShowDropDownArrow = false;
            Editor_Eliminar.Size = new Size(54, 20);
            Editor_Eliminar.Text = "Eliminar";
            Editor_Eliminar.Click += Editor_Eliminar_Click;
            // 
            // Editor_Conectar
            // 
            Editor_Conectar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Editor_Conectar.Image = (Image)resources.GetObject("Editor_Conectar.Image");
            Editor_Conectar.ImageTransparentColor = Color.Magenta;
            Editor_Conectar.Name = "Editor_Conectar";
            Editor_Conectar.ShowDropDownArrow = false;
            Editor_Conectar.Size = new Size(59, 20);
            Editor_Conectar.Text = "Conectar";
            Editor_Conectar.Click += Editor_Conectar_Click;
            // 
            // Tab
            // 
            Tab.Controls.Add(TabEditor);
            Tab.Dock = DockStyle.Fill;
            Tab.Location = new Point(0, 22);
            Tab.Name = "Tab";
            Tab.SelectedIndex = 0;
            Tab.Size = new Size(993, 507);
            Tab.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 529);
            Controls.Add(Tab);
            Controls.Add(statusStrip1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Diseñador";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            TabEditor.ResumeLayout(false);
            TabEditor.PerformLayout();
            Barra_Editor.ResumeLayout(false);
            Barra_Editor.PerformLayout();
            Tab.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripSplitButton Barra_Archivo;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripSplitButton Barra_Probar;
        private TabPage TabEditor;
        private StatusStrip Barra_Editor;
        private ToolStripDropDownButton Editor_Seleccionar;
        private ToolStripDropDownButton Editor_Agregar;
        private TabControl Tab;
        private Panel Pizarra;
        private ToolStripDropDownButton Editor_Eliminar;
        private ToolStripDropDownButton Editor_Conectar;
    }
}