namespace kolokwium
{
    
    public class OrderPosition
        {
            public string CargoName { get; set; }
            public float UnitPrice { get; set; }
            public int RateVat { get; set; }
            public float Quantity { get; set; }

            
        public void CalculateGross(double TaxGross)
        {
            if(TaxGross == 23)
            {
                TaxGross = UnitPrice * 0.23;
            }
             else if(TaxGross == 8)
            {
                TaxGross = UnitPrice * 0.08;
            }
            else if(TaxGross == 5)
            {
                TaxGross = UnitPrice * 0.05;
            }
            else
            {
                TaxGross = 0;
            }

        }
            
        public void CalculateNet(double TaxNet)
        {
            TaxNet = UnitPrice;
        }





    }
    
}
