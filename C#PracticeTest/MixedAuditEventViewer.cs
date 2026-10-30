using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class MixedAuditEventViewer
    {
        public class AuditEvent
        {
            public DateTime eventDay;
            public string ToString()
            {
                return $"Audit event date : {eventDay.Date}";
            }
        }

        public static void Main()
        {
            AuditEvent auditEvent = new AuditEvent();
            auditEvent.eventDay = DateTime.Now;
            object[] objArray =
            {
                11,
                233.99m,
                "Hello",
                DateTime.Now,
                auditEvent
            };

            foreach(object obj in objArray)
            {
                dynamic o = obj;
                Console.WriteLine(o.GetType().Name);
            }
            string str = auditEvent.ToString();
            Console.WriteLine(str);

            var event1 = auditEvent;
            var event2 = auditEvent;
            event2.eventDay = DateTime.UtcNow;
            Console.WriteLine(event1 == event2);



            AuditEvent audit1 = new AuditEvent();
            AuditEvent audit2 = new AuditEvent();
            Console.WriteLine(audit1 == audit2);

        }
    }
}
