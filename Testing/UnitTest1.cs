using System;
using System.Text.RegularExpressions;

namespace Testing;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestFunctionIfnumber1()
    {
        // Arrange

        double a = 3;
        double c = -2;
        double x = 2;

        //double a = 3;
        //double c = 2; //Переменные для вывода ошибки
        //double x = 2;

        double expected = -a * Math.Pow(x, 2);
        double actual;

        // Act
        if (c < 0 && a != 0)
        {
            actual = -a * Math.Pow(x, 2);
        }
        else
        {
            actual = 0; // Начальное значение
        }

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestFunctionIfnumber2()
    {
        
        double a = 0;
        double c = 5;
        double x = 3;

        //double a = 1;
        //double c = 5; //Переменные для вывода ошибки
        //double x = 3;

        double expected = (a - x) / (c * x);
        double actual;

        
        if (c > 0 && a == 0)
        {
            actual = (a - x) / (c * x);
        }
        else
        {
            actual = 0; //Наша начальное значение
        }

       
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestFunctionIfnumber3()
    {
       
        double a = 2;
        double c = 5;
        double x = 3;

        //double a = 0;
        //double c = 5; //Переменные для вывода ошибки
        //double x = 3;

        double expected = -x / (c - a * x);
        double actual;


        if (c < 0 && a == 0 || c > 0 && a != 0)
        {
            actual = -x / (c - a * x);
        }
        else
        {
            actual = 0; // default value
        }

        
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestUserInputIsNumber()
    {
        var consoleInput = "non-numeric input\n"; //Имитация ввода в консоль пользователем
        //var consoleInput = "12"; //Ошибочные данные

        var reader = new StringReader(consoleInput); //считывание  данных
        Console.SetIn(reader); //ввод в консоль считанной строки 
        var result = Console.ReadLine();//запись в переменную result 
        Assert.IsFalse(int.TryParse(result, out int numericResult));
    }

    [TestMethod]
    public void TestInSpecialCharacters()
    {
        string input = "3\n-2\n5\n"; //Эмуляция ввода чисел от пользователя
        //string input = "3@\n-2\n5\n"; //Ошибочные данные

        string pattern = @"^[^@!\\/#$%^&*]+$"; // регулярное выражение для поиска специальных символов
        bool containsSpecialChars = !Regex.IsMatch(input, pattern); //Проверка с помощью регулярки на содержание
                                                                   // специальных символов

        Assert.IsFalse(containsSpecialChars, "Имя файла содержит специальные символы"); //Если найдены спец символы, то ошибка
    }



}