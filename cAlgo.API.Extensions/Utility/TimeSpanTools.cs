﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace cAlgo.API.Extensions.Utility
{
    public static class TimeSpanTools
    {
        public static void TryParse(string value, Chart chart, string parameterName, out TimeSpan result)
        {
            bool parseResult = TimeSpan.TryParse(value, CultureInfo.InvariantCulture, out result);

            if (!parseResult)
            {
                chart.ShowInvalidParameterMessage(parameterName, value);
            }
        }
    }
}