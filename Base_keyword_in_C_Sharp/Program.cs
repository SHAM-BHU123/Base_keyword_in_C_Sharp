using System;

namespace Base_keyword_in_C_Sharp
{

   public  class Animals
    {
        public String color = "Black";
    }

    public class Dog : Animals {

        String color = "White";

        public void showColor()
        {
            Console.WriteLine(base.color);
            Console.WriteLine(color);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.showColor();
        }
    }
}
