using System;
using System.IO;


namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            RelocateFruit();
            RelocateVegetables();
            Delete();
        }
        public static void RelocateFruit()
        {
            string Point1 = @"C:\Users\PC\samples\WWF";
            string Point2 = @"C:\Users\PC\samples\WWF\fruit";
            string Fruit = "apples.txt";
            string Fruit2 = "bananas.txt";
            string Fruit3 = "pineapples.txt";

            File.Move(Path.Combine(Point1, Fruit), Path.Combine(Point2, Fruit));
            File.Move(Path.Combine(Point1, Fruit2), Path.Combine(Point2, Fruit2));
            File.Move(Path.Combine(Point1, Fruit3), Path.Combine(Point2, Fruit3));

            Console.WriteLine("Fruits moved into the fruit folder");
        }

        public static void RelocateVegetables()
        {
            string Point1 = @"C:\Users\PC\samples\WWF";
            string Point3 = @"C:\Users\PC\samples\WWF\vegetables";
            string Veggie = "cucumbers.txt";
            string Veggie2 = "onions.txt";
            string Veggie3 = "potatos.txt";

            Console.WriteLine("Veggies moved into the vegetables folder");

            File.Move(Path.Combine(Point1, Veggie), Path.Combine(Point3, Veggie));
            File.Move(Path.Combine(Point1, Veggie2), Path.Combine(Point3, Veggie2));
            File.Move(Path.Combine(Point1, Veggie3), Path.Combine(Point3, Veggie3));
        }

        public static void Delete()
        {
            string fruitFolder = @"C:\Users\PC\samples\WWF\fruit";
            string veggieFolder = @"C:\Users\PC\samples\WWF\vegetables";
            string Cheese = "cheese.txt";
            string TP = "toiletPaper.txt";

            File.Delete(Path.Combine(fruitFolder, TP));
            Console.WriteLine("Toilet paper deleted from the Fruit folder!");
            File.Delete(Path.Combine(veggieFolder, Cheese));
            Console.WriteLine("Cheese deleted from the Vegetables folder!");

        }



    }
}

