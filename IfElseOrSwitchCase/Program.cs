Console.Write("Rüya Manavina Hos Geldiniz!\nElma = 2 TL\nArmut = 3 TL\nÇilek = 2 TL\nMuz = 3 TL\nDiger bütün meyveler = 4 TL" +
    "\nHangi meyveyi satin almak istersiniz? (Elma/Armut/Çilek/Diğer):");
string meyve = Console.ReadLine().ToLower();
/*
if (meyve == "elma")
{
    Console.WriteLine("Seçtiginiz meyvenin fiyati: 2 TL");
}
else if (meyve == "armut")
{
    Console.WriteLine("Seçtiginiz meyvenin fiyati: 3 TL");
}
else if (meyve == "çilek")
{
    Console.WriteLine("Seçtiginiz meyvenin fiyati: 2 TL");
}
else if (meyve == "muz")
{
    Console.WriteLine("Seçtiginiz meyvenin fiyati: 3 TL");
}
else
{
    Console.WriteLine("Seçtiginiz meyvenin fiyati: 4 TL");
}
*/
// Yukarida if-else kullanarak yapilmis versiyonu mevcuttur.
switch (meyve)
{
    case "elma":
        Console.WriteLine("Seçtiginiz meyvenin fiyati: 2 TL");
        break;
    case "armut":
        Console.WriteLine("Seçtiginiz meyvenin fiyati: 3 TL");
        break;
    case "çilek":
        Console.WriteLine("Seçtiginiz meyvenin fiyati: 2 TL");
        break;
    case "muz":
        Console.WriteLine("Seçtiginiz meyvenin fiyati: 3 TL");
        break;
    default:
        Console.WriteLine("Seçtiginiz meyvenin fiyati: 4 TL");
        break;
}
//switch-case, karar verme mekanizmaları için daha uygundur. Daha okunakli ve yonetilebilir bir kod saglar.
