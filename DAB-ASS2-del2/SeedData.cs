using DAB_ASS2.Models;
using Microsoft.EntityFrameworkCore;

namespace DAB_ASS2
{
    public class SeedData
    {
        public static void SeedDatabase(DbContext db)
        {

            Console.WriteLine("Seeding database!");

            Chairman chairman1 = new Chairman()
            {
                chairman_name = "John Fraleasy",
                chairman_CPR = 1111111111,
                chairman_address = "Leasyvej 8, 8888 Leasytown"
            };

            Chairman chairman2 = new Chairman()
            {
                chairman_name = "Brian Mokaisken",
                chairman_CPR = 1312131313,
                chairman_address = "Storegade 1 1.th, 8900 Randers C"
            };

            Chairman chairman3 = new Chairman()
            {
                chairman_name = "Einstajn Von Langsom",
                chairman_CPR = 3112111009,
                chairman_address = "Bagvendtgade 321, 9876 Snagvendtstrup"
            };

            db.Add(chairman1);
            db.Add(chairman2);
            db.Add(chairman3);

            Society society1 = new Society()
            {
                society_CVR = 88888888,
                society_name = "Leasy society",
                society_activity = "Leasying stuff",
                society_member_count = 69,
                chairmanid = 1,
                KeyResponsible_Id = 1
            };

            Society society2 = new Society()
            {
                society_CVR = 12345678,
                society_name = "Randers appreciation society",
                society_activity = "Appreciating the city of Randers",
                society_member_count = 420,
                chairmanid = 2,
                KeyResponsible_Id = 2
            };

            Society society3 = new Society()
            {
                society_CVR = 87654321,
                society_name = "Counting backwards society",
                society_activity = "Counting backwards",
                society_member_count = 1337,
                chairmanid = 3,
                KeyResponsible_Id = 3
            };

            db.Add(society1);
            db.Add(society2);
            db.Add(society3);

            Booking booking1 = new Booking()
            {
                booking_from = new DateTime(2022, 12, 13, 22, 30, 0),
                booking_to = new DateTime(2023, 12, 14, 10, 30, 0),
                society_Id = 1,
                room_Id = 1,
            };

            Booking booking2 = new Booking()
            {
                booking_from = new DateTime(2022, 03, 13, 10, 00, 0),
                booking_to = new DateTime(2023, 03, 22, 10, 30, 0),
                society_Id = 2,
                room_Id = 2,
            };

            Booking booking3 = new Booking()
            {
                booking_from = new DateTime(2024, 1, 13, 12, 00, 0),
                booking_to = new DateTime(2025, 8, 14, 23, 59, 0),
                society_Id = 3,
                room_Id = 3,
            };

            db.Add(booking1);
            db.Add(booking2);
            db.Add(booking3);

            Room room1 = new Room()
            {
                room_name = "Leasy HQ",
                room_capacity = 888,
                location_ID = 1,
                
            };

            Room room2 = new Room()
            {
                room_name = "Zwei Grosse",
                room_capacity = 69,
                location_ID = 2,
            };

            Room room3 = new Room()
            {
                room_name = "Room 765",
                room_capacity = 321,
                location_ID = 3,
            };

            db.Add(room1);
            db.Add(room2);
            db.Add(room3);

            RoomProperty roomProperty1 = new RoomProperty()
            {
                room_property_name = "Leasy stuff",
            };

            RoomProperty roomProperty2 = new RoomProperty()
            {
                room_property_name = "Mokai",
            };

            RoomProperty roomProperty3 = new RoomProperty()
            {
                room_property_name = "Backwards Numbers",
            };

            db.Add(roomProperty1);
            db.Add(roomProperty2);
            db.Add(roomProperty3);

            Location location1 = new Location()
            {
                location_address = "Leasystreet 69",
                location_zipcode = 8888,
                location_name = "Leasy HQ's HQ"
            };

            Location location2 = new Location()
            {
                location_address = "Storegade 69",
                location_zipcode = 8900,
                location_name = "Storegade"
            };

            Location location3 = new Location()
            {
                location_address = "BackwardsStreet 987",
                location_zipcode = 1337,
                location_name = "The house of backwards"
            };

            db.Add(location1);
            db.Add(location2);
            db.Add(location3);

            LocationProperty locationProperty1 = new LocationProperty()
            {
                location_property_name = "Leasy things and stuff",
            };

            LocationProperty locationProperty2 = new LocationProperty()
            {
                location_property_name = "Masser af Mokai og nike shocks",
            };

            LocationProperty locationProperty3 = new LocationProperty()
            {
                location_property_name = "Backwards numbers for some reason",
            };

            db.Add(locationProperty1);
            db.Add(locationProperty2);
            db.Add(locationProperty3);

        LocationAccess locationAccess11 = new LocationAccess()
        {
            locationcode = 1234,
            locationId = 1

        };

        LocationAccess locationAccess12 = new LocationAccess()
        {



        };








        Console.WriteLine("Database Seeded");

            db.SaveChanges();

        }


        





    }
}
