using System;

class Program
{
    static void Main()

    {
        bool totalValid = false; // eğer ikinci bir tatil planı yapılacaksa while geri dönebilmek için genel kodu kapsayan bool bir total valid oluşturdum
        while (!totalValid)
        {

            int price = 0; 
            string location = "";

            bool valid = false;
            while (!valid)
            {

                Console.WriteLine("1. Bodrum (Paket Başlangıç Fiyatı 4000 TL)");
                Console.WriteLine("2. Marmaris (Paket Başlangıç Fiyatı 3000 TL)");
                Console.WriteLine("3. Çeşme (Paket Başlangıç Fiyatı 5000 TL)");

                Console.WriteLine("\nLütfen gitmek istediğiniz lokasyonu seçiniz: ");

                string input = Console.ReadLine().ToLower();

                switch (input) // if de kullanabilirdim sadece switch case pekiştirmek için bu yöntemi kullandım
                {
                    case "1": //kullanıcı 1 de yazsa bodrumda yazsa case 1e girecek ve anlayacak
                    case "bodrum":
                        location = "Bodrum";
                        price = 4000;
                        valid = true;
                        Console.WriteLine("Bodrum'da tatilde yapabileceğiniz birkaç keyifli aktivite şunlar olabilir: Bodrum Kalesi'ni ziyaret ederek tarihe tanıklık etmek, deniz kenarında gün batımını izlemek, Bodrum'un meşhur plajlarında güneşin tadını çıkarmak, yerel lezzetleri denemek ve alışveriş yapmak. Ayrıca Bodrum'un tarihi sokaklarında gezinerek yöreye özgü hediyelik eşyalar bulabilirsiniz.");
                        break;
                    case "2":
                    case "marmaris":
                        location = "Marmaris";
                        price = 3000;
                        valid = true;
                        Console.WriteLine("Marmaris'te tatilde yapabileceğiniz birkaç keyifli aktivite şunlar olabilir: Mavi tur tekneleriyle Ege Denizi'nin berrak sularında gezinti yapmak, Marmaris Kalesi'ni ziyaret ederek tarihi dokuyu keşfetmek, İçmeler Plajı'nda güneşlenmek ve denizin tadını çıkarmak, Marmaris'in ünlü gece hayatını keşfetmek ve canlı müzik mekanlarında eğlenmek. Ayrıca çevredeki doğal güzelliklerde trekking yapmak veya yöresel lezzetleri tatmak da unutulmaz deneyimler sunacaktır.");
                        break;
                    case "3":
                    case "çeşme":
                        location = "Çeşme";
                        price = 5000;
                        valid = true;
                        Console.WriteLine("Çeşme'de tatilde yapabileceğiniz birkaç keyifli aktivite şunlar olabilir: Altınkum Plajı gibi kumsallarda güneşlenmek ve denize girmek, Ilıca Plajı'nda termal suların tadını çıkarmak, Alaçatı'nın taş sokaklarında gezip yöresel restoranlarda lezzetli yemekler denemek, rüzgar sörfü veya kitesurf yapmak için ideal koşullara sahip plajları keşfetmek. Ayrıca Çeşme Kalesi'ni ziyaret ederek tarihi dokuyu yakından görmek ve şehrin tarihi mirasını keşfetmek de unutulmaz bir deneyim olabilir.");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim yaptınız.");
                        valid = false; // burda içerdeki while ın validi false olduğu için while ın içine baştan girer
                        break;
                }
            }

            Console.Write("\n\nKaç kişilik tatil planı oluşturmak istersiniz? ----> ");
            int personNum = Convert.ToInt32(Console.ReadLine());

            bool valid2 = false;
            while (!valid2)
            {
                Console.WriteLine("\n\nTatile hangi şekilde gitmek istersiniz?");
                Console.WriteLine("1 - Kara yolu (Kişi başı ulaşım tutarı gidiş - dönüş 1500 TL)");
                Console.WriteLine("2 - Hava yolu (Kişi başı ulaşım tutarı gidiş - dönüş 4000 TL)");
                int choosen = Convert.ToInt32(Console.ReadLine());

                int price2;
                string transportation;

                if (choosen == 1)
                {
                    valid2 = true;
                    price2 = 1500;
                    transportation = "Kara yolu";
                    Console.WriteLine("\n" +personNum + " kişi " + transportation + " ile gideceğiniz " + location + " tatiline toplam ödenecek tutar: " + personNum * (price2 + price) + " TL");
                }
                else if (choosen == 2)
                {
                    valid2 = true;
                    price2 = 4000;
                    transportation = "Hava yolu";
                    Console.WriteLine("\n" + personNum + " kişi " + transportation + " ile gideceğiniz " + location + "tatiline toplam ödenecek tutar: " + personNum * (price2 + price) + " TL");
                }
                else
                {
                    Console.WriteLine("Yanlış bir değer girdiniz, tekrar deneyin.");
                }
            }
            Console.WriteLine("Başka bir tatil planlamak ister misiniz? y/n");
            string another = Console.ReadLine();

            if (another == "y") 
            {
                totalValid = false; // total valid false olursa bütün programı baştan çalıştırır ve tekrar bir tatil planı oluşturur
            }
            else
            {
                Console.WriteLine("İyi günler dileriz!");
            }

        }
    } }