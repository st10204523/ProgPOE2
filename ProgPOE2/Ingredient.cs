using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPOE2
{
    internal class Ingredient
    {
        private string Name;

        private double Quantity;

        private string Unit;

        private double originalQuantity;

        private double Calorie;

        private string foodGroup;

        public double OriginalQuantity { get => originalQuantity; set => originalQuantity = value; }
        public double Calorie1 { get => Calorie; set => Calorie = value; }
        public string FoodGroup { get => foodGroup; set => foodGroup = value; }
        public string Name1 { get => Name; set => Name = value; }
        public double Quantity1 { get => Quantity; set => Quantity = value; }
        public string Unit1 { get => Unit; set => Unit = value; }

        public void ResetQuantity()
        {
            Quantity = originalQuantity;
        }
    }
}
