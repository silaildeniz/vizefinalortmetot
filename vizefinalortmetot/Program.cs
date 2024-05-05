using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizefinalortmetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
                int vize, final;

                // Get the sila score from the user
                do
                {
                    Console.Write("Vize puanınızı girin ");
                } while (!int.TryParse(Console.ReadLine(), out vize) || vize < 0);

                // Get the alis score from the user
                do
                {
                    Console.Write("Final puanınızı girin ");
                } while (!int.TryParse(Console.ReadLine(), out final) || final < 0);

                // Calculate the average and letter grade using the Calculate method
                double ort = Hesapla(vize, final);
                string harfnotu = "";

                if (ort >= 90)
                {
                    harfnotu = "A";
                }
                else if (ort >= 75)
                {
                    harfnotu = "B";
                }
                else if (ort >= 60)
                {
                    harfnotu = "C";
                }
                else if (ort >= 45)
                {
                    harfnotu = "D";
                }
                else
                {
                    harfnotu = "Kaldı";
                }

                // Print the letter grade to the console
                Console.WriteLine("\nHarf Notu: {0}", harfnotu);

                Console.ReadLine();
            }

            static double Hesapla(int vize, int final)
            {
                double ort = 0.4 * vize + 0.6 * final;
                return ort >= 50 ? ort : 0;
            }
        }

    }


