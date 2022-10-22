using System.Data.Entity;

namespace FinalTask.Models
{
    public class StudentsDbInitializer: DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            context.Students.Add(new Student
            {
                StudentName = "Иванов Иван Иванович",
                CSDeveloping = 100,
                JavaDeveloping = 120
            });
            context.Students.Add(new Student
            {
                StudentName = "Петров Петр Петрович",
                CSDeveloping = 90,
                JavaDeveloping = 85
            });
            context.Students.Add(new Student
            {
                StudentName = "Сидоров Василий Львович",
                CSDeveloping = 110,
                JavaDeveloping = 95
            });
            base.Seed(context);
        }
    }
}