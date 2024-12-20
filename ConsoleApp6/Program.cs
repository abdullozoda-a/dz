using System;

namespace ConsoleApp6
{
    class Animal
    {
        public string kind="собака";
        public string name="фуркат";
        public int age=6;
        public int weight = 90;
        
        
        public void PrintInfo()
        {
            Console.WriteLine("тип: "+kind);
            Console.WriteLine("имя: "+name);
            Console.WriteLine("лет: "+age+" years");
            Console.WriteLine("вес: "+weight+"kg");
    
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
         
            animal.PrintInfo();
        }
    }
}
