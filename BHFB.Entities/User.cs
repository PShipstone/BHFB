using System;

namespace BHFB.Entities
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedById { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int UpdatedOnId { get; set; }
    }
}
