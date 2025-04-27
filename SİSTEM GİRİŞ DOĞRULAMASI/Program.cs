namespace SİSTEM_GİRİŞ_DOĞRULAMASI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi = "admin";
            string sifre = "123456";
        girisEkrani:
            Console.WriteLine("Kullanıcı adı ve şifre giriniz lütfen.");
            
            Console.WriteLine("Kullanıcı Adı:");
            string ad = Console.ReadLine();
            
            Console.WriteLine("Şifre:");
            string sifre1 = Console.ReadLine();

            if (kullaniciAdi == ad && sifre == sifre1)
            {
                Console.WriteLine("Giriş başarılı.");
            }
            else
            {
                Console.WriteLine("Lütfen bilgilerinizi kontrol ediniz.");
                goto girisEkrani;

            }

        }
    }
}
