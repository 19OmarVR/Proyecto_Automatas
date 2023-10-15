using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Automatas
{
    public class Nodo
    {
        //Atributos
        private Point coordenada;
        private string nombre;
        public const int radio = 40; // Radio del círculo
        private Rectangle rect;
        private Color c;

        //Metodos

        public Nodo(Point coordenada)
        {
            this.coordenada = coordenada;
            nombre = "q0";
            rect = new Rectangle(coordenada.X - radio, coordenada.Y - radio, 2 * radio, 2 * radio);
        }

        //Metodos get
        public Rectangle Rect{ get {return rect;} }
        public Point Coordenada { get { return coordenada; } }
        public Color Color { set { c = value; } }

        public void Dibujar(Graphics g)//Dibuja un nodo en la pizarra
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Black, 3);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            g.DrawEllipse(pen, rect);
            g.FillEllipse(new SolidBrush(c), rect);
        }

        public void Mover(int x, int y)//Da la nueva coordenada del nodo que se movio
        {
            coordenada.X = x;
            coordenada.Y = y;
            rect.X = coordenada.X - radio;
            rect.Y = coordenada.Y - radio;
        }

        public bool EstaDentro(int x, int y)//Revisa si existe un nodo en donde se hizo el click
        {
            return Math.Pow(x - coordenada.X, 2) + Math.Pow(y - coordenada.Y, 2) <= Math.Pow(radio, 2);
        }

        public Arista Conectar(Nodo otroNodo, string valor)
        {
            // Crea una arista que conecta este nodo con otro nodo
            return new Arista(this, otroNodo, valor);
        }
    }
}
