using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalTask.Models
{
    public class StudentsDbInitializer: DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            context.Students.Add(new Student { LastName = "Никулин", FirstName = "Иван", Surname = "Игоревич", Email = "nikulin98@yandex.ru",
                MathematicMark = 3, PhisicMark = 4, PhilosophyMark = 5, ChemistryMark = 3});
            context.Students.Add(new Student { LastName = "Абдуллина", FirstName = "Инга", Surname = "Игоревна", Email = "inga.abdullina99@gmail.com",
                MathematicMark = 4, PhisicMark = 4,PhilosophyMark = 4, ChemistryMark = 3});
            context.Students.Add(new Student { LastName = "Вяхирев", FirstName = "Глеб", Surname = "Владимирович", Email = "glebv@inbox.ru", 
                MathematicMark = 5, PhisicMark = 3, PhilosophyMark = 4, ChemistryMark = 4});
            context.Students.Add(new Student { LastName = "Глинский", FirstName = "Владимир", Surname = "Александрович", Email = "glen_90@bk.ru", 
                MathematicMark = 3, PhisicMark = 3, PhilosophyMark =3, ChemistryMark = 3});
            context.Students.Add(new Student { LastName = "Дерягин", FirstName = "Алексей", Surname = "Сергеевич", Email = "deryagin.alex@outlook.com", 
                MathematicMark = 5, PhisicMark = 5, PhilosophyMark = 4, ChemistryMark = 4});
            context.Students.Add(new Student { LastName = "Егоров", FirstName = "Дмитрий", Surname = "Геннадьевич", Email = "egorov-vlkl@yandex.ru", 
                MathematicMark = 3 , PhisicMark = 3, PhilosophyMark = 4, ChemistryMark= 4});
            context.Students.Add(new Student { LastName = "Иванов", FirstName = "Владимир", Surname = "Сергеевич", Email = "breaksforall@yandex.ru", 
                MathematicMark = 5, PhisicMark = 4, PhilosophyMark = 4, ChemistryMark = 4});
            context.Students.Add(new Student { LastName = "Иванов", FirstName = "Владислав", Surname = "Алексеевич", Email = "vladislavivanovspb@gmail.com", 
                MathematicMark = 5, PhisicMark = 5, PhilosophyMark = 4, ChemistryMark = 5});
            context.Students.Add(new Student { LastName = "Иванов", FirstName = "Илья", Surname = "Николаевич", Email = "inix@mail.ru", 
                MathematicMark = 4, PhisicMark = 4, PhilosophyMark = 4, ChemistryMark = 4});
            context.Students.Add(new Student { LastName = "Кабикова", FirstName = "Виктория", Surname = "Константиновна", Email = "victoriakabikova@gmail.com", 
                MathematicMark = 5, PhisicMark = 5, PhilosophyMark = 4, ChemistryMark = 3});
            context.Students.Add(new Student { LastName = "Калинин", FirstName = "Алексей", Surname = "Владимирович", Email = "alexeykalinin@bk.ru", 
                MathematicMark = 5, PhisicMark = 5, PhilosophyMark = 5, ChemistryMark = 5});
            context.Students.Add(new Student { LastName = "Леонтьев", FirstName = "Андрей", Surname = "Юрьевич", Email = "leon-and@yandex.ru", 
                MathematicMark = 3, PhisicMark = 3, PhilosophyMark = 4, ChemistryMark = 3});
            context.Students.Add(new Student { LastName = "Мартынов", FirstName = "Дмитрий", Surname = "Юрьевич", Email = "dm888@list.ru", 
                MathematicMark = 5, PhisicMark = 4, PhilosophyMark = 3, ChemistryMark = 4});
            context.Students.Add(new Student { LastName = "Муравьев", FirstName = "Алексей", Surname = "Александрович", Email = "muraviev-aa@yandex.ru", 
                MathematicMark = 3, PhisicMark = 4, PhilosophyMark = 3, ChemistryMark = 4});
            context.Students.Add(new Student { LastName = "Никулина", FirstName = "Ульяна", Surname = "Сергеевна", Email = "Russkaya2011@gmail.com", 
                MathematicMark = 5, PhisicMark = 5, PhilosophyMark = 3, ChemistryMark = 5});
            context.Students.Add(new Student { LastName = "Перепелица", FirstName = "Анастасия", Surname = "Викторовна", Email = "perepelitsa_a@mail.ru", 
                MathematicMark = 5, PhisicMark = 5, PhilosophyMark = 5, ChemistryMark = 5});
            context.Students.Add(new Student { LastName = "Печеркин", FirstName = "Максим", Surname = "Вадимович", Email = "maximal96@yandex.ru", 
                MathematicMark = 4, PhisicMark = 3, PhilosophyMark = 5, ChemistryMark = 3});
            context.Students.Add(new Student { LastName = "Самокрутов", FirstName = "Михаил", Surname = "Ростиславович", Email = "mishkamaslov@mail.ru", 
                MathematicMark = 5, PhisicMark = 5, PhilosophyMark = 3, ChemistryMark = 4});
            context.Students.Add(new Student { LastName = "Самородов", FirstName = "Аркадий", Surname = "Алексеевич", Email = "arkadiy1987@yandex.ru", 
                MathematicMark = 3, PhisicMark = 4, PhilosophyMark = 3, ChemistryMark = 3});
            context.Students.Add(new Student { LastName = "Сапожников", FirstName = "Вячеслав", Surname = "Андреевич", Email = "Darkoment@yandex.ru", 
                MathematicMark =3, PhisicMark = 3, PhilosophyMark = 3, ChemistryMark = 3});
            context.Students.Add(new Student { LastName = "Цветков", FirstName = "Сергей", Surname = "Викторович", Email = "tsvetkov71@gmail.com", 
                MathematicMark = 5, PhisicMark = 5, PhilosophyMark = 3, ChemistryMark = 5});
            base.Seed(context);
        }
    }
}