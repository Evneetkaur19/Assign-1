using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign_1.Controllers
{
    public class SquareController : ApiController
    {/// <summary>
     /// Now take user input and do square of it.
     /// </summary>
     /// <param name="id"></param>
     /// <returns> squared user input </returns>
     /// <example> https://localhost:44390/api/Square/2 --> 4 </example>
     /// <example> https://localhost:44390/api/Square/18 --> 324 </example>
     /// <example> https://localhost:44390/api/Square/12 --> 144 </example>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
