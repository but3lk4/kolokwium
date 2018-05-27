namespace kolokwium
{
    class Transfer : Payment
    {
        public string BankAccount { get; set; }
        public string PaymentTitle { get; set; }


        public override void Pay(Order order)
        {
            
        }

        public override void PrintConfirmation()
        {
            
        }
    }
}