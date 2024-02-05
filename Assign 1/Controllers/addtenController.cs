using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign_1.Controllers
{
    public class addtenController : ApiController
    {
        /// <summary>
        /// Now Add nine to user input.
        /// </summary>
        /// <returns>user input plus ten </returns>
        /// <example>https://localhost:44390/api/addten/9 --> 19 </example>
        /// <example>https://localhost:44390/api/addten/25 --> 35 </example>
        /// <example>https://localhost:44390/api/addten/56 --> 66 </example>
        /// <example>https://localhost:44390/api/addten/17 --> 27 </example>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
