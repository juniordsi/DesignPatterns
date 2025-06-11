using Strategy.Payment;
using Strategy.Payment.Strategies;
using Strategy.Payment.Contracts;
using Xunit;

namespace Payment.Tests;

public class PaymentResolverTests
{
    [Fact]
    public void Resolve_ReturnsCashStrategy_WhenTypeIsCash()
    {
        IPaymentStrategy[] strategies = { new Cash(), new CreditCard() };
        var resolver = new PaymentResolver(strategies);

        var result = resolver.resolve(EPaymentType.Cash);

        Assert.IsType<Cash>(result);
    }

    [Fact]
    public void Resolve_ReturnsCreditCardStrategy_WhenTypeIsCreditCard()
    {
        IPaymentStrategy[] strategies = { new Cash(), new CreditCard() };
        var resolver = new PaymentResolver(strategies);

        var result = resolver.resolve(EPaymentType.CreditCard);

        Assert.IsType<CreditCard>(result);
    }
}
