using System.Net;

namespace LamHoang.CsIntro.Processing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PassByReferenceV2(out int n);
            Console.WriteLine("After calling f(), n = " + n);
            Sum(100, out int sum); // nhan ket qua tra ve ngay tren tham so
            Console.WriteLine("Sum from 1..100 = " + sum);
        }

        // viet ham tinh tong cac so tu 1...n, ko dung lenh return nhung van tra ve dc gia tri
        static void Sum(int n, out int sum)
        {
            sum = 0;
            for (int i = 0; i <= n; i++) 
            { 
                sum+=i;
            } 
        }

        //static void Main(string[] args)
        //{
        //    int n = 3979;
        //    Console.WriteLine("Before calling f(), n = " + n);
        //    //PassByReferenceV1(ref n);
        //    // muon choi vs ref, bien noi goi phai co san 1 value nao do roi lat ham sua sau!!!
        //    // nhung ham co quyen ko sua
        //    // nhung choi vs out, trong ham bat buoc phai co lenh sua value cua bien out!!!

        //    PassByReferenceV2(out n);
        //    Console.WriteLine("After calling f(), n = " + n);
        //}

        static void PassByReferenceV2(out int n)
        {
            n = 60;
        }

        static void PassByReferenceV1(ref int n)
        {
            n = 5;
        }
        //static void Main(string[] args)
        //{
        //    //Console.WriteLine("Hello, World!");
        //    //int sum = Sum(100);
        //    //Console.WriteLine($"Sum from 1 to 100: {Sum(100)}");


        //    int n = 69;// gui no qua ham va ham se bien doi =5
        //    Console.WriteLine("In main(), before calling f(), n = " + n);
        //    PassByValue(n);
        //    Console.WriteLine("In main(), after calling f(), n = " + n);
        //}

        //// C# cung cap them 2 "mon la" lien quan den tham so cua ham!!!
        //// do la out & ref
        //// kieu nhu truyen tham chieu/con tro!!!
        //// 2 cai nay giup mo rong viec tra ve cua 1 ham!!!


        //// ham nhan vao 1 con so nguyen, tam goi la n
        //// viet kieu nay goi la truyen tham tri!!! Y CHANG C, JAVA
        //// n nat se hung value tu 1 bien khac o noi goi cai ham nay
        //// ai goi ham nay se phai truyen value cho ham, value thuong nam trong bien nao do
        //static void PassByValue(int n)
        //{
        //    //bien doi n, ben ngoai dua n bang bao nhieu cung ko care, sua!!!
        //    Console.WriteLine("In function PassByValue(), before modifying n-parameter = " + n);
        //    n = 5;
        //    Console.WriteLine("In function PassByValue(), after modifying n-parameter = " + n);
        //}


        // cac ham se nam ngoai main va trong class
        // tung hoc: static thi choi vs static
        // ctrl+k+c: cmt code
        // ctrl+k+d: format code
        // 

        //tinh tong cac so nguyen tu 1...n
        //static int Sum(int n)

        //{
        //    int sum = 0;
        //    for (int i = 0; i <= n; i++)
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}

        static int Sum(int n)
        {
            int sum = 0, i = 1;
            do
            {
                sum+=i;
                i++;
            } while (i <= n);
            return sum;
        }
    }
}