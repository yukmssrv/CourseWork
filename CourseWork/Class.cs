using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork;
using System.Text.Json.Serialization;

namespace CourseWork
{
    [Serializable]
    public class Avto
    {
        private string registrationnumber;
        private string name;
        private string firma;
        private string bodynumber;
        private string chassisnumber;
        private string enginenumber;
        private string bodymodel;
        private string color;
        private double volume;
        private int power;
        private string wheel;
        private string drivewheel;
        private int yearv;
        private string dateofregistration;
        private string tehtalonumber;
        private string datetehtalon;
        private int yeartax;
        private int index = 0;

        public string Dateofregistration { get; set; }
        public string Datetehtalon { get; set; }
        public int Index { get ; set; }
        public string Registrationnumber
        {
            get { return registrationnumber; }
            set
            {
                if ((value.Length < 8) || (value.Length > 10))
                {
                    throw new Exception("Введено некорректное значение регистрационного номера автомобиля. Убедитесь, что ввели от 8 до 10 сиволов ");
                }
                else
                {
                    registrationnumber = value;
                }
            }
        }
        public string Name { get; set; }
        public string Firma { get; set; }
        public string Bodynumber
        {
            get { return bodynumber; }
            set
            {
                if (value.Length != 17)
                {
                    throw new Exception("Введено некорректное значение номера кузова автомобиля. Убедитесь, что введено 17 символов ");
                }
                else
                {
                    bodynumber = value;
                }
            }
        }
        public string Chassisnumber { get; set; }
        public string Enginenumber
        {
            get { return enginenumber; }
            set
            {
                if (value.Length != 14)
                {
                    throw new Exception("Введено некорректное значение номера двигателя. Убедитесь, что введено 14 символов");
                }
                else
                {
                    enginenumber = value;
                }
            }
        }
        public string Bodymodel { get; set; }
        public string Color
        {
            get { return color; }
            set
            {
                if (!Regex.IsMatch(value, "^[a-zA-Zа-яА-ЯёЁ]+$"))
                {
                    throw new Exception("Цвет может быть записан только в буквенном виде");
                }
                else
                {
                    color = value;
                }
            }
        }
        public double Volume
        {
            get { return volume; }
            set
            {
                if ((value < 0) || (value >= 30))
                {
                    throw new Exception("Введено некорректное значение объема. Введите значение от 1 до 30 литров ");
                }
                else
                {
                    volume = value;
                }
            }
        }
        public int Power
        {
            get { return power; }
            set
            {
                if ((value < 0) || (value >= 1500))
                {
                    throw new Exception("Введено некорректное значение мощности. Введите значение от 1 до 1500 ");
                }
                else
                {
                    power = value;
                }
            }
        }
        public string Wheel { get; set; }
        public string Drivewheel { get; set; }
        public int Yearv
        {
            get { return yearv; }
            set
            {
                if ((value < 1900) || (value > 2024))
                {
                    throw new Exception("Введено некорректное значение года выпуска. Убедитесь, что ввели год выпуска позже 1900");
                }
                else
                {
                    yearv = value;
                }
            }

        }
        public string Tehtalonumber { get; set; }
        public int Yeartax { get; set; }
        private double VolumewithPoint(string str)
        {
            string double_str = "";
            foreach (char vol in str)
            {
                if (vol == '.')
                {
                    double_str += ',';
                }
                else
                {
                    double_str += vol;
                }
            }
            return double.Parse(double_str);
        }
        public void ValidateDates()
        {
            // Преобразование строк в даты
            DateTime registrationDate = DateTime.Parse(Dateofregistration);
            DateTime tehtalonDate = DateTime.Parse(Datetehtalon);
            if (yearv > registrationDate.Year)
            {
                throw new Exception("Год выпуска автомобиля должен быть раньше года постановки на учет.");
            }
            if (yearv > tehtalonDate.Year)
            {
                throw new Exception("Год выпуска автомобиля должен быть раньше года выдачи тех.талона.");
            }
        }
        public Avto(string Registrationnumber, string Name, string Firma, string Bodynumber, string Chassisnumber, string Enginenumber, string Bodymodel, string Color, string Volume, int Power, string Wheel, string Drivewheel, int Yearv, string Dateofregistration, string Tehtalonumber, string Datetehtalon, int Yeartax,int Index = 0)
        {
            this.Registrationnumber = Registrationnumber;
            this.Name = Name;
            this.Firma = Firma;
            this.Bodynumber = Bodynumber;
            this.Chassisnumber = Chassisnumber;
            this.Enginenumber = Enginenumber;
            this.Bodymodel = Bodymodel;
            this.Color = Color;
            this.Volume = VolumewithPoint(Volume);
            this.Power = Power;
            this.Wheel = Wheel;
            this.Drivewheel = Drivewheel;
            this.Yearv = Yearv;
            this.Dateofregistration = Dateofregistration;
            this.Tehtalonumber = Tehtalonumber;
            this.Datetehtalon = Datetehtalon;
            this.Yeartax = Yeartax;
            this.Index = Index;
        }
        public Avto(string Registrationnumber, string Name, string Firma, string Bodynumber, string Chassisnumber, string Enginenumber, string Bodymodel, string Color, double Volume, int Power, string Wheel, string Drivewheel, int Yearv, string Dateofregistration, string Tehtalonumber, string Datetehtalon, int Yeartax, int Index)
        {
            this.Registrationnumber = Registrationnumber;
            this.Name = Name;
            this.Firma = Firma;
            this.Bodynumber = Bodynumber;
            this.Chassisnumber = Chassisnumber;
            this.Enginenumber = Enginenumber;
            this.Bodymodel = Bodymodel;
            this.Color = Color;
            this.Volume = Volume;
            this.Power = Power;
            this.Wheel = Wheel;
            this.Drivewheel = Drivewheel;
            this.Yearv = Yearv;
            this.Dateofregistration = Dateofregistration;
            this.Tehtalonumber = Tehtalonumber;
            this.Datetehtalon = Datetehtalon;
            this.Yeartax = Yeartax;
            this.Index = Index;
        }
        public Avto()
        {
            this.Registrationnumber = "12345678";
            this.Name = "a";
            this.Firma = "firr";
            this.Bodynumber = "12345678901234567";
            this.Chassisnumber = "12345678901234";
            this.Enginenumber = "12345678901234";
            this.Bodymodel = "Bodymodel";
            this.Color = "Color";
            this.Volume = 1;
            this.Power = 1;
            this.Wheel = "Wheel";
            this.Drivewheel = "Drivewheel";
            this.Yearv = 1999;
            this.Dateofregistration = "Dateofregistration";
            this.Tehtalonumber = "Tehtalonumber";
            this.Datetehtalon = "Datetehtalon";
            this.Yeartax = 1999;
            this.Index = 0;
        }

    }
    [Serializable]
    public struct FIO
    {
        [JsonInclude]
        public string name;
        [JsonInclude]
        public string surname;
        [JsonInclude]
        public string middlename;
        public FIO(string name, string surname, string middlename)
        {
            this.name = name;
            this.surname = surname;
            this.middlename = middlename;
            if (name.Length < 0 || !FIOwithoutDigit(name))
            {
                name = null;
                throw new Exception("Введено некорректное значение имени ");
            }
            if (surname.Length < 0 || !FIOwithoutDigit(surname))
            {
                throw new Exception("Введено некорректное значение фамилии ");
            }
            if (middlename.Length < 0 || !FIOwithoutDigit(middlename))
            {
                throw new Exception("Введено некорректное значение отчества ");
            }
        }
        public FIO()
        {
            name = "Иван";
            surname = "Иванов";
            middlename = "Иванович";

        }
        public bool FIOwithoutDigit(string str)
        {
            foreach (char simb in str)
            {
                if (!((simb >= 'A' && simb <= 'Z') ||
                        (simb >= 'a' && simb <= 'z') ||
                        (simb >= 'А' && simb <= 'Я') ||
                        (simb >= 'а' && simb <= 'я') ||
                        simb == 'Ё' || simb == 'ё'))
                {
                    return false;
                }
            }
            return true;
        }
    }
    [Serializable]
    public class Owner
    {
        public FIO fio;
        private ulong phonenumber;
        public Avto av;
        private string city;
        private string street;
        private string house;
        private string flat;

        public ulong Phonenumber
        {
            get { return phonenumber; }
            set
            {
                if ((value < 100) || (value > 100000000000))
                {
                    throw new Exception("Введено некорректное значение номера телефона ");
                }
                else
                {
                    phonenumber = value;
                }
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (!Regex.IsMatch(value, "^[a-zA-Zа-яА-ЯёЁ-]+$"))
                {
                    throw new Exception("Город может записываться только в буквенном виде");
                }
                else
                {
                    city = value;
                }
            }
        }
        public string Street { get; set; }
        public string House { get; set; }

        public string Flat { get; set; }
        public Owner(string surname, string name, string middlename, ulong phonenumber, Avto avto, string city, string street, string house, string flat)
        {
            fio = new FIO(name, surname, middlename);
            Phonenumber = phonenumber;
            av = avto;
            City = city;
            Street = street;
            House = house;
            Flat = flat;
        }
        public Owner()
        {
            fio = new FIO();
            Phonenumber = 88005553535;
            av = new Avto();
            City = "Москва";
            Street = "улица";
            House = "35";
            Flat = "11";

        }
    }
    [Serializable]
    public class Fowner : Owner
    {
        private string passportnumber;
        private string passportseries;
        public string datePassport;
        private string passportorganization;
        public string Passportseries
        {
            get { return passportseries; }
            set
            {
                if (value.Length != 4 || !Regex.IsMatch(value, "^[0-9]+$"))
                {
                    throw new Exception("Введено некорректное значение серии паспорта. Серия должна состоять из 4 цифр.");
                }
                else
                {
                    passportseries = value;
                }
            }
        }

        public string Passportnumber
        {
            get { return passportnumber; }
            set
            {
                if (value.Length != 6 || !Regex.IsMatch(value, "^[0-9]+$"))
                {
                    throw new Exception("Введено некорректное значение номера паспорта. Номер должен состоять из 6 цифр.");
                }
                else
                {
                    passportnumber = value;
                }
            }
        }
        public string Passportorganization { get; set; }
        public Fowner(Avto avto, string city, string street, string house, string flat, string surname, string name, string middlename, ulong phonenumber, string passportseries, string passportnumber, string datePassport, string passportorganization) : base(surname, name, middlename, phonenumber, avto, city, street, house, flat)
        {
            City = city;
            Street = street;
            House = house;
            Flat = flat;
            fio = new FIO(name, surname, middlename);
            Phonenumber = phonenumber;
            av = avto;
            Passportnumber = passportnumber;
            Passportseries = passportseries;
            this.datePassport = datePassport;
            Passportorganization = passportorganization;
        }
        public Fowner()
        {
            City = "Москва";
            Street = "ааааа";
            House = "35";
            Flat = "54";
            fio = new FIO();
            Phonenumber = 88005553535;
            av = new Avto();
            Passportnumber = "123424";
            Passportseries = "1234";
            this.datePassport = "14 февраля 2024";
            Passportorganization = "ГУ МВД";
        }
    }
    [Serializable]
    public class Yuowner : Owner
    {
        private string organizationname;
        public string Organizationname { get; set; }
        public Yuowner(Avto avto, string organizationname, string city, string street, string house, string flat, string surname, string name, string middlename, ulong phonenumber) : base(surname, name, middlename, phonenumber, avto, city, street, house, flat)
        {
            Organizationname = organizationname;
            City = city;
            Street = street;
            House = house;
            Flat = flat;
            fio = new FIO(name, surname, middlename);
            Phonenumber = phonenumber;
            av = avto;
        }
        public Yuowner()
        {
            Organizationname = "ООО Воздушные шары";
            City = "Санкт-Петербург";
            Street = "ааа";
            House = "14";
            Flat = "11";
            fio = new FIO();
            Phonenumber = 88005553535;
            av = new Avto();
        }
    }
    [Serializable]
    public class Driver
    {
        private FIO Fio;
        private string Datebirth;
        private string numberVU;
        private string category;
        private string DateVU;
        private int Index = 0;
        public FIO fio { get; set; }
        public string datebirth { get; set; }
        public string dateVU { get; set; }
        public int index { get; set; }
        public string NumberVU
        {
            get { return numberVU; }
            set
            {
                if (value.Length != 10 || !value.All(char.IsDigit))
                {
                    throw new Exception("Введено некорректное значение номера водительского удостоверения. Удостоверьтесть, что написано 10 ЦИФР без пробелов (4 цифры - серия, 6 цифр - номер)");
                }
                else
                {
                    numberVU = value;
                }
            }
        }
        public string Category { get; set; }
        public Driver(string surname, string name, string middlename, string datebirth, string NumberVU, string Category, string dateVU)
        {
            fio = new FIO(name, surname, middlename);
            this.datebirth = datebirth;
            this.NumberVU = NumberVU;
            this.Category = Category;
            this.dateVU = dateVU;
        }
        public Driver(string surname, string name, string middlename, string datebirth, string NumberVU, string Category, string dateVU, int index)
        {
            Fio = new FIO(name, surname, middlename);
            this.Datebirth = datebirth;
            this.numberVU = NumberVU;
            this.category = Category;
            this.DateVU = dateVU;
            this.Index = index;
        }
        public Driver()
        {
            this.Fio = new FIO();
            this.Datebirth = "11 марта 2021";
            this.numberVU = "1234567890";
            this.category = "А";
            this.DateVU = "10 мая 2020";
            this.Index = 0;
        }
        public void ValidateDateOfBirth()
        {
            // Преобразование строки в дату
            DateTime birthDate = DateTime.Parse(datebirth);
            DateTime VUdate = DateTime.Parse(dateVU);
            if (birthDate.Year > 2006)
            {
                throw new Exception("Дата рождения водителя должна быть не позже 2006. ВУ получает человек, достигший совершенолетия.");
            }
            if (VUdate.Year < birthDate.Year + 18)
            {
                throw new Exception("ВУ не может быть выдано до совершенолетия");
            }
        }
    }
    [Serializable]
    public class Technical_Inspection
    {
        public Avto av;
        public string dateTO;
        public FIO fio;
        private int mileage; //пробег
        private int pay; //оплата за ТО
        private int paysign; //оплата за знак ТО
        public int Mileage { get; set; }
        public int Pay { get; set; }
        public int Paysign { get; set; }
        public Technical_Inspection(Avto avto, string dateTO, string surname, string name, string middlename, int mileage, int pay, int paysign)
        {
            av = avto;
            this.dateTO = dateTO;
            fio = new FIO(name,surname,middlename);
            Mileage = mileage;
            Pay = pay;
            Paysign = paysign;
        }
        public Technical_Inspection()
        {
            av = new Avto();
            this.dateTO = "1 апреля 2011";
            fio = new FIO();
            Mileage = 11111;
            Pay = 22222;
            Paysign = 33333;
        }
        public void ValidateDateTO()
        {
            // Преобразование строки в дату
            DateTime TOdate = DateTime.Parse(dateTO);
            if (TOdate.Year >= 2025)
            {
                throw new Exception("Дата рождения водителя должна быть не позже 2006. ВУ получает человек, достигший совершенолетия.");
            }
        }
    }
    [Serializable]
    public class Accident
    {
        public string dateDTP;
        private string place;
        public string participant;
        private string severity; //степень тяжести дтп
        public FIO fio;
        private string description;//описание

        public string Place { get; set; }
        public string Severity { get; set; }
        public string Description { get; set; }
        public Accident(string dateDTP, string place, string Participant, string severity, string surname, string name, string middlename, string description)
        {
            this.dateDTP = dateDTP;
            Place = place;
            participant = Participant;
            Severity = severity;
            fio = new FIO(name, surname, middlename);
            Description = description;
        }
        public Accident()
        {
            this.dateDTP = "12 сентября 2010";
            Place = "Площадь";
            participant = "водитель и авто";
            Severity = "спедней тяжести";
            fio = new FIO();
            Description = "гололед";
        }
        public void ValidateDateDTP()
        {
            // Преобразование строки в дату
            DateTime DTPdate = DateTime.Parse(dateDTP);
            if (DTPdate.Year >= 2025)
            {
                throw new Exception("Дата рождения водителя должна быть не позже 2006. ВУ получает человек, достигший совершенолетия.");
            }
        }
    }
}
