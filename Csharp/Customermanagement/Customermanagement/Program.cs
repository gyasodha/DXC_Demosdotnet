using System.Security.Cryptography.X509Certificates;

namespace Customermanagement
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public double PHno { get; set; }
        public string city { get; set; }


    }
    class CustManagement
    {
        List<Customer> Cust;
        public int ID = 3;
        public CustManagement()
        {
            Cust = new List<Customer>()
            {
                new Customer { Id = 1, FirstName="Megha", LastName="Sri", EmailId="megha@dxc.com", PHno=123456789d, city="HYd"  },
                new Customer { Id = 2, FirstName="kalyan", LastName="ram" , EmailId="ram@dxc.com", PHno=5656712561d, city="manglore" },

            };
        }
        public void AddCustomer()
        {
            Console.WriteLine("Enter Customer FirstName");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Customer LastName");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Product EmailId");
            string EmailId = (Console.ReadLine());
            Console.WriteLine("Enter the Phonenumber");
            double Phno = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the city");
            string city = Console.ReadLine();
            int id = ID++;
            Cust.Add(new Customer() {Id=id, FirstName = FirstName, LastName = LastName, EmailId = EmailId, PHno = Phno, city = city });

            
            
        }
        public Customer GetCustomer(int id)
        {
            foreach (Customer customer in Cust)
            {
                if (customer.Id == id)
                    return customer;
            }
            return null;
        }
        public List<Customer> GetCustomers()
        {
            return Cust;
        }
        public void UpdateCustomer(int id)
        {

            foreach (var cust in Cust)
            {
                if (cust.Id == id)
                {
                   Console.WriteLine("Enter the updated customer first name");
                   cust.FirstName = Console.ReadLine();
                   Console.WriteLine("Enter the updated customer Last name");
                   cust.LastName = Console.ReadLine();
                    Console.WriteLine("Enter the updated customer EmailId");
                    cust.EmailId = Console.ReadLine();
                    Console.WriteLine("Enter the updated customer PHno");
                    cust.PHno = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the updated customer city");
                    cust.city = Console.ReadLine();
                    Console.WriteLine("Customer Details updated Succesfully");
                }
            }
        }
        public bool DeleteCustomer(int id)
        {
                foreach (Customer c in Cust)
                {
                    if (c.Id == id)
                    {
                        Cust.Remove(c);
                        return true;
                    }
                }
                return false;
            
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                CustManagement obj = new CustManagement();
                string ans = "";
                do
                {
                    Console.WriteLine("Welcome to Customer Management App");
                    Console.WriteLine("1. Add Customer");
                    Console.WriteLine("2. Get Customer By Id");
                    Console.WriteLine("3. Get All Customer");
                    Console.WriteLine("4. Delete Customer By Id");
                    Console.WriteLine("5. Update Customer By Id");
                    int choice = Convert.ToInt16(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {

                                obj.AddCustomer();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Enter Customer Id");
                                int id = Convert.ToInt16(Console.ReadLine());
                                Customer? c = obj.GetCustomer(id);
                                if (c == null)
                                {
                                    Console.WriteLine("The entered Cutomer Id does not exist");
                                }
                                else
                                {
                                    Console.WriteLine($"{c.Id} {c.FirstName} {c.LastName} {c.EmailId} {c.PHno} {c.city}");
                                }
                                break;
                            }
                        case 3:
                            {
                                foreach (var c in obj.GetCustomers())
                                {
                                    Console.WriteLine($"{c.Id} {c.FirstName} {c.LastName} {c.EmailId} {c.PHno} {c.city}");
                                }
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Enter Customer Id");
                                int id = Convert.ToInt16(Console.ReadLine());
                                if (obj.DeleteCustomer(id))
                                {
                                    Console.WriteLine("Customer deleted Successfully");
                                }
                                else
                                {
                                    Console.WriteLine("Customer Id which u have entered doesnot exist");
                                }
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Enter the Customer Id");
                                int id = Convert.ToInt16(Console.ReadLine());
                                obj.UpdateCustomer(id);
                                break;
                            }
                    }
                    
                    Console.WriteLine("Do you wish to continue? [y/n] ");
                    ans = Console.ReadLine();
                } while (ans.ToLower() == "y");
            }
        }
    }
}