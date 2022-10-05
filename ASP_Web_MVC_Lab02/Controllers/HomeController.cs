﻿using ASP_Web_MVC.Models;
using System;
using System.Web.Mvc;

namespace ASP_Web_MVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string hel)
        {
            int hour = DateTime.Now.Hour;
            string Greeting = ModelClass.ModelHello() + ", " + hel;
            //return Greeting;
            //string res = ExeEnum();
            //string res = ExeStruct();
            //string res = ExeFactorial(5);
            string res = ExeTriangle();
            return res;
        }

        public string ExeEnum()
        {
            AccountType goldAccount;
            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            string res1 = String.Format("Тип банковского счета {0}", goldAccount);
            string res2 = String.Format("Тип банковского счета {0}", platinumAccount);
            string res = res1 + "<p>" + res2;
            return res;
        }

        public string ExeStruct() 
        {
            BankAccount goldBankAccount;
            goldBankAccount.accType = AccountType.Checking;
            goldBankAccount.accBal = (decimal)3200.00;
            goldBankAccount.accNo = 123;

            //string res = String.Format("Номер счета {0}, баланс {1}, тип {2}", goldBankAccount.accNo, goldBankAccount.accBal, goldBankAccount.accType);
            //1 - string res = String.Format("Информация о банковском счете: {0}", goldBankAccount);
            //string res = $"Номер счета {accNo}, баланс {accBal}, тип {accYype}";
            //2 - string res = StudyCsharp.SetStatus(3);
            //3 - string res = StudyCsharp.ExeSwitch(StudyCsharp.SetStatus(3));
            string res = StudyCsharp.GetFunction(0, 9);
            return res;
        }

        public string ExeFactorial(int x)
        {
            int f;
            bool ok = StudyCsharp.Factorial(x, out f);

            if (ok)
                return String.Format("Факториал числа {0} равен {1} ",
                x, f);
            else
                return "Невозможно вычислить факториал";
        }

        public string ExeTriangle()
        {
            Triangle tr1 = new Triangle(3, 5, 6);
            string sq1 = String.Format("Площадь фигуры {0} равна: {1:0.##}", tr1.Name, tr1.Area);
            return sq1;
        }
    }
}