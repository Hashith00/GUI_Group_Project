using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GUIProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace GUIProject.ViewModel
{
    public partial class LoginWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string username;

        [ObservableProperty]
        public string password;

        public readonly UserDataContext dbContext;

        
        [RelayCommand]
        public void MinimizeWindow()
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        [RelayCommand]
        public void CloseWindow()
        {
            Application.Current.MainWindow.Close();
        }


        public LoginWindowVM(UserDataContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public LoginWindowVM()
        {

        }


        [RelayCommand]
        private void Login()
        {
            var user = dbContext.Users.FirstOrDefault(u => u.Name == username && u.Pasword == password);

            if (user != null)
            {
                Window window;

                if (user.IsAdmin)
                {
                    window = new AdminWindow();
                }
                else
                {
                    window = new MainWindow();
                }


                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
                window.Show();


            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
