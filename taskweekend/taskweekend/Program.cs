using System;

namespace taskweekend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

        }
    }
    class Person
    {
        public string _name;
        public string _surname;
        public string _fathername;
        public DateTime _birthday;
        public int  _fincode;
        public int _telenum;
        public int _salary;

        public Person(string name, string surname,string fathername, DateTime birthday, int fincode, int telenum, int salary)
        {
            _name = name;
            _surname = surname;
            _fathername = fathername;
            _birthday = birthday;
            _fincode = fincode;
            _telenum = telenum;
            _salary = salary;
        }

        static bool Name1(string name)
        {

            char[] alfabet = { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            for (int i = 0; i < alfabet.Length; i++)
            {
                for (int k = 0; k < name.Length; k++)
                {
                    if (name[k] != alfabet[i])
                    {
                        Console.WriteLine("incorrect");
                        break;
                    }
                }
            }
            return true;
        }
        static bool Name2(string name)
        {

            char[] smallLetter = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            for (int i = 0; i < smallLetter.Length; i++)
            {
                if (name.Length < 2 || name.Length > 20)
                {
                    Console.WriteLine("incorrect");
                    break;
                }
            }
            return true;
        }
        static bool Name3(string name)
        {

            char[] smallLetter = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            for (int i = 0; i < smallLetter.Length; i++)
            {

                if (name[0] == smallLetter[i])
                {
                    Console.WriteLine("incorrect");
                    break;
                }


            }
            return true;
        }
        static bool Surname1(string surname)
        {
            char[] alfabet = { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            for (int i = 0; i < alfabet.Length; i++)
            {
                for (int k = 0; k < surname.Length; k++)
                {
                    if (surname[k] != alfabet[i])
                    {
                        Console.WriteLine("incorrect");
                        break;
                    }
                }
            }
            return true;
        }
        static bool Surname2(string surname)
        {
            char[] smallLetter = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            for (int i = 0; i < smallLetter.Length; i++)
            {
                if (surname.Length < 2 || surname.Length > 20)
                {
                    Console.WriteLine("incorrect");
                    break;
                }
            }
            return true;
        }
        static bool Surname3(string surname)
        {
            char[] smallLetter = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            for (int i = 0; i < smallLetter.Length; i++)
            {

                if (surname[0] == smallLetter[i])
                {
                    Console.WriteLine("incorrect");
                    break;
                }


            }
            return true;
        }
        static bool Fathername1(string fathername)
        {
            char[] alfabet = { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            for (int i = 0; i < alfabet.Length; i++)
            {
                for (int k = 0; k < fathername.Length; k++)
                {
                    if (fathername[k] != alfabet[i])
                    {
                        Console.WriteLine("incorrect");
                        break;
                    }
                }
            }
            return true;
        }
        static bool Fathername2(string fathername)
        {
            char[] smallLetter = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            for (int i = 0; i < smallLetter.Length; i++)
            {
                if (fathername.Length < 2 || fathername.Length > 20)
                {
                    Console.WriteLine("incorrect");
                    break;
                }
            }
            return true;
        }
        static bool Fathername3 (string fathername)
        {
            char[] smallLetter = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            for (int i = 0; i < smallLetter.Length; i++)
            {

                if (fathername[0] == smallLetter[i])
                {
                    Console.WriteLine("incorrect");
                    break;
                }


            }
            return true;
        }
        static bool Age(int age)
        {
            if(18<age && age<65)
            {
                return true;
            }
            return false;
        }
        static bool Fintype1(string fincode)
        {
            if (fincode.Length!=7)
            {
                Console.WriteLine("incorrect");
                
            }
           return true;
        }
        
    }
}

