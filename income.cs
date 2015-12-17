using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace group8CodeProj
{
    [DelimitedRecord(",")]
    [IgnoreEmptyLines()]
    [IgnoreFirst()]
    public class Income
    {
        public decimal? id { get; set; }
        public String neighborhood { get; set; }
        public decimal? crowded { get; set; }
        public decimal? poverty { get; set; }
        public decimal? unemployed { get; set; }
        public decimal? noDiploma { get; set; }
        public decimal? middleAged { get; set; }
        public decimal? income { get; set; }
        public decimal? hardship { get; set; }
    }
}