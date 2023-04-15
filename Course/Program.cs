namespace Course;
using Course.Entities;
class Program
{
    /*
       - Not recommended solution.
       - Bad solution - returning a string from a method 

       There is a method from Reservation class, called UpdateDates, that may return a string error to the Main class.

       Why is it a bad solution ?
       Reasons:
       1) The semantics of the operation are impaired. Returning a string has nothing to do with updating the reservation. What if operation had to return a string (and not an error)? Just imagine a method that must return a string. This string would conflict with the error message string.
       2) Besides, it's not possible to handle exceptions in constructors in this way, because a constructor can't return a string. Thus, I still had to keep reservation logic in the Main program. But reservation logic must be in the Reservation class.
       3) Logic is restricted to nested conditionals.

    */
    static void Main(string[] args)
    {
        Console.Write("Room number: ");
        int roomNumber = int.Parse(Console.ReadLine());
        Console.Write("Check-in date (dd/MM/yyyy): ");
        DateTime checkIn = DateTime.Parse(Console.ReadLine());
        Console.Write("Check-out date (dd/MM/yyyy): ");
        DateTime checkOut = DateTime.Parse(Console.ReadLine());

        // reservation logic is still in the Main class (not recommended)
        if (checkOut <= checkIn)
        {
            Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
        }
        else
        {
            /*
              A reservation construct can't return a string (error message). So, the above logic had to be maintained.
            */   
            Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine();

            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            // returning a possible error in reservation.
            string error  = reservation.UpdateDates(checkIn, checkOut);

            if(error != null ){
                System.Console.WriteLine("Error in reservation: " + error);
            }
            else
            { 
                Console.WriteLine("Reservation: " + reservation);
            }
        }
    }
}
