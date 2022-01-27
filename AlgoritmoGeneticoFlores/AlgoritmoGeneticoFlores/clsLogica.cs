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
    class clsLogica
    {

        public Flores[] poblacion = new Flores[10];
        private int iPadreA, iPadreB;

        public class Flores {

            // Variables necesarias para la clase
            private int x; // Posicion en el form
            private double adaptacion; //Nivel de adaptacion con la creacion de los 6 cromosomas  con el array cromosoma // 

            public int[] cromosoma = new int[6]; // Creamos el cromosoma de la flor
                                                 // 0-Altura
                                                 // 1-Color de la flor
                                                 // 2-Color del tallo
                                                 // 3-Ancho del tallo
                                                 // 4-Tamaño de la flor
                                                 // 5-Tamaño del centro de la flor
                                                 // Creamos las propiedades
            public int CoordX// propiedad la posicion en el form
            {
                set { x = value; }
                get { return x; }
            }
            public double Adaptacion
            {
                set { adaptacion = value; }
                get { return adaptacion; }
            }


        }
        public void pintarFlores(System.Windows.Forms.PaintEventArgs e)
        {
            // Pintamos un suelo y lo tomamos como base en el lienso del form modificando los valores hasta que quede ajustado
            e.Graphics.FillRectangle(Brushes.DarkGreen, 0, 455, 810, 50);
            // creacion de las flores  para que se muestren en la pantalla
            for (int n = 0; n < 10; n++)
            {
                //creamos el tallo pintandolo con los valores aleatorios iniciales de la funcion Aleatoriedadini()
                if (poblacion[n].cromosoma[2] == 0)
                    e.Graphics.FillRectangle(Brushes.DarkGreen,
                     poblacion[n].CoordX, 455 - poblacion[n].cromosoma[0],
                     poblacion[n].cromosoma[3], poblacion[n].cromosoma[0]);
                else if (poblacion[n].cromosoma[2] == 1)
                    e.Graphics.FillRectangle(Brushes.Green,
                     poblacion[n].CoordX, 455 - poblacion[n].cromosoma[0],
                     poblacion[n].cromosoma[3], poblacion[n].cromosoma[0]);
                else if (poblacion[n].cromosoma[2] == 2)
                    e.Graphics.FillRectangle(Brushes.LightGreen,
                     poblacion[n].CoordX, 455 - poblacion[n].cromosoma[0],
                     poblacion[n].cromosoma[3], poblacion[n].cromosoma[0]);


                // se pinta la flor igualmente con los valores aleatorios de la funcion aleatoriedadini() 
                Color cflor = new Color();
                if (poblacion[n].cromosoma[1] == 0)
                    cflor = Color.Red;
                else if (poblacion[n].cromosoma[1] == 1)
                    cflor = Color.Blue;
                else if (poblacion[n].cromosoma[1] == 2)
                    cflor = Color.Yellow;

                e.Graphics.FillEllipse(new SolidBrush(cflor),
                 poblacion[n].CoordX + poblacion[n].cromosoma[3] / 2 - poblacion[n].cromosoma[4] / 2,
                 455 - poblacion[n].cromosoma[0] - poblacion[n].cromosoma[4] / 2,
                 poblacion[n].cromosoma[4], poblacion[n].cromosoma[4]);

                //se pinta el centro de la flor
                e.Graphics.FillEllipse(Brushes.DarkOrange,
                 poblacion[n].CoordX + poblacion[n].cromosoma[3] / 2 - poblacion[n].cromosoma[5] / 2,
                 455 - poblacion[n].cromosoma[0] - poblacion[n].cromosoma[5] / 2,
                 poblacion[n].cromosoma[5], poblacion[n].cromosoma[5]);
            }
        

    }

        public void AleatoriedadIni()
        {
            //VALORES ALEATORIOS PARA LAS FLORES QUE SE VAN A DIBUJAR Y SU CROSSOVER INICIAL
            Random random = new Random(unchecked((int)DateTime.Now.Ticks));
            for (int n = 0; n < 10; n++)
            {
                Flores temp = new Flores();
                poblacion[n] = temp;
                poblacion[n].CoordX = n * 80 + 40;

                // Inicializamos el cromosoma con valores al azar

                // La altura va de 10 a 300
                poblacion[n].cromosoma[0] = random.Next(10, 300);

                // El color de la flor. 0-rojo, 1-azul, 2-amarillo
                poblacion[n].cromosoma[1] = random.Next(0, 3);

                // El color del tallo. Diferentes tonos de verde
                poblacion[n].cromosoma[2] = random.Next(0, 3);

                // El ancho del tallo. De 5 a 15
                poblacion[n].cromosoma[3] = random.Next(5, 15);

                // El tamano de la flor. De 20 a 80
                poblacion[n].cromosoma[4] = random.Next(20, 80);

                // El tamano del centro de la flor. De 5 a 15
                poblacion[n].cromosoma[5] = random.Next(5, 15);
            }
        }

       public void CalculaAdaptacion(RadioButton rbBajo, RadioButton rbMedio, RadioButton rbAlto,
            RadioButton rbRojo, RadioButton rbAzul, RadioButton rbAmarillo,
            RadioButton rbPequeno, RadioButton rbNormal, RadioButton rbGrande)
        {
            // Variables para las opciones del usuario con los radio buttons
            int altura, color, tamano;
            altura = color = tamano = 0;

            // Variables necesarias para el calculo
            double Aaltura, Acolor, Atamano;
            Aaltura = Acolor = Atamano = 0.0;

            // Obtnemos la altura deseada por el usuario
            if (rbBajo.Checked == true)
                altura = 0;
            else if (rbMedio.Checked == true)
                altura = 1;
            else if (rbAlto.Checked == true)
                altura = 2;

            // Obtenemos el color deseado por el usuario
            if (rbRojo.Checked == true)
                color = 0;
            else if (rbAzul.Checked == true)
                color = 1;
            else if (rbAmarillo.Checked == true)
                color = 2;

            // Obtenemos el tamaño de la flor deseado por el usuario
            if (rbPequeno.Checked == true)
                tamano = 0;
            else if (rbNormal.Checked == true)
                tamano = 1;
            else if (rbGrande.Checked == true)
                tamano = 2;

            // Recorremos toda la población para encontrar su adaptación
            for (int n = 0; n < 10; n++)
            {
                // Vemos el calculo de adaptación para la altura
                if (altura == 0) // rango 10 a 100
                    Aaltura = poblacion[n].cromosoma[0] / 100;
                else if (altura == 1) // rango 100 a 200
                    Aaltura = poblacion[n].cromosoma[0] / 200;
                else if (altura == 2) // rango 200 a 300
                    Aaltura = poblacion[n].cromosoma[0] / 300;

                if (Aaltura > 1.0)
                    Aaltura = 1 / Aaltura;

                // Checamos el nivel de adaptación del color
                if (color == poblacion[n].cromosoma[1])
                    Acolor = 1.0;
                else
                    Acolor = 0.0;

                // Checamos el nivel de adaptación del tamaño de la flor
                if (tamano == 0) // rango 20 a 40
                    Atamano = poblacion[n].cromosoma[4] / 40;
                else if (tamano == 1) // rango 40 a 60
                    Atamano = poblacion[n].cromosoma[4] / 60;
                else if (tamano == 2) // rango 60 a 80
                    Atamano = poblacion[n].cromosoma[4] / 80;

                if (Atamano > 1.0)
                    Atamano = 1 / Atamano;

                // Calculamos el valor final de adaptación
                poblacion[n].Adaptacion = (Aaltura + Acolor + Atamano) / 3.0;

            }



        }

        public void SeleccionaPadres()
        {
            // Seleccionamos los dos mejores
            iPadreA = iPadreB = 0;
            // Encontramos el padre A
            for (int n = 0; n < 10; n++)
            {
                Console.WriteLine(poblacion[n].Adaptacion);
                if (poblacion[n].Adaptacion > poblacion[iPadreA].Adaptacion)
                    iPadreA = n;
            }
            // Encontramos el padre B
            for (int n = 0; n < 10; n++)
            {
                Console.WriteLine(poblacion[n].Adaptacion);
                if (poblacion[n].Adaptacion > poblacion[iPadreB].Adaptacion && iPadreA != n)
                    iPadreB = n;
            }

        }

        public void Crossover()
        {
            // Llevamos a cabo el cross over

            // Copiamos los padres, ya que todo el arreglo sera
            // llenado nuevamente con hijos
            Flores PadreA = new Flores();
            Flores PadreB = new Flores();
            // Copiamos los padres
            for (int n = 0; n < 6; n++)
            {
                PadreA.cromosoma[n] = poblacion[iPadreA].cromosoma[n];
                PadreB.cromosoma[n] = poblacion[iPadreB].cromosoma[n];

            }

            // Creamos la siguiente generacion

            Random random = new Random(unchecked((int)DateTime.Now.Ticks));


            for (int n = 0; n < 10; n++)
            {

                int desde = random.Next(0, 5);
                int hasta = random.Next(desde, 6);

                for (int c = desde; c < hasta; c++)
                {
                    // Si el random es 0, se copia el gen de PadreA
                    // si el random es 1, se copia el gen de PadreB
                    if (random.Next(0, 2) == 0)
                        poblacion[n].cromosoma[c] = PadreA.cromosoma[c];
                    else
                        poblacion[n].cromosoma[c] = PadreB.cromosoma[c];

                    // incluimos la mutacion
                    if (random.Next(0, 100) <= 5)
                    {

                        if (c == 0)
                            poblacion[n].cromosoma[0] = random.Next(10, 300);

                        if (c == 1)
                            poblacion[n].cromosoma[1] = random.Next(0, 3);

                        if (c == 2)
                            poblacion[n].cromosoma[2] = random.Next(0, 3);

                        if (c == 3)
                            poblacion[n].cromosoma[3] = random.Next(5, 15);

                        if (c == 4)
                            poblacion[n].cromosoma[4] = random.Next(20, 80);

                        if (c == 5)
                            poblacion[n].cromosoma[5] = random.Next(5, 15);

                    }

                }
            }
        }

    }
}
