using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace oopsLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Circle cir = new Circle();
                //cir.radius = 10;
                //Console.WriteLine("Radius" + cir.radius);
                //cir.radius = -10;

                //2nd

                //Employee emp = new Employee();
                //emp.empName = "Sanju";
                //emp.Salary = 3000;
                //Console.WriteLine("Name" + emp.empName + "\nSalary is " + emp.Salary);
                //emp.Salary = -10;


                //3rd
                //Library libary = new Library();

                //Book bk1 = new Book("The covanent of  water", "Abhraham Vargeese", "123456");
                //libary.AddBook(bk1);
                //Book bk2 = new Book("famous five", "blydon", "5544444");
                //libary.AddBook(bk2);
                //Console.WriteLine("Boks in the library are:");
                //libary.DisplayBooks();
                //libary.RemoveBook("123456");
                //libary.DisplayBooks();


                //4th question

                //Account acc1 = new Account("SBI12344", "SANJITH RAHMAN", 50000);
                //Account acc2 = new Account("SBI145344", "dasarth", 60000);
                //acc1.Deposit(2000);
                //acc2.Deposit(3000);
                //acc1.Withdraw(5000000);
                //acc2.Withdraw(300);


                //5th question

                //student stud1 = new student("Sanju", 1);
                //stud1.addGrade(80);
                //stud1.addGrade(30);
                //stud1.calaculateAverage();

                //6th question
                //Item apple = new Item("Apple", 50, 0.5);
                //Item banana = new Item("Banana", -5, 0.3);
                //Item grapes = new Item("Grapes", 30, 3);
                //Inventory inventory = new Inventory();
                //inventory.AddItem(apple);
                //apple.DisplayDetails();
                //inventory.AddItem(grapes);
                //grapes.DisplayDetails();
                //inventory.RemoveItem("grapes");
                //inventory.UpdateItem("Apple", 60, 1);
                //apple.DisplayDetails();



                //7th question

                //List<Product> productList = new List<Product>();
                //Product prd1 = new Product("mobile phones", 20000, 50);

                //Product prd2 = new Product("tv", 44000, 60);
                //productList.Add(prd1);
                //prd1.DisplayDetails();
                //productList.Add(prd2);
                //prd2.DisplayDetails();
                //Order order1 = new Order("mobile phones", 30);
                //order1.PlaceOrder(productList);

                //8th

                //Print pr = new Print();
                //pr.PrintData("Hello kochi");
                //pr.PrintData(123);
                //int[] a = { 1, 33, 6, 8, 9 };
                //pr.PrintData(a);

                //9th
                //Rectangle rect = new Rectangle();
                //rect.area(10, 20);
                //rect.area(10);

                //10th
                //Time time = new Time();
                //time.WriteTime(36000);
                //time.WriteTime(10, 30);

                //11-static fields;

                //Bank myBankAccount = new Bank(1000.00);

                //12
                //Car car1 = new Car();
                //Car car2 = new Car();
                //Car car3 = new Car();


                //13;
                //MathOperations Ops = new MathOperations();
                //MathOperations.CalcArea(6);

                ////14
                //Console.WriteLine($"Apptication in background:{SystemConfig.AppName}");
                //Console.WriteLine($"Version{SystemConfig.Version}");
                //SystemConfig sys = new SystemConfig("appleos", 16);

                //15

                //MobilePhone ph1 = new MobilePhone("Samsung", "Galaxy S21");
                //ph1.DisplayDetails();
                ////creating reference copy
                //MobilePhone referencePhone = ph1;
                ////creating a copy
                //MobilePhone ph2 = new MobilePhone(ph1);
                ////modifyiung the reference
                //referencePhone.Brand = "xiomi";
                //referencePhone.Modal = "note 7 pro";

                //Console.WriteLine("after modyfing the reference copy");

                //ph1.DisplayDetails();
                //Console.WriteLine("Deep copy changes");
                //ph2.DisplayDetails();

                //16
                //BookDetails book1 = new BookDetails("The covananent of water");
                //book1.DisplayDetails();
                //BookDetails book2 = new BookDetails("the alchemist", "paulo coelo");
                //book2.DisplayDetails();
                //BookDetails book3 = new BookDetails("The matilda", "Rihl dhal", 500);
                //book3.DisplayDetails();
                //BookDetails book4 = new BookDetails("The famous five", "end blydon", 900, 1960);
                //book4.DisplayDetails();


                //17

                //ProductDetails prd1 = new ProductDetails("watch");
                //ProductDetails prd2 = new ProductDetails("Mobile Phone", 20000);
                //ProductDetails prd3 = new ProductDetails("tv", 440000, 15);
                //prd1.CalculatePrice();
                //prd1.DisplayDetails();
                //prd2.DisplayDetails();

                //prd3.DisplayDetails();
                //prd3.CalculatePrice();


                //18
               // // 1. Constructor initialization
               // ProductCategory product1 = new ProductCategory("Laptop", 999.99, "Electronics");
               // product1.DisplayDetails();

               // // 2. Object initializer syntax
               // ProductCategory product2 = new ProductCategory { Name = "Chair", Price = 49.99, Category = "Furniture" };
               // product2.DisplayDetails();

               // // 3. Static factory method
               // ProductCategory product3 = ProductCategory.Create("Coffee", 3.99, "Beverage");
               // product3.DisplayDetails();

               // //4.Anonymous types
               //var anonymousProduct = new
               //{Name = "Pen",Price = 1.50,Category = "Stationery"};
               // Console.WriteLine($"Anonymous Product - Name: {anonymousProduct.Name}, Price: {anonymousProduct.Price}, Category: {anonymousProduct.Category}");

               // //5.Reflection to create a ProductCategory object
               //Type productType = typeof(ProductCategory);
               // ProductCategory product4 = (ProductCategory)Activator.CreateInstance(productType, "Tablet", 299.99, "Electronics");
               // product4.DisplayDetails();


                //19.

                //ShoppingCart cart = new ShoppingCart();
                //cart.AddProduct("Laptop", 10000, 1);
                //cart.AddProduct("Mouse", 2000, 2);
                //cart.AddProduct("Keyboard", 5555, 1);

                //cart.DisplayCart();
                //cart.CalculatePr();

                //20.
                //BankDetails sbi = new BankDetails();
                //sbi.AddCustomer("sanju");
                //sbi.AddCustomer("Nihad");
                //sbi.AddAccount("sanju", "sbi3332", 9000);
                //sbi.AddAccount("Nihad", "sbi77788", 100000);
                //sbi.DisplayDetails();

                //21,
                //university ktu = new university();
                //ktu.AddDepartment("Computer Science");
                //ktu.AddDepartment("Mathematics");
                //ktu.AddCourse("Computer Science", "c programming", "cs777", 3);
                //ktu.AddCourse("Computer Science", "python  programming", "cs7000", 4);
                //ktu.AddCourse("Mathematics", "calculus", " mat201", 4);
                //ktu.DisplayDetails();























































            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);


            }

            Console.ReadLine();
        }
    }
}
