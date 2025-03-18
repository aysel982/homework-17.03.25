//#region task1

//#endregion

//using System;

//namespace ConsoleApp7
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int minValue = GetMin();
//            Console.WriteLine("Minimum deyer: " + minValue);
//        }

//        static int GetMin()
//        {
//            int[] arr = { 1, 2, 3, 4, 5 };
//            int min = arr[0];

//            for (int i = 1; i < arr.Length; i++)
//            {
//                if (arr[i] < min)
//                {
//                    min = arr[i];
//                }
//            }

//            return min;
//        }
//    }
//}




//#region task2

//#endregion

//using System.Security.Cryptography;

//namespace ConsoleApp9
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            area(4);
//            area(4, 8);
//            area(4, 8, 4);
//            area(2, 2, 2, 2);
//        }
//        static void area(double radius)
//        {
//            double pi = 3.14;
//            double safe = pi * radius * radius;
//            Console.WriteLine("Çevrenin sahesi:" + safe);
//        }
//        static void area(double a, double b)
//        {
//            double sahe = a * b;

//            Console.WriteLine("Düzbucaqlının sahesi: " + sahe);
//        }
//        static void area(double a, double b, double c)
//        {

//            double sahe = 2 * (a * b + b * c + a * c);

//            Console.WriteLine("Düzbucaqlı paralelpipedin tam sethinin sahesi:" + sahe);
//        }
//        static void area(double a, double b, int c, double radius)
//        {
//            double perimetir = (a + b + c) / 2;
//            double sahe = perimetir * radius;

//            Console.WriteLine("Ücbucaqlının daxiline çekilmiş çevrenin sahesi:" + sahe);
//        }
//    }
//}