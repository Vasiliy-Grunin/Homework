using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace kursach
{
    class Class1
    {
        public string login;
        public string password;
        //public string user;
        public string file = "user.txt";
        public static void registre(string login, string password, string file)
        {
            // throw new NotImplementedException();
            string user = login + password;
            char later;
            int tmp = user.Length;
            char[] c = user.ToCharArray();
            for (int i = 1; i < tmp; i++)
            {
                later = c[i];
                c[i] = c[i - 1];
                c[i - 1] = later;
            }
            using (StreamWriter write = File.CreateText(file))
            {
                if (!String.IsNullOrEmpty(user))
                {
                    write.WriteLine(user);
                }
            }
        }
        public static void st(string l, string p)
        {
            // login = l;
            // password=p;
        }
        public static int input(string login, string password, string file)
        {
            string user = login + password;
            char later;
            int tmp = user.Length;
            char[] c = user.ToCharArray();
            for (int i = 1; i < tmp; i++)
            {
                later = c[i];
                c[i] = c[i - 1];
                c[i - 1] = later;
            }
            string user1 = null;
            tmp = 0;
            using (StreamReader reader = File.OpenText(file))
            {
                do
                {
                    user1 = reader.ReadLine();
                    if (user1 == user)
                        tmp = 1;
                }
                while (!string.IsNullOrEmpty(user1));
            }
            if (tmp == 1)
                return 1;
            else
                return 0;
        }
    }   
}
