namespace P02._Identity_Before
{
    using Contracts;
    using System;
    using System.Collections.Generic;

    public class AccountManager : IAccountAuthentifiable
    {
        
        public void Register(string username, string password)
        {
            Console.WriteLine("Registered!");
        }

        public void Login(string username, string password)
        {
            Console.WriteLine("Login successful!");
        }

        public void ChangePassword(string oldPass, string newPass)
        {
            Console.WriteLine("Password changed!");
        }

        
    }
}
