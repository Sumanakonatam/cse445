using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface InvService
    {
        [OperationContract]
        string GetLatestQuantities();

        [OperationContract]
        string UpdateQuantities(string data);

        [OperationContract]
        string DecrementItemQuantity(int itemNum, int amt);

        [OperationContract]
        string IncrementItemQuantity(int itemNum, int amt);
    }
}
