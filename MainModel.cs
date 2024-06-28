using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

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
        public async Task GenerateRecords(int amount)
        {
            _Users.Clear();
            Random random = new Random();

            await Task.Run(() =>
            {
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
            });
        }

        /// <summary>
        /// Метод сортировки коллекции по полю логина
        /// </summary>
        public async Task SortByLogin()
        {
            await Task.Run(() => BubbleSort((user1, user2) => string.Compare(user1.login, user2.login)));
        }

        /// <summary>
        /// Метод сортировки коллекции по полю ника
        /// </summary>
        public async Task SortByNickname()
        {
            await Task.Run(() => BubbleSort((user1, user2) => string.Compare(user1.nickname, user2.nickname)));
        }

        /// <summary>
        /// Метод сортировки коллекции по полю возраста
        /// </summary>
        public async Task SortByAge()
        {
            await Task.Run(() => BubbleSort((user1, user2) => user1.age.CompareTo(user2.age)));
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
            bool swapped;
            for (int i = 0; i < _Users.Count - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < _Users.Count - i - 1; j++)
                {
                    if (comparison(_Users[j], _Users[j + 1]) > 0)
                    {
                       User temp = _Users[j];
                       _Users[j] = _Users[j + 1];
                        _Users[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
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
