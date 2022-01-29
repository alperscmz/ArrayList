using System;
using System.Collections;

namespace arrayList 
{
    class Program
    {
        static void Main(string[]args)
        {
          ArrayList Liste=new ArrayList();
          Liste.Add("alper");
          Liste.Add(7);
          Liste.Add(true);
          Liste.Add('a');

          //içerisindeki verilere erişme
          foreach (var item in Liste)
              Console.WriteLine(item);

          //AddRange 
          Console.WriteLine("****************");
          string[] renkler={"sarı","mavi"};
          List<int> sayilar=new List<int>(){1,3,2,6,5};
          Liste.AddRange(renkler);
          Liste.AddRange(sayilar);   
          foreach (var item in Liste)
              Console.WriteLine(item);

         //Sort  sıralama yaparken hata vericektir tek tipte değerler olmadığı için.
         //Console.WriteLine("************");
         //Liste.Sort();

         //BinarySearch sıralaması yapıldıktan sonra aranılan değerin sırasını vericektir.
         //Console.WriteLine(Liste.BinarySearch(6));

         //Reverse  tersi şekilde sıralamaya yapar.
         //Liste.Reverse();

         //Clear listeyi temizler
         //Liste.Clear();
        
    


        }
    }
}

