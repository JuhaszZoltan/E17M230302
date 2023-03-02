using E17M230302;
using System.Text;

List<IdozitettFelirat> feliratok = new();

using StreamReader sr = new("..\\..\\..\\RES\\feliratok.txt", Encoding.UTF8);
while (!sr.EndOfStream)
{
    feliratok.Add(new IdozitettFelirat(
        idozites: sr.ReadLine(),
        felirat: sr.ReadLine()));
}

Console.WriteLine($"5. feladat: felriatok száma: {feliratok.Count}");

var feladat7 = feliratok.MaxBy(f => f.SzavakSzama);
Console.WriteLine("7. feladat: legtöbb szóból álló felirat:");
Console.WriteLine(feladat7.Felirat);

int maxindex = 0;
for (int i = 1; i < feliratok.Count; i++)
{
    if (feliratok[maxindex].SzavakSzama < feliratok[i].SzavakSzama)
        maxindex = i;
}
Console.WriteLine("7. feladat - alt: legtöbb szóból álló felirat:");
Console.WriteLine(feliratok[maxindex].Felirat);


using StreamWriter sw = new("..\\..\\..\\RES\\felirat.srt", append: false, Encoding.UTF8);
int ssz = 1;
foreach (var f in feliratok)
{
    sw.WriteLine(ssz);
    sw.WriteLine(f.SrtIdozites);
    sw.WriteLine(f.Felirat);
    sw.Write('\n');
    ssz++;
}


