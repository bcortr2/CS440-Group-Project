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
    public class TIF
    {
        public decimal? id;
        [FieldQuoted('"', QuoteMode.OptionalForBoth, MultilineMode.AllowForRead)]
        public string TIFDistrict;
        [FieldQuoted('"', QuoteMode.OptionalForBoth, MultilineMode.AllowForRead)]
        public string projectName;
        [FieldQuoted('"', QuoteMode.OptionalForBoth, MultilineMode.AllowForRead)]
        public string address;
        [FieldQuoted('"', QuoteMode.OptionalForBoth, MultilineMode.AllowForRead)]
        public string developer;
        public decimal? projectID;
        [FieldQuoted('"', QuoteMode.OptionalForBoth, MultilineMode.AllowForRead)]
        public string projectDescription;
        [FieldQuoted('"', QuoteMode.OptionalForBoth, MultilineMode.AllowForRead)]
        public string cdcDate;
        [FieldQuoted('"', QuoteMode.OptionalForBoth, MultilineMode.AllowForRead)]
        public string approvedAmmount;
        [FieldQuoted('"', QuoteMode.OptionalForBoth, MultilineMode.AllowForRead)]
        public string totalProjectCost;
        public decimal? xCoordinate;
        public decimal? yCoordinate;
        public decimal? latitude;
        public decimal? longitude;
        [FieldQuoted('"', QuoteMode.OptionalForBoth, MultilineMode.AllowForRead)]
        public string location;
    }
}