using Strategy.Payment.Contracts;

namespace Strategy.Payment;

internal sealed class PaymentContext : IPaymentContext
{
   private readonly IPaymentResolver _resolver;

   public PaymentContext(IPaymentResolver resolver)
   {
      _resolver = resolver;
   }

   public bool process(EPaymentType type, object data)
   {
      var strategy = _resolver.resolve(type);
      return strategy.execute(data);
   }
}
