using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ContosoUniversityEntities())
            {
                db.Database.Log = Console.WriteLine;
                var c = db.Department.Find(1);
                c.Name += "!!";
                db.SaveChanges();
            }



            //var c = new Course()
            //{
            //    CourseID = 0,
            //    Credits = 1,
            //    //CreateTime = DateTime.Now,
            //    ModifyTime = DateTime.Now,
            //    DepartmentID = 2,
            //    Title = "Entity Framework 6 @ Ede"

            //};

            //using (var db1 = new ContosoUniversityEntities())
            //{
            //    c = db1.Course.Find(6);
            //    c.Title += "!!";
            //}

            //using (var db2 = new ContosoUniversityEntities())
            //{
            //    //db2.Course.Attach(c);
            //    db2.Entry(c).State = System.Data.Entity.EntityState.Modified;
            //    db2.SaveChanges();
            //}


            using (var db = new ContosoUniversityEntities())
            {





                //db.Database.Log = msg =>
                //{
                //    Console.WriteLine(msg);
                //};


                ////var c =db.Course.Find(5);
                ////c.Credits += 1;
                ////db.SaveChanges();

                //var addcurse = new Course()
                //{
                //    CourseID = 0,
                //    Credits = 1,
                //    CreateTime = DateTime.Now,
                //    //ModifyTime = DateTime.Now,
                //    DepartmentID = 2,
                //    Title = "Entity Framework 6 @ Ede"

                //};
                //db.Course.Add(addcurse);

                //var c = db.Course.Find(2);
                //c.CreateTime = DateTime.Now;
                //c.Credits += 1;

                //db.SaveChanges();
            }
        }
    }
}
