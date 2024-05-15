// Класс Program представляет точку входа в приложение
class Program
{
    static void Main()
    {
        // Переменная nowDay хранит текущий день недели (от 0 до 6)
        int nowDay = 0;

        // Делегат Day представляет функцию получения следующего дня недели
        Day day = () =>
        {
            // Массив daysWeek содержит названия дней недели
            string[] daysWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            // Переменная nextDay хранит название следующего дня недели
            string nextDay = daysWeek[nowDay];

            // Переход к следующему дню недели
            nowDay = (nowDay + 1) % 7;

            // Возврат названия следующего дня недели
            return nextDay;
        };

        // Печать названий дней недели в течение 15 дней
        for (byte i = 0; i < 15; i++)
            Console.WriteLine(day());
    }
}

// Делегат Day представляет функцию получения следующего дня недели
delegate string Day();