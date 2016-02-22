using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreServic.Contract
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public DateTime PublishDate { get; set; }
        [DataMember]
        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
