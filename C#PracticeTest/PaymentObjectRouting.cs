using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class PaymentObjectRouting
    {
        public class CardPayment
        {
            public void pay()
            {
                Console.WriteLine("Paid via Card");
            }
        }
        public class WalletPaymant
        {
            public void pay()
            {
                Console.WriteLine("Paid via Wallet");
            }
        }
        public static void Main()
        {
            object[] array =
            {
                new CardPayment(),
                new WalletPaymant(),
                "String",
                null
            };
            foreach(object obj in array)
            {
                if(obj is CardPayment)
                {
                    //CardPayment Card = (CardPayment)obj;
                    //Card.pay();
                    (obj as CardPayment).pay();
                }
                else if(obj is WalletPaymant)
                {
                    WalletPaymant wallet = (WalletPaymant)obj;
                    wallet.pay();
                }
                else if(obj ==  null)
                {
                    Console.WriteLine("Null object");
                }
                else
                {
                    Console.WriteLine($"Object type : {obj.GetType().Name}");
                }
            }
        }
    }
}
