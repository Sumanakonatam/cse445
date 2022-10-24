using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    public class InventoryService : InvService
    {
        public string GetLatestQuantities()
        {
            WebClient client = new WebClient();
            string currentVersion = client.DownloadString("http://webstrar31.fulton.asu.edu/page5/currentVersion.txt");
            string quantities = client.DownloadString("http://webstrar31.fulton.asu.edu/page5/quantitySnapshots/inv"+currentVersion+".txt");
            return quantities;
        }

        public bool UpdateQuantities(string data)
        {
            return false;
        }

        public bool DecrementItemQuantity(int itemNum, int amt)
        {
            return false;
        }

        public bool IncrementItemQuantity(int itemNum, int amt)
        {
            return false;
        }
    }
}
