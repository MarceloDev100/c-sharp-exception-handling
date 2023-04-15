using System.Text;

namespace Course.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return duration.Days;
           //TimeSpan duration = CheckOut.Subtract(CheckIn);
           //return (int) duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn , DateTime checkOut)
        {
             CheckIn = checkIn;
             CheckOut = checkOut;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Room ");
            sb.Append(RoomNumber);
            sb.Append(", check-in: ");
            sb.Append(CheckIn.ToString("dd/MM/yyyy"));
            sb.Append(", check-out: ");
            sb.Append(CheckOut.ToString("dd/MM/yyyy"));
            sb.Append(", ");
            sb.Append(Duration().ToString());
            sb.AppendLine(" nights");

            return sb.ToString();
        }
    }
}