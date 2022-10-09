﻿using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.collection.generic
            Dictionary<int,string> kullanıcılar = new Dictionary<int,string>();

            kullanıcılar.Add(10,"Ayşe Yılmaz");
            kullanıcılar.Add(12,"Ahmet Yılmaz");
            kullanıcılar.Add(18,"Deniz Arda");
            kullanıcılar.Add(20,"Özcan Çoşar");

            // Dizinin elemanlarına erişim
            Console.WriteLine("******* Elamlara Erişim *****");
            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
                Console.WriteLine(item);
            
            //Count;
            Console.WriteLine("******* Count *****");
            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine("******* Cantains *****");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Zikriye Ürkmez"));

            //Remove
            Console.WriteLine("****** Remove *******");
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
                Console.WriteLine(item.Value);

            //Keys
            Console.WriteLine("****** Keys *******");
            foreach (var item in kullanıcılar.Keys)
                Console.WriteLine(item);
            //Value
            Console.WriteLine("****** Value *******");
            foreach (var item in kullanıcılar.Values)
                Console.WriteLine(item);
        }
    }
}
