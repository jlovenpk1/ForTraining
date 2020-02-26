using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining.ForFun.Builder
{
    class Builder
    {
        public void Execute()
        {
            Console.WriteLine("Будем строить дом!");
            MakeStandartHouse msh = new MakeStandartHouse();
            msh.BuildWall();
            msh.BuildHead();
            msh.BuildWindow();
            msh.BuildDoor();
            var house = msh.GetHouse();
            house.InfoHouse();
            Console.ReadKey();

        }
    }

    public interface IBuilder
    {
        void BuildWall();
        void BuildHead();
        void BuildWindow();
        void BuildDoor();

    }

    public class MakeStandartHouse : IBuilder
    {
        private SampleHouse _house = new SampleHouse();

        public MakeStandartHouse()
        {
            this.Reset();
        }

        private void Reset()
        {
            _house = new SampleHouse();
        }

        public SampleHouse GetHouse()
        {
            SampleHouse _currentHouse = this._house;
            this.Reset();
            return _currentHouse;
        }
        public void BuildDoor()
        {
            Console.WriteLine("Введите высоту: \n  Ширину двери: ");
            int h = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип материала(например: дерево): ");
            string type = Console.ReadLine();
            var door = new Door(h, w, type);
            this._house.AddDoor(door);
        }

        public void BuildHead()
        {
            Console.WriteLine("Введите высоту: \n  Ширину крыши: ");
            int h = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип материала(например: дерево): ");
            string type = Console.ReadLine();
            var head = new Head(h, w, type);
            this._house.AddHead(head);
        }

        public void BuildWall()
        {
            Console.WriteLine("Введите высоту: \n  Ширину стен: ");
            int h = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип материала(например: дерево): ");
            string type = Console.ReadLine();
            var wall = new Wall(h, w, type);
            this._house.AddWall(wall);
        }

        public void BuildWindow()
        {
            Console.WriteLine("Введите высоту: \n  Ширину окон: ");
            int h = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип материала(например: дерево): ");
            string type = Console.ReadLine();
            var window = new Window(h, w, type);
            this._house.AddWindow(window);
        }
    }

    public class SampleHouse
    {
        private List<object> _house = new List<object>();

        public void AddWall(Wall wall)
        {
            this._house.Add(wall);
        }
        public void AddHead(Head head)
        {
            this._house.Add(head);
        }
        public void AddWindow(Window window)
        {
            this._house.Add(window);
        }
        public void AddDoor(Door door)
        {
            this._house.Add(door);
        }

        public void InfoHouse()
        {
            foreach(var h in _house)
            {
               if (h is Wall) { var _wall = h as Wall; Console.WriteLine($"Высота стены: {_wall.height}; \n Ширина стены: {_wall.width}; \n Тип материала: {_wall.type}"); }
               if (h is Head) { var _head = h as Head; Console.WriteLine($"Высота крыши: {_head.height}; \n Ширина крыши: {_head.width}; \n Тип материала: {_head.type}"); }
               if (h is Door) { var _door = h as Door; Console.WriteLine($"Высота двери: {_door.height}; \n Ширина двери: {_door.width}; \n Тип материала: {_door.type}"); }
               if (h is Window) { var _window = h as Window; Console.WriteLine($"Высота окна: {_window.height}; \n Ширина окна: {_window.width}; \n Тип материала: {_window.type}"); }
            }

        }
    }

    public class Wall
    {
        public int height;
        public int width;
        public string type;

        public Wall(int height, int width, string type)
        {
            this.height = height;
            this.width = width;
            this.type = type;
        }
    }
    public class Head
    {
        public int height;
        public int width;
        public string type;

        public  Head(int height, int width, string type)
        {
            this.height = height;
            this.width = width;
            this.type = type;
        }
    }
    public class Window
    {
        public int height;
        public int width;
        public string type;

        public Window(int height, int width, string type)
        {
            this.height = height;
            this.width = width;
            this.type = type;
        }
    }
    public class Door
    {
        public int height;
        public int width;
        public string type;

        public Door(int height, int width, string type)
        {
            this.height = height;
            this.width = width;
            this.type = type;
        }
    }
}
