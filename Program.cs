namespace Lab6OOPGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------PART-ONE-----------------------------------------------------//

            // Creating five employees
            Employee Mika = new Employee("E001", "Mika Mikasdotter", Gender.Female, 25600);
            Employee Elvira = new Employee("E002", "Elvira Mariesdotter", Gender.Female, 38400);
            Employee Sam = new Employee("E003", "Sam Samssen", Gender.Other, 16700);
            Employee Andreas = new Employee("E004", "Andreas Andreasson", Gender.Male, 30000);
            Employee Hera = new Employee("E005", "Hera Hund", Gender.Female, 6050);


            // Creating a Stack to contain Employee objects
            Stack<Employee> employeeStack = new Stack<Employee>();


            // Pushing in five new employees with filled in property values
            employeeStack.Push(Mika);
            employeeStack.Push(Elvira);
            employeeStack.Push(Sam);
            employeeStack.Push(Andreas);
            employeeStack.Push(Hera);


            // Print out all employees in the stack with the help of a foreach loop
            Console.WriteLine("Retrieving all employees with console writelines and foreach loop. . .");
            foreach (var employee in employeeStack)
            {
                PrintEmployee(employee, employeeStack.Count);
            }


            // Print out all employees through the Pop method
            // Since we are removing items from the Stack, i with a value of stack.count, and reduces by 1 every iteration.
            // Once the stack reaches 0, the loop wont start.
            Console.WriteLine("Retrieving all employees using Pop method. . .");
            for (int i = employeeStack.Count; i > 0; i--)
            {
                Employee currentEmployee = employeeStack.Pop();
                PrintEmployee(currentEmployee, employeeStack.Count);
            }


            // Push the objects back into the stack
            employeeStack.Push(Mika);
            employeeStack.Push(Elvira);
            employeeStack.Push(Sam);
            employeeStack.Push(Andreas);
            employeeStack.Push(Hera);


            // Print out employees of the stack using the Peek method.
            // Since we now that we want to only print two members of the list, we can set i to stop after two iterations.
            Console.WriteLine("Retrieving employees using Peek method. . .");
            for (int i = 0; i < 2; i++)
            {
                Employee emp = employeeStack.Peek();
                PrintEmployee(emp, employeeStack.Count);
            }


            // Sam is the object num 3 in the stack. If Sam is still in the stack, Contains will return true and the writeline will print.
            if (employeeStack.Contains(Sam))
            {
                Console.WriteLine($"Employee 3 named {Sam.Name} is in stack");
            }


            //------------------------------------------------------------PART-TWO------------------------------------------------------------//

            // Creating a List to contain Employee objects
            List<Employee> employeeList = new List<Employee>();


            // Pushing in five new employees with filled in property values
            employeeList.Add(Mika);
            employeeList.Add(Elvira);
            employeeList.Add(Sam);
            employeeList.Add(Andreas);
            employeeList.Add(Hera);

            // If else statement checking if the list contains the object Elvira
            if (employeeList.Contains(Elvira))
            {
                Console.WriteLine($"The employee named {Elvira.Name} exists in the list");
                Console.WriteLine("--------------------------\n");
            }
            else
            {
                Console.WriteLine($"The employee named {Elvira.Name} does NOT exist in the list");
                Console.WriteLine("--------------------------\n");
            }


            // Finds first member of list that matches female gender, then prints that object's property values.
            Console.WriteLine("First female in employee list: ");
            Employee firstFemale = employeeList.Find(x => x.Gender == Gender.Female);
            PrintEmployee(firstFemale);


            // Makes new list with only female employees. Loop through that list and print out their property values
            Console.WriteLine("All females in employee list: ");
            List<Employee> listOfFemales = employeeList.FindAll(x => x.Gender == Gender.Female);
            foreach (var female in listOfFemales)
            {
                PrintEmployee(female);
            }
        }

        // Method to print employee and how many are left in the stack.
        static void PrintEmployee(Employee employee, int itemsLeft)
        {
            Console.WriteLine($"Name: {employee.Name}\nWork ID: {employee.Id}\nCurrent Salary: {employee.Salary:C0}\nGender: {employee.Gender}");
            Console.WriteLine($"Items left in the stack: {itemsLeft}");
            Console.WriteLine("--------------------------\n");
        }

        // Method overload if one do not wanna print out how many items are left.
        static void PrintEmployee(Employee employee)
        {
            Console.WriteLine($"Name: {employee.Name}\nWork ID: {employee.Id}\nCurrent Salary: {employee.Salary:C0}\nGender: {employee.Gender}");
            Console.WriteLine("--------------------------\n");
        }
    }
}
