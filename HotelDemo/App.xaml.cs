using HotelDemo.Model;
using HotelDemo.View.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;

namespace HotelDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Представляет контекст данных для взаимодействия с базой данных.
        /// </summary>
        public static HotelEntities context = new HotelEntities();

        /// <summary>
        /// Представляет поле для хранения пользователя вошедшего в систему.
        /// </summary>
        public static User currentUser;
    }
}
