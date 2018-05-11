using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;

using Domain;

namespace Contract
{
    [ServiceContract]
    public interface IRepository
    {
        [OperationContract]
        Point GetPoint(int key);
    }
}
