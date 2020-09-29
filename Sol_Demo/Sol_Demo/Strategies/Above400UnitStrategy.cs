using Sol_Demo.Cores;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Strategies
{
    internal class Above400UnitStrategy : IUnitSurchargeCalculation
    {
        private const double surchargeUnit = 3.20;

        Task<ElectricitySurchargeModel> IUnitSurchargeCalculation.SurchargeCalculationAsync(ElectricityUnitModel electricityUnitModel)
        {
            return Task.Run(() =>
            {
                return new ElectricitySurchargeModel()
                {
                    SurchargeAmount = electricityUnitModel?.Unit * surchargeUnit
                };
            });
        }
    }
}