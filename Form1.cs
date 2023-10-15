using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

namespace Proyecto_Automatas
{
    public partial class Form1 : Form
    {
        //Atributos
        private int estado = 1;
        /*  Estado:
            1.- Seleccionar
            2.- Agregar
            3.-
         */
        private List<Nodo> ListaNodos = new List<Nodo>();
        private List<Arista> ListaAristas = new List<Arista>();
        private bool arrastrando = false;
        private bool Elegido = false;
        private Nodo nodo = new Nodo(new Point(0, 0));
        private int cont = 1;

        //Metodos

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;//Abre la pantalla completa al inicializar la aplicacion
        }

        //----------------------------------------------------------- Botones del editor --------------------------------------------------------------------
        private void Editor_Seleccionar_Click(object sender, EventArgs e)
        {
            estado = 1;
            Editor_Seleccionar.BackColor = Color.SkyBlue;
            Editor_Agregar.BackColor = Color.Transparent;
            Editor_Eliminar.BackColor = Color.Transparent;
            Editor_Conectar.BackColor = Color.Transparent;
        }

        private void Editor_Agregar_Click(object sender, EventArgs e)
        {
            estado = 2;
            Editor_Seleccionar.BackColor = Color.Transparent;
            Editor_Agregar.BackColor = Color.SkyBlue;
            Editor_Eliminar.BackColor = Color.Transparent;
            Editor_Conectar.BackColor = Color.Transparent;
        }

        private void Editor_Eliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            Editor_Seleccionar.BackColor = Color.Transparent;
            Editor_Agregar.BackColor = Color.Transparent;
            Editor_Eliminar.BackColor = Color.SkyBlue;
            Editor_Conectar.BackColor = Color.Transparent;
        }

        private void Editor_Conectar_Click(object sender, EventArgs e)
        {
            estado = 4;
            Editor_Seleccionar.BackColor = Color.Transparent;
            Editor_Agregar.BackColor = Color.Transparent;
            Editor_Eliminar.BackColor = Color.Transparent;
            Editor_Conectar.BackColor = Color.SkyBlue;
        }

        //----------------------------------------------------------- Dibujo del automata --------------------------------------------------------------------

        private void Pizarra_MouseClick(object sender, MouseEventArgs e)
        {
            switch (estado)
            {
                case 2:
                    //Agrega un Nodo
                    nodo = new Nodo(e.Location);
                    ListaNodos.Add(nodo);
                    nodo.Color = Color.Gold;
                    nodo.Dibujar(Pizarra.CreateGraphics());
                    break;
                case 3:
                    //Elimina un nodo
                    foreach (Nodo n in ListaNodos)
                    {
                        if (n.EstaDentro(e.X, e.Y))
                        {
                            Rectangle r = new Rectangle(n.Rect.X - 4, n.Rect.Y - 4, 2 * Nodo.radio + 8, 2 * Nodo.radio + 8);
                            Pizarra.Invalidate(r);
                            ListaNodos.Remove(n);
                            break;
                        }
                    }
                    break;
            }
        }

        private void Pizarra_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Arista a in ListaAristas)
            {
                a.Dibujar(g);
            }

            foreach (Nodo n in ListaNodos)
            {
                n.Dibujar(g);
            }
        }

        private void Pizarra_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (estado == 1 || estado == 4)
                {
                    // Verificar si el clic está dentro del nodo
                    foreach (Nodo n in ListaNodos)
                    {
                        if (n.EstaDentro(e.X, e.Y))
                        {
                            if(estado == 1)
                            {
                                nodo = n;
                                nodo.Color = Color.DeepSkyBlue;
                                arrastrando = true;
                            }
                            else if(Elegido == false)
                            {
                                nodo = n;
                                Elegido = true;
                                n.Color = Color.DeepSkyBlue;
                            }
                            else
                            {
                                string valor = Interaction.InputBox("Ingrese el valor para la arista:", "Valor de la arista", "");//Pregunta por valor de la arista
                                ListaAristas.Add(nodo.Conectar(n, valor));
                                ListaAristas[ListaAristas.Count - 1].Dibujar(Pizarra.CreateGraphics());
                                Elegido = false;
                                nodo.Color = Color.Gold;
                            }
                            Pizarra.Invalidate();
                            break;
                        }
                    }
                }
            }
            else if(e.Button == MouseButtons.Right)
            {

            }
        }

        private void Pizarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastrando)
            {
                // Mover el nodo con el cursor del mouse
                Rectangle rec = new Rectangle(nodo.Rect.X - Nodo.radio - 50, nodo.Rect.Y - Nodo.radio - 50, Nodo.radio * 5, Nodo.radio * 5);
                nodo.Mover(e.X, e.Y);

                Pizarra.Invalidate();
            }
        }

        private void Pizarra_MouseUp(object sender, MouseEventArgs e)
        {
            if(estado == 1)
            {
                nodo.Color = Color.Gold;
                nodo.Dibujar(Pizarra.CreateGraphics());
                arrastrando = false;
            }
            
        }
    }
}