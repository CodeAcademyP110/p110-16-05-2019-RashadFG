using System;

namespace _20._05._0219
{
    class Program
    {
        static void Main(string[] args)
        {
            Student samir = new Student("Samir", "Dadashzade", new DateTime(1996, 09, 06), "rashadfg@gmail.com");

            //Console.WriteLine(samir.Firstname);
            //Console.WriteLine(samir.Lastname);
            //Console.WriteLine(samir.Date);
            //Console.WriteLine(samir.Age);
            //Console.WriteLine(samir.getUsername());

            Console.WriteLine(samir.ShowInfo());
            //Console.WriteLine(samir.FullInfo());
        }
    }

    class Student
    {
        public string Firstname;
        public string Lastname;
        private string Username;
        public DateTime Date = new DateTime();
        private string Email;
        public int Age;

        //consturtor 1
        public Student(string name, string surname)
        {
            setName(name);
            setLastName(surname);
            Username = ($"{Firstname.ToLower()}  {Lastname.ToLower()}").Replace(" ", "");
        }

        //constroctor 2
        public Student(string name, string surname, DateTime date, string email) : this(name, surname)
        {
            getAGE(date);
            getDate(date);
            getEmail(email);
        }

        //get Username
        public string getUsername()
        {
            return Username;
        }

        //checked email
        public void getEmail(string email)
        {
            if (email.IndexOf("@gmail.com") != -1)
            {
                Email = email;
            }
            else
            {
                Console.WriteLine("please input valid email");
            }
        }

        //get date
        public void getDate(DateTime date)
        {
            if (date < DateTime.Now)
            {
                Date = date;
            }
        }

        //getage
        public void getAGE(DateTime date)
        {
            if (date < DateTime.Now)
            {

                Age = DateTime.Now.Year - date.Year;
            }
        }

        //setName
        public void setName(string name)
        {
            if (name.Length > 2)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] > 0 && (int)name[i] >= 65 && (int)name[i] <= 128)
                    {
                        Firstname = name;
                    }
                    else
                    {
                        Console.WriteLine("pleae input valid name");
                    }
                }
            }
            else
            {
                Console.WriteLine("pleae input valid name");
            }
        }

        //setLastName
        public void setLastName(string surname)
        {
            if (surname.Length > 2)
            {
                for (int i = 0; i < surname.Length; i++)
                {
                    if (surname[i] > 0 && (int)surname[i] >= 65 && (int)surname[i] <= 122)
                    {
                        Lastname = surname;
                    }
                    else
                    {
                        Console.WriteLine("pleae input valid surname");
                    }
                }
            }
            else
            {
                Console.WriteLine("pleae input valid surname");
            }
        }

        //showInfo
        public string ShowInfo()
        {
            return Username;
        }

        //FullInfo
        public string FullInfo()
        {
            return $"{Firstname} {Lastname} {Username} {Date}  {Email}";
        }
    }
}
