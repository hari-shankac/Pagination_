namespace PaginationMVc_Core.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string Country { get; set; }
    }

    public class AllEmployee
    {
        private List<Employee> emp = new List<Employee>()
        {
            new Employee { id = 1, name = "John Doe", email = "john.doe@example.com", phoneNumber = "123-456-7890", address = "123 Main St", city = "Anytown", state = "CA", Country = "USA" },
        new Employee { id = 2, name = "Jane Smith", email = "jane.smith@example.com", phoneNumber = "234-567-8901", address = "456 Elm St", city = "Othertown", state = "NY", Country = "USA" },
        new Employee { id = 3, name = "Alice Johnson", email = "alice.johnson@example.com", phoneNumber = "345-678-9012", address = "789 Oak St", city = "Newville", state = "TX", Country = "USA" },
        new Employee { id = 4, name = "Bob Brown", email = "bob.brown@example.com", phoneNumber = "456-789-0123", address = "567 Pine St", city = "Smalltown", state = "AZ", Country = "USA" },
        new Employee { id = 5, name = "Ella Davis", email = "ella.davis@example.com", phoneNumber = "567-890-1234", address = "890 Cedar St", city = "Hometown", state = "IL", Country = "USA" },
        new Employee { id = 6, name = "George Wilson", email = "george.wilson@example.com", phoneNumber = "678-901-2345", address = "345 Birch St", city = "Newtown", state = "FL", Country = "USA" },
        new Employee { id = 7, name = "David Lee", email = "david.lee@example.com", phoneNumber = "789-012-3456", address = "678 Oak St", city = "Othertown", state = "NJ", Country = "USA" },
        new Employee { id = 8, name = "Grace Turner", email = "grace.turner@example.com", phoneNumber = "890-123-4567", address = "456 Maple St", city = "Smallville", state = "WA", Country = "USA" },
        new Employee { id = 9, name = "Henry Hall", email = "henry.hall@example.com", phoneNumber = "901-234-5678", address = "567 Walnut St", city = "Downtown", state = "GA", Country = "USA" },
        new Employee { id = 10, name = "Isabella Clark", email = "isabella.clark@example.com", phoneNumber = "012-345-6789", address = "890 Pine St", city = "Uptown", state = "NC", Country = "USA" },
        new Employee { id = 11, name = "Jack Harris", email = "jack.harris@example.com", phoneNumber = "123-456-7890", address = "123 Cedar St", city = "Midtown", state = "VA", Country = "USA" },
        new Employee { id = 12, name = "Katherine White", email = "katherine.white@example.com", phoneNumber = "234-567-8901", address = "345 Birch St", city = "Newtown", state = "OH", Country = "USA" },
        new Employee { id = 13, name = "Liam Baker", email = "liam.baker@example.com", phoneNumber = "345-678-9012", address = "567 Elm St", city = "Hometown", state = "LA", Country = "USA" },
        new Employee { id = 14, name = "Mia Green", email = "mia.green@example.com", phoneNumber = "456-789-0123", address = "789 Cedar St", city = "Cityville", state = "MS", Country = "USA" },
        new Employee { id = 15, name = "Noah Taylor", email = "noah.taylor@example.com", phoneNumber = "567-890-1234", address = "890 Oak St", city = "Villagetown", state = "OR", Country = "USA" },
        new Employee { id = 16, name = "Olivia Martinez", email = "olivia.martinez@example.com", phoneNumber = "678-901-2345", address = "123 Maple St", city = "Newburg", state = "OK", Country = "USA" },
        new Employee { id = 17, name = "Patrick Garcia", email = "patrick.garcia@example.com", phoneNumber = "789-012-3456", address = "456 Walnut St", city = "Smalltown", state = "NM", Country = "USA" },
        new Employee { id = 18, name = "Quinn Miller", email = "quinn.miller@example.com", phoneNumber = "890-123-4567", address = "567 Pine St", city = "Othertown", state = "KY", Country = "USA" },
        new Employee { id = 19, name = "Ryan Lewis", email = "ryan.lewis@example.com", phoneNumber = "901-234-5678", address = "789 Birch St", city = "Midtown", state = "KS", Country = "USA" },
        new Employee { id = 20, name = "Sophia Wilson", email = "sophia.wilson@example.com", phoneNumber = "012-345-6789", address = "234 Cedar St", city = "Uptown", state = "NH", Country = "USA" },
        new Employee { id = 21, name = "Thomas Scott", email = "thomas.scott@example.com", phoneNumber = "123-456-7890", address = "567 Elm St", city = "Downtown", state = "IA", Country = "USA" },
        new Employee { id = 22, name = "Uma Turner", email = "uma.turner@example.com", phoneNumber = "234-567-8901", address = "678 Oak St", city = "Smallville", state = "SC", Country = "USA" },
        new Employee { id = 23, name = "Vincent Harris", email = "vincent.harris@example.com", phoneNumber = "345-678-9012", address = "890 Walnut St", city = "Hometown", state = "NE", Country = "USA" },
        new Employee { id = 24, name = "Willow Young", email = "willow.young@example.com", phoneNumber = "456-789-0123", address = "234 Cedar St", city = "Cityville", state = "WV", Country = "USA" },
        new Employee { id = 25, name = "Xander Martinez", email = "xander.martinez@example.com", phoneNumber = "567-890-1234", address = "456 Elm St", city = "Villagetown", state = "WI", Country = "USA" },
        new Employee { id = 26, name = "Yara Jackson", email = "yara.jackson@example.com", phoneNumber = "678-901-2345", address = "789 Maple St", city = "Newburg", state = "ID", Country = "USA" },
        new Employee { id = 27, name = "Zane Brown", email = "zane.brown@example.com", phoneNumber = "789-012-3456", address = "890 Oak St", city = "Smalltown", state = "ME", Country = "USA" },
        new Employee { id = 28, name = "Amelia Adams", email = "amelia.adams@example.com", phoneNumber = "890-123-4567", address = "123 Pine St", city = "Othertown", state = "ND", Country = "USA" },
        new Employee { id = 29, name = "Benjamin Clark", email = "benjamin.clark@example.com", phoneNumber = "901-234-5678", address = "234 Birch St", city = "Midtown", state = "SD", Country = "USA" },
        new Employee { id = 30, name = "Charlotte Davis", email = "charlotte.davis@example.com", phoneNumber = "012-345-6789", address = "567 Cedar St", city = "Uptown", state = "RI", Country = "USA" },
        new Employee { id = 31, name = "Daniel Evans", email = "daniel.evans@example.com", phoneNumber = "123-456-7890", address = "678 Elm St", city = "Downtown", state = "VT", Country = "USA" },
        new Employee { id = 32, name = "Evelyn Foster", email = "evelyn.foster@example.com", phoneNumber = "234-567-8901", address = "123 Main St", city = "Hometown", state = "MT", Country = "USA" },
        new Employee { id = 33, name = "Finn Green", email = "finn.green@example.com", phoneNumber = "345-678-9012", address = "456 Oak St", city = "Cityville", state = "HI", Country = "USA" },
        new Employee { id = 34, name = "Grace Harris", email = "grace.harris@example.com", phoneNumber = "456-789-0123", address = "567 Cedar St", city = "Villagetown", state = "WY", Country = "USA" },
        new Employee { id = 35, name = "Henry Smith", email = "henry.smith@example.com", phoneNumber = "567-890-1234", address = "890 Elm St", city = "Newburg", state = "NH", Country = "USA" },
        new Employee { id = 36, name = "Isabella Turner", email = "isabella.turner@example.com", phoneNumber = "678-901-2345", address = "123 Walnut St", city = "Smalltown", state = "AR", Country = "USA" },
        new Employee { id = 37, name = "Jack Wilson", email = "jack.wilson@example.com", phoneNumber = "789-012-3456", address = "234 Elm St", city = "Othertown", state = "VT", Country = "USA" },
        new Employee { id = 38, name = "Katherine Young", email = "katherine.young@example.com", phoneNumber = "890-123-4567", address = "567 Main St", city = "Midtown", state = "NV", Country = "USA" },
        new Employee { id = 39, name = "Liam Adams", email = "liam.adams@example.com", phoneNumber = "901-234-5678", address = "789 Oak St", city = "Uptown", state = "DE", Country = "USA" },
        new Employee { id = 40, name = "Mia Clark", email = "mia.clark@example.com", phoneNumber = "012-345-6789", address = "234 Pine St", city = "Hometown", state = "AK", Country = "USA" },
        new Employee { id = 41, name = "Noah Baker", email = "noah.baker@example.com", phoneNumber = "123-456-7890", address = "456 Maple St", city = "Cityville", state = "VT", Country = "USA" },
        new Employee { id = 42, name = "Olivia Evans", email = "olivia.evans@example.com", phoneNumber = "234-567-8901", address = "567 Cedar St", city = "Downtown", state = "ND", Country = "USA" },
        new Employee { id = 43, name = "Patrick Foster", email = "patrick.foster@example.com", phoneNumber = "345-678-9012", address = "678 Elm St", city = "Villagetown", state = "NE", Country = "USA" },
        new Employee { id = 44, name = "Quinn Green", email = "quinn.green@example.com", phoneNumber = "456-789-0123", address = "890 Oak St", city = "Newburg", state = "SD", Country = "USA" },
        new Employee { id = 45, name = "Ryan Hall", email = "ryan.hall@example.com", phoneNumber = "567-890-1234", address = "123 Cedar St", city = "Smalltown", state = "WV", Country = "USA" },
        new Employee { id = 46, name = "Sophia Harris", email = "sophia.harris@example.com", phoneNumber = "678-901-2345", address = "234 Birch St", city = "Othertown", state = "DE", Country = "USA" },
        new Employee { id = 47, name = "Thomas Jackson", email = "thomas.jackson@example.com", phoneNumber = "789-012-3456", address = "567 Elm St", city = "Midtown", state = "ME", Country = "USA" },
        new Employee { id = 48, name = "Uma Martinez", email = "uma.martinez@example.com", phoneNumber = "890-123-4567", address = "789 Cedar St", city = "Hometown", state = "NH", Country = "USA" },
        new Employee { id = 49, name = "Vincent Turner", email = "vincent.turner@example.com", phoneNumber = "901-234-5678", address = "456 Pine St", city = "Newville", state = "RI", Country = "USA" },
        new Employee { id = 50, name = "Willow Young", email = "willow.young@example.com", phoneNumber = "012-345-6789", address = "567 Elm St", city = "Othertown", state = "NV", Country = "USA" },
        new Employee { id = 51, name = "Xander Clark", email = "xander.clark@example.com", phoneNumber = "123-456-7890", address = "678 Cedar St", city = "Downtown", state = "ID", Country = "USA" },
        new Employee { id = 52, name = "Yara Davis", email = "yara.davis@example.com", phoneNumber = "234-567-8901", address = "123 Oak St", city = "Cityville", state = "VT", Country = "USA" },
        new Employee { id = 53, name = "Zane Foster", email = "zane.foster@example.com", phoneNumber = "345-678-9012", address = "567 Pine St", city = "Smalltown", state = "NE", Country = "USA" },
        new Employee { id = 54, name = "Amelia Garcia", email = "amelia.garcia@example.com", phoneNumber = "456-789-0123", address = "890 Elm St", city = "Hometown", state = "SD", Country = "USA" },
        new Employee { id = 55, name = "Benjamin Green", email = "benjamin.green@example.com", phoneNumber = "567-890-1234", address = "234 Cedar St", city = "Midtown", state = "WY", Country = "USA" },
        new Employee { id = 56, name = "Charlotte Hall", email = "charlotte.hall@example.com", phoneNumber = "678-901-2345", address = "456 Main St", city = "Uptown", state = "NH", Country = "USA" },
        new Employee { id = 57, name = "Daniel Harris", email = "daniel.harris@example.com", phoneNumber = "789-012-3456", address = "123 Pine St", city = "Newburg", state = "ME", Country = "USA" },
        new Employee { id = 59, name = "Employee 59", email = "employee59@example.com", phoneNumber = "123-456-7890", address = "59 Main St", city = "City59", state = "State59", Country = "Country59" },
        new Employee { id = 60, name = "Employee 60", email = "employee60@example.com", phoneNumber = "123-456-7890", address = "60 Main St", city = "City60", state = "State60", Country = "Country60" },
        new Employee { id = 61, name = "Employee 61", email = "employee61@example.com", phoneNumber = "123-456-7890", address = "61 Main St", city = "City61", state = "State61", Country = "Country61" },
        new Employee { id = 62, name = "Employee 62", email = "employee62@example.com", phoneNumber = "123-456-7890", address = "62 Main St", city = "City62", state = "State62", Country = "Country62" },
        new Employee { id = 63, name = "Employee 63", email = "employee63@example.com", phoneNumber = "123-456-7890", address = "63 Main St", city = "City63", state = "State63", Country = "Country63" },
        new Employee { id = 64, name = "Employee 64", email = "employee64@example.com", phoneNumber = "123-456-7890", address = "64 Main St", city = "City64", state = "State64", Country = "Country64" },
        new Employee { id = 65, name = "Employee 65", email = "employee65@example.com", phoneNumber = "123-456-7890", address = "65 Main St", city = "City65", state = "State65", Country = "Country65" },
        new Employee { id = 66, name = "Employee 66", email = "employee66@example.com", phoneNumber = "123-456-7890", address = "66 Main St", city = "City66", state = "State66", Country = "Country66" },
        new Employee { id = 67, name = "Employee 67", email = "employee67@example.com", phoneNumber = "123-456-7890", address = "67 Main St", city = "City67", state = "State67", Country = "Country67" },
        new Employee { id = 68, name = "Employee 68", email = "employee68@example.com", phoneNumber = "123-456-7890", address = "68 Main St", city = "City68", state = "State68", Country = "Country68" },
        new Employee { id = 69, name = "Employee 69", email = "employee69@example.com", phoneNumber = "123-456-7890", address = "69 Main St", city = "City69", state = "State69", Country = "Country69" },
        new Employee { id = 70, name = "Employee 70", email = "employee70@example.com", phoneNumber = "123-456-7890", address = "70 Main St", city = "City70", state = "State70", Country = "Country70" },
        new Employee { id = 71, name = "Employee 71", email = "employee71@example.com", phoneNumber = "123-456-7890", address = "71 Main St", city = "City71", state = "State71", Country = "Country71" },
        new Employee { id = 72, name = "Employee 72", email = "employee72@example.com", phoneNumber = "123-456-7890", address = "72 Main St", city = "City72", state = "State72", Country = "Country72" },
        new Employee { id = 73, name = "Employee 73", email = "employee73@example.com", phoneNumber = "123-456-7890", address = "73 Main St", city = "City73", state = "State73", Country = "Country73" },
        new Employee { id = 74, name = "Employee 74", email = "employee74@example.com", phoneNumber = "123-456-7890", address = "74 Main St", city = "City74", state = "State74", Country = "Country74" },
        new Employee { id = 75, name = "Employee 75", email = "employee75@example.com", phoneNumber = "123-456-7890", address = "75 Main St", city = "City75", state = "State75", Country = "Country75" },
        new Employee { id = 76, name = "Employee 76", email = "employee76@example.com", phoneNumber = "123-456-7890", address = "76 Main St", city = "City76", state = "State76", Country = "Country76" },
        new Employee { id = 77, name = "Employee 77", email = "employee77@example.com", phoneNumber = "123-456-7890", address = "77 Main St", city = "City77", state = "State77", Country = "Country77" },
        new Employee { id = 78, name = "Employee 78", email = "employee78@example.com", phoneNumber = "123-456-7890", address = "78 Main St", city = "City78", state = "State78", Country = "Country78" },
        new Employee { id = 79, name = "Employee 79", email = "employee79@example.com", phoneNumber = "123-456-7890", address = "79 Main St", city = "City79", state = "State79", Country = "Country79" },
        new Employee { id = 80, name = "Employee 80", email = "employee80@example.com", phoneNumber = "123-456-7890", address = "80 Main St", city = "City80", state = "State80", Country = "Country80" },
        new Employee { id = 81, name = "Employee 81", email = "employee81@example.com", phoneNumber = "123-456-7890", address = "81 Main St", city = "City81", state = "State81", Country = "Country81" },
        new Employee { id = 82, name = "Employee 82", email = "employee82@example.com", phoneNumber = "123-456-7890", address = "82 Main St", city = "City82", state = "State82", Country = "Country82" },
        new Employee { id = 83, name = "Employee 83", email = "employee83@example.com", phoneNumber = "123-456-7890", address = "83 Main St", city = "City83", state = "State83", Country = "Country83" },
        new Employee { id = 84, name = "Employee 84", email = "employee84@example.com", phoneNumber = "123-456-7890", address = "84 Main St", city = "City84", state = "State84", Country = "Country84" },
        new Employee { id = 85, name = "Employee 85", email = "employee85@example.com", phoneNumber = "123-456-7890", address = "85 Main St", city = "City85", state = "State85", Country = "Country85" },
        new Employee { id = 86, name = "Employee 86", email = "employee86@example.com", phoneNumber = "123-456-7890", address = "86 Main St", city = "City86", state = "State86", Country = "Country86" },
        new Employee { id = 87, name = "Employee 87", email = "employee87@example.com", phoneNumber = "123-456-7890", address = "87 Main St", city = "City87", state = "State87", Country = "Country87" },
        new Employee { id = 88, name = "Employee 88", email = "employee88@example.com", phoneNumber = "123-456-7890", address = "88 Main St", city = "City88", state = "State88", Country = "Country88" },
        new Employee { id = 89, name = "Employee 89", email = "employee89@example.com", phoneNumber = "123-456-7890", address = "89 Main St", city = "City89", state = "State89", Country = "Country89" },
        new Employee { id = 90, name = "Employee 90", email = "employee90@example.com", phoneNumber = "123-456-7890", address = "90 Main St", city = "City90", state = "State90", Country = "Country90" },
        new Employee { id = 91, name = "Employee 91", email = "employee91@example.com", phoneNumber = "123-456-7890", address = "91 Main St", city = "City91", state = "State91", Country = "Country91" },
        new Employee { id = 92, name = "Employee 92", email = "employee92@example.com", phoneNumber = "123-456-7890", address = "92 Main St", city = "City92", state = "State92", Country = "Country92" },
        new Employee { id = 93, name = "Employee 93", email = "employee93@example.com", phoneNumber = "123-456-7890", address = "93 Main St", city = "City93", state = "State93", Country = "Country93" },
        new Employee { id = 94, name = "Employee 94", email = "employee94@example.com", phoneNumber = "123-456-7890", address = "94 Main St", city = "City94", state = "State94", Country = "Country94" },
        new Employee { id = 95, name = "Employee 95", email = "employee95@example.com", phoneNumber = "123-456-7890", address = "95 Main St", city = "City95", state = "State95", Country = "Country95" },
        new Employee { id = 96, name = "Employee 96", email = "employee96@example.com", phoneNumber = "123-456-7890", address = "96 Main St", city = "City96", state = "State96", Country = "Country96" },
        new Employee { id = 97, name = "Employee 97", email = "employee97@example.com", phoneNumber = "123-456-7890", address = "97 Main St", city = "City97", state = "State97", Country = "Country97" },
        new Employee { id = 98, name = "Employee 98", email = "employee98@example.com", phoneNumber = "123-456-7890", address = "98 Main St", city = "City98", state = "State98", Country = "Country98" },
        new Employee { id = 99, name = "Employee 99", email = "employee99@example.com", phoneNumber = "123-456-7890", address = "99 Main St", city = "City99", state = "State99", Country = "Country99" },
        new Employee { id = 100, name = "Employee 100", email = "employee100@example.com", phoneNumber = "123-456-7890", address = "100 Main St", city = "City100", state = "State100", Country = "Country100" },


        new Employee { id = 101, name = "Zoe Young", email = "zoe.young@example.com", phoneNumber = "987-654-3210", address = "123 Elm St", city = "Sometown", state = "MI", Country = "USA" }

        };

        public async Task<List<Employee>> GetAllEmployee(int pageNo)
        {
            var employees = emp.Skip(10*(pageNo-1)).Take(10).ToList();
            return employees;
        }
    }
}
