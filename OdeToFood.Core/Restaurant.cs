﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Core
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }  //Could be and object of it's own
        public CuisineType Cuisine { get; set; }
    }
}
