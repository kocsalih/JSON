using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personel> personellerim = new List<Personel>();

            for (int i = 0; i < 1000; i++)
            {
                Personel p1 = new Personel();
                p1.id = Guid.NewGuid();
                p1.isim = FakeData.NameData.GetFirstName();
                p1.soyisim = FakeData.NameData.GetSurname();
                p1.emailAdres =@" {p1.isim}.{ p1.soyisim}@{ FakeData.NetworkData.GetDomain()}";
                p1.telefonNumarasi = FakeData.PhoneNumberData.GetPhoneNumber();
                personellerim.Add(p1);
            }
            Console.WriteLine("Bilgileriniz Json formatında kayıt edilecektir.");

            if (Directory.Exists(@"c:\JsonIslemleri"))
            {

            }
            else Directory.CreateDirectory(@"c:\XML\JsonIslemleri.json");

            string JsonPersonellerim = Newtonsoft.Json.JsonConvert.SerializeObject(personellerim);
            File.WriteAllText(@"C:\XML\JsonIslemleri.json", JsonPersonellerim);
         }
    }
}
