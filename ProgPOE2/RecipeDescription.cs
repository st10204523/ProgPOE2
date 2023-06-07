using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPOE2
{
    internal class RecipeDescription
    {
        private String Recipename;
        private List<Ingredient> ingredients;
        private List<steps> steps;

        public string Name { get => Recipename; set => Recipename = value; }
        internal List<Ingredient> Ingredients { get => ingredients; set => ingredients = value; }
        internal List<steps> Steps { get => steps; set => steps = value; }

       
    }
}
