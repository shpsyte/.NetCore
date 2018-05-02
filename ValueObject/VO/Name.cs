using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ValueObject.VO
{
    public class Name 
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        

    }

}