using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    internal class Passport
    {
        public int PassportNumber { get; private set; }
        public string FullName { get; private set; }
        public DateTime DateStart { get; private set; }
        public DateTime DateEnd { get; private set; }
        public string Nationality { get; private set; }

        public Passport(int passportNumber, string fullName, DateTime datestart, DateTime dateend, string nationality)
        {
            PassportNumber = passportNumber; 
            FullName = ValidateFullName(fullName);
            DateStart = datestart;
            DateEnd = ValidateEndDate(datestart, dateend);
            Nationality = ValidateNationality(nationality);
        }
        private string ValidateFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Поле ввода обязательно должно быть заполнено");
            return fullName;
        }
        private DateTime ValidateEndDate(DateTime datestart, DateTime dateend)
        {
            if (dateend <= datestart)
                throw new ArgumentException("Дата окончания действия заграничного паспорта не может быть раньше даты выдачи");
            return dateend;
        }
        private string ValidateNationality(string nationality)
        {
            if (string.IsNullOrWhiteSpace(nationality))
                throw new ArgumentException("Поле ввода обязательно должно быть заполнено");
            return nationality;
        }
        public void OutputPassportInfo()
        {
            Console.WriteLine("Заграничный паспорт:");
            Console.WriteLine($"Номер паспорта: {PassportNumber}");
            Console.WriteLine($"ФИО владельца: {FullName}");
            Console.WriteLine($"Дата выдачи паспорта: {DateStart:dd.MM.yyyy}");
            Console.WriteLine($"Дата окончания действия паспорта: {DateEnd:dd.MM.yyyy}");
            Console.WriteLine($"Национальность: {Nationality}");
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            try
            {
                Passport passport = new Passport(1234567890, "Малиновский Николай Иванович", new DateTime(2024, 10, 27), new DateTime(2029, 10, 27), "Украинец");
                passport.OutputPassportInfo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
