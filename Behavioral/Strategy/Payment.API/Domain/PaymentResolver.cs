using Strategy.Payment.Contracts;

namespace Strategy.Payment;

internal class PaymentResolver : IPaymentResolver
{
   private readonly IEnumerable<IPaymentStrategy> _strategies;

   public PaymentResolver(IEnumerable<IPaymentStrategy> strategies)
   {
      _strategies = strategies;
   }

   public IPaymentStrategy resolve(EPaymentType type)
   {
      var strategy = _strategies.FirstOrDefault(x => x.Type.Equals(type));

      if (strategy is null)
         throw new NotImplementedException();
      
      return strategy;
   }
}
