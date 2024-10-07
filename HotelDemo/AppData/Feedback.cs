﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HotelDemo.AppData
{
    /// <summary>
    /// Предоставляет методы для создания сообщений обратной связи с пользователем.
    /// </summary>
    internal class Feedback
    {
        /// <summary>
        /// Генерирует сообщение с исключением.
        /// </summary>
        /// <param name="exception">Исключение</param>
        public static void Error(Exception exception)
        {
            MessageBox.Show(exception.Message, exception.HelpLink, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        /// <summary>
        /// Генерирует сообщение с ошибкой.
        /// </summary>
        /// <param name="text">Текст ошибки</param>
        /// <param name="title">Заголовок ошибки</param>
        public static void Error(string text, string title = "Ошибка")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        /// <summary>
        /// Генерирует сообщение с информацией.
        /// </summary>
        /// <param name="text">Текст информации</param>
        /// <param name="title">Заголовок</param>
        public static void Information(string text, string title = "Информация")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }
        /// <summary>
        /// Генерирует сообщение с вопросом.
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <param name="title">Заголовок</param>
        /// <returns></returns>
        public static bool Question(string text, string title = "Вопрос")
        {
            return MessageBox.Show(text, title, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes;
        }
        /// <summary>
        /// Генерирует сообщение с предупреждением.
        /// </summary>
        /// <param name="text">Сообщение с предупреждением</param>
        /// <param name="title">Заголовок</param>
        public static void Warning(string text, string title = "Предупреждение")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
