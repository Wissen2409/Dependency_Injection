public class Helper : IHelper
{

    public IPayment _payment;
    public Helper(IPayment payment)
    {
        _payment = payment;
    }
    public string SayHello()
    {
        // Payment sınıfını entegre ettik kullanalım

        string payReturnValue = _payment.Pay();

        return "Hello";
    }
}
public interface IHelper
{
    public string SayHello();
}