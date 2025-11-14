using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MyWebApp.Models
{
    public class DbInitialize
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context =  new SchoolContext(serviceProvider.GetRequiredService<DbContextOptions<SchoolContext>>()))
            {
                context.Database.EnsureCreated();
                if (context.Majors.Any())
                {
                    return;   // DB has been seeded
                }
                var majors = new Major[]
                {
                    new Major{MajorName = "IT" },
                    new Major{MajorName = "Economics" },
                    new Major{MajorName = "Mathematics" },
                }; 
                foreach (Major m in majors)
                {
                    context.Majors.Add(m);
                }
                context.SaveChanges();
                var learners = new Learner[]
                {
                    new Learner{FirstMidName="John",LastName="Doe",EnrollmentDate=DateTime.Parse("2020-09-01"), MajorID=1},
                    new Learner{FirstMidName="Jane",LastName="Smith",EnrollmentDate=DateTime.Parse("2019-09-01"), MajorID=2},
                    new Learner{FirstMidName="Jim",LastName="Brown",EnrollmentDate=DateTime.Parse("2021-09-01"), MajorID=3},
                };
                foreach (Learner l in learners)
                {
                    context.Learners.Add(l);
                }
                context.SaveChanges();
                var coures = new Course[]
                {
                    new Course{CourseID = 1050, Title = "Chemistry",Credits = 3},
                    new Course{CourseID = 4022, Title = "Microeconomics", Credits = 3},
                    new Course{CourseID = 4041, Title = "Macroeconomics", Credits = 3},
                };
                foreach (Course c in coures)
                {
                    context.Courses.Add(c);
                }
                context.SaveChanges();
                var enrollments = new Enrollment[]
                {
                    new Enrollment{LearnerID=1,CourseID=1050, Grade=5.5f },
                    new Enrollment{LearnerID=1,CourseID=4022, Grade=7.5f },
                    new Enrollment{LearnerID=2,CourseID=1050, Grade=3.5f },
                    new Enrollment{LearnerID=2,CourseID=4041, Grade=7f },
                };
                foreach (Enrollment e in enrollments)
                {
                    context.Enrollments.Add(e);
                }
                context.SaveChanges();
            }
        }

    }
}
