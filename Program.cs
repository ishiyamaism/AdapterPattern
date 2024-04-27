namespace AdapterPattern;

using AdapterPattern.CSSeries;
using VBClassLibrary;

class Program
{
    private static ICSSeries _csSeries = CS01.Instance;
    static void Main(string[] args)
    {
        Console.WriteLine("Press Enter to get value, and the other Keys for Input Trigger. Esc to exit.");

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);  // trueでキーのエコーをオフにする
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("bye.");
                break;
            }
            // Escキーでループを抜けてプログラムを終了

            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine("Press: Enter");
                    int value = _csSeries.GetMeasure();
                    Console.WriteLine($"{value}m/s2");
                    break;
                case ConsoleKey.D1:
                    Console.WriteLine("Press Button: CS01");
                    _csSeries = CS01.Instance;
                    Console.WriteLine("Active Mode: CS01");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("Press Button: CS02");
                    _csSeries = CS02.Instance;
                    Console.WriteLine("Active Mode: CS02");
                    break;

                case ConsoleKey.B:
                    Console.WriteLine("Press Button: B");
                    _csSeries = VB01Adapter.Instance;
                    Console.WriteLine("Active Mode: VB.dll");
                    break;

                case ConsoleKey.V:
                    Console.WriteLine("Press Button: V");
                    _csSeries = VB01Adapter2.Instance;
                    Console.WriteLine("Active Mode2: VB.dll");

                    break;
                default:
                    break;
            }
        }
    }
}
