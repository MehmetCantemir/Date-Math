namespace Datetime_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            //math kütüphanesi

            Console.WriteLine("**********Math Kütüphanesi **********");

            Console.WriteLine(Math.Abs(-25));   //25
            Console.WriteLine(Math.Sin(10));    // Sinüs karışılığını verir
            Console.WriteLine(Math.Cos(10));    // Cosinüs karşılığını verir
            Console.WriteLine(Math.Tan(10));    // Tanjant karşılığını verir

            Console.WriteLine(Math.Ceiling(22.3)); // yazılan sayıdan sonraki en büyük tam sayıyı yazdırıyor .23
            Console.WriteLine(Math.Round(22.3)); //En yakına yuvarlar
            Console.WriteLine(Math.Floor(22.7));//Aşağı yuvarlar.
            Console.WriteLine(Math.Max(2,6)); //sayılar arasında en büyük sayıyı alır
            Console.WriteLine(Math.Min(2,6));   // sayılar arasında en küçük sayıyı alır.

            Console.WriteLine(Math.Pow(3,4)); //3^4 ü alır.
            Console.WriteLine(Math.Sqrt(9));  // Karekök alır.
            Console.WriteLine(Math.Log(4));  //logaritmansını gösterir.

            Console.WriteLine(Math.Exp(3)); // e üzeri 3 ü verir.
            Console.WriteLine(Math.Log10(10)); //10 sayısının logaritma 10 tabanındaki karşılığı.
           

        }
    }
}