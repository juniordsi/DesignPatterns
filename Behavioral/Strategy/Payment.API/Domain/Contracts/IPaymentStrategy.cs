namespace Strategy.Payment.Contracts;

internal interface IPaymentStrategy
{
   EPaymentType Type { get; }

   bool execute(object data);
}