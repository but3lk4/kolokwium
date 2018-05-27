
namespace kolokwium

{
    class Credit : Payment
    {
        public byte NumberOfInstallments { get; set; }
        public string Bank { get; set; }
        public float AnnualInterestRate { get; set; }

        public override void Pay(Order order)
        {
            throw new System.NotImplementedException();

        }

        public override void PrintConfirmation()
        {
            throw new System.NotImplementedException();
        }
    }
}