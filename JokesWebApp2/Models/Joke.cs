using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JokesWebApp2.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }
    }
}