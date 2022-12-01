namespace LeapYear
{
    public class program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter a year in four digit number:");
            year=Convert.ToInt32(Console.ReadLine());
            if (year/4==0 && year/400==0||year/100!=0)
            {
                Console.WriteLine("It is a LeapYear");
            }
            else
            {
                Console.WriteLine("It is not a LeapYear");
            }
            

        }
        

        
    }
}