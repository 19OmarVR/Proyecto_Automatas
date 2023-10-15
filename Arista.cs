using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Automatas
{
    public class Arista
    {
        //Atributos
        private Nodo n1;
        private Nodo n2;
        private string valor;
        private Rectangle rect;

        public Arista(Nodo n1, Nodo n2, string valor)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.valor = valor;
        }
        public void Dibujar(Graphics g)
        {
            // Calcular el ángulo y la posición de la flecha
            double angle = Math.Atan2(n2.Coordenada.Y - n1.Coordenada.Y, n2.Coordenada.X - n1.Coordenada.X);
            int arrowSize = 10;  // Tamaño de la flecha

            // Calcular la posición del final de la flecha
            int endX = (int)(n2.Coordenada.X - arrowSize * Math.Cos(angle));
            int endY = (int)(n2.Coordenada.Y - arrowSize * Math.Sin(angle));

            Pen pen = new Pen(Color.Black, 2);
            if(n1 != n2)
            {
                g.DrawLine(pen, n1.Coordenada.Y, n1.Coordenada.Y, endX, endY);
            }
            else //Se conecta a si mismo
            {
                g.DrawLine(pen, n1.Coordenada.Y, n1.Coordenada.Y, endX, endY);
            }

            // Dibujar la cabeza de flecha
            g.FillPolygon(Brushes.Black, new Point[]
            {
                new Point(endX, endY),
                new Point((int)(endX - arrowSize * Math.Cos(angle - Math.PI / 6)), (int)(endY - arrowSize * Math.Sin(angle - Math.PI / 6))),
                new Point((int)(endX - arrowSize * Math.Cos(angle + Math.PI / 6)), (int)(endY - arrowSize * Math.Sin(angle + Math.PI / 6)))
            });

            // Calcular la posición para mostrar el valor en el medio de la arista
            int centerX = (n1.Coordenada.X + n2.Coordenada.X) / 2;
            int centerY = (n1.Coordenada.Y + n2.Coordenada.Y) / 2;

            // Dibujar el valor en el medio de la arista
            Font font = new Font("Arial", 12, FontStyle.Bold);
            SizeF textSize = g.MeasureString(valor, font);
            g.DrawString(valor, font, Brushes.Black, centerX - textSize.Width / 2, centerY - textSize.Height / 2);
        }
    }
}
