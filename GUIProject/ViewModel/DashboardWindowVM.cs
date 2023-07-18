﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GUIProject.Model;
using GUIProject.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

namespace GUIProject.ViewModel
{
    public partial class DashboardWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string name;

        [ObservableProperty]
        public string pasword;

        [ObservableProperty]
        public bool role;

        
        [ObservableProperty]
        ObservableCollection<User> users;

        [ObservableProperty]
        public User selectedUser = null;

        [RelayCommand]
        public void InsertUser()
        {
            User u = new User()
            {
                Name = "",
                Pasword = "",
                IsAdmin = false
            };
            selectedUser = u;
            users.Add(u);

            using (var db = new UserDataContext())
            {
                db.Users.Add(u);
                db.SaveChanges();
            }
            LoadUser();
        }

        [RelayCommand]
        public void UpdateUser()
        {
            using (var db = new UserDataContext())
            {
                var existingUser = db.Users.FirstOrDefault(p => p.Id == selectedUser.Id);
                if (existingUser != null)
                {
                    existingUser.Name = selectedUser.Name;
                    existingUser.Pasword = selectedUser.Pasword;
                    existingUser.IsAdmin = selectedUser.IsAdmin; 
                    
                    db.SaveChanges();
                }
            }
            LoadUser();
        }


        [RelayCommand]
        public void DeleteUser()
        {
            using (var db = new UserDataContext())
            {
                var existingUser = db.Users.FirstOrDefault(p => p.Id == selectedUser.Id);
                if (existingUser != null)
                {
                    db.Users.Remove(existingUser);
                    db.SaveChanges();
                    users.Remove(selectedUser);
                }
            }
            LoadUser();
        }

        [RelayCommand]
        public void LoadUser()
        {
            using (var db = new UserDataContext())
            {
                var list = db.Users.OrderBy(p => p.Id).ToList();
                users.Clear();
                foreach (var user in list)
                {
                    users.Add(user);
                }
                
            }

            
        }

       

        public DashboardWindowVM()
        {
            users = new ObservableCollection<User>();
            LoadUser();
        }
    }
}
