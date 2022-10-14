using EmergencyQueue_Keeton;
using System;
using System.Linq;
using System.ComponentModel.Design;


Console.WriteLine("Patients in Emergency Room queue: ");
EmergencyRoom EmergencyQueue = new EmergencyRoom();
EmergencyQueue.Enqueue(new patients("Mickey Mouse"), 2);
EmergencyQueue.Enqueue(new patients("Fred Flintstone"), 1);
EmergencyQueue.Enqueue(new patients("George Jetson"), 2);
EmergencyQueue.Enqueue(new patients("Barney Rubble"), 3);
EmergencyQueue.Enqueue(new patients("Johnny Quest"), 1);
EmergencyQueue.patientsNames();
EmergencyQueue.patientCount();

Menu();

void Menu()
{
    Console.WriteLine("Menu");
    Console.WriteLine("1: Veiw List");
    Console.WriteLine("2: Add");
    Console.WriteLine("3: Remove");
    Console.WriteLine("4: Exit");

    string choice;
    choice = Console.ReadLine().ToLower();

    switch (choice)
    {
        case "1":
            EmergencyQueue.patientsNames();
            EmergencyQueue.patientCount();
            Menu();
            break;
        
        case "2":
            string patientName;
            string _Priority;
            int priority = 0;
            Console.WriteLine("\nType patient's first and last name:");
            patientName = Console.ReadLine();
            if (patientName == "")
            {
                while (patientName == "")
                {
                    Console.WriteLine("\nError: Type patient name:");
                    patientName = Console.ReadLine();
                }

            }

            Console.WriteLine("\nEnter patient's priority: 1 | 2 | 3");
            _Priority = Console.ReadLine();
            if (_Priority == "1" || _Priority == "2" || _Priority == "3")
            {
                priority = Convert.ToInt32(_Priority);
            }
            else
            {
                Console.WriteLine("Enter a correct priority number.");
            }
            EmergencyQueue.Enqueue(new patients(patientName), priority);
            Console.WriteLine(patientName + " has been added with a number " + priority + " priority.");
            patientName = "";
            _Priority = "";
            priority = 0;
            EmergencyQueue.patientCount();
            Menu();
            break;

        case "3":
            Console.WriteLine("Press Y to remove patient from queue.");
            string remove = Console.ReadLine();

            if (remove == "Y")
            {
                EmergencyQueue.removePatientName();

            }
            else
            {
                Console.WriteLine("Rerouting to Menu");
            }
            EmergencyQueue.patientCount();
            Menu();
            break;

        case "4":
            Console.WriteLine("Exiting......");
            break;

        default:
            Console.WriteLine("Please select a number.");
            Menu();
            break;
    }
}



