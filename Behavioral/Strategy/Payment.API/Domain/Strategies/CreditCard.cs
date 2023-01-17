using Strategy.Payment.Contracts;

namespace Strategy.Payment.Strategies;

internal class CreditCard : IPaymentStrategy
{
   public EPaymentType Type { get; }

   public CreditCard()
   {
      Type = EPaymentType.CreditCard;
   }

   public bool execute(object data)
   {
      throw new NotImplementedException();
   }
}
