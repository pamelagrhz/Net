using System;

namespace PracticaPorObjetivos1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Platillo pizza = new Platillo("pizza");
            Alimentos[] ingredientes = new Alimentos[]
            {
                new Alimentos ("Piña",10,200),
                new Alimentos ("jamon",35,100),
                new Alimentos("salsa",45,50)

            };
            pizza.Ingredientes = ingredientes;
            Console.WriteLine(pizza);




        }
    }
}
