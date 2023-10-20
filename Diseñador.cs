using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Automatas
{
    public partial class Diseñador : Form
    {
        //Atributos globales
        private int estado = 0; //1 = Seleccionar, 2 = Agregra, 3 = Conectar, 4 = eliminar
        private int contadorNodos = 0;
        private bool isDragging = false;
        private Point lastLocation;
        //variable para almacenar el PictureBox seleccionado
        private PictureBox selectedPictureBox;
        public string originalcolor = "";

        public Diseñador()
        {
            InitializeComponent();
        }



        //Funcion para Regresar al Menu de inicio
        private void General_Menu_Regresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(this);
            this.Hide();
        }

        #region Control de Seleccion del menu pizzarra 
        private void Pizzarra_Menu_Seleccionar_Click(object sender, EventArgs e)
        {
            estado = 1;
            Pizzarra_Menu_Seleccionar.ForeColor = Color.SkyBlue;
            Pizzarra_Menu_Agregar.ForeColor = Color.Black;
            Pizzarra_Menu_Conectar.ForeColor = Color.Black;
            Pizzarra_Menu_Eliminar.ForeColor = Color.Black;
        }

        private void Pizzarra_Menu_Agregar_Click(object sender, EventArgs e)
        {
            estado = 2;
            Pizzarra_Menu_Seleccionar.ForeColor = Color.Black;
            Pizzarra_Menu_Agregar.ForeColor = Color.SkyBlue;
            Pizzarra_Menu_Conectar.ForeColor = Color.Black;
            Pizzarra_Menu_Eliminar.ForeColor = Color.Black;
        }

        private void Pizzarra_Menu_Conectar_Click(object sender, EventArgs e)
        {
            estado = 3;
            Pizzarra_Menu_Seleccionar.ForeColor = Color.Black;
            Pizzarra_Menu_Agregar.ForeColor = Color.Black;
            Pizzarra_Menu_Conectar.ForeColor = Color.SkyBlue;
            Pizzarra_Menu_Eliminar.ForeColor = Color.Black;
        }

        private void Pizzarra_Menu_Eliminar_Click(object sender, EventArgs e)
        {
            estado = 4;
            Pizzarra_Menu_Seleccionar.ForeColor = Color.Black;
            Pizzarra_Menu_Agregar.ForeColor = Color.Black;
            Pizzarra_Menu_Conectar.ForeColor = Color.Black;
            Pizzarra_Menu_Eliminar.ForeColor = Color.SkyBlue;
        }
        #endregion

        //Funcion al dar un click en la Pizzarra
        private void Pizzarra_MouseClick(object sender, MouseEventArgs e)
        {
            switch (estado)
            {
                //Seleccionar
                case 1:

                    break;

                //Agregar
                case 2:
                    // Crea un nuevo PictureBox
                    PictureBox pictureBox = new PictureBox();

                    // Establece la ubicación del PictureBox en el lugar del clic
                    Point clickLocation = Pizzarra.PointToClient(Cursor.Position);
                    pictureBox.Location = clickLocation;

                    // Establece el tamaño del PictureBox
                    pictureBox.Size = new Size(50, 50);

                    // Obtén la ruta de la carpeta raíz del proyecto
                    string proyectoRaiz = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);

                    // Concatena el nombre de tu imagen a la ruta de la carpeta raíz
                    string imagePath = System.IO.Path.Combine(proyectoRaiz, "src/Circulo.png");

                    // Cargar la imagen original
                    Image originalImage = Image.FromFile(imagePath);

                    // Crear una nueva imagen con el texto centrado
                    Bitmap imageWithText = new Bitmap(originalImage);

                    using (Graphics g = Graphics.FromImage(imageWithText))
                    {
                        // Dibujar la imagen original
                        g.DrawImage(originalImage, new Rectangle(0, 0, imageWithText.Width, imageWithText.Height));

                        // Configurar la fuente y el formato del texto
                        Font font = new Font("Console", 100, FontStyle.Bold);
                        string text = "q" + contadorNodos.ToString();
                        SizeF textSize = g.MeasureString(text, font);
                        Point textLocation = new Point((imageWithText.Width - (int)textSize.Width) / 2, (imageWithText.Height - (int)textSize.Height) / 2);

                        // Dibujar el texto centrado
                        g.DrawString(text, font, Brushes.Black, textLocation);
                    }

                    // Mostrar la nueva imagen en el PictureBox
                    pictureBox.Image = imageWithText;

                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;


                    // Establece un nombre específico
                    pictureBox.Name = "q" + contadorNodos.ToString(); // Puedes asignar un nombre único
                    contadorNodos++;

                    // Establece un color de fondo (opcional)
                    pictureBox.BackColor = Color.Gold;

                    // Asigna un controlador de eventos a los pictureBox
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;


                    // Agrega el PictureBox al Panel "Pizzarra"
                    Pizzarra.Controls.Add(pictureBox);

                    //Agregra en la lista el nodo
                    break;
            }

        }

        // Controlador de eventos de MouseDown para los PictureBox
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (estado)
                {
                    //Seleccionar
                    case 1:
                        if (e.Button == MouseButtons.Left)
                        {
                            isDragging = true;
                            lastLocation = e.Location;
                            PictureBox nodo = sender as PictureBox;
                            string color = nodo.BackColor.ToString();
                            originalcolor = color.Replace("Color [", "");
                            originalcolor = originalcolor.Replace("]", "");
                            nodo.BackColor = Color.SkyBlue;
                            nodo.BringToFront(); // Trae el PictureBox al frente para evitar que quede detrás de otros controles
                        }
                        break;

                    //Eliminar 
                    case 4:
                        if (sender is PictureBox pictureBox)
                        {
                            //Elimina el PictureBox del Panel Pizzarra
                            Pizzarra.Controls.Remove(pictureBox);
                        }
                        break;
                }

            }
            else if (e.Button == MouseButtons.Right)
            {
                //Mostrar propiedades
                switch (estado)
                {
                    // Selección
                    case 1:
                        isDragging = true;
                        lastLocation = e.Location;
                        selectedPictureBox = sender as PictureBox;
                        selectedPictureBox.BringToFront();
                        // Actualiza los controles en la tabla de propiedades con las propiedades del PictureBox seleccionado
                        UpdatePropertyTable(selectedPictureBox);
                        TB_Propiedades_Nombre.Enabled = true;
                        CB_Propiedades_Color.Enabled = true;
                        TB_Propiedades_Radio.Enabled = true;
                        BT_Propiedades_Guardar.Enabled = true;
                        break;
                }
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (estado)
                {
                    case 1:
                        isDragging = false;
                        PictureBox nodo = sender as PictureBox;
                        nodo.BackColor = Color.FromName(originalcolor);
                        break;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {

            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isDragging) // Comprueba que el botón izquierdo del ratón esté presionado y se esté arrastrando
            {
                PictureBox pictureBox = sender as PictureBox;
                Point newLocation = pictureBox.Location;

                newLocation.X += e.X - lastLocation.X;
                newLocation.Y += e.Y - lastLocation.Y;

                pictureBox.Location = newLocation;
            }
        }

        // Método para actualizar los controles en la tabla de propiedades
        private void UpdatePropertyTable(PictureBox pictureBox)
        {
            if (pictureBox != null)
            {
                // Muestra las propiedades en los controles de la tabla de propiedades
                TB_Propiedades_Nombre.Text = pictureBox.Name;
                CB_Propiedades_Color.Text = pictureBox.BackColor.Name;
                TB_Propiedades_Radio.Text = (pictureBox.Width / 2).ToString();

                // Otros controles y propiedades aquí...

                // Habilita el botón de aplicar cambios
                BT_Propiedades_Guardar.Enabled = true;
            }
        }

        private void BT_Propiedades_Guardar_Click(object sender, EventArgs e)
        {
            if (selectedPictureBox != null)
            {
                //Aplica los cambios a las propiedades del PictureBox seleccionado
                try
                {
                    if (int.TryParse(TB_Propiedades_Radio.Text, out int radio))
                    {
                        int diametro = radio * 2;
                        selectedPictureBox.Width = diametro;
                        selectedPictureBox.Height = diametro;
                    }

                    if (!string.IsNullOrEmpty(CB_Propiedades_Color.Text))
                    {
                        selectedPictureBox.BackColor = Color.FromName(CB_Propiedades_Color.Text);
                    }

                    if (!string.IsNullOrEmpty(TB_Propiedades_Nombre.Text))
                    {
                        selectedPictureBox.Name = TB_Propiedades_Nombre.Text;
                    }

                    // Obtén la ruta de la carpeta raíz del proyecto
                    string proyectoRaiz = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);

                    // Concatena el nombre de tu imagen a la ruta de la carpeta raíz
                    string imagePath = System.IO.Path.Combine(proyectoRaiz, "src/Circulo.png");

                    // Cargar la imagen original
                    Image originalImage = Image.FromFile(imagePath);

                    // Crear una nueva imagen con el texto centrado
                    Bitmap imageWithText = new Bitmap(originalImage);

                    using (Graphics g = Graphics.FromImage(imageWithText))
                    {
                        // Dibujar la imagen original
                        g.DrawImage(originalImage, new Rectangle(0, 0, imageWithText.Width, imageWithText.Height));

                        // Configurar la fuente y el formato del texto
                        Font font = new Font("Console", 100, FontStyle.Bold);
                        string text = TB_Propiedades_Nombre.Text;
                        SizeF textSize = g.MeasureString(text, font);
                        Point textLocation = new Point((imageWithText.Width - (int)textSize.Width) / 2, (imageWithText.Height - (int)textSize.Height) / 2);

                        // Dibujar el texto centrado
                        g.DrawString(text, font, Brushes.Black, textLocation);
                    }

                    // Mostrar la nueva imagen en el PictureBox
                    selectedPictureBox.Image = imageWithText;
                }
                catch
                {
                    MessageBox.Show("Error en los valores de Propiedades");
                }
                selectedPictureBox = null;
                // Limpia los controles de la tabla de propiedades
                LimpiarPropiedades();
            }
        }
        private void LimpiarPropiedades()
        {
            TB_Propiedades_Nombre.Text = string.Empty;
            CB_Propiedades_Color.Text = string.Empty;
            TB_Propiedades_Radio.Text = string.Empty;
            BT_Propiedades_Guardar.Enabled = false;

            TB_Propiedades_Nombre.Enabled = false;
            CB_Propiedades_Color.Enabled = false;
            TB_Propiedades_Nombre.Enabled = false;
        }
    }
}
