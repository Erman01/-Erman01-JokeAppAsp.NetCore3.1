﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Joke
    {
        public Joke()
        {

        }
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
