string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
string kurs3 = "Java";
string kurs4 = "Python";
string kurs5="C#";
string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
    "Programlamaya Başlangıç İçin Temel Kurs","Java","Python","C#"};




for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("For Bitti");

foreach (string kurs in kurslar)//dizi temelli yapıları tek tek dönmeye dolaşmaya yarıyor
{
    Console.WriteLine(kurs);
}

Console.WriteLine("Sayfa Sonu - Footer");