namespace Strategy.Payment.Contracts;

internal interface IPaymentResolver
{
   IPaymentStrategy resolve(EPaymentType type);
}