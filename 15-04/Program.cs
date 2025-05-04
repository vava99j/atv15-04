using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] fila = new string[10];
            int fimfila = 0;
       

            do
            {
                Console.WriteLine("1-cadastrar cliente");
                Console.WriteLine("2-listar fila");
                Console.WriteLine("3-cadastrar c. prioritario");
                Console.WriteLine("4-atender cliente");
                Console.WriteLine("q-sair");
              
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
    Console.WriteLine("-cadastrar cliente-");
                        Console.WriteLine("");
                      
                        if ( fimfila < 10)
                        {
                            Console.WriteLine("nome do cliente");
                      string nome = Console.ReadLine();
                            fila[fimfila++] = nome;
                        }
                        else
                        {
                            Console.WriteLine("fila cheia , retorne outra hora");
                        }
                        break;
                      
                    
                    
                    case"2":
                        Console.WriteLine("-listando fila-");
                        for (int i = 0; i < fimfila ;i++) {
                         
                            Console.WriteLine($"{ fila[i]}");
                        }
                            break;



                        case "3":
                         Console.WriteLine("-cadastrar c. prioritario-");
                        Console.WriteLine("");

                        if (fimfila <= 10)
                        {

                         
                            for (int i = fimfila; i > 0; i--)
                            {
                                fila[i] = fila[i - 1];
                            }
                            
                            Console.WriteLine("nome do cliente");
                            string nome = Console.ReadLine();
                            fila[0] = nome;
                            fimfila++;
                        }
                        else
                        {
                           
                            for (int i = fimfila; i > 0 ; i--)
                            {
                                fila[i] = fila[i - 1];
                            }
                           
                            fila[fimfila - 1] = null;
                            Console.WriteLine("nome do cliente");
                            string nome = Console.ReadLine();
                            fila[0] = nome;
                            fimfila++;
                        }
                            break;
                        
                    
                    
                    case"4":


                        for (int i = 0; i <= fimfila - 1; i++)
                        {
                         
                            fila[i] = fila[i + 1];
                        }
                        fimfila--;
                   

                        Console.WriteLine($"ateder cliente {fila[0]}");
                        break;
                }
            } while (input !="q");





        }
    }
}
