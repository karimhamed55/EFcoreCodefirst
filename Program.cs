using System;
using System.Linq;
using EFcore;

class Program
{
    static void Main()
    {
        var context = new test2Context();
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear(); // Clears the screen to keep it clean
            Console.WriteLine("*********** DEPARTMENT MANAGER **********");
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Read");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    // CREATE
                    Console.Write("Enter Department Name: ");
                    var newName = Console.ReadLine();
                    var newDept = new Department { DepartmentName = newName };
                    context.Departments.Add(newDept);
                    context.SaveChanges();
                    Console.WriteLine("Saved successfully!");
                    break;

                case "2":
                    // READ
                    var departments = context.Departments.ToList();
                    Console.WriteLine("\n--- List of Departments ---");
                    foreach (var dept in departments)
                    {
                        Console.WriteLine($"ID: {dept.DepartmentId} | Name: {dept.DepartmentName} | Desc: {dept.Description}");
                    }
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine(); // Pauses so you can read the list
                    break;

                case "3":
                    // UPDATE
                    Console.Write("Enter the ID of the Department to edit: ");
                    int editId = Convert.ToInt32(Console.ReadLine());

                    var deptToEdit = context.Departments.Find(editId);
                    if (deptToEdit != null)
                    {
                        Console.Write($"Current Name is '{deptToEdit.DepartmentName}'. Enter New Name: ");
                        deptToEdit.DepartmentName = Console.ReadLine();

                        Console.Write("Enter New Description (or press enter to skip): ");
                        var newDesc = Console.ReadLine();
                        if (!string.IsNullOrEmpty(newDesc))
                        {
                            deptToEdit.Description = newDesc;
                        }

                        context.SaveChanges();
                        Console.WriteLine("Updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Department not found!");
                    }
                    break;

                case "4":
                    // DELETE
                    Console.Write("Enter the ID to delete: ");
                    int deleteId = Convert.ToInt32(Console.ReadLine());

                    var deptToDelete = context.Departments.Find(deleteId);
                    if (deptToDelete != null)
                    {
                        context.Departments.Remove(deptToDelete);
                        context.SaveChanges();
                        Console.WriteLine("Deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Department not found!");
                    }
                    break;

                case "5":
                    keepRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            if (keepRunning && input != "2")
            {
                // Small delay so you can see "Saved successfully" messages
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}