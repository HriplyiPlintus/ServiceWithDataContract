using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient
{
    [ServiceContract]
    public interface IRepository
    {
        [OperationContract]
        Point GetPoint(int key);
    }

    //контракт данных
    [DataContract(Namespace = "Domain")]
    public class Point
    {
        [DataMember]
        public int X { get; set; }
        [DataMember]
        public int Y { get; set; }
    }
}
