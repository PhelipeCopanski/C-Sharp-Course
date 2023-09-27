using System.Globalization;

namespace Contribuintes.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double anualIncome)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override string ToString()
        {
            return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);

        }

        public override double Tax()
        {
            if (AnualIncome < 20000.00 && HealthExpenditures > 0)
            {
                return AnualIncome * 0.15 - HealthExpenditures / 2.0;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures / 2.0;
            }
        }
    }
}
