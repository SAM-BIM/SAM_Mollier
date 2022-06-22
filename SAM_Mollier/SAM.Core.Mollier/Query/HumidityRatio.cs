﻿using System;

namespace SAM.Core.Mollier
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates humidity ratio from dry bulb temperature, relative humidity and pressure.
        /// </summary>
        /// <param name="dryBulbTemperature">Dry bulb temperature [°C]</param>
        /// <param name="relativeHumidity">Relative humidity (0 - 100)[%]</param>
        /// <param name="pressure">Atmospheric pressure [Pa]</param>
        /// <returns>Humidity Ratio [kg_waterVapor/kg_dryAir]</returns>
        public static double HumidityRatio(double dryBulbTemperature, double relativeHumidity, double pressure)
        {
            if (double.IsNaN(relativeHumidity) || relativeHumidity > 100 || relativeHumidity < 0 || double.IsNaN(dryBulbTemperature) || double.IsNaN(pressure))
            {
                return double.NaN;
            }

            double saturationVapourPressure = SaturationVapourPressure(dryBulbTemperature, relativeHumidity);
            if(double.IsNaN(saturationVapourPressure))
            {
                return double.NaN;
            }

            //saturationVapourPressure = saturationVapourPressure * relativeHumidity / 100;

            return 0.6222 * saturationVapourPressure / (pressure - saturationVapourPressure);
        }

        /// <summary>
        /// Calculates humidity ratio from dry bulb temperature and enthalpy.
        /// </summary>
        /// <param name="dryBulbTemperature">Dry bulb temperature [°C]</param>
        /// <param name="enthalpy">Moist air Enthalpy[J / kg]</param>
        /// <returns>Humidity Ratio [kg_waterVapor/kg_dryAir]</returns>
        public static double HumidityRatio_ByEnthalpy(double dryBulbTemperature, double enthalpy)
        {
            if(double.IsNaN(enthalpy) || double.IsNaN(dryBulbTemperature))
            {
                return double.NaN;
            }

            return ((enthalpy / 1000)- dryBulbTemperature) / (2501 + 1.86 * dryBulbTemperature);
        }
    }
}
