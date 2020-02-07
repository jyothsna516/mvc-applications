using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMvcModelValidation.Models;

namespace HandsOnMvcModelValidation.Repositories
{
    public class UserRepository
    {
        public static List<User> list = new List<User>() { new User(){ Name = "jyo", Uname = "jyo123",Country = "India", Pwd = "jyo123"}

            };
            public UserRepository()
            {
            }
        public void Add(User item)
        {
            list.Add(item);// add user data in list
        }
        public User Validate(string uname,string pwd)
        {
            foreach(var item in list)
            {
                if(item.Uname==uname&& item.Pwd == pwd)
                {
                    return item;
                }

            }
            return null;
        }
    }
}
