using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ww
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 ile 100 arasındaki 25 sayıyı diziye atayıp sıralı şekilde ekrana yazdırma

            int gecici = 0;
            Random rnd = new Random();
            int[] rasDizi = new int[25]; 

            for (int i = 0; i < rasDizi.Length; i++)
            {
                int rasSayi = rnd.Next(1, 100);
                rasDizi[i] = rasSayi;
            }

            Console.WriteLine("******DİZİNİN İLK HALİ******");
            foreach (int k in rasDizi)
            {
                
                Console.WriteLine(k);
            }

            for (int i = 0; i < rasDizi.Length; i++)
            {
                for (int x = i + 1; x < rasDizi.Length; x++)
                {
                    if (rasDizi[i] > rasDizi[x])
                    {
                        gecici = rasDizi[x];
                        rasDizi[x] = rasDizi[i];
                        rasDizi[i] = gecici;
                    }
                }
            }

            Console.WriteLine("****DİZİNİN SON HALİ****");
            foreach (int sayac in rasDizi)
            {
                Console.WriteLine(sayac);
            }


            Console.ReadKey();










            //List<int> yenıLıst = new List<int>();
            //List<string> strıngLıst = new List<string>();

            //  void Yazdır()
            //{
            //    yenıLıst.Add(1);
            //    yenıLıst.Add(2);
            //    yenıLıst.Add(8);

            //    strıngLıst.Add("ali");

            //    Console.WriteLine(yenıLıst);
            //    Console.WriteLine(strıngLıst);

            //    //for (int i = 0; i < 10; i++)
            //    //{
            //    //    yenıLıst.Add(i);
            //    //}
            //    //Console.WriteLine(yenıLıst);
            //}
            //Yazdır();
            //Console.ReadLine();


        }





    }
}
