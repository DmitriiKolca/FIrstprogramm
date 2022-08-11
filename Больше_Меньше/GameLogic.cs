using Program.Utils;

namespace Program
{
    class GameLogic
    {
        private int randomNumber;
            
        public void GameStart()
        {
            Greeting();
            GenerateRandomNumber();
            GameProcess();
        }

        private void Greeting()
        {
            Console.WriteLine("Добро пожаловать в игру 'Больше Меньше'");
        }

        private void GenerateRandomNumber()
        {
            Console.WriteLine("Я загадал число от 0 до 100.");
            randomNumber = Generator.GenerateRandomNumber(0, 100);
            //Console.WriteLine($"{numm}");
        }

        private void GameProcess()
        {
            int userInputedNumber;
            do
            {
                Console.Write("Введите число: ");
                userInputedNumber = Convert.ToInt32(Console.ReadLine());
                CheckUserInputedNumber(userInputedNumber);
            }
            while (userInputedNumber != randomNumber);
        }

        private void CheckUserInputedNumber(int userNumber)
        {
            if ((userNumber < 0) || (userNumber > 100))
            {
                Console.WriteLine("Вы ввели не верное значение");
            }
            else if (userNumber < randomNumber)
            {
                Console.WriteLine("Больше");
            }
            else if (userNumber > randomNumber)
            {
                Console.WriteLine("Меньше");
            }
            else
            {
                Console.WriteLine("Поздравляю вы отгадали!");
            }
        }
    }
}
