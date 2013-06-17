namespace TemplateMethod.CaffeineBeverage
{
    using System.Text;

    public class Coffee
    {
        public string PrepareRecipe()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.BoilWater());
            sb.Append(this.BrewCoffeeGrinds());
            sb.Append(this.PourInCup());
            sb.Append(this.AddSugarAndMilk());

            return sb.ToString();
        }

        public string BrewCoffeeGrinds()
        {
            return "Dripping coffee through filter\n";
        }

        public string AddSugarAndMilk()
        {
            return "Adding sugar and milk\n";
        }

        public string BoilWater()
        {
            return "Boiling water\n";
        }

        public string PourInCup()
        {
            return "Pouring into cup\n";
        }
    }
}