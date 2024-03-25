using ChallengeApp;
using System.Runtime.CompilerServices;

Employee employee1 = new Employee("Maks", "Buller", "29");
Employee employee2 = new Employee("Iwona", "Zió³kowska", "30");
Employee employee3 = new Employee("Dominika", "Brzustowska", "33");

employee1.AddScore(8);
employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(9);
employee1.AddScore(6);

employee2.AddScore(6);
employee2.AddScore(9);
employee2.AddScore(3);
employee2.AddScore(5);
employee2.AddScore(4);

employee3.AddScore(3);
employee3.AddScore(6);
employee3.AddScore(10);
employee3.AddScore(5);
employee3.AddScore(6);

List<Employee> employees = new List<Employee>()
{ 
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
    }
}
Console.WriteLine("Pracownik z najwiêksz¹ liczb¹ punktów: " + employeeWithMaxResult.imie + " " + employeeWithMaxResult.nazwisko);
Console.WriteLine("Wiek : " + employeeWithMaxResult.wiek);
Console.WriteLine("Iloœæ zebranych punktów: " + employeeWithMaxResult.Result);