using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Juego_Vida
{
    class Celda
    {
        //Declaracion de variables utilizadas. 
        public enum Estado {viva, muerta };
        int x,y;
        public Estado estado_actual;
        public Estado estado_siguiente;
        static int lado;
        //Funcion publica creada para asignar el estado a las celdas.
        public Celda(int x, int y, Random r)
        {
            double d =  r.NextDouble();
            if (d < .80)
                estado_actual = Estado.muerta;
            else
                estado_actual = Estado.viva;

            this.x = x; this.y = y;
        }
        //Funcion publica creada para igualar el valor asignado a una variable del objeto Value Changed a una variable local.
        public Celda(int TC)
        {
            lado = TC;
        }
        //Funcion que dibuja el estado viva de las Celulas.
        public void Dibuja(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawRectangle(new Pen(Color.Black, 1), x, y, lado,lado);
            if (estado_actual == Estado.viva)
                g.FillRectangle(new SolidBrush(Color.Black),x,y,lado,lado);
            
        }
        //Funcion que actualiza el estado de las celdas.
        public void update()
        {
            estado_actual = estado_siguiente;
        }
    }
    //Clase utilizada para generar el Tablero.
    class Tablero
    {
        List<List<Celda>> tablero;
        int tamaño;
        Random r = new Random();
        public Tablero (int tamaño)
        {
            tablero = new List<List<Celda>>();
            this.tamaño = tamaño;
            for(int i=0; i < tamaño; i++)
            {
                List<Celda> temp = new List<Celda>();
                for (int j = 0; j < tamaño; j++)
                {
                    temp.Add(new Celda(20+i*20,20+j*20, r));
                }
                tablero.Add(temp);

            }

        }
        //Clase que dibuja el tablero.
        public void Dibuja(Form f)
        {

            for (int i = 0; i < tamaño; i++)
                for (int j = 0; j < tamaño; j++)
                {
                    tablero[i][j].Dibuja(f);
                }
        }
        //Funcion que dibuja el estado siguiente del tablero.
        public void next()
        {
            for (int i = 0; i < tamaño; i++)
                for (int j = 0; j < tamaño; j++)
                {
                    int vecinas = cuantas_vecinas_vivas(i,j);
                    // Cualquier célula viva con menos de dos vecinos vivos muere.
                    if (vecinas < 2)
                        tablero[i][j].estado_siguiente = Celda.Estado.muerta;
                    //Cualquier Celula Viva.
                    if ( tablero[i][j].estado_actual == Celda.Estado.viva)
                    {
                       // Con 2 o 3 vecinos vivos.
                        if (vecinas == 2 || vecinas == 3)
                        {
                            
                        }
                        // con mas de tres vecinos muertos. 
                        else if (vecinas > 3)
                        {
                            tablero[i][j].estado_siguiente = Celda.Estado.muerta;
                        }     
                       
                    }
                    //Cualquier celula muerta con exactamente tres vecinos vivos se convierte en una celula viva.
                    else
                    {
                        if(vecinas == 3)
                        {
                            tablero[i][j].estado_siguiente = Celda.Estado.viva;

                        }
                    }
                       
                }

        }
        //Funcion que actualiza el tablero.
        public void update()
        {
            for (int i = 0; i < tamaño; i++)
                for (int j = 0; j < tamaño; j++)
                    tablero[i][j].update();
        }


        int cuantas_vecinas_vivas(int i, int j)
        {
            int vivas = 0;
            //NorOeste
            if (i > 0 && j > 0 && tablero[i - 1][j - 1].estado_actual == Celda.Estado.viva)
                vivas++;
            //Norte
            if (i > 0  && tablero[i - 1][j].estado_actual == Celda.Estado.viva)
                vivas++;
            //NorEste
            if (i > 0 && j < tamaño-1 && tablero[i-1][j+1].estado_actual == Celda.Estado.viva)
                vivas++;
            //Oeste
            if ( j > 0 && tablero[i][j - 1].estado_actual == Celda.Estado.viva)
                vivas++;
            //Este
            if (j < tamaño - 1 && tablero[i][j + 1].estado_actual == Celda.Estado.viva)
                vivas++;
            //SurOeste
            if (i < tamaño-1 && j > 0 && tablero[i + 1][j - 1].estado_actual == Celda.Estado.viva)
                vivas++;
            //Sur
            if (i < tamaño - 1 && tablero[i + 1][j].estado_actual == Celda.Estado.viva)
                vivas++;
            //SurEste
            if (i < tamaño - 1 && j < tamaño - 1 && tablero[i + 1][j + 1].estado_actual == Celda.Estado.viva)
                vivas++;
            
            return vivas;

        }
    }
}
