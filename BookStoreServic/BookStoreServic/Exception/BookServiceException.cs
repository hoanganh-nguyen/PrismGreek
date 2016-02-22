using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreServic.Exception
{
    [DataContract]
    public class BookServiceFault
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string ExceptionMessage { get; set; }
        [DataMember]
        public string InnerException { get; set; }
        [DataMember]
        public string StackTrace { get; set; }

    }
}
