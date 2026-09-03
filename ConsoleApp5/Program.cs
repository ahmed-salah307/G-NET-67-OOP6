using CinemaSystem;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
            Abstraction is about hiding complexity and essential background details 
            while exposing only the necessary interface to the user


Encapsulation is about bundling data and methods operating
            on that data into a single unit(class) and restricting direct 
            access to internal state using access modifiers like private or protected 

            Real World Example

            Atmospheric Weather Station

            Pressing a "Get Temperature" button on a digital weather console You get the temperature display instantly
            without needing to know how the thermistor calculates voltage drop => (Abstraction)

            The inner circuit board, thermal sensors, and raw voltage data are sealed inside
            a  weatherproof casing with private fields, You interact only through exposed public methods or properties like GetTemperatureInCelsius()
             preventing external tampering with critical sensor calibration variables =>(Encapsulation)


             */

            #endregion
            #region Q2
            /*
             
             Abstract Class   :
            Supports single inheritance (class A : B)
            Can contain instance fields, constructors, and state
            Members can have public, protected, private, etc
            Can provide fully implemented methods alongside abstract ones


            Interface
            Supports multiple inheritance (class A : B, C, D)
            Cannot contain instance fields or constructors (stateless contract)
            Members are traditionally public contract declarations
            Primarily defines signatures (though modern C# allows default implementations, state is omitted)


            When to Choose Which:

Choose an Abstract Class when classes share a strong "IS-A" relationship


            Choose an Interface when defining a "CAN-DO'
             

             
             
             */
            #endregion
            #region Q3
            /*
             
            A) No, it will cause a compilation error.

Concept: Appliance is declared as an abstract clas
            Abstract classes cannot be instantiated directly using new because they represent 
            an incomplete specification
             

            b) No, it will cause a compilation error.

Concept: Appliance is declared as an abstract class
            Abstract classes cannot be instantiated directly
            using new because they represent an incomplete specification


            c)
            Returns "Standby"

Why 
            Toaster does not override Status(), so C# executes the base virtual implementation defined in Appliance
             
             
             */
            #endregion
            #region Q4
            /*
             a) Partial Class:

Concept: A partial class allows the definition of a single class to be split across multiple .cs files. The compiler merges them into one class during compilation

Why Split: Separation of concerns  and multi-developer collaboration on the same class without merge conflicts





   b) Partial Method:

 Concept; A partial method has its declaration in one partial class file and an optional implementation in another

If OnCalculated() in Calculator.Logging.cs is deleted: The code will still compile successfully, If no implementation is provided, the C# compiler removes the method signature and all calls to it at compile time with zero performance overhead



     c) Extension Method & Rules



Concept; Enables adding new methods to existing types without modifying their source code or inheriting from them

  Three Rules

The class containing the method must be static

The method itself must be static

The first parameter must use the this keyword before the target type 




d) Output of the execution block:

Calculation: 19.5 + 0.5 = 20.0

Output: $20.00 (due to ToCurrency() formatting "{value:F2}")
             
             */
            #endregion
            #region PROJECT


            Cinema cinema = new Cinema();
            cinema.OpenCinema();

            // a. Proving abstract class instantiation failure:
            // Ticket t = new Ticket("Test", 100); // ERROR: Cannot create instance of abstract type 'Ticket'

            // b. Create one of each ticket type with hardcoded data & book them
            StandardTicket t1 = new StandardTicket("Inception", 80, "A5");
            VipTicket t2 = new VipTicket("Avengers", 200, true, 50);
            ImaxTicket t3 = new ImaxTicket("Dune", 130, true);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.BookAllTickets();

            // c. Print all tickets via Cinema's reporting file
            cinema.PrintAllTickets();

            // d. Demonstrate Polymorphism
            Console.WriteLine("--- Polymorphism: Final Price per Ticket ---");
            Ticket[] ticketsArray = cinema.GetTicketsArray();
            foreach (var ticket in ticketsArray)
            {
                Console.WriteLine($"{ticket.GetType().Name} => Final Price: {ticket.CalculateFinalPrice():F2}");
            }
            Console.WriteLine();

            // e. Call Extension Method: Generate Receipt on a single ticket (VIP)
            Console.WriteLine("--- Extension Method: Receipt ---");
            Console.WriteLine(t2.GenerateReceipt());
            Console.WriteLine();

            // f. Call Extension Method: Calculate Total Revenue on ticket array
            Console.WriteLine("--- Extension Method: Total Revenue ---");
            Console.WriteLine($"Total Revenue: {ticketsArray.CalculateTotalRevenue():F2}\n");

            // g. Close Cinema
            cinema.CloseCinema();


            #endregion

        }
    }
}
