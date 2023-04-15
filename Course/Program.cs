namespace Course;
using Course.Entities;
using Course.Entities.Exceptions;
class Program
{
    /*
       - Recommended solution
       - Very good solution - creating a custom exception. 

       A custom exception can be created when extending an ApplicationException class.
       It was created in the project, a DomainException class which extends ApplicationException class.
       Note that this way code is more organized, concise and having a linear execution. There is no nested "if-else" statements and code is more readable.
       Exception handling logic is delegated to the Reservation class, what is expected. Validation logic is done by UpdateDate method and the constructor of the Reservation class.
       If an exception is thrown, run is interrupted and it is captured in the corresponding catch block.
       
    */
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());


            Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine();

            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            reservation.UpdateDates(checkIn, checkOut);

            Console.WriteLine("Reservation: " + reservation);

        }
        catch (DomainException e)
        {
            Console.WriteLine("Error in reservation: " + e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Format error: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected error: " + e.Message);
        }
    }
}
