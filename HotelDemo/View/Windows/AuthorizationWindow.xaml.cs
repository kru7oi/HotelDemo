using HotelDemo.AppData;
using HotelDemo.Model;
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

namespace HotelDemo.View.Windows
{
    /// <summary>
    /// Interaction logic for AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();

            BlockingUserByDate();
        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            Authorization();
        }

        /// <summary>
        /// Осуществляет авторизацию пользователя в системе по связке логин/пароль.
        /// </summary>
        public void Authorization()
        {
            if (Validation() == true)
            {
                Authentication();
            }
        }
        public void BlockingUserByDate()
        {
            foreach (var user in App.context.User)
            {
                if (user.RegistrationDate.AddMonths(1) <= DateTime.Now)
                {
                    user.IsBlocked = true;
                }
            }

            App.context.SaveChanges();
        }

        public bool Validation()
        {
            if (LoginTb.Text == string.Empty && PasswordPb.Password == string.Empty)
            {
                Feedback.Warning("Введите логин и пароль!");
                return false;
            }
            else if (LoginTb.Text == string.Empty)
            {
                Feedback.Warning("Введите логин!");
                return false;
            }
            else if (PasswordPb.Password == string.Empty)
            {
                Feedback.Warning("Введите пароль!");
                return false;
            }

            return true;
        }

        public void Authentication()
        {
            App.currentUser = App.context.User.FirstOrDefault(user => user.Login == LoginTb.Text && user.Password == PasswordPb.Password);

            if (App.currentUser == null)
            {
                Feedback.Error("Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введенные данные!");
            }
            else if (App.currentUser.IsBlocked == true)
            {
                Feedback.Error("Вы заблокированы. Обратитесь к администратору!");
            }
            else if (App.currentUser.IsActivated == false)
            {
                ChangePasswordWindow changePasswordWindow = new ChangePasswordWindow();
                changePasswordWindow.Show();
                Hide();
            }
            else
            {
                Feedback.Information("Вы успешно авторизовались!");
            }
        }
    }
}
