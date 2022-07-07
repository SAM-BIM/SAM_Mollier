﻿namespace SAM.Core.Mollier
{
    public static partial class Create
    {
        public static Cooling Cooling(this MollierPoint start, double dryBulbTemperature)
        {
            if (start == null || double.IsNaN(dryBulbTemperature))
            {
                return null;
            }

            if (dryBulbTemperature > start.DryBulbTemperature)
            {
                return null;
            }

            MollierPoint end = new MollierPoint(dryBulbTemperature, start.HumidityRatio, start.Pressure);
            if (end == null)
            {
                return null;
            }

            return new Cooling(start, end);
        }

        public static Cooling Cooling_ByTemperatureDifference(this MollierPoint start, double temperatureDifference)
        {
            if (start == null || double.IsNaN(temperatureDifference))
            {
                return null;
            }


            MollierPoint end = new MollierPoint(start.DryBulbTemperature - temperatureDifference, start.HumidityRatio, start.Pressure);
            if (end == null)
            {
                return null;
            }

            return new Cooling(start, end);
        }

        public static Cooling Cooling_ByEnthalpyDifference(this MollierPoint start, double enthalpyDifference)
        {
            if (start == null || double.IsNaN(enthalpyDifference))
            {
                return null;
            }

            MollierPoint end = MollierPoint_ByEnthalpy(start.Enthalpy - enthalpyDifference, start.HumidityRatio, start.Pressure);
            if (end == null)
            {
                return null;
            }

            return new Cooling(start, end);
        }

        public static Cooling Cooling_ByMedium(this MollierPoint start, double efficiency, double flowTemperature, double returnTemperature)
        {
            if(start == null || double.IsNaN(efficiency) || double.IsNaN(flowTemperature) || double.IsNaN(returnTemperature))
            {
                return null;
            }

            double averageTemperature = (flowTemperature + returnTemperature) / 2;

            double temperatureDifference = start.DryBulbTemperature - averageTemperature;
            double humidityRatioDifference = start.HumidityRatio - Query.HumidityRatio(averageTemperature, 100, start.Pressure);

            MollierPoint end = new MollierPoint(start.DryBulbTemperature - (temperatureDifference * efficiency), start.HumidityRatio - (humidityRatioDifference * efficiency), start.Pressure);
            if(end == null)
            {
                return null;
            }

            return new Cooling(start, end);
        }
    }
}