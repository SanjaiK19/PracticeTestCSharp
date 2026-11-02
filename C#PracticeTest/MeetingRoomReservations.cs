using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class RoomBooking
    {
        public int RoomNumber;
        public DateTime StartTime;
        public int Duration;
        public string Organizer;

        public bool IsValid(int RoomNumber, int Duration)
        {
            if (RoomNumber > 0 && Duration > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void displayBookingDetails()
        {
            Console.WriteLine($"Room Number: {RoomNumber}");
            Console.WriteLine($"Start Time: {StartTime}");
            Console.WriteLine($"Duration: {Duration} minutes");
            Console.WriteLine($"Organizer: {Organizer}");
        }
        public RoomBooking(int roomNumber, DateTime startTime, int duration, string organizer)
        {
            if (!IsValid(roomNumber, duration))
            {
                throw new ArgumentException("Invalid room booking parameters.");
            }
            RoomNumber = roomNumber;
            StartTime = startTime;
            Duration = duration;
            Organizer = organizer;
        }
        public RoomBooking(int roomNumber, DateTime startTime, int duration)
        {
            if (!IsValid(roomNumber, duration))
            {
                throw new ArgumentException("Invalid room booking parameters.");
            }
            RoomNumber = roomNumber;
            StartTime = startTime;
            Duration = duration;
            Organizer = "Unassigned";
        }
        public RoomBooking(int roomNumber, DateTime startTime)
        {
            if (!IsValid(roomNumber, 30))
            {
                throw new ArgumentException("Invalid room booking parameters.");
            }
            RoomNumber = roomNumber;
            StartTime = startTime;
            Duration = 30;
            Organizer = "Unassigned";
        }
    }

    public class MeetingRoomReservations
    {
        public static void Main()
        {
            RoomBooking booking1 = new RoomBooking(101, DateTime.Now, 60, "Aadhi");
            RoomBooking booking2 = new RoomBooking(102, DateTime.Now.AddHours(1), 45);
            RoomBooking booking3 = new RoomBooking(103, DateTime.Now.AddHours(2));

            booking1.displayBookingDetails();
            Console.WriteLine();
            booking2.displayBookingDetails();
            Console.WriteLine();
            booking3.displayBookingDetails();

        }
    }
}
