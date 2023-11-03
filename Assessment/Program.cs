using System.Linq.Expressions;

namespace Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> pizzaList = new List<Pizza>();
            string choice = "y";
            while (choice.ToLower() == "y")
            {
                
                string size=null;
                int qtyCheese, qtyPepperoni, qtyHam;
                Console.WriteLine("Enter size: ");
                try
                {
                    size = Console.ReadLine();
                    if (size.ToLower()!="small" && size.ToLower()!="medium"&&size.ToLower()!="large")
                    {
                        throw new Exception("Please enter size: small, medium, large");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                Console.WriteLine("quantity of cheese on you pizza?");
                qtyCheese = byte.Parse(Console.ReadLine());
                Console.WriteLine("quantity of pepperoni on you pizza?");
                qtyPepperoni=byte.Parse(Console.ReadLine()); 
                Console.WriteLine("quantity of Ham on you pizza?");
                qtyHam=byte.Parse(Console.ReadLine());
                Pizza pizza=new Pizza(size,qtyCheese,qtyPepperoni,qtyHam);
                pizzaList.Add(pizza);

                Console.WriteLine("do you want to add another Pizza?\nyes(y) no(press any other key)");
                choice = Console.ReadLine();
            }

            foreach(Pizza pizza in pizzaList)
            {
                string desc=pizza.GetDescription();
                Console.WriteLine(desc);
                double cost = pizza.CalcCost();
                Console.WriteLine($"Cost of this pizza is {cost}\n");
            }
        }
    }
}