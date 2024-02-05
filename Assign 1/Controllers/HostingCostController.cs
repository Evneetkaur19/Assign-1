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
    ///calculates the no. of armnight and gives the bill according to the user input.
    ///<param name="userid">user input number of days transpired</param>
    ///<param name="OneNight">14 days, or a fortnight</param>
    ///<param name="FortNightCount">fortnight divided by user input +1 to push into next billing cycle</param>
    ///<param name="FortNightCost">cost per fortnight</param>
    ///<param name="HST">HST percentage</param>
    ///<param name="Total">total </param> ///
    ///</summary>
    ///<return>returns fee of 5.50 per fortnight plus HST, concated within a string.
    ///</return>
    ///<example>https://localhost:44390/api/HostingCost/31 --> 3 fortnights at $5.5/FN = $16.5CAD HST 13% = $2.145CAD Total = $18.645CAD</example>
    {
        public string Get(int id)

        {
            int OneNight = 14;
            int FortNightCount = id / OneNight + 1;
            float FortNightCost = 5.50f;
            float HST = 0.13f;
            float Total = FortNightCount * FortNightCost * HST + FortNightCost * FortNightCount;
            return FortNightCount + " fortnights at $" + FortNightCost + "/FN = $" + (FortNightCount * FortNightCost) + "CAD HST 13% = $" + (FortNightCount * FortNightCost * HST) + "CAD Total = $" + Total + "CAD";

        }
    }
}
