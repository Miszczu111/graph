using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_grafy
{
    public partial class Form1 : Form
    {
        int[,] tab;
        int n, f;
        Dictionary<int, int[]> dict = new Dictionary<int, int[]>();

        public Form1()
        {
            InitializeComponent();
        }

        private void czytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            
            StreamReader sr = new StreamReader(of.FileName);
                     
            string line;
            int k = 0;
            tab = new int[6, 6];
            //tab = new int[sr.ReadLine().Length/2 + 1, sr.ReadLine().Length/2 + 1];
            while ((line = sr.ReadLine()) != null)
            {
                string[] s = line.Split(new string[] { " " },
                    StringSplitOptions.RemoveEmptyEntries);                
                for (int i = 0; i < s.Length; i++)
                {                    
                    tab[k,i] = Convert.ToInt32(s[i]);
                }
                k++;
            }

            //Wyświetlenie
            for (int i = 0; i < tab.GetLength(1); i++)
            {
                for (int j = 0; j < tab.GetLength(0); j++)
                {
                    txtList.Text += tab[i, j] + " ";
                }
                txtList.Text += "\r\n";
            }
        }

        private void grafToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            rysowanie(380,150, 0);
        }

        private void rysowanie(int xi, int yi, int coRysujemy)
        {
            n = tab.GetLength(0);

            dict.Clear();

            double alfa = 360 / n; //kat pomiedzy rozmieszczonymi na okregu wierzchołkami

            Image wierzcholek = Image.FromFile(@".\punkt.png"); //obrazek wierzchołka

            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.DarkRed, 3); //do pisania stopni wierzchołków            
            int key = 0;

            Font myFont = new Font("Arial", 11); // czcionka do opisywania wierzchołków

            for (int i = 0; i < n; i++) //pętla przechodząca po wszystkich wierzchołkach
            {
                double kat = alfa * (i + 1); //aktualny kąt (potrzebne do rysowania)

                double x = xi + 100 * Math.Cos(2 * Math.PI * i / n); //oblicznie współrzędnych wierzchołka
                double y = yi + 100 * Math.Sin(2 * Math.PI * i / n);

                //double x = 560 + 200 * Math.Cos(2 * Math.PI * i / n); //oblicznie współrzędnych wierzchołka
                //double y = 250 + 200 * Math.Sin(2 * Math.PI * i / n);

                int xk = Convert.ToInt32(x); //konwersja (potrzebna do funkcji rysowania)
                int yk = Convert.ToInt32(y);

                int[] wsp = new int[2]; //tablica przechowująca pare współrzędnych danego wierzchołka
                wsp[0] = xk;
                wsp[1] = yk;

                dict.Add(key, wsp); //dodanie wierzchołka z jego współrzędnymi do dictionary
                key++; //inkrementacja klucza dictionary
                int stopien = 0; //zmienna do przechowania stopnia aktualnego wierzchołka w pętli

                graphicsObj.DrawImage(wierzcholek, xk, yk); // rysowanie wierzchołków

                //obliczanie stopnia aktualnego wierzchołka
                for (int j = 0; j < n; j++)
                {
                    stopien += tab[i, j];
                }

                //Opisywanie stopnia każdego wierzchołka
                //if ((yk <250) && (xk < 560))
                //    graphicsObj.DrawString(stopien.ToString(), myFont, Brushes.DarkRed, new PointF(xk - 19, yk - 14));
                //else if ((yk >= 250) && (xk < 560))
                //    graphicsObj.DrawString(stopien.ToString(), myFont, Brushes.DarkRed, new PointF(xk - 19, yk + 14));
                //else if ((yk >= 250) && (xk >= 560))
                //    graphicsObj.DrawString(stopien.ToString(), myFont, Brushes.DarkRed, new PointF(xk + 10, yk + 14));
                //else if ((yk < 250) && (xk >= 560))
                //    graphicsObj.DrawString(stopien.ToString(), myFont, Brushes.DarkRed, new PointF(xk + 10, yk - 14));

                //numerowanie wierzchołków
                if ((yk < 250) && (xk < 560))
                    graphicsObj.DrawString((i + 1).ToString(), myFont, Brushes.DarkRed, new PointF(xk - 19, yk - 14));
                else if ((yk >= 250) && (xk < 560))
                    graphicsObj.DrawString((i + 1).ToString(), myFont, Brushes.DarkRed, new PointF(xk - 19, yk + 14));
                else if ((yk >= 250) && (xk >= 560))
                    graphicsObj.DrawString((i + 1).ToString(), myFont, Brushes.DarkRed, new PointF(xk + 10, yk + 14));
                else if ((yk < 250) && (xk >= 560))
                    graphicsObj.DrawString((i + 1).ToString(), myFont, Brushes.DarkRed, new PointF(xk + 10, yk - 14));
            }

            int Pwspx = 0, Pwspy = 0; //wsp pierwszego wierzchołka 
            int Dwspx = 0, Dwspy = 0; //wsp drugiego wierzchołka  - Pomiedzy nimi rysujemy krawędź
            Pen zielony = new Pen(System.Drawing.Color.Green, 1);
            Pen czarny = new Pen(System.Drawing.Color.Black, 1);
            //petla chodzaca po macierzy krawędzi
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    switch (coRysujemy)
                    {
                        case 0:
                            if (tab[i, j] == 1 && i != j) //jesli natrafiamy na 1 w macierzy to:                    
                                foreach (KeyValuePair<int, int[]> d in dict)
                                {
                                    //pobieramy z dictionary wspolrzedne obu wierzchołków

                                    if (d.Key == i)
                                    {
                                        Pwspx = d.Value[0];
                                        Pwspy = d.Value[1];
                                    }

                                    else if (d.Key == j)
                                    {
                                        Dwspx = d.Value[0];
                                        Dwspy = d.Value[1];
                                    }
                                }
                            
                            graphicsObj.DrawLine(czarny, Pwspx + 6, Pwspy + 6, Dwspx + 6, Dwspy + 6); //rysujemy krawędź pomiędzy wierzchołkami
                            break;

                        case 1:
                            if (tab[i, j] == 0 && i != j) //jesli natrafiamy na 0 w macierzy to:                    
                                foreach (KeyValuePair<int, int[]> d in dict)
                                {
                                    //pobieramy z dictionary wspolrzedne obu wierzchołków

                                    if (d.Key == i)
                                    {
                                        Pwspx = d.Value[0];
                                        Pwspy = d.Value[1];
                                    }

                                    else if (d.Key == j)
                                    {
                                        Dwspx = d.Value[0];
                                        Dwspy = d.Value[1];
                                    }
                                }
                            
                            graphicsObj.DrawLine(zielony, Pwspx + 6, Pwspy + 6, Dwspx + 6, Dwspy + 6); //rysujemy krawędź pomiędzy wierzchołkami
                            break;
                        default:
                            if (i != j)
                                foreach (KeyValuePair<int, int[]> d in dict)
                                {
                                    //pobieramy z dictionary wspolrzedne obu wierzchołków
                                    if (d.Key == i)
                                    {
                                        Pwspx = d.Value[0];
                                        Pwspy = d.Value[1];
                                    }
                                
                                    else if (d.Key == j)
                                    {
                                        Dwspx = d.Value[0];
                                        Dwspy = d.Value[1];
                                    }
                                }                                
                            if (tab[i,j] == 1)
                                graphicsObj.DrawLine(czarny, Pwspx + 6, Pwspy + 6, Dwspx + 6, Dwspy + 6); //rysujemy krawędź pomiędzy wierzchołkami
                            else
                                graphicsObj.DrawLine(zielony, Pwspx + 6, Pwspy + 6, Dwspx + 6, Dwspy + 6); //rysujemy krawędź pomiędzy wierzchołkami
                            break;
                    }
                }
            }
        }

        private void grafDopełniajacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rysowanie(700, 150, 1);
        }

        private void razemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rysowanie(150, 380, 2);
        }



    }
}
