namespace BusinessLayer
{
    public class Address
    {
        public string Street { get; private set; }
        public string Housenumber { get; private set; }
        public string Addendum { get; private set; }
        public string City { get; private set; }
        public string PostalCode { get; private set; }

        public Address(string street, string housenumber, string city, string postalCode)
        {
            Street = street;
            Housenumber = housenumber;
            City = city;
            PostalCode = postalCode;
        }
        public Address(string street, string housenumber, string addendum, string city, string postalCode)
        {
            Street = street;
            Housenumber = housenumber;
            Addendum = addendum;
            City = city;
            PostalCode = postalCode;
        }
    }
}