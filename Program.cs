namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            week.Day=DayOfWeek.Friday;
            Console.WriteLine();
            int index = (int) week.Day;

            switch (index)
            {
                case 1: Console.WriteLine("Dushanba"); break;
                case 2: Console.WriteLine("Seshanba"); break;
                case 3: Console.WriteLine("chorshanba"); break;
                case 4: Console.WriteLine("Payshanba"); break;
                case 5: Console.WriteLine("Juma"); break;
                case 6: Console.WriteLine("Shanaba"); break;
                case 7: Console.WriteLine("Yakshanba"); break;

            }






        }
    }
    class Week
    {
        public DayOfWeek Day;

    }
    enum DayOfWeek
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}