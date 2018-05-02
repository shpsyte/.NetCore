namespace ValueObject.VO
{
    public class Document
    {
        public string DocumentNumber { get; private set; }
        public bool isValidDoc => !string.IsNullOrEmpty(this.DocumentNumber);
    }

}