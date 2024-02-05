using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign_1.Controllers
{
    public class HostingCostController : ApiController
    ///<summary>
    ///calculates the no. of fortnight and gives the bill according to the user input.
    ///<param name="id">user input number of days transpired</param>
    ///<param name="OneFortNight">14 days, or a fortnight</param>
    ///<param name="FortNightCount">fortnight divided by user input +1 to push into next billing cycle</param>
    ///<param name="FortNightCost">cost per fortnight</param>
    ///<param name="HST">HST percentage</param>
    ///<param name="Total">total </param> ///
    ///</summary>
    ///<return>returns fee of 5.50 per fortnight plus HST, concated within a string.
    ///</return>
    ///<example>http://localhost:61608/api/hostingcost/2 --> 1 fortnights at $5.5/FN = $5.5CAD HST 13% = $0.715CAD Total = $6.215CAD</example>
    {
        public string Get(int id)

        {
            int OneFortNight = 14;
            int FortNightCount = id / OneFortNight + 1;
            float FortNightCost = 5.50f;
            float HST = 0.13f;
            float Total = FortNightCount * FortNightCost * HST + FortNightCost * FortNightCount;
            return FortNightCount + " fortnights at $" + FortNightCost + "/FN = $" + (FortNightCount * FortNightCost) + "CAD HST 13% = $" + (FortNightCount * FortNightCost * HST) + "CAD Total = $" + Total + "CAD";

        }
    }
}
