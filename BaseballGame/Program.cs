
using BaseballGame;

try
{
    string[] ops = new string[] { "5", "2", "C", "D", "+" };

    Console.WriteLine(CalcPoints.Calc(ops));


    ops = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };

    Console.WriteLine(CalcPoints.Calc(ops));


    ops = new string[] { "1", "C" };

    Console.WriteLine(CalcPoints.Calc(ops));


    ops = new string[] { "C" };

    Console.WriteLine(CalcPoints.Calc(ops));
}
catch (Exception ex)
{
    Console.WriteLine("Something get wrong. " + ex.ToString());
}