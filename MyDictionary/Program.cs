using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> User = new MyDictionary<string, int>();
            User.Add("Alper", 18);
            User.Add("Ülkü", 18);
            User.Add("Murat", 18);

            /*foreach (var item in User) bu fonksiyonu kullanarak çıktı alacağım sonraya bırakıyorum çünkü ben bir eziğim çözemedim nasıl yapılacağını ehe
            {

            }*/
            Console.WriteLine(User.Length);
        }
    }
}
