using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WalletPlus.web.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public GenderEnum Gender { get; set; }

        public MaritalStatusEnum MaritalStatus { get; set; }
        public string Country { get; set; }

        public string State { get; set; }
        public string City { get; set; }




    }
}
