using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalTask.Models
{
    public class Student
    {
        // ID студента
        public virtual int StudentId { get; set; }
        // Имя
        public virtual string LastName { get; set; }
        // Фамилия
        public virtual string FirstName { get; set; }
        // Отчество
        public virtual string Surname { get; set; }
        // E-mail
        public virtual string Email { get; set; }
        //Оценка по математике
        public virtual int MathematicMark { get; set; }
        //Оценка по физике
        public virtual int PhisicMark { get; set; }
        //Оценка по философии
        public virtual int PhilosophyMark { get; set; }
        //Оценка по химии
        public virtual int ChemistryMark { get; set; }
    }
}