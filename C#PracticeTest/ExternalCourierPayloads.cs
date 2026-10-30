using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class ExternalCourierPayloads
    {
        public class Shipment
        {
            public string TrackingId = "TID1";
            public string Status = "Shipped";

        }
        public static void Main(string[] args)
        {
            var varShipment = new Shipment();
            Console.WriteLine(varShipment.TrackingId);
            Console.WriteLine(varShipment.Status);

            dynamic dynamicShipment1 = new Shipment();
            dynamicShipment1.TrackingId = "TID1000";
            dynamicShipment1.Status = "Not Shipped";


            dynamic dynamicShipment2 = new Shipment();
            dynamicShipment2.TrackingId = "TID999";

            varShipment.Status = "Not shipped";
            //varShipment.Delivery = 11; // Invalid member access


        }
    }
}
