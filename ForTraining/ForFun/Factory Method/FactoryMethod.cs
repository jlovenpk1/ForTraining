using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.ForFun.Factory_Method
{
    class FactoryMethod
    {
        public void Execute()
        {
            Console.WriteLine("С какой компанией Вы хотите ознакомиться?\n 1 Mega Tours Turkish \n 2 One Day Tours \n 3 Sun Tours Turkish");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    WorkWithCompany(new CreateMTT());
                    break;
                case 2:
                    WorkWithCompany(new CreateODT());
                    break;
                case 3:
                    WorkWithCompany(new CreateSTT());
                    break;
                case 0: Console.WriteLine("Требуется выбрать компанию для работы!"); Execute(); break;
            }
        }
        private void WorkWithCompany(Creator create)
        {
            var _company = create.FactoryMethod();
            _company.Info();
            _company.BestTours();
            _company.DiscountTours();
            _company.HotTours();
        }
    }

    /// <summary>
    /// Класс создатель, данный класс создает в будущем экзепляры
    /// </summary>
    public abstract class Creator
    {
        public abstract ICompany FactoryMethod();

        public void OnCreateCompany()
        {
            var _company = FactoryMethod();
            _company.Info();
        }
    }

    public class CreateMTT: Creator
    {

        public override ICompany FactoryMethod()
        {
            return new MegaToursTurkish();
        }
    }
    public class CreateODT: Creator
    {

        public override ICompany FactoryMethod()
        {
            return new OneDayTours();
        }
    }
    public class CreateSTT: Creator
    {

        public override ICompany FactoryMethod()
        {
            return new SunToursTurkish();
        }
    }

    public class MegaToursTurkish : ICompany
    {
        public void BestTours()
        {
            Console.WriteLine("Лучший тур: 11 дней 12 ночей, Анталия 110 000р с человека");
        }

        public void DiscountTours()
        {
            Console.WriteLine("Скидки на туры: 7 дней 8 ночей, Алания 55 000р с человека");
        }

        public void HotTours()
        {
            Console.WriteLine("Горячие туры: Мухмутар. Алания. Анталия.");
        }

        public void Info()
        {
            Console.WriteLine("Лучшие туры в Турции: Компания Mega Tours Turkish. Отдых для Вас и Ваших детей.");
        }
    }
    public class OneDayTours : ICompany
    {
        public void BestTours()
        {
            Console.WriteLine("Лучший тур: 15 дней 116 ночей, Анталия 120 000р с человека");
        }

        public void DiscountTours()
        {
            Console.WriteLine("Скидки на туры: 7 дней 8 ночей, Алания 57 000р с человека");
        }

        public void HotTours()
        {
            Console.WriteLine("Горячие туры: Мухмутар. Алания. Анталия.");
        }

        public void Info()
        {
            Console.WriteLine("Лучшие туры в Турции: Компания One Day Tours. Отдых для Вас и Ваших детей.");
        }
    }
    public class SunToursTurkish : ICompany
    {
        public void BestTours()
        {
            Console.WriteLine("Лучший тур: 9 дней 10 ночей, Анталия 75 000р с человека");
        }

        public void DiscountTours()
        {
            Console.WriteLine("Скидки на туры: 5 дней 6 ночей, Алания 35 000р с человека");
        }

        public void HotTours()
        {
            Console.WriteLine("Горячие туры: Мухмутар. Алания. Анталия.");
        }

        public void Info()
        {
            Console.WriteLine("Лучшие туры в Турции: Sun Tours Turkish. Отдых для Вас и Ваших детей.");
        }
    }
    public interface ICompany
    {
        void Info();
        void HotTours();
        void BestTours();
        void DiscountTours();
    }
}
