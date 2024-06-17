using System.Reflection.Metadata.Ecma335;

namespace Week1 {
    class Program {
        public static void Main(String[] args) {
            bool again = false;

            List<Student> students = new List<Student>();

            while (again == false) {
                Console.WriteLine("Enter a name and age (separated by space)");
                string listofNums = Console.ReadLine();

                string[] nums = listofNums.Split(' ');

                if (nums.Length == 2) {
                    string name = nums[0];
                    int age = int.Parse(nums[1]);
                    Student student = new Student(name, age);
                    students.Add(student);
                    Console.WriteLine("Name: {0}", student.name);
                    Console.WriteLine("Age: {0}", student.age);
                    Console.WriteLine("Student has been added");
                }
                
                bool again1 = false;
                bool addAnotherName = false;   
                while (addAnotherName == false) {
                    Console.WriteLine("Would you like to add another student? (y/n)");
                    char yesOrNo = char.Parse(Console.ReadLine());
                    if (yesOrNo == 'y') {
                        addAnotherName = true;
                        again = false;
                    } else if (yesOrNo == 'n') {
                        addAnotherName = true;
                        again1 = true;
                        again = true;
                    } else {
                        addAnotherName = false;
                        again = true;
                    }
                }
                

                   
                while (again1 == true) {
                    Console.WriteLine("Would you like to do something else?");
                    Console.WriteLine("    Type l to list all students.");
                    Console.WriteLine("    Type d followed by a name to delete a student with that name. (ex. d John)");
                    Console.WriteLine("    Type a followed by a name and age to add a student with that name and age. (ex. a John 30)");
                    Console.WriteLine("    Type q to escape.");
                    
                    string somethingElse = Console.ReadLine();
                    
                    if (somethingElse == "l") {
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        if (students.Count == 0) {
                                Console.WriteLine("No students in the list!");
                        } else {
                            for (int i = 0; i < students.Count; i++) {
                                
                                Console.WriteLine("Name: {0}, Age: {1}", students[i].Name, students[i].Age);
                            }
                        }
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                    } else if (somethingElse.StartsWith("d ")) {
                        string nameToRemove = somethingElse.Substring(2);
                        for (int i = 0; i < students.Count; i++) {
                            var studentToRemove = students.Find(s => s.Name.Equals(nameToRemove, StringComparison.OrdinalIgnoreCase));
                            students.Remove(studentToRemove);
                        }
                        Console.WriteLine("Student {0} has been removed.", nameToRemove);
                    } else if (somethingElse.StartsWith("a ")) {
                        string[] addStudents = somethingElse.Split(' ');
                        string nameToAdd = addStudents[1];
                        int ageToAdd = int.Parse(addStudents[2]);
                        students.Add(new Student(nameToAdd, ageToAdd));
                        Console.WriteLine("Student {0} with age {1} has been added.", nameToAdd, ageToAdd);
                    } else if (somethingElse == "q") {
                        again1 = false;
                        again = true;
                    } else {
                        Console.WriteLine("Invalid Entry. Try again!");
                    }
                }
            }
        }
    }  
}