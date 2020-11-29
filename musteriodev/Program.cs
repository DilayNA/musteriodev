using System;

namespace musteriodev
{
    class Program
    {
        static void Main(string[] args)
        {
            



                var musteri1 = new musteri()
                {

                    ad = "Dilay",
                    soyad = "Abit",
                    yas = 2001,
                    ogrencino = "221903536",
                    meslek = "ogrenci",
                    maas ="",
                };
                var musteri2 = new musteri()
                {
                    ad = "Elif",
                    soyad = "Atlı",
                    yas = 1999,
                    ogrencino = "221903551",
                    meslek = "ogrenci",
                    maas ="",
                };

                var musteri3 = new musteri ()
                {
                    ad = "Diğdem",
                    soyad = "Alper",
                    yas = 2001,
                    ogrencino = "221903545",
                    meslek = "ogrenci",
                    maas= "",
                };

            var musteri4 = new musteri()
            {
                ad = "Merve",
                soyad = "Alp",
                yas = 1990,
                ogrencino = "",
                meslek = "Hemşire",
                maas = "6000",
            };

            var musteri5 = new musteri()
            {
                ad = "Mert",
                soyad = "Sefer",
                yas = 1979,
                ogrencino = "",
                meslek = "Profesör",
                maas = "9000",
            };

            var musteri6 = new musteri()
            {
                ad = "Ayşe",
                soyad = "Yılmaz",
                yas = 1968,
                ogrencino = "",
                meslek = "Öğretmen",
                maas = "5000",
            };






            ToConsole(musteri1);
            ToConsole(musteri2);
            ToConsole(musteri3);
            ToConsole(musteri4);
            ToConsole(musteri5);
            ToConsole(musteri6);



        }

        static void ToConsole(musteri person)
            {
                Console.WriteLine("---------");
                Console.WriteLine($"ad: {person.ad}");
                Console.WriteLine($"soyad: {person.soyad}");
                Console.WriteLine($"yas: {person.yas}");
            Console.WriteLine($"ogrencino: {person.ogrencino}");
            Console.WriteLine($"meslek: {person.meslek}");
            Console.WriteLine($"maas: {person.maas}");
            Console.WriteLine("---------");
            }

        }

    class musteri
    {
        public string ad { get; set; }

        public string soyad { get; set; }

        public int yas { get; set; }

        public string ogrencino { get; set; }

        public string meslek { get; set; }

        public string maas { get; set; }


        public int Age
        {
            get
            {
                return DateTime.Now.Year - yas;
            }
        }
    }
}









