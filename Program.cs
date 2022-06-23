using System;

namespace cSharpAssignment2;
class Grading
{
    public static void Main(string[] args) {
        String studName;
        int Id, age;
        double course1, course2, course3, course4, sum, average;
        string ans="";
        while (ans!="n")
        {
            Console.Write("Enter student name: ");
            studName = Console.ReadLine();
            Console.Write("Enter age: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Id: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of the 4 courses");
            Console.Write("English: ");
            course1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geography: ");
            course2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Database: ");
            course3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Programming: ");
            course4 = Convert.ToDouble(Console.ReadLine());
            sum = course1 + course2 + course3 + course4;
            average = sum / 4;
            Console.WriteLine("Name: " + studName + "\n" + "ID: " + Id + "\n" + "Age: " + age);
            Console.WriteLine("Average: " + average);

            if (average >= 90 && average <= 100)
                Console.WriteLine("The grade is A. Excellent!\n");

            else if (average >= 75 && average < 90)
                Console.WriteLine("The grade is B. Very good!\n");

            else if (average >= 50 && average < 75)

                Console.WriteLine("The grade is C. Good!\n");

            else if (average >= 40 && average < 50)

                Console.WriteLine("The grade is D. Warning!\n");

            else if (average >= 0 && average < 40)

                Console.WriteLine("The grade is F. Failed!\n");

            else

                Console.WriteLine("Invalid grade!!\n");
            Console.WriteLine("Do you want to add another student? If yes enter any character else enter (n)");
            ans = Console.ReadLine();

        }


    } }


