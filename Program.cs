using System;

namespace L38_workWithClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(12, 2, "Sam", "Archer");

            player.ShowInfo();
            Console.WriteLine();
        }
    }

    class Player
    {
        private int _positionX;
        private int _positionY;
        private string _name;
        private string _combatClass;

        public Player(int positionX, int positionY, string name, string combatClass)
        {
            _positionX = positionX;
            _positionY = positionY;
            _name = name;
            _combatClass = combatClass;
        }

        public int PositionX
        {
            get
            {
                return _positionX;
            }
            private set
            {
                if (value >= 0)
                    _positionX = value;
            }
        }

        public int PositionY
        {
            get
            {
                return _positionX;
            }
            private set
            {
                if (value >= 0)
                    _positionX = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }

        public string ComatClass
        {
            get
            {
                return _combatClass;
            }
            private set
            {
                _combatClass = value;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Местоположение игрока по x:{_positionX} y:{_positionY}" +
                              $"\nИмя игрока: {_name}\tКласс: {_combatClass}");
        }
    }
}
