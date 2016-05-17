using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_Vida
{
    /*Integrantes:
        Antunes Mancera Emmanuel - No.Control: 15211267
        Juarez Salas Angel Alberto - No.Control: 15211309
    */
    public partial class Juego_Vida : Form
    {
        Tablero t;
        int Turno = 0;        
        public Juego_Vida()
        {
            InitializeComponent();
            t = new Tablero(10);
            
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //Condicional Creada para hacer el conteo del turno en el juego y cambiar el estado del tablero.
            if (Turno > 0)
            {
                t.next();
                t.update();
                this.Invalidate();
                
                Turno++;
                this.Text = "JV Turno " + Turno;
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Dibuja el tablero.
            t.Dibuja(this);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Condicional creada para reiniciar el juego.
            if ((int)e.KeyCode == (int)Keys.R)
            {
                Application.Restart();
                
            }
        }
        //Evento creado para asignar el valor maximo y minimo de las celdas del tablero.
        private void Tamaño_Celdas_ValueChanged(object sender, EventArgs e)
        {
                Tamaño_Celdas.Maximum = 20;
                Tamaño_Celdas.Minimum = 5;
            
        }
        //Evento creado para elegir la medida de las celdas del tablero.
        private void Elegir_Medida_Click(object sender, EventArgs e)
        {
            int TC = (int)Tamaño_Celdas.Value;
            Celda tc = new Celda(TC);
            MSJ_1.Visible = false;
            Elegir_Medida.Visible = false;
            Tamaño_Celdas.Visible = false;
            Tamaño_Celdas.Enabled = false;
            Turno++;
            this.Text = "JV Turno " + Turno;
            
        }
    }
    
}
