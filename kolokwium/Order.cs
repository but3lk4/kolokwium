using System;
using System.Collections.Generic;

namespace kolokwium
{
    
        public class Order : INote
        {
            public DateTime RealizationTime { get; set; }
            public bool OrderStatus { get; set; }
            public string OrderId { get; set; }
            public List<OrderPosition> Orders = new List<OrderPosition>();
            public bool ElectronicConfirmation { get; set; }


            public void OrderValue(double orderValue)
            {
                
            }

            public void TaxValue(double taxValue)
            {
                
            }

            public void OrderPay( Payment payment)
            {
                
            }

            public void PrintConfirmation()
            {
                        
            }

            public void AddToOrderList(OrderPosition orderPosition)
            {
            
                
            }

            public string printConfirmation(string Confirmation)
        {
            throw new NotImplementedException();
        }
    }


        
    
}
