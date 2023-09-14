using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Address
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Street {  get; set; }
        public string City { get; set; }

        public string Province { get; set; }
        public int ZipCode { get; set; }

        public Address(string firstName, string lastName, string street, string city, string province, int zipCode) 
        { 
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Street = street;
            this.City = city;
            this.Province = province;
            this.ZipCode = zipCode;
        }

        public override string ToString()
        {
            return $"L'indirizzo di {this.FirstName} {this.LastName} è: {this.Street}, {this.City}, {this.Province}, {this.ZipCode} ";
        }
    }
}
