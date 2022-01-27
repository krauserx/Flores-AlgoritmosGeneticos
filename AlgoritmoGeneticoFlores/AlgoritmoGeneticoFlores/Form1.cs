using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoGeneticoFlores
{
   
    public partial class Form1 : Form
    {

        clsLogica funcionamiento = new clsLogica();
        private int generacion = 0;
   
        public Form1()
        {
          
            InitializeComponent();

        //llamamos los valores iniciales para cargar con algo los datos de las flores
        funcionamiento.AleatoriedadIni();   
            
}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // llamamos las funciones adaptacion,seleccionPadres y crossover para aplicar el algoritmo genetico del caso
            funcionamiento.CalculaAdaptacion(rbBajo,  rbMedio, rbAlto,
            rbRojo,  rbAzul, rbAmarillo,
             rbPequeno, rbNormal,rbGrande); 
            
            funcionamiento.SeleccionaPadres();  
           funcionamiento.Crossover();


            generacion++;
            // Redibujamos la ventana
            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            funcionamiento.pintarFlores(e);
            lblGeneracion.Text = "Generacion: " + generacion.ToString();

        }

    //Marco Ugalde Oses
}
}




