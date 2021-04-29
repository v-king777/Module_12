using System.Collections.Generic;

namespace Task_12_1_5
{
    public class ListOfUsers
    {
        private List<User> users = new List<User>();

        public List<User> GetUsers()
        {
            users.Add(new User { Login = "v-king777", Name = "Владимир", IsPremium = true });
            users.Add(new User { Login = "alfa", Name = "Артём", IsPremium = false });
            users.Add(new User { Login = "beta", Name = "Борис", IsPremium = true });
            users.Add(new User { Login = "gamma", Name = "Геннадий", IsPremium = false });
            users.Add(new User { Login = "delta", Name = "Дмитрий", IsPremium = true });

            return users;
        }
    }
}
