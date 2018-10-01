using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace arbolDecisionOrdenado
{
    //AUTORS:
    //ANGEL GAMBOA CRUZ
    //JASON BARRANTES RODRIGUEZ
    public class ArbolDecision
    {
        //variable inservible
        static int e = 0; //lineas ejecutadas, al final no era esto sino la suma de asignaciones y comparaciones
        //variable inservible

        
        static int a = 0;//asignaciones
        static int c = 0;//comparaciones
        static int n = 50; // tamano del arreglo

        static void Main(string[] args)
        {
            ArbolDecision abo = new ArbolDecision();

            //Arreglo Ordenado
            Console.WriteLine("");
            Console.WriteLine("LISTA ORDENADA");
            LlenarArregloOrdenado(n); // rellena arreglo ordenado

            abo.Insertar(lista); //inserta la lista en el arbol binario 
            Console.WriteLine("ARBOL DE DECISIONES: ");
            abo.ImprimirEntre(); //muestra los valores ubicados en el arbol binario ordenados
            Console.WriteLine("asignaciones: " + a);
            Console.WriteLine("comparaciones: " + c);
            Console.WriteLine("lineas ejecutadas: " + e);
            a = 0;
            c = 0;
            e = 0;

            //Arreglo Inverso
            raiz = null;
            Console.WriteLine("");
            Console.WriteLine("LISTA INVERSA");
            LlenarArregloInverso(n);// rellena arreglo inverso

            abo.Insertar(lista); //inserta la lista en el arbol binario 
            Console.WriteLine("ARBOL DE DECISIONES: ");
            abo.ImprimirEntre(); //muestra los valores ubicados en el arbol binario ordenados
            Console.WriteLine("asignaciones: " + a);
            Console.WriteLine("comparaciones: " + c);
            Console.WriteLine("lineas ejecutadas: " + e);
            a = 0;
            c = 0;
            e = 0;

            //Arreglo aleatorio
            raiz = null;
            Console.WriteLine("");
            Console.WriteLine("LISTA ALEATORIA");
            LlenarArregloAleatorio(n); // rellena arreglo aleatorio

            abo.Insertar(lista);//inserta la lista en el arbol binario 
            Console.WriteLine("ARBOL DE DECISIONES: ");
            abo.ImprimirEntre(); //muestra los valores ubicados en el arbol binario ordenados
            Console.WriteLine("asignaciones: " + a);
            Console.WriteLine("comparaciones: " + c);
            Console.WriteLine("lineas ejecutadas: " + e);
            a = 0;
            c = 0;
            e = 0;

            Console.ReadKey();
        }
        

        public static int[] lista = new int[n];
        class Nodo
        {

            public int numero;
            public Nodo izq, der;
        }
        static Nodo raiz;

        public ArbolDecision()
        {
            raiz = null;
        }



        static void LlenarArregloInverso(int n)
        {

            for (int i = 0; i < n; i++)
                lista[i] = n - i;

        }

        static void LlenarArregloOrdenado(int n)
        {

            for (int i = 0; i < n; i++){ 
                lista[i] = i;
        }

        }
        static void LlenarArregloAleatorio(int n)
        {
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
                lista[i] = rnd.Next(0, n);
        }
        

        public void Insertar(int[] lista) //inserta los valores de la lista en el arbol binario
        {
            var tiempo = Stopwatch.StartNew();   // empieza el tiempo de ejecucion

            a++;
            
            for (int i = 0; i < lista.Length; i++)// sirve para darle cada valor de la lista al arbol
            {e++;

                a++;
                c++;

                
                int numero = lista[i];e++;
                a++;
           
                Nodo nuevo;
                nuevo = new Nodo(); //inicializa el nodo
                nuevo.numero = numero; a++;
                nuevo.izq = null; a++;
                nuevo.der = null; a++;
                e += 4;
                
                if (raiz == null) //insertar el primer valor en la raiz
                {e++;
                    c++;
                    a++;
                    raiz = nuevo;e++;
                }
                else // inserta el resto
                {e++;
                    c++;
                    Nodo anterior = null, reco; a++;e++;
                    reco = raiz; a++;e++;
                    while (reco != null) 
                    {e++;
                        c++;
                        anterior = reco; a++;e++;
                        if (numero < reco.numero) 
                        {e++;
                            c++;
                            reco = reco.izq; a++;e++;
                        }
                        else
                        {e++;
                            c++;
                            reco = reco.der; a++;e++;
                        }
                    }
                    c++;
                    if (numero < anterior.numero) //si es mejor se va a la izquierda
                    {e++;
                        c++;
                        anterior.izq = nuevo; a++;e++;
                    }
                    else //si es mayor se va a la derecha
                    {e++;
                        c++;
                        anterior.der = nuevo; a++;e++;
                    }
                }
                
            }
            c++;
            Console.WriteLine("Tiempo: " + tiempo.Elapsed.TotalMilliseconds); // muestra el tiempo de ejecucion
        }


  
        private void ImprimirEntre(Nodo reco) // muestra los valores en orden
        {
            if (reco != null)
            {
                ImprimirEntre(reco.izq);
                Console.Write(reco.numero + " ");
                ImprimirEntre(reco.der);
            }
        }

        public void ImprimirEntre()
        {
            ImprimirEntre(raiz);
            Console.WriteLine();
        }

        


        private void Insertar(List<int> list)
        {
            throw new NotImplementedException();
        }
    }
}

