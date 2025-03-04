using System;
using System.Reflection.Metadata;
using Access_Modifiers.Classes;


namespace Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.eMail = "emretastanberk@gmail.com";
            user.NameSurname = "Emre Taştanberk";
            user.Age = 18;
            user.showInfos();
        }
    }
}

