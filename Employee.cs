namespace CatWorx.BadgeMaker {
  class Employee
  {
    private string FirstName;
    private string LastName;
    private int Id;
    private string PhotoUrl;
    public Employee(string firstName, string lastName, int id, string photoUrl) {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
        PhotoUrl = photoUrl;
    }
    public string GetName() {
        return  FirstName + " " + LastName;
    }
  
    public int GetId() {
        return Id;
    }

    public string GetPhotoUrl() {
        return PhotoUrl;

    }
  }
}




// namespace CatWorx.BadgeMaker
// {
//   class Employee
//   {
//     // more to come!
    
// //   string FirstName;
//    public string FirstName;
//    public string LastName;
//    public int Id;
//    public string PhotoUrl;

// //      public Employee(string firstName) {
// //     FirstName = firstName;
// //   }
// // public Employee(string firstName, string lastName) {
// //   FirstName = firstName;
// //   LastName = lastName;
// // }
// public Employee(string firstName, string lastName, int id, string photoUrl) {
//     FirstName = firstName;
//     LastName = lastName;
//     Id = id;
//     PhotoUrl = photoUrl;
// }
// public string GetName() {
//   return  FirstName + " " + LastName;
// }
//   }
// // class Employee
// // {
// //   public string FirstName; 
// //   public string LastName;
// //   public Employee(string firstName, string lastName) 
// //   {
// //     FirstName = firstName;
// //     LastName = lastName;
// //   }
// // }
// }