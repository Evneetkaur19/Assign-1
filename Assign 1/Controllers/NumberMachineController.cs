using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign_1.Controllers
{
    public class NumberMachineController : ApiController
    ///<summary>
    ///It will perform four mathematical operations in the users input.
    ///<param name="id"> integer user input </param>
    ///</summary>
    ///<return> final answer of user input after addition, subtraction, multiply and divide </return>
    ///<example>https://localhost:44390/api/NumberMachine/13 --> 10 </example>
    ///<example>https://localhost:44390/api/NumberMachine/23 --> 20 </example>
    ///<example>https://localhost:44390/api/NumberMachine/33 --> 30 </example>
    {
        public int Get(int id)
        {
            return id - 3 + 2 / 9 * 5;
        }
    }
}
