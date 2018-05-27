namespace kolokwium
{
    public abstract class Payment 
    {
       private int PaymentAmount;


        public virtual void Pay(Order order)
        {

        }

        public virtual void PrintConfirmation()
        {

        }
    }
    
}