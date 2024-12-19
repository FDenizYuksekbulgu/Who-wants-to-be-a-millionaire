using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kim Milyoner Olmak İster'e Hoş Geldiniz!");
        Console.WriteLine("Yarışmamız 2 seçenekli 3 sorudan oluşmaktadır. \n" +
           "Sorulardan en az 2 tanesine doğru cevaplamanız durumunda artık bir milyonersiniz :) \n" +
           "Başarılar!");

        int correctAnswers = 0; 

        // Soru 1
        Console.WriteLine("SORU 1: Buzların Madonnası lakabıyla tanınan artistik buz pateni sporcusu kimdir?");
        Console.WriteLine("A) Bertolt Brecht      B) Katarina Witt");
        Console.WriteLine("Cevabınız: ");
        string? answer1 = Console.ReadLine();

        if (answer1 == "b")
        {
            correctAnswers++;
            Console.WriteLine("Doğru cevap!");
        }
        else
        {
            Console.WriteLine("Yanlış cevap!");
        }

        // Soru 2
        Console.WriteLine("SORU 2: A = 3+2sinX olduğuna göre, A'nın alabileceği tam sayı değerleri toplamı kaçtır?");
        Console.WriteLine("A) 15      B) 20");
        Console.WriteLine("Cevabınız: ");
        string? answer2 = Console.ReadLine();

        if (answer2 == "a")
        {
            correctAnswers++;
            Console.WriteLine("Doğru cevap!");
        }
        else
        {
            Console.WriteLine("Yanlış cevap!");
        }

        // 2.sorunun cevabı yarışmanın devam edip etmeyeceği durumunu belirlediği için cevap önemlidir.
        // Toplam doğru sayısı en az 1 olmalıdır yarışmanın devam etmesi için.
        if (correctAnswers >= 2)
        {
            Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
            return;
        }

        // Eğer iki soruda da doğru cevap sayısı 0 ise, üçüncü soruya geçmeden oyun biter!
        if (correctAnswers == 0)
        {
            Console.WriteLine("Maalesef, ilk iki sorudan hiçbirini doğru cevaplayamadınız.");
            Console.WriteLine("Yarışmamıza katıldığınız için teşekkür ederiz!");
            return;
        }

        // Soru 3
        Console.WriteLine("\nSORU 3: Bir satranç notasyon kağıdında 1 kale, 1 fil, 3 piyon kazanan oyuncunun kaç puanı vardır?");
        Console.WriteLine("A) 10      B) 11");
        Console.WriteLine("Cevabınız: ");
        string? answer3 = Console.ReadLine();

        if (answer3 == "b")
        {
            correctAnswers++;
            Console.WriteLine("Doğru cevap!");
        }
        else
        {
            Console.WriteLine("Yanlış cevap!");
        }

        // Sonuç
        Console.WriteLine($"\nDoğru cevap sayınız: {correctAnswers}");
        if (correctAnswers >= 2)
        {
            Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
        }
        else
        {
            Console.WriteLine("Yarışmamıza katıldığınız için teşekkür ederiz. Kazanamadınız!");
        }
    }
}
