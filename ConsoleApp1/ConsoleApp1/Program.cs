using System;

namespace ConsoleApp1
{
    abstract class Person
    {
        public  string name { get; set; }
        public string course { get; set; }
        public int number { get; set; }
    
         public Person(string name, string course, int number)
        
            {
                this.name = name;
                this.course = course;
                this.number = number;
            }
        
        public abstract void Print();

    }

    class Student : Person
    {
        public Student(string name, string course, int number) : base(name, course, number) { }
        
      
        public override void Print()
        {
            Console.WriteLine($"Last name : {name}\tCourse of Study : {course}\tGrade book number : {number}");
        }

        public override int GetHashCode()                // by GetHashCode
        {
            return name.GetHashCode();              
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Student student = (Student)obj;
           return (this.number==student.number);
            
        }

    }


    class Aspirant : Person
    {
        public string thesisTitle { get; set; }
        public Aspirant(string name, string course, int number, string thesis) : base(name, course, number)
        {
            thesisTitle = thesis;
        }
        public override void Print()
        {
            Console.WriteLine($"Last name : {name}\tCourse of Study : {course}\tGrade book number : {number}\tThesis title is {thesisTitle}");
        }
        public override string ToString()                   //by ToString
        {
            return $"Last name : {name}\tCourse of Study : {course}\tGrade book number : {number}\tThesis title is {thesisTitle}";
        }

        public override int GetHashCode()                     // by GetHashCode
        {
            return thesisTitle.GetHashCode();              
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Brown","Geography",2020104);
            Aspirant aspirant1 = new Aspirant("McKinley", "Astronomy", 2020205, "Ring singularity");
            Student student2 = new Student("Aliyev", "Math\t", 2020107);
            student1.Print();
            student2.Print();
            Console.WriteLine(aspirant1.ToString() + "\n");       //by ToString
           
            Console.WriteLine("HashCode of student1.name :" + student1.GetHashCode());      // by GetHashCode 
            Console.WriteLine("HashCode of aspirant1.thesisTitle :" + aspirant1.GetHashCode());      // by GetHashCode
            Console.WriteLine("Namespace and Classname of student1 :" + student1.GetType()) ;        // by Gettype
            bool numbercomparison = student1.Equals(student2);
        }
        
    }

}

