using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web;

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
            //try
            //{
                string[] quantities = data.Split(
                    new string[] { Environment.NewLine },
                    StringSplitOptions.None
                );

                if (quantities.Length < 20 || quantities.Length > 20)
                {
                    Console.WriteLine("Incorrect length");
                    return false;
                } else
                {
                    WebClient client = new WebClient();
                    string currentVersion = client.DownloadString("http://webstrar31.fulton.asu.edu/page5/currentVersion.txt");
                    string newVersion = (Int32.Parse(currentVersion) + 1).ToString();
                    string fLocation = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data"); // From server root to current
                    fLocation = Path.Combine(fLocation, newVersion + ".txt"); // From current to App_Data
                    //File.WriteAllText("http://webstrar31.fulton.asu.edu/page5/quantitySnapshots/inv" + newVersion + ".txt", data);
                    //File.WriteAllText("http://webstrar31.fulton.asu.edu/page5/currentVersion.txt", newVersion);
                    //File.WriteAllText(fLocation, data);
                    File.WriteAllText("http://webstrar31.fulton.asu.edu/page5/currentVersion.txt", newVersion);
                    return true;
                }

            //}
            //catch (Exception exc) {
            //    Console.WriteLine(exc.Message);
            //    return false; 
            //}
        }

        public string DecrementItemQuantity(int itemNum, int amt)
        {
            string result;
            string latest = GetLatestQuantities();
            string[] quantities = latest.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.None
            );

            quantities[itemNum-1] = (Int32.Parse(quantities[itemNum-1]) - amt).ToString();

            result = string.Join("\n", quantities);
            return result;
        }

        public string IncrementItemQuantity(int itemNum, int amt)
        {
            string result;
            string latest = GetLatestQuantities();
            string[] quantities = latest.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.None
            );

            quantities[itemNum-1] = (Int32.Parse(quantities[itemNum-1]) + amt).ToString();

            result = string.Join("\n", quantities);
            return result;
        }
    }
}
