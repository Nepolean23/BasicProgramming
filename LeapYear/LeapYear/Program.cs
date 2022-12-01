namespace LeapYear
{
    public class program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter a year:");
            year=Convert.ToInt32(Console.ReadLine());
            if (year >999)
            {
                Console.WriteLine("You have entered:" + year);
            }
            else
            {
                Console.WriteLine("you have entered a invalid year");
            }

        }
        

        
    }
}