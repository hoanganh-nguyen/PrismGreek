using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService.Contract
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public string ISIN { get; set; }
        [DataMember]
        public double Price { get; set; }
        public Book ()
	    {

	    }
    }
}
