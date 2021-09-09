using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using UserAndClassJsonSerializer.Library;
using UserAndClassJsonSerializer.Library.Classes;

namespace UserAndClassJsonSerializer
{
    class Program
    {
        // CHANGE ME: Change these to some sample files on your computer
        static string classFile = "C:\\Users\\berickson\\source\\repos\\High School Portal\\High-School-Portal\\HighSchoolPortal\\HighSchoolPortal\\data\\classFile.json";
        static string userFile = "C:\\Users\\berickson\\source\\repos\\High School Portal\\High-School-Portal\\HighSchoolPortal\\HighSchoolPortal\\data\\userFile.json";

        static List<string> userList;
        static List<string> classList;

        static void Main(string[] args)
        {
            userList = new List<string>();
            classList = new List<string>();

            bool repeat = false;
            do
            {
                if (repeat)
                {
                    Console.WriteLine(userList);
                    Console.WriteLine(classList);
                }

                // Accept user input to create a class or user
                Console.WriteLine("Would you like to make a (c)lass or (u)ser?");
                string menuOption = Console.ReadLine();

                if (menuOption == "c")
                {
                    int TeacherId;
                    int Grade;
                    string ClassName;

                    // TeacherId
                    Console.WriteLine("What is the id of the teacher for this class?");
                    string TeacherIdInput = Console.ReadLine();
                    if (int.TryParse(TeacherIdInput, out int IntTeacherId))
                    {
                        TeacherId = IntTeacherId;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                        continue;
                    }

                    // Grade
                    Console.WriteLine("What grade is taking this class?");
                    string GradeInput = Console.ReadLine();
                    if (int.TryParse(GradeInput, out int IntGrade))
                    {
                        Grade = IntGrade;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                        continue;
                    }

                    // ClassName
                    Console.WriteLine("What is the name of the class?");
                    ClassName = Console.ReadLine();

                    // Add serialized object to class list
                    SchoolClass schoolClass = new SchoolClass(TeacherId, Grade, ClassName);
                    classList.Add(JsonConvert.SerializeObject(schoolClass));
                }
                else if (menuOption == "u")
                {
                    int? TeacherId;
                    int? Grade;
                    PowerLevel powerLevel;
                    string Username;
                    string Password;

                    // PowerLevel
                    Console.WriteLine("What is the PowerLevel of the user: Student or Teacher? (Please be exact with your input)");
                    string PowerLevelInput = Console.ReadLine();
                    if (Enum.TryParse(PowerLevelInput, out PowerLevel overNineThousand))
                    {
                        powerLevel = overNineThousand;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                        continue;
                    }

                    //Grade or TeacherId
                    if (powerLevel == PowerLevel.Student)
                    {
                        TeacherId = null;

                        Console.WriteLine("What grade is the student in?");
                        string GradeInput = Console.ReadLine();
                        if (int.TryParse(GradeInput, out int IntGrade))
                        {
                            Grade = IntGrade;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            continue;
                        }
                    }
                    else
                    {
                        Grade = null;

                        Console.WriteLine("What is the teacher's ID?");
                        string TeacherIdInput = Console.ReadLine();
                        if (int.TryParse(TeacherIdInput, out int IntTeacherId))
                        {
                            TeacherId = IntTeacherId;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                            continue;
                        }
                    }

                    // Username and password
                    Console.WriteLine("What is their username?");
                    Username = Console.ReadLine();
                    Console.WriteLine("What is their password?");
                    Password = Console.ReadLine();

                    // Add the user to the userList
                    User user = new User(powerLevel, Grade, TeacherId, Username, Password);
                    userList.Add(JsonConvert.SerializeObject(user));
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

                Console.WriteLine("Are you done adding classes and users? (y/n)");
                string userRepeatInput = Console.ReadLine();
                if (userRepeatInput == "y")
                {
                    List<string> existingUsers = new List<string>();
                    List<string> existingClasses = new List<string>();

                    if (File.Exists(userFile))
                    {
                        existingUsers = new List<string>(File.ReadAllLines(userFile));
                    }
                    if (File.Exists(classFile))
                    {
                        existingClasses = new List<string>(File.ReadAllLines(classFile));
                    }

                    existingUsers.AddRange(userList);
                    existingClasses.AddRange(classList);

                    File.WriteAllLines(userFile, existingUsers);
                    File.WriteAllLines(classFile, existingClasses);
                    repeat = false;
                }
                else
                {
                    repeat = true;
                }
            }
            while (repeat);
        }
    }
}
