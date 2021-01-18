using System;

namespace UnderstandingMetods
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = Add2();

            int number1 = 20;
            int number2 = 100;

            int number4;
            int number5=5;
            //aslinde metotdaki number1 in sadece değeri gidiyor
            //yani 20 gidiyor number1 gitmiyor

            var result2 = Add3(ref number1, number2);

            //outta değer vememize gerek yok ref ten tek farkı budur
            var result3 = Add4(out number4, number5);
            //basına ref yazarsan demek oluyor ki artık referens tip gibi kullan yani deperini değil kendini gönder
            Console.WriteLine(number1);
            Console.WriteLine(result2);

        }
        static void Add()
        {
            Console.WriteLine("Eklendi!");
        }
        //yanina sayı yazarak defult değer oluşturabiliriz
        static int Add2(int number1=10, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Add4(out int number4, int number5)
        {
            number4= 50;
            return number4 + number5;
        }
    }
}
