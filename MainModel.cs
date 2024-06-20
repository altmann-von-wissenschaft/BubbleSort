using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BubbleSort
{
    /// <summary>
    /// Класс модели
    /// </summary>
    class MainModel : IMainModel
    {
        private static List<User> _Users = new List<User>();

        /// <summary>
        /// Метод возврата коллекции для чтения
        /// </summary>
        public IReadOnlyCollection<User> Users 
        { 
            get { return _Users.AsReadOnly(); }
        }

        /// <summary>
        /// Метод генерации пользователей
        /// </summary>
        /// <param name="amount">Количество пользователей</param>
        public void GenerateRecords(int amount)
        {
            Random random = new Random();

            for (int i = 0; i < amount; i++)
            {
                string login = GenerateRandomString(random, 5, 10);
                string nickname = GenerateRandomString(random, 5, 10);
                byte age = (byte)random.Next(18, 100);

                User user = new User
                {
                    login = login,
                    nickname = nickname,
                    age = age
                };

                _Users.Add(user);
            }
        }

        /// <summary>
        /// Метод сортировки коллекции по полю логина
        /// </summary>
        public void SortByLogin()
        {
            BubbleSort((userPrev, userNext) => string.Compare(userPrev.login, userNext.login));
        }

        /// <summary>
        /// Метод сортировки коллекции по полю ника
        /// </summary>
        public void SortByNickname()
        {
            BubbleSort((userPrev, userNext) => string.Compare(userPrev.nickname, userNext.nickname));
        }

        /// <summary>
        /// Метод сортировки коллекции по полю возраста
        /// </summary>
        public void SortByAge()
        {
            BubbleSort((userPrev, userNext) => userPrev.age.CompareTo(userNext.age));
        }

        /// <summary>
        /// Метод, записывающий коллекцию в csv файл
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        public void SaveAsFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var user in _Users)
                {
                    writer.WriteLine($"{user.login},{user.nickname},{user.age}");
                }
            }
        }

        /// <summary>
        /// Метод, читаюзий коллекцию из csv файла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        public void LoadAsFile(string fileName)
        {
            _Users.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    User user = new User
                    {
                        login = parts[0],
                        nickname = parts[1],
                        age = byte.Parse(parts[2])
                    };
                    _Users.Add(user);
                }
            }
        }

        private void BubbleSort(Comparison<User> comparison)
        {
            for (int i = 0; i < _Users.Count - 1; i++)
            {
                for (int j = 0; j < _Users.Count - i - 1; j++)
                {
                    if (comparison(_Users[j], _Users[j + 1]) > 0)
                    {
                        User temp = _Users[j];
                        _Users[j] = _Users[j + 1];
                        _Users[j + 1] = temp;
                    }
                }
            }
        }

        private string GenerateRandomString(Random random, int minLength, int maxLength)
        {
            int length = random.Next(minLength, maxLength + 1);
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            char[] stringChars = new char[length];

            stringChars[0] = char.ToUpper(chars[random.Next(chars.Length)]);

            for (int i = 1; i < length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(stringChars);
        }
    }
}
