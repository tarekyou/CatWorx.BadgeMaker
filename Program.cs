using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {

    //   static  List<string> GetEmployees()
//       static  List<Employee> GetEmployees()
// {
// //   List<string> employees = new List<string>();
// List<Employee> employees = new List<Employee>();
//   while (true) 
//   {
//     Console.WriteLine("Please enter a name: (leave empty to exit): ");
//     string input = Console.ReadLine();
//     if (input == "") 
//     {
//       break;
//     }

// // Create a new Employee instance
//   Employee currentEmployee = new Employee(input, "smith");
// // currentEmployee.FirstName = input;
//     // employees.Add(input);
//     // employees.Add(currentEmployee.GetName());
//     employees.Add(currentEmployee);
//   }
//   // This is important!
// //   return employees;
// // Update the method return type

// return employees;
// }

// static void PrintEmployees(List<string> employees)
// Change the type of the employees parameter
static List<Employee> GetEmployees()
{
List<Employee> employees = new List<Employee>();
while(true) 
{
  // Move the initial prompt inside the loop, so it repeats for each employee
  Console.WriteLine("Enter first name (leave empty to exit): ");

  // change input to firstName
  string firstName = Console.ReadLine();
  if (firstName == "") 
  {
    break;
  }

  // add a Console.ReadLine() for each value
  Console.Write("Enter last name: ");
  string lastName = Console.ReadLine();
  Console.Write("Enter ID: ");
//   int id = Console.ReadLine();
int id = Int32.Parse(Console.ReadLine());
  Console.Write("Enter Photo URL:");
  string photoUrl = Console.ReadLine();
  Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
  employees.Add(currentEmployee);
  }

  return employees;
}

static void PrintEmployees(List<Employee> employees)
{
//   for (int i = 0; i < employees.Count; i++) 
//   {

//     Console.WriteLine(employees[i]);

//   }
// for (int i = 0; i < employees.Count; i++) 
// {
//   // each item in employees is now an Employee instance
//   Console.WriteLine(employees[i].GetName());
// }
for (int i = 0; i < employees.Count; i++) 
{
  string template = "{0,-10}\t{1,-20}\t{2}";
  Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
}
}
static void Main(string[] args) {
  List<Employee> employees = GetEmployees();
  PrintEmployees(employees);
}
//       static void Main(string[] args)
// {
// //   List<string> employees = new List<string>();
//   // Collect user values until the value is an empty string

//   // this will run infinitely
// //   while (true)
// //   {
// //     Console.WriteLine("Please enter a name: ");
// //     string input = Console.ReadLine();
// //     employees.Add(input);
// //   } 

// // we moved this to getemployees()
// // while (true)
// // {
// //   Console.WriteLine("Please enter a name: (leave empty to exit): ");
// //   string input = Console.ReadLine();
// //   // Break if the user hits ENTER without typing a name
// //   if (input == "") 
// //   {
// //     break;
// //   }
// //   employees.Add(input);
// // }
// List<string> employees = GetEmployees();
// // we moved this to printemployees
// //   for (int i = 0; i < employees.Count; i++) 
// //   {
// //     Console.WriteLine(employees[i]);
// //   }
// PrintEmployees(employees);
// }













    // static void Main(string[] args)
    // {
    //   List<string> employees = new List<string>() { "adam", "amy" };
    //   employees.Add("barbara");
    //   employees.Add("billy");
    //   Console.WriteLine("Please enter a name: ");
    //   // Get a name from the console and assign it to a variable
    //   string input = Console.ReadLine();
    //   employees.Add(input);
    //   for (int i = 0; i < employees.Count; i++) 
    //   {
    //     Console.WriteLine(employees[i]);
    //   }
    // }
  }
}





// // // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");
// using System;
// using System.Collections.Generic;

// namespace CatWorx.BadgeMaker
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//     //   Console.WriteLine("Hello, World!");
//     //   string greeting = "Hello";
//     //   greeting = greeting + "World";
//     //   Console.WriteLine("greeting" + greeting);
//     //   Console.WriteLine($"greeting {greeting}"); 
//     //   Console.WriteLine("greeting: {0}", greeting);
//       // How do you find the area of a square? Area = side * side
//      //float side = 3.14; this doesn't work
//     // this works
//      // double side = 3.14;
//      // double area = side * side;
//      // Console.WriteLine("area: {0}", area);
//      // Console.WriteLine("area is a {0}", area.GetType());
// //      Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, *
// // Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3
// // Console.WriteLine(1 + 2 * 3);     // order of operations
// // Console.WriteLine(10 / 3.0);      // int's and doubles
// // Console.WriteLine(10 / 3);        // int's 
// // Console.WriteLine("12" + "3");    // What happens here?

// // int num = 10;
// // num += 100;
// // Console.WriteLine(num);
// // num ++;
// // Console.WriteLine(num);

// // bool isCold = true;
// // Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink
// // Console.WriteLine(!isCold ? "drink" : "add ice");  // output: add ice
// // string stringNum = "2";
// // int intNum = Convert.ToInt16(stringNum);
// // Console.WriteLine(intNum);
// // Console.WriteLine(intNum.GetType());

// // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();

// // myScoreBoard.Add("firstInning", 10);
// // myScoreBoard.Add("secondInning", 20);
// // myScoreBoard.Add("thirdInning", 30);
// // myScoreBoard.Add("fourthInning", 40);
// // myScoreBoard.Add("fifthInning", 50);
// // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
// //     { "firstInning", 10 },
// //     { "secondInning", 20},
// //     { "thirdInning", 30},
// //     { "fourthInning", 40},
// //     { "fifthInning", 50}
// // };

// // Console.WriteLine("----------------");
// // Console.WriteLine("  Scoreboard");
// // Console.WriteLine("----------------");
// // Console.WriteLine("Inning |  Score");
// // Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
// // Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
// // Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
// // Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
// // Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);

// // string[] favFoods = new string[3]{ "pizza", "doughnuts", "icecream" };
// // string firstFood = favFoods[0];
// // string secondFood = favFoods[1];
// // string thirdFood = favFoods[2];
// // Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);

// List<string> employees = new List<string>() { "adam", "amy" };

// employees.Add("barbara");
// employees.Add("billy");
// // Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);

// for (int i = 0; i < employees.Count; i++) 
// {
//   Console.WriteLine(employees[i]);
// }
//     }
//   }
// }