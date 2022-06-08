try
{
    double a1, an, n, r, S;

    Console.WriteLine("Введите первый член последовательности: ");
    a1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите знаменатель геометрической прогрессии: ");
    r = double.Parse(Console.ReadLine());
    if (r == 0) throw new Exception("r не может равнятся 0");
    Console.WriteLine("Введите количество членов геометрической прогрессии: ");
    n = double.Parse(Console.ReadLine());
    if (n == 1 || n == 0 || n < 0) throw new Exception("Количество членов геометрической прогрессии" +
        " не может равнятся единице, нулю или быть отрицательным");
    an = a1 * Math.Pow(r, n - 1);
    Console.WriteLine($"{n} член геометрической прогрессии = {an}");
    S = (a1 - an * r) / (1 - r);
    Console.WriteLine($"Сумма {n} членов геометрической прогрессии = {S}");

}
catch (Exception e)
{
    Console.WriteLine($"Ошибка: {e.Message}");
}