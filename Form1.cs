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
            3.- Eliminar
            4.- Conectar
         */
        private List<Nodo> ListaNodos = new List<Nodo>();
        private List<Arista> ListaAristas = new List<Arista>();
        private bool arrastrando = false;
        private bool Elegido = false;
        private Nodo nodo;

        //Metodos

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;//Abre la pantalla completa al inicializar la aplicacion
            Editor_Seleccionar.BackColor = Color.SkyBlue;
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
            switch (estado)
            {
                case 1:
                    //Seleccionar
                    if (e.Button == MouseButtons.Left)
                    {
                        // Verificar si el clic est� dentro del nodo
                        foreach (Nodo n in ListaNodos)
                        {
                            if (n.EstaDentro(e.X, e.Y))
                            {
                                nodo = n;
                                nodo.Color = Color.DeepSkyBlue;
                                arrastrando = true;
                                Pizarra.Invalidate();
                                break;
                            }
                        }
                    }
                    else if (e.Button == MouseButtons.Right)
                    {

                    }

                    break;
                case 2:
                    //Agrega un Nodo
                    nodo = new Nodo(e.Location);
                    nodo.Color = Color.Gold;
                    ListaNodos.Add(nodo);
                    nodo.Dibujar(Pizarra.CreateGraphics());
                    break;
                case 3:
                    //Elimina un nodo y/o arista
                    foreach (Nodo n in ListaNodos)//Eliminar un nodo al hacer clic
                    {
                        if (n.EstaDentro(e.X, e.Y))
                        {
                            List<Arista> aristasEliminar = ListaAristas.FindAll(a => a.Nodoinicio == n || a.Nodofin == n);//Busca todas las aristas conectadas al nodo
                            foreach (Arista a in aristasEliminar)//Elimina todas las aristas conectadas al nodo
                            {
                                ListaAristas.Remove(a);
                            }
                            ListaNodos.Remove(n);
                            Pizarra.Invalidate();
                            break;
                        }
                    }

                    foreach (Arista a in ListaAristas)//Eliminar una arista al hacer clic
                    {
                        if (a.EstaDentro(new Point(e.X, e.Y)))
                        {
                            ListaAristas.Remove(a);
                            Pizarra.Invalidate();
                            break;
                        }
                    }
                    break;
                case 4:
                    // Verificar si el clic est� dentro del nodo
                    foreach (Nodo n in ListaNodos)
                    {
                        if (n.EstaDentro(e.X, e.Y))
                        {
                            if (Elegido == false)
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
                    break;
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
            //Hola
            if (estado == 1 && arrastrando)
            {
                nodo.Color = Color.Gold;
                nodo.Dibujar(Pizarra.CreateGraphics());
                arrastrando = false;
            }

        }
    }
}