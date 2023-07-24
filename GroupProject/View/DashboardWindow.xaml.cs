using GUIProject.Model;
using GUIProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUIProject.View
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private List<User> DatabaseUsers;

        public AdminWindow()
        {
            InitializeComponent();
            
        }

        private void Listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

              
        
        private void userlblBack_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = loginWindow;
            loginWindow.Show();
        }

        private void DBStudLink_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow mainlWindow = new MainWindow();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = mainlWindow;
            mainlWindow.Show();
        }
    }
}
