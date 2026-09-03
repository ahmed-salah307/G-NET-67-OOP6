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

        }
    }
}
