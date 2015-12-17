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
    class Crime
    {
        public string caseNO;
        public string date;
        public string block;
        public string iucr;
        [FieldQuoted('"', QuoteMode.OptionalForBoth, MultilineMode.AllowForRead)]
        public string primaryDesc;
        [FieldQuoted('"', QuoteMode.OptionalForBoth, MultilineMode.AllowForRead)]
        public string secondaryDesc;
        [FieldQuoted('"', QuoteMode.OptionalForBoth, MultilineMode.AllowForRead)]
        public string locDesc;
        public string arrest;
        public string domestic;
        public decimal? beat;
        public decimal? ward;
        public string fbiCD;
        public decimal? x;
        public decimal? y;
        public decimal? latitude;
        public decimal? longitude;
        [FieldQuoted('"', QuoteMode.OptionalForBoth, MultilineMode.AllowForRead)]
        public string location;
    }
}
