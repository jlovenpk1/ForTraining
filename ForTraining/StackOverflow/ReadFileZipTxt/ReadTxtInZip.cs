using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.StackOverflow.ReadFileZipTxt
{
    class ReadTxtInZip
    {
        string _zipPath = @"D:\1.zip"; // путь до архива
        string _pathTxt = @"D:\"; // куда будет грузить файл из архива
        string _nameFile = "1.txt"; // текстовый документ его имя
        string _word = "Test"; // переменная которую записываем 

        public void workWithZip()
        {
            using (ZipArchive archive = ZipFile.Open(_zipPath, ZipArchiveMode.Update)) // открываем архив в режиме Update(Запись/Чтение)
            {
                archive.ExtractToDirectory(_pathTxt); // выгружаем файл из архива
                using (StreamWriter sw = new StreamWriter(_pathTxt+_nameFile, false, System.Text.Encoding.UTF8)) // открываем файл
                {
                    sw.WriteLine(_word); // записываем переменную
                }
                archive.CreateEntryFromFile(_pathTxt + _nameFile, _nameFile); // загружаем файл обратно в архив
            }

        }

        public void workWithZip2()
        {
            try
            {
                using (ZipArchive archive = ZipFile.Open(_zipPath, ZipArchiveMode.Update)) // открываем архив в режиме Update(Запись/Чтение)
                {
                    archive.ExtractToDirectory(_pathTxt); // выгружаем файл из архива
                    using (StreamWriter sw = new StreamWriter(_pathTxt + _nameFile, false, System.Text.Encoding.UTF8)) // открываем файл
                    {
                        sw.WriteLine(_word); // записываем переменную
                    }
                    archive.CreateEntryFromFile(_pathTxt + _nameFile, _nameFile); // загружаем файл обратно в архив
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: "+ex.Message);
            }
            finally
            {
                Console.WriteLine("Устраните ошибку и нажмите кнопку, что бы продолжить!");
                Console.ReadKey();
                workWithZip2();
            }
            
        }

    }
}
