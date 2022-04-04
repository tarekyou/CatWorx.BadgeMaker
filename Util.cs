// Import correct packages
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Net;

namespace CatWorx.BadgeMaker
{
  class Util
  {
    // Add List parameter to method
    public static void PrintEmployees(List<Employee> employees) 
    {
      for (int i = 0; i < employees.Count; i++) 
      {
        string template = "{0,-10}\t{1,-20}\t{2}";
        Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
      }
    }

        public static void MakeCSV(List<Employee> employees)
    {
     // Check to see if folder exists
if (!Directory.Exists("data")) 
{
  // If not, create it
  Directory.CreateDirectory("data");
}
// StreamWriter file = new StreamWriter("data/employees.csv");
using (StreamWriter file = new StreamWriter("data/employees.csv"))
{
  // Any code that needs the StreamWriter would go in here
  file.WriteLine("ID,Name,PhotoUrl");

  // Loop over employees
  for (int i = 0; i < employees.Count; i++)
  {
    // Write each employee to the file
    string template = "{0},{1},{2}";
    file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
  }
}   
    }

    public static void MakeBadges(List<Employee> employees) { 
        // Layout variables
int BADGE_WIDTH = 669;
int BADGE_HEIGHT = 1044;
int COMPANY_NAME_START_X = 0;
int COMPANY_NAME_START_Y = 110;
int COMPANY_NAME_WIDTH = 100;
int PHOTO_START_X = 184;
int PHOTO_START_Y = 215;
int PHOTO_WIDTH = 302;
int PHOTO_HEIGHT = 302;
int EMPLOYEE_NAME_START_X = 0;
int EMPLOYEE_NAME_START_Y = 560;
int EMPLOYEE_NAME_WIDTH = BADGE_WIDTH;
int EMPLOYEE_NAME_HEIGHT = 100;
int EMPLOYEE_ID_START_X = 0;
int EMPLOYEE_ID_START_Y = 690;
int EMPLOYEE_ID_WIDTH = BADGE_WIDTH;
int EMPLOYEE_ID_HEIGHT = 100;
          // Create image
  Image newImage = Image.FromFile("badge.png");
  newImage.Save("data/employeeBadge.png");

  // Graphics objects
StringFormat format = new StringFormat();
format.Alignment = StringAlignment.Center;
int FONT_SIZE = 32;
Font font = new Font("Arial", FONT_SIZE);
Font monoFont = new Font("Courier New", FONT_SIZE);
SolidBrush brush = new SolidBrush(Color.Black);

  using(WebClient client = new WebClient())
{
  for (int i = 0; i < employees.Count; i++)
  {
//  Stream employeeStream = client.OpenRead(employees[i].GetPhotoUrl());
//   Image photo = Image.FromStream(employeeStream);
 Image photo = Image.FromStream(client.OpenRead(employees[i].GetPhotoUrl()));
//  photo.Save("data/employeeBadge.png");
    Image background = Image.FromFile("badge.png");
    Image badge = new Bitmap(BADGE_WIDTH, BADGE_HEIGHT);
    Graphics graphic = Graphics.FromImage(badge);
    graphic.DrawImage(background, new Rectangle(0, 0, BADGE_WIDTH, BADGE_HEIGHT));
    graphic.DrawImage(photo, new Rectangle(PHOTO_START_X, PHOTO_START_Y, PHOTO_WIDTH, PHOTO_HEIGHT));

    // Company name
graphic.DrawString(
  employees[i].GetCompanyName(),
  font,
  new SolidBrush(Color.White),
  new Rectangle(
    COMPANY_NAME_START_X,
    COMPANY_NAME_START_Y,
    BADGE_WIDTH,
    COMPANY_NAME_WIDTH
  ),
format
);
// Employee name
graphic.DrawString(
  employees[i].GetName(),
  font,
  brush,
  new Rectangle(
    EMPLOYEE_NAME_START_X,
    EMPLOYEE_NAME_START_Y,
    BADGE_WIDTH,
    EMPLOYEE_NAME_HEIGHT
  ),
format
);

// Employee ID
graphic.DrawString(
  employees[i].GetId().ToString(),
  monoFont,
  brush,
  new Rectangle(
    EMPLOYEE_ID_START_X,
    EMPLOYEE_ID_START_Y,
    EMPLOYEE_ID_WIDTH,
    EMPLOYEE_ID_HEIGHT
  ),
format
);
string template = "data/{0}_badge.png";
badge.Save(string.Format(template, employees[i].GetId()));
// badge.Save("data/{0}_badge.png", employees[i].GetId());
//   badge.Save("data/employeeBadge.png");
    // background.Save("data/employeeBadge.png");
//     Console.WriteLine(photo.GetType());
// Console.WriteLine(background.GetType());
  }
  }
}
    }
  }


//pseudo code steps to save in a cvs file
// Add another static method to the Util class, which will make the CSV file.
// Call this method from within Program, passing it the list of employees.
// In the method, check whether a data folder exists. If not, create it.
// Create a new file located at data/employees.csv.
// Loop over the given employees.
// Write each employee’s info as a comma-separated string to the CSV file.



// namespace CatWorx.BadgeMaker
// {
//   class Util
//   {
//     // Method declared as "static"
//     public static void PrintEmployees()
//     {

//   }
// }
// }