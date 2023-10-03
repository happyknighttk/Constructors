using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer() {Id=1, City= "Istanbul", FirstName="Tolga", LastName="Kayış"}; Default constructor ile çalışır
            Customer customer2 = new Customer(2, "Ross", "Geller", "New York");
        }
    }
    class Customer
    {
        //default constructor public Customer() { } 
        public Customer(int id, string Firstname, string Lastname, string city) {
            Console.WriteLine("Yapıcı blok calıstı");
            Id = id;
            FirstName = Firstname;
            LastName = Lastname;
            City = city;
            Console.WriteLine(Id + " " + FirstName + " " + LastName + " " + City);
        } 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
