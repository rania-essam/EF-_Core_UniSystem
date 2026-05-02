using EFday1_UniversitySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.RP;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using EFday1_UniversitySystem.Models;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using Microsoft.EntityFrameworkCore.Query.Internal;
namespace EFday1_UniversitySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            DB_Context context = new DB_Context();

            #region  STudent CRUD  and adding data

            //Students
            // Create / Read / Update / Delete



            //context.Students.Add(
            //        new Student
            //        {
            //            Name = "Rokaya Ibrahim",
            //            Age = 20,
            //            Email = "roka@example.com",

            //        }
            //        );
            //context.Students.Add(
            //new Student
            //{
            //    Name = "Rania Essam",
            //    Age = 22,
            //    Email = "rou@example.com",
            //}
            //);
            //context.Students.Add(
            //        new Student
            //        {
            //            Name = "Sara Essam",
            //            Age = 25,
            //            Email = "Sara12@gmail.com"
            //        }
            //);
            //    context.SaveChanges();

            //  var Stds = context.Students.ToList();
            //foreach (var st in Stds)
            //{
            //    Console.WriteLine($"ID: {st.Id}, Name: {st.Name}, Age: {st.Age}, Email: {st.Email}");
            //}



            //var std = context.Students.Where(s => s.Id == 27).FirstOrDefault();


            //if (std != null)
            //{
            //    std.Age = 21;
            //    Console.WriteLine($"{std.Name}  {std.Id} {std.Email}");
            //    context.Students.Remove(std);
            //    context.SaveChanges();
            //    Console.WriteLine("Student Deleted ");

            //}

            //var S = context.Students.Where(s => s.Id == 27).FirstOrDefault();
            //if (S == null)
            //{
            //    Console.WriteLine("Deleted Sucessfully ");
            //}
            //else
            //{
            //    Console.WriteLine("Not Deleted ");
            //}

            //Console.WriteLine(std?.Name);

            //#endregion

            //#region AddingData

            //context.Departments.Add(
            //        new Department
            //        {
            //            Name = "Computer Science",
            //        }
            //);

            //context.Departments.Add(
            //        new Department
            //        {
            //            Name = "Information Technology",
            //        }
            //);
            //context.Departments.Add(
            //         new Department
            //         {
            //             Name = "Software Engineering",
            //         }
            //);


            //context.SaveChanges();

            //context.Instructors.Add(
            //    new Instructor
            //    {
            //        Name = "Rania Essam ",
            //        Salary = 500000.00M
            //    }

            //    );


            //context.Instructors.Add(
            //    new Instructor
            //    {
            //        Name = "Ahmed  ",
            //        Salary = 100000.00M

            //    }

            //    );

            //context.SaveChanges();




            //           context.Courses.Add(
            //                   new Course
            //                   {
            //                       Title = "C#",
            //                       Credits = 3
            //                   }
            //           );
            //           context.Courses.Add(
            //                   new Course
            //                   {
            //                       Title = "Java",
            //                       Credits = 4
            //                   }
            //           );

            //           context.SaveChanges();


            //           context.Enrollments.Add(

            //                       new Enrollment
            //                       {
            //                           StudentId = 28,
            //                           CourseId = 5,
            //                           Grade = 87.21M
            //                       }
            //           );

            //           context.Enrollments.Add(
            //               new Enrollment
            //               {
            //                   StudentId = 29,
            //                   CourseId = 4,
            //                   Grade = 90.00M
            //               }

            //               );




            //           context.Departments.Add(
            //    new Department
            //    {
            //        Name = "Computer Science",
            //        Instructor = new Instructor
            //        {
            //            Name = "Dr. Ahmed",
            //            Salary = 15000
            //        }
            //    }
            //);

            //           context.Departments.Add(
            //               new Department
            //               {
            //                   Name = "Information Technology",
            //                   Instructor = new Instructor
            //                   {
            //                       Name = "Dr. Sara",
            //                       Salary = 14000
            //                   }
            //               }
            //           );

            //           context.Departments.Add(
            //               new Department
            //               {
            //                   Name = "Software Engineering",
            //                   Instructor = new Instructor
            //                   {
            //                       Name = "Dr. Ali",
            //                       Salary = 16000
            //                   }
            //               }
            //           );

            //           context.SaveChanges();


            #endregion


            #region  Explicit Loading  ( means loading when needed )
            // you can load also with a condition or without

            //var instructors = context.Instructors.ToList();

            //foreach (var ins in instructors)
            //{
            //    context.Entry(ins).Collection(ins => ins.Courses).Load(); // loading collection of objects 
            //    context.Entry(ins).Reference(ins => ins.Department).Load();// loading single object
            //                                                               // Load with a condition
            //    var selectedcourses
            //         = context.Entry(ins).Collection(ins => ins.Courses).Query().Where(c => c.Id > 2);

            //    foreach(var c in selectedcourses)
            //        Console.WriteLine(c.Title);
            //    foreach(var crs in ins.Courses)
            //        Console.WriteLine($"CourseName : {crs.Title}");

            //    Console.WriteLine($"DepartmentName : {ins.Department?.Name}");

            //}

            #endregion


            #region Lazy Loading
            //1 - install Core.Proxies package
            //2 - mark all navigation properties using virtual
            #endregion


            #region eagerloading
            // use assplitquery , Dtos to manage queries with include 

            //var res = context.Students.Select(s => new
            //{
            //    sname = s.Name,
            //    dname = s.Department.Name,
            //    num_courses = s.Courses.Count()

            //}).ToList();

            //foreach (var st in res)
            //{
            //    Console.WriteLine($"Student Name: {st.sname}, Department Name: {st.dname}, Number of Courses: {st.num_courses}");
            //}

            //----------- include , then inlcude , AsSplitQuery
            // eager loading
            //Collection navigation  ---- include collection  ( eager loading a collection of objects )
            //reference navigation   ---- include object      ( eager loading a single object 

            //var students = context.Students.AsSplitQuery()
            //                      .Include(s => s.Department)
            //                      .Include(s => s.Enrollments)
            //                          .ThenInclude(e => e.course)
            //                      .ToList();

            //foreach (var student in students)
            //{
            //    Console.WriteLine($"Student Name: {student.Name}, Department Name: {student.Department?.Name}, FirstCourseName: {student.Enrollments.FirstOrDefault()?.course?.Title}");
            //}



            //                    var courses = context.Courses
            //            .Include(c => c.Instructor)
            //            .Include(c => c.Enrollments)
            //            .ThenInclude(e=>e.Student)
            //            .ToList();

            //                    foreach (var c in courses)
            //                    {
            //                        Console.WriteLine($"Course: {c.Title}");
            //                        Console.WriteLine($"Instructor: {c.Instructor?.Name}");

            //                        foreach (var en in c.Enrollments)
            //                        {
            //                            Console.WriteLine($"Student: {en.Student.Name}");
            //                        }
            //}


            //var departments = context.Departments
            //.Include(d => d.Students)
            //.Include(d => d.Instructor)
            //.ToList();

            //foreach (var d in departments)
            //{
            //    Console.WriteLine($"Department: {d.Name}");

            //    Console.WriteLine($"Head Instructor: {d.Instructor?.Name}");

            //    foreach (var s in d.Students)
            //    {
            //        Console.WriteLine($"Student: {s.Name}");
            //    }
            //}

            #endregion


            #region  compare_performance  
            //var  res = context.Departments.Where(d => d.Id > 2);
            //foreach(var dep in res)
            //    Console.WriteLine(dep);


            //var res2 = context.Departments.ToList().Where(d => d.Id > 2);

            //foreach( var dep in res2)
            //{
            //    Console.WriteLine(dep);
            //}
            #endregion


            #region automatic join 
            //var emp_dept = (
            //    from std in context.Students
            //    select new { std_name = std.Name, Dept_name = std.Department.Name } // creates join query qutomatically
            //    ).ToList();

            //foreach (var emp in emp_dept)
            //    Console.WriteLine(emp);

            #endregion

            #region Concurrency Check 

            //DB_Context context2 = new DB_Context();

            //var std = context.Students.FirstOrDefault();

            //var std2 = context2.Students.FirstOrDefault();

            //std.Age--;
            //context.SaveChanges();


            //// loop it until operation successed
            //try
            //{
            //    context2.SaveChanges();
            //}
            //catch(DbUpdateConcurrencyException ex)
            //{
            //    var std1 = ex.Entries.First().Entity as Student;

            //    context2.Entry(std1).Reload();

            //    std1.Age -= 2;
            //    context2.SaveChanges();
            //}

            #endregion


            #region   client_server evaluation

            //var res = from ins in context.Instructors
            //          .ToList()
            //          select string.Join(':', "Ins_name", ins.Name) ;
            //// join can’t be translated to SQL Query 
            //// fetch data then filter it in memory --- bad performance 


            #endregion

            #region EF functions ( Using SQL Functions that doesnot exist in LINQ inside ef )
            //var res = from ins in context.Instructors
            //          where EF.Functions.Like(ins.Name, "%R%")
            //          select ins.Name;


            #endregion

            #region AsNotracking
            // modify changetracker object at context to make all objects untracked
            // changing object (Entry) State to Attached make it tracked

            //var res = context.Students.AsNoTracking()
            //    .Include(s => s.Department)
            //    .ToList();
            /*
             100 students in one department == 100 objects of department and 100 objects of students 
             */

            // var res2 = context.Students.AsNoTrackingWithIdentityResolution() // use it with large sets of data
            //.Include(s => s.Department)
            //.ToList();
            /*
               // compiler checks if object exists or not before creating it
                100 students in one department == only one object of department and 100 objects of students 
             */



            #endregion

            #region ShadowProperty

            //var res = context.Departments.ToList();
            //foreach (var dept in res)
            //{
            //    // accessing shadow property
            //    context.Entry(dept).Property("Is_Deleted").CurrentValue = false;
            //}
            ////using shadow property in a query

            //var res2 = from dept in context.Departments
            //           where EF.Property<bool>(dept, "Is_Deleted") == false
            //           select dept;

          
            #endregion





        }
    }
}
