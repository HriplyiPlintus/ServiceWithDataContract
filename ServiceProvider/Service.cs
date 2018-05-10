using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace ServiceProvider
{
    public class Service : IRepository
    {
        public Point GetPoint(int key) =>
            (new PointRepository()).GetPoint(key);
    }
}
