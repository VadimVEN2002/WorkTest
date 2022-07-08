using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Приложение_из_примера_по_курсовой.Model
{
    class TGroup
    {
        string nameGroup; //название группы
        int numStudents; //количество студентов в группе
        TStudent[] students; //студенты группы
       public TGroup()
        {
            try //обработка исключения
            {
                string path = "D:\\list.txt"; //сохраняем путь доступа к файлу
                // Создаем объект класса StremReader для считывания данных с файла.
                StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
                // Объявляем локальные переменные для временного хранения данных.
                string surname; string name; char pol; int day, month, year; string town;
                nameGroup = sr.ReadLine(); //считываем с файла название группы
                numStudents = int.Parse(sr.ReadLine()); //считываем с файла количество студентов
                sr.ReadLine(); //перемещаем указатель в файле на строчку вниз
                students = new TStudent[numStudents]; //создаем массив объектов
                for (int i = 0; i < numStudents; i++) //создаем студентов
                {
                    //Считываем данные с файла.
                    surname = sr.ReadLine();
                    name = sr.ReadLine();
                    pol = char.Parse(sr.ReadLine());
                    day = int.Parse(sr.ReadLine());
                    month = int.Parse(sr.ReadLine());
                    year = int.Parse(sr.ReadLine());
                    town = sr.ReadLine();
                    DateTime date = new DateTime(year, month, day);
                    //Создаем студента.
                    students[i] = new TStudent(surname, name, pol, date, town);
                    sr.ReadLine();
                }
            }
            catch(Exception e) //В случае исключения, выводим информацию об ошибке
            {
                Console.WriteLine(e.Message);
            }
        }
        public string ShowPol () //метод для отображения колличества юношей и девушек в группе
        {
            int m = 0, w = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Pol() == 'M') m++;
                if (students[i].Pol() == 'Ж') w++;
            }
            return $"Количество юношей в группе = {m}\nКоличество девушек в группе = {w} \n";
        }
        public string ShowGroup() //Метод для отображения студентов в группе
        {
            string s = $"Список студентов группы: {nameGroup}\n";
            s += "\n";
            for (int i = 0; i < students.Length; i++)
            {
                s += students[i].ShowStudent();
                s += "\n";
            }
            s += ShowPol();
            return s;
        }
        
    }
}
