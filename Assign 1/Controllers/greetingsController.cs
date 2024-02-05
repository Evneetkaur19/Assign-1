using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign_1.Controllers
{
    public class greetingsController : ApiController
    {
        public string Post()
        /// <summary>
        /// Post request returns string "Hemllo World!"
        /// </summary>
        /// <return>"Hemllo World"</return>
        /// <example> In command prompt: curl -d "public string Post()
        /// <summary>
        /// Post request returns string "Hello World!"
        /// </summary>
        /// <return>"Hello World"</return>
        /// <example> In command prompt: curl -d "" https://localhost:44390/api/greetings -->"hello world!"</example>
        {
            return "hello world!";
        }
        public string Get(int id)
        {   /// <summary>
            /// Takes user input and concatenates that number to a greeting message
            /// <param name="id"/>user input integer</param>
            /// </summary>
            /// <return>"greeting to id people</return>
            /// <example>https://localhost:44390/api/greetings/2 --> greetings to 2 people!</example>
            /// <example>https://localhost:44390/api/greetings/10 --> greetings to 10 people!</example>
            /// <example>https://localhost:44390/api/greetings/90 --> greetings to 90 people!</example>

            return $"greetings to {id} people!";
        }
    }
}    
    

         
   


