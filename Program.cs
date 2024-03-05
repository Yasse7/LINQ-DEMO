using System;
using System.Linq;
using System.Collections.Generic;

					
public class Program
{
	public static void Main()
	{
		
		IList<Student> studentList = new List<Student>() { 
				new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
				new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
			};
		
		
		var teenAgerStudent = from s in studentList
							  where s.Age > 12 && s.Age < 20
							  select s;
		Console.WriteLine("Teen age Students:");
						  
		foreach(Student std in teenAgerStudent){			
			Console.WriteLine(std.StudentName);
		}
        //______________________Query Syntax__________________________________________
        Console.WriteLine("---------------------------Query Syntax--------------------------------------");
        IList<string> stringlist = new List<string>(){
            "yassir",
            "jerrari",
            "imane",
            "mehdi"
        } ; 
        var result = from s in stringlist
                    where s.Contains('j') 
                    select s; 
        foreach(var s in result){
            Console.Write(s+"\n");
        }

        //______________________Method Syntax__________________________________________
        Console.WriteLine("---------------------------Method Syntax--------------------------------------");
        
        var QMethod = studentList.Where( st=> st.Age>12 && st.Age<20).ToList<Student>();//Lamba Expression
        foreach(Student stu in QMethod){
            Console.Write("this a Methode Syntax Test : "+stu.StudentID+"--"+stu.StudentName);
        }

	}
}

public class Student{

	public int StudentID { get; set; }
	public string StudentName { get; set; }
	public int Age { get; set; }
	
}