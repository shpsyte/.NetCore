using ValueObject.VO;

public class Customer
{
    public int Id { get; private set; }
    public Name Name { get; private set; }    
    public Document Document { get; private set; }
    public string Address { get; private set; }
    public EmailAddress EmailAddress { get; private set; }
    public string Note { get; private set; }
    public bool IsDeleted { get; private set; }
    

}