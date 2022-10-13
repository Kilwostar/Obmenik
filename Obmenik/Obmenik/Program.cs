double MetersToCentimeters(double num)
{
    num = num * 100;
    return num;
}
Console.WriteLine(MetersToCentimeters(1));


double MetersToKilometers(double num)
{
    num = num / 1000;
    return num;
}
Console.WriteLine(MetersToKilometers(1000));


double GramsToLiters(double num)
{
    num = num / 1000;
    return num;
}
Console.WriteLine(GramsToLiters(1000));


double LitersToGalons(double num)
{
    num = num * 0.219969;
    return num;
}
Console.WriteLine(LitersToGalons(10));


double CelsiusToFahrenheit(double num)
{
    num = ((num * 1.8000) + 32);
    return num;
}
Console.WriteLine(CelsiusToFahrenheit(10));