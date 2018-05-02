using ValueObject.VO;

public class Supplier
{
    public int Id { get; private set; }
    public Name Name { get; private set; }
    public Document Document { get; private set; }
    public EmailAddress Email { get; private set; }
    public string MethodShipping { get; private set; }
    public decimal ValueAddOrder { get; private set; }
    public decimal SecurityPrice { get; private set; }

}