using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Pizza
    {
        string size;
        public string Size {  get { return size; } set {  size = value; } }
        int qtyCheeseToppings;
        public int QtyCheeseToppings { get { return qtyCheeseToppings; } set {  qtyCheeseToppings = value;} }
        int qtyPepperoniToppings;
        public int QtyPepperoniToppings {  get { return qtyPepperoniToppings; } set { qtyPepperoniToppings = value; } }

        int qtyHamToppings;
        public int QtyHamToppings { get { return qtyHamToppings; } set{ qtyHamToppings = value; } }

        public Pizza()
        {
            size = "";
            qtyCheeseToppings = 0;
            qtyPepperoniToppings = 0;
            qtyHamToppings = 0;
        }
        public Pizza(string size, int qtyCheeseToppings ,int qtyPepperoniToppings,int qtyHamToppings)
        {
            this.size = size;
            this.qtyCheeseToppings= qtyCheeseToppings;
            this.qtyHamToppings = qtyHamToppings;
            this.qtyPepperoniToppings= qtyPepperoniToppings;

        }
        public double CalcCost()
        {
            double cost = 0.0;
            switch (size.ToLower())
            {
                case "small":
                    {
                        cost = 10 + 2*(qtyCheeseToppings + qtyPepperoniToppings + qtyHamToppings);
                        break;
                    }
                case "medium":
                    {
                        cost = 12 + 2 * (qtyCheeseToppings + qtyPepperoniToppings + qtyHamToppings);
                        break;
                    }
                case "large":
                    {
                        cost = 14 + 2 * (qtyCheeseToppings + qtyPepperoniToppings + qtyHamToppings);
                        break;
                    }

            }
                    return cost;
        }

        public string GetDescription()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pizza size : {size}");
            sb.AppendLine($"number of  cheese toppings : {qtyCheeseToppings}");
            sb.AppendLine($"number of  pepperoni toppings : {qtyPepperoniToppings}");
            sb.Append($"number of  Ham toppings : {qtyHamToppings}");
            return sb.ToString();
        }


    }
}
