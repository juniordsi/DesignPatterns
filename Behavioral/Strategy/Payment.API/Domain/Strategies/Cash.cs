using Strategy.Payment.Contracts;

namespace Strategy.Payment.Strategies;

internal class Cash : IPaymentStrategy
{
   public EPaymentType Type { get ; }

   public Cash()
   {
      Type = EPaymentType.Cash;
   }

   public bool execute(object data)
   {
      throw new NotImplementedException();
   }
}