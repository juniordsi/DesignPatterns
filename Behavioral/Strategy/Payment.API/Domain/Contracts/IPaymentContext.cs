namespace Strategy.Payment.Contracts;

internal interface IPaymentContext
{
   bool process(EPaymentType type, object data);
}