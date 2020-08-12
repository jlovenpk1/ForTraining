using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.StackOverflow.OpenFileInFolder
{
    class FileFindFolder
    {
        private bool f1 = false; // чек работы с первой папкой
        private string _firstPath = ""; // первый путь
        private string _secondPath = ""; // второй путь

        /// <summary>
        /// Конструкт класса FileFindFolder
        /// </summary>
        /// <param name="_firstPath">Первый путь до папки</param>
        /// <param name="_secondPath">Второй путь до папки</param>
        public FileFindFolder(string _firstPath, string _secondPath) 
        {
            this._firstPath = _firstPath;
            this._secondPath = _secondPath;
        }

        /// <summary>
        /// Запуск работы программы
        /// </summary>
        public  void Run()
        {
            LookFileFirst();
            LookFileSecond();
            Console.WriteLine("Что бы закончить, нажмите любую кнопку");
            Console.ReadKey();
        }

        /// <summary>
        /// Слежка за первой папкой
        /// </summary>
        private  void LookFileFirst()
        {
            FileSystemWatcher _watcher = new FileSystemWatcher(); // можно упростить создание экземпляра
            
                _watcher.Path = _firstPath; 
                _watcher.Filter = "*.txt";
                _watcher.EnableRaisingEvents = true; 
                _watcher.NotifyFilter = NotifyFilters.FileName; 
                _watcher.Renamed += OnChanged;
        }

        /// <summary>
        /// Слежка за второй папкой
        /// </summary>
        private  void LookFileSecond()
        {
            FileSystemWatcher _watcher = new FileSystemWatcher();

                    _watcher.Path = _secondPath;
                    _watcher.Filter = "*.txt";
                    _watcher.EnableRaisingEvents = true;
                    _watcher.NotifyFilter = NotifyFilters.FileName;
                    _watcher.Renamed += OnChanged2;
                
        }

        /// <summary>
        /// Реакция на приход в первую папку файла
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private  void OnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("Выполняю задачу с первой папкой"); 
            f1 = true;
            // Что то сделалось
            // присвоить f1 = false

        }

        /// <summary>
        /// Реакция на приход во вторую папку файла
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnChanged2(object source, FileSystemEventArgs e)
        {
           if (!f1)
            {
                Console.WriteLine("Выполняю задачу с второй папкой");
            } else { Console.WriteLine("Приоритет работы с файлом из первой папки"); }
          
        }
    }
}
