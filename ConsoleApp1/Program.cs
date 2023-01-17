using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionearray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dichiarazione dell'array
            int[] arr = new int[5];
            //numero elementi utilizzati
            int f = 0;
            int dim = 0;
            int scelta = 0;

            //stuttura menù
            do
            {
                //stampa delle opzioni
                Console.Clear();
                Console.WriteLine("1 - aggiungi elemento");
                Console.WriteLine("2 - stampa elementi caricati");
                Console.WriteLine("3 - Cerca elemento nell'array");
                Console.WriteLine("4 - Inserire elemento da eliminare dall'array");
                Console.WriteLine("5 - Inserimento elemento nell'array");
                Console.WriteLine("0 - uscita");
                //scelta dell'opzione
                Console.WriteLine("inserisci la scelta ");
                scelta = int.Parse(Console.ReadLine());
                //esecuzione dell'opzione
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("inserisci l'elemento ");
                        int ele = int.Parse(Console.ReadLine());
                        if (AddArray(arr, ele, ref dim) == true)
                        {
                            Console.WriteLine("elemnto inserito correttamente");
                        }
                        else
                        {
                            Console.WriteLine("array pieno");
                        }
                        break;

                    case 2:
                        for (int i = 0; i < dim; i++)
                        {
                            Console.WriteLine(arr[i]);
                        }

                        break;

                    case 3:
                            Console.WriteLine("Inserisci elemento da cercare ");
                        int l = int.Parse(Console.ReadLine());
                        if (Findarray(arr,l,f) == true)
                        {
                            Console.WriteLine("Il numero inserito è presente nell'array, la sua posizione nell array è " + f);
                        }
                        else
                        {
                            Console.WriteLine("-1 ");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Inserire elemento da eliminare ");
                        int c = int.Parse(Console.ReadLine());
                        if (Deletearray(arr,c) == true)
                        {
                            Console.WriteLine("Valore eliminato dall'array ");
                        }
                        else
                        {
                            Console.WriteLine("Il valore non può essere eliminato in quanto non è contenuto nell'array ");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Inserire elemento da aggiungere all'array ");
                        int s = int.Parse(Console.ReadLine());
                        Console.WriteLine("Inserire posizione dell'elemento ");
                        int m = int.Parse(Console.ReadLine());
                        if (Enterarray(arr, s, m) == true)
                        {
                            Console.WriteLine("Elemento sostituito correttamente ");
                        }
                        break;



                }
                Console.ReadLine();
            } while (scelta != 0);


        }
        static bool AddArray(int[] a, int e, ref int index)
        {
            //controllare se abbiamo raggiunto la dimensione massima
            bool inserito = true;
            if (index < a.Length)
            {
                //aggiungere l'elemento
                a[index] = e;
                //incrementare l'indice
                index++;
            }
            else
            {
                inserito = false;
            }

            return inserito;
        }
         
        static bool Findarray(int[] a,int l,int f)
        {

                bool cercato = true;
            //Confronto l'elemento inserito dall'utente con gli elementi contenuti nell'array
            for (int i = 0; i < a.Length; i++)

                //Confronto con ciascun elemento
                if (l == a[i])
                {
                    f = i;
                    return cercato;
                }
                else
                {
                    cercato = false;
                }
                return cercato;
        }

        static bool Deletearray(int[] a, int c)
        {
            bool cercato = true;
            //Confronto l'elemento inserito dall'utente con gli elementi contenuti nell'array
            for (int i = 0; i < a.Length; i++)

                
            if (c == a[i])
                {
                    //Se l'elemento è contenuto nell'array lo vado ad eliminare
                    a[i] = a[i] - c ;
                    return cercato;   
                }
                else
                {
                    cercato = false;
                }
            return cercato;
        }


        static bool Enterarray(int[] a, int s,int m)
        {
            bool elemento1 = true;
            //Sostituisco il valore nella posizione imessa dall'utente

            a[m] = s;
          
            return elemento1;
        }
    }
}
