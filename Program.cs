namespace Project03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentId;
            string studentName;
            int subMarks;
            int total=0;
            double avg=0;
            string state;

            Console.Write("Enter Your Name : ");
            studentName = Console.ReadLine();

            Console.Write("Enter Your Student ID : ");
            studentId = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Enter Your Subeject " + i + " Marks :");
                subMarks = Convert.ToInt32(Console.ReadLine());
                total = total + subMarks;
            }

            avg = total / 3;

            Console.WriteLine("Your report :");
            Console.WriteLine("Name :" + studentName);
            Console.WriteLine("ID :" + studentId);
            Console.WriteLine("Total marks :" + total);
            Console.WriteLine("Avarage :" + avg);

            if (avg > 40)
            {
                Console.WriteLine("Your Pass the exam with C pass");
            }
            else if (avg > 60)
            {
                Console.WriteLine("Your Pass the exam with B pass");
            }
            else if (avg > 75) 
            {
                Console.WriteLine("Your Pass the exam with A pass");
            }

            

            Console.ReadLine();
        }
    }
}
