using System;
namespace StateDesignPattern
{
    // Concrete States implement various behaviors, associated with a state of the Context Object.
    // The following Concrete State class implement behavior when the ATM State i.e. Context Object State is DebitCardNotInsertedState
    public class DebitCardNotInsertedState : IATMState
    {
        public void InsertDebitCard()
        {
            Console.WriteLine("DebitCard Inserted");
        }

        public void EjectDebitCard()
        {
            Console.WriteLine("You cannot eject the Debit CardNo, as no Debit Card in ATM Machine slot");
        }

        public void EnterPin()
        {
            Console.WriteLine("you cannot enter the pin, as No Debit Card in ATM Machine slot");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("you cannot withdraw money, as No Debit Card in ATM Machine slot");
        }
    }
}