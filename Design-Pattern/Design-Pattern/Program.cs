// See https://aka.ms/new-console-template for more information

using Design_Pattern;

SingeltonPattern heinrich = SingeltonPattern.getInstance();

heinrich.setName("Heinrich");

Console.WriteLine(heinrich.Angriffsbefehl());

SingeltonPattern ludwig = SingeltonPattern.getInstance();

ludwig.setName("Ludwig");

Console.WriteLine(ludwig.Angriffsbefehl());
Console.WriteLine(heinrich.Rückzugbefehl());
