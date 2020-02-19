using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.ForFun.Delegate
{
    public class Delegate
    {
        public delegate Tuple<Int64, String> MathFunc(Int64 p1, Int64 p2);
        public delegate String HelloWorld(string text);
        public delegate String sayMe(string text);
        public delegate void DMultiCast();
        public delegate void SetStringInt(string p1, int p2);

        private Tuple<Int64, String> Sum(Int64 p1, Int64 p2)
        {
            Int64 result = p1 + p2;
            String _result = "Сложение!";
            return Tuple.Create(result, _result);
        }
        
        private Tuple<Int64, String> Subtract(Int64 p1, Int64 p2)
        {
            Int64 result = p1 - p2;
            String _result = "Вычитание!";
            return Tuple.Create(result, _result);
        }

        private string Say(String text)
        {
            return text;
        }

        private void First()
        {
            Console.WriteLine("Первый здесь");
        }
        private void Second()
        {
            Console.WriteLine("Второй здесь");
        }
        public void Execute()
        {
            MathFunc _func;
            _func = Sum;
            Console.WriteLine("Результат суммирования: " + _func(10, 20).Item1);
            _func = Subtract;
            Console.WriteLine("Результат вычитания: " + _func(20, 10).Item1) ;
            _func = Sum;
            _func += Subtract;
            Console.WriteLine("Верну значение: Сложение или Вычитание?\n" + _func(20, 10).Item2);
            ///
            HelloWorld _hello;
            _hello = Say;
            Console.WriteLine("Скажи: ТЕСТ!\n" + _hello("ТЕСТ"));
            ///
            DMultiCast cast;
            cast = First;
            cast += Second;
            cast();
            /// or 
            DMultiCast cast2;
            cast = First;
            cast2 = Second;
            cast += cast2;
            cast();
            ///or
            cast = First;
            cast2 = cast + Second;
            cast2();
            cast2 -= First;
            cast2();
            ///
            MyClass _mc = new MyClass();
            SetStringInt ssi;
            ssi = _mc.SetNameAge;
            ssi("Mail", 25);
            Console.WriteLine( _mc.Name + " " + "" + _mc.Age);
            ssi("Lisio", -2);
            Console.WriteLine( _mc.Name + " " + "" + _mc.Age);
            Calculator calc = new Calculator();
            calc.Execute("+", 25, 25);
            calc.Execute("-", 25, 25);
            calc.Execute("*", 25, 25);
            calc.Execute("/", 25, 25);
            calc.Execute("плюс", 25, 25);
            MyBot mb = new MyBot();
            mb.Execute();
        }

    }

    public class MyClass
    {
        private string _name;
        private int _age;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { if (value < 0)
                {
                    Console.WriteLine("Возраст у " + Name + " не может быть меньше 0");
                    _age = SetAge();
                } else { _age = value; }
            }
        }

        public void SetNameAge(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        private int SetAge()
        {
            Console.WriteLine("Введите новый возраст: ");
            int age = int.Parse(Console.ReadLine());
            return age;
        }
    }

    public class Calculator
    {
        private Dictionary<string, Operation> Math;
        private delegate double Operation(double p1, double p2);
        private double Sum(double p1, double p2) { return p1 + p2; }
        private double Subtract(double p1, double p2) { return p1 - p2; }
        private double Myltiply(double p1, double p2) { return p1 * p2; }
        private double Divide(double p1, double p2) { return p1 / p2; }
        public void Execute (string operation, double p1, double p2)
        {
            double _result = 0;
            Math = new Dictionary<string, Operation> {  {"+", this.Sum },
                                                        {"-", this.Subtract },
                                                        {"*", this.Myltiply },
                                                        {"/", this.Divide },};
            if (!Math.ContainsKey(operation)) { Console.WriteLine("Увы, операции " + operation + " не существует!");
                Console.WriteLine("Введите корректную операцию! Доступные операции:\n +\n -\n *\n /\n");
                operation = Console.ReadLine(); Execute(operation, p1, p2); }
            else
            { _result = Math[operation](p1, p2); Console.WriteLine("Результат операции " + operation + " : "+_result); }
        }
    }

    public class MyBot
    {

        private Dictionary<string, Message> command;
        private delegate void Message();

        private void OnSayHello() => Console.WriteLine("Да, привет! Как дела? ☺");

        private void OnSayHowAreYou() => Console.WriteLine("Я? Да я, как и все примитивные ИИ - Хорошо, пока меня учат.");

        private void AnswerGood() => Console.WriteLine("Это хорошо! Очень хорошо, что хорошо!");
        private void AnswerBad() => Console.WriteLine("Сочувствую, но увы, ты человек, а значит у тебя всегда будет все плохо, если ты будешь, так сильно переживать!");
        private void Bye() => Console.WriteLine("Пока-Пока!");
        public  void Execute()
        {
            command = new Dictionary<string, Message> { { "Привет", OnSayHello },
                {"Как дела?", OnSayHowAreYou },
                {"Хорошо", AnswerGood },
                {"Плохо", AnswerBad },
                {"Пока", Bye } };
            Console.WriteLine("Доступные команды: ");
            foreach (var c in command)
            {
                Console.WriteLine("Операция: " + c.Key);
            }
            var operation = Console.ReadLine();
            if (operation == "Пока") { command[operation](); } else
            {
                if (!command.ContainsKey(operation))
                {
                    Console.WriteLine("Извините! Я не знаю такие вещи! Попробуйте еще раз! Или вы хотите меня научить?");
                    var Answer = Console.ReadLine();
                    if (Answer == "Учить") { Learn(); }
                    if (Answer == "Попытка") { Execute(); }
                }
                else { command[operation](); Execute(); }
            }
        }

        private void Learn()
        {
            Console.WriteLine("Мне лень учиться :) Пока-Пока");
        }
    }
}
