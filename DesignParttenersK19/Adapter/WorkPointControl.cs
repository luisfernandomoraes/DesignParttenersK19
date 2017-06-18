using System;

namespace DesignParttenersK19.Adapter
{
    public class WorkPointControl
    {
        public void RegistreEntry(Employee employee)
        {
            Console.WriteLine($"Employee {employee.Name} came in at {DateTime.Now}.");
        }

        public void RegistreOut(Employee employee)
        {
            Console.WriteLine($"Employee {employee.Name} came out at {DateTime.Now}.");
        }
    }
}