using System;

namespace DesignParttenersK19.Adapter
{
    public class NewWorkPointControl
    {
        public void Registre(Employee employee, bool isEntry)
        {
            if (isEntry)
            {
                Console.WriteLine($"Employee {employee.Name} came in at {DateTime.Now}.");
            }
            else
            {
                Console.WriteLine($"Employee {employee.Name} came out at {DateTime.Now}.");
            }
        }
    }
}