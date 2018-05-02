namespace ValueObject.VO
{
    public class EmailAddress
    {
        public string Email { get; private set; }
        public bool isValidEmail => !string.IsNullOrEmpty(this.Email);
    }

}