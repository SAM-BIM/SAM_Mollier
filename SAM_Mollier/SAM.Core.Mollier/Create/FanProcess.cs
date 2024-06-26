﻿namespace SAM.Core.Mollier
{
    public static partial class Create
    {
        public static FanProcess FanProcess(this MollierPoint start, double spf)
        {
            if (start == null || double.IsNaN(spf))
            {
                return null;
            }

            return new FanProcess(start, new MollierPoint(start.PickupTemperature(spf), start.HumidityRatio, start.Pressure));
        }

        public static FanProcess FanProcess_ByDryBulbTemperature(this MollierPoint start, double dryBulbTemperature)
        {
            if (start == null || double.IsNaN(dryBulbTemperature))
            {
                return null;
            }

            HeatingProcess heatingProcess = HeatingProcess_ByTemperatureDifference(start, System.Math.Abs(start.DryBulbTemperature - dryBulbTemperature));
            if(heatingProcess == null)
            {
                return null;
            }

            return new FanProcess(start, heatingProcess.End);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start">Dry Bulb Temperature [C]</param>
        /// <param name="spf">Specific Fan Power [W/l/s]</param>
        /// <param name="density">Moist Air Density ρ [kg_MoistAir/m3]</param>
        /// <param name="specificHeatCapacity">Specific Heat Capacity of Air [kJ/kgK]</param>
        /// <param name="efficiency">Process efficiency 0-1</param>
        /// <returns></returns>
        public static FanProcess FanProcess(this MollierPoint start, double spf, double density, double specificHeatCapacity)
        {
            if (start == null || double.IsNaN(spf))
            {
                return null;
            }

            return new FanProcess(start, new MollierPoint(start.DryBulbTemperature + Query.PickupTemperature(spf, density, specificHeatCapacity), start.HumidityRatio, start.Pressure));
        }
    }
}
