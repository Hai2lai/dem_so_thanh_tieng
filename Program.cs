namespace test
{
    class Program
    {
    private static void Main(string[] args)
    {
        Console.WriteLine("nhap 1 so tu ban phim ");
        float n = float.Parse(Console.ReadLine());
        if(n<10)
        {
            switch (n)
            {
                case 0: Console.WriteLine("khong");
                break;
                case 1: Console.WriteLine("mot");
                break;
                case 2: Console.WriteLine("hai");
                break;
                case 3: Console.WriteLine("ba");
                break;
                case 4: Console.WriteLine("bon");
                break;
                case 5: Console.WriteLine("nam");
                break;
                case 6: Console.WriteLine("sau");
                break;
                case 7: Console.WriteLine("bay");
                break;
                case 8: Console.WriteLine("tam");
                break;
                case 9: Console.WriteLine("chin");
                break;

            }
        }else if(n < 20)
        {
            float dv;
            dv = n%10;
            float chuc;
            chuc = n/10;
            Console.Write("muoi ");
            switch (dv)
            {
                case 0: Console.WriteLine(" ");
                break;
                case 1: Console.WriteLine("mot");
                break;
                case 2: Console.WriteLine("hai");
                break;
                case 3: Console.WriteLine("ba");
                break;
                case 4: Console.WriteLine("bon");
                break;
                case 5: Console.WriteLine("nam");
                break;
                case 6: Console.WriteLine("sau");
                break;
                case 7: Console.WriteLine("bay");
                break;
                case 8: Console.WriteLine("tam");
                break;
                case 9: Console.WriteLine("chin");
                break;

            }
            

        }else if(n<99)
        {
            int hangchuc =(int) n/10;
            float hangdv = n%10;
             switch (hangchuc)
            {
                case 0: Console.Write(" ");
                break;
                case 1: Console.Write("mot");
                break;
                case 2: Console.Write("hai");
                break;
                case 3: Console.Write("ba");
                break;
                case 4: Console.Write("bon");
                break;
                case 5: Console.Write("nam");
                break;
                case 6: Console.Write("sau");
                break;
                case 7: Console.Write("bay");
                break;
                case 8: Console.Write("tam");
                break;
                case 9: Console.Write("chin");
                break;
            }
            Console.Write(" muoi ");
                 switch (hangdv)
            {
                case 0: Console.WriteLine(" ");
                break;
                case 1: Console.WriteLine("mot");
                break;
                case 2: Console.WriteLine("hai");
                break;
                case 3: Console.WriteLine("ba");
                break;
                case 4: Console.WriteLine("bon");
                break;
                case 5: Console.WriteLine("nam");
                break;
                case 6: Console.WriteLine("sau");
                break;
                case 7: Console.WriteLine("bay");
                break;
                case 8: Console.WriteLine("tam");
                break;
                case 9: Console.WriteLine("chin");
                break;

            }
        }
    }
    }
}