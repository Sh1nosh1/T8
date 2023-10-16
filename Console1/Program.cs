using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*string str1;    //Объявление строковой величины без инициализации

                string str2 = null;     //Инициализация стр. величины с неопределённым значением (выведет пустую строку)
                WriteLine(str2);

                string str3 = String.Empty;     //Строка объявляется как пустая с помощью метода .Empty
                WriteLine(str3);

                string str4 = "На улице осень";     //Инициализация строковым литералом или константой
                WriteLine(str4);

                var str5 = "Информатика";       //Строковое значение переменной присваивается без явного вывода конструктора
                WriteLine(str5);

                string str6 = new String('a', 6);       //Инициализация строки с использованием конструктора класса String
                WriteLine(str6);

                char[] str7 = {'m','e','s','s','a','g','e'};    //Создание строки из массива символов
                WriteLine(str7);

                string str8 = new string(str7);     //Создание строки из массива символов
                WriteLine(str8);*/

                //Конкатенация (объединение строк)

                //ex1
                //string st1 = "я люблю";
                //string st2 = " программирование";
                //string st3 = " на языке С#";
                //string st = st1 + st2 + st3;
                //WriteLine(st);

                //ex2
                //st1 += st2;
                //st1 += st3;
                //WriteLine(st1);

                //ex3
                //string st4 = String.Concat(st," !!!");
                //WriteLine(st4);

                //ex4
                //string st1 = "я";
                //string st2 = "люблю";
                //string st3 = "программирование";
                //string[] omas = new string[] { st1, st2, st3 };
                //string s = String.Join(" ", omas); //только с массивом
                //WriteLine(s);

                // переменная а=фальш б=монеты с=б д=ивые е= в мешках
                /*string st1 = "фальш";
                string st2 = "монеты";
                string st3 = "в";
                string st4 = "ивые";
                string st5 = "мешках";*/
                //string st6 = " ";

                /*st1 += st4;
                st1 += st2;
                st1 += st3;
                st1 += st5;
                WriteLine(st1);*/

                /* string st = String.Concat(st1,st4,st6,st2,st6,st3,st6,st5);
                 WriteLine(st);*/

                /*st1 += st4;
                string[] omas = new string[] { st1, st2, st3, st5 };
                string s = String.Join(" ", omas);
                WriteLine(s);*/

                //Найти индекс первого подстроки в строке

                Write("Введите строку: ");
                string st1 = ReadLine();
                Write("Введите подстроку: ");
                string st2 = ReadLine();
                int index = st1.IndexOf(st2);
                Write(index);
            }
            catch 
            { 
            
            }
            ReadKey();
        }
    }
}
