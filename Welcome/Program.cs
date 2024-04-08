﻿using System;
using Welcome.Model;
using Welcome.ViewModel;
using Welcome.View;
using Welcome.Others;

namespace Welcome
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            User user = new User
            {
                Name = "John Doe",
                Password = "password123",
                Role = UserRolesEnum.ADMIN
            };

            UserViewModel userViewModel = new UserViewModel(user);

            UserView userView = new UserView(userViewModel);

            userView.Display();

            Console.ReadKey();
        }
    }
}
