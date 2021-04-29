using System;

namespace Task_12_1_5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ListOfUsers listOfUsers = new ListOfUsers();
            Advertising advertising = new Advertising();

            foreach (var user in listOfUsers.GetUsers())
            {
                Console.WriteLine("Привет, {0}!", user.Name);

                if (!user.IsPremium)
                {
                    advertising.ShowAds();
                }

                Console.WriteLine();
            }
        }
    }
}
