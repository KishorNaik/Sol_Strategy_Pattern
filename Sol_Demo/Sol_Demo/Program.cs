using Sol_Demo.Contexts;
using Sol_Demo.Models;
using System;
using System.Threading.Tasks;

namespace Sol_Demo
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");

                // Step 1: Input
                ElectricityUnitModel electricityUnitModel = new ElectricityUnitModel()
                {
                    Unit = 200
                };

                SurchargeCalculationContext surchargeCalculationContext = new SurchargeCalculationContext();

                // Step 2 : surcharge Calculation
                ElectricitySurchargeModel electricitySurchargeModel = await surchargeCalculationContext.GetSurchargeCalculationAsync(electricityUnitModel);

                // Step 3: Display surchare Calculation
                Console.WriteLine($"Unit : {electricityUnitModel?.Unit}");
                Console.WriteLine($"Surcharge Amount : {electricitySurchargeModel?.SurchargeAmount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}