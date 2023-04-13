// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine("Jesmael Atienza - Coding Exam\n");

Console.WriteLine("\nItem 1:\n");
int [] array = new int [] { 5, 1, 4, 6, 7, 3, 5, 7, 3 };

Console.WriteLine("[ 5, 1, 4, 6, 7, 3, 5, 7, 3 ]\r\n\nDuplicated elements from the array:");

for (int x = 0; x < array.Length; x++) {
    for(int y = x + 1; y < array.Length;y++)
    {
        if (array[x] == array[y])

            Console.WriteLine(array[y]);
    };
}

Console.WriteLine("\nItem 2:\n");
int num = 6;
int i, j;

for(i = 1; i <= num; i++)
{
    for (j = 1; j <= i; j++)
        Console.Write("{0}", i);
    Console.Write("\n");
}

Console.WriteLine("\nItem 3:\n");
Console.Write("Enter the number of newly hired males: ");
int nhm = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of newly hired females: ");
int nhf = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of permanent position males: ");
int ppm = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of permanent position females: ");
int ppf = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of resigned males: ");
int rm = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of resigned females: ");
int rf = Convert.ToInt32(Console.ReadLine());

int he_total = nhm + nhf;
int pe_total = ppm + ppf;
int re_total = rm + rf;

double nhm_percent = (((double)nhm / (double)he_total) * 100);
nhm_percent = Math.Round(nhm_percent, 2);
double nhf_percent = (((double)nhf / (double)he_total) * 100);
nhf_percent = Math.Round(nhf_percent, 2);

double ppm_percent = (((double)ppm / (double)pe_total) * 100);
ppm_percent = Math.Round(ppm_percent, 2);
double ppf_percent = (((double)ppf / (double)pe_total) * 100);
ppf_percent = Math.Round(ppf_percent, 2);

double rm_percent = (((double)rm / (double)re_total) * 100);
rm_percent = Math.Round(rm_percent, 2);
double rf_percent = (((double)rf / (double)re_total) * 100);
rf_percent = Math.Round(rf_percent, 2);

Console.WriteLine("\n****************************************\n");
Console.WriteLine("Thank you for the information");
Console.WriteLine("\n****************************************\n");
Console.WriteLine("Here is the Summary !!!\n");

Console.WriteLine("\nNumber of Hired Employees = " + he_total);
Console.WriteLine("Male = " + nhm_percent + "%");
Console.WriteLine("Female = " + nhf_percent + "%");

Console.WriteLine("\nNumber of Permanent Employees = " + pe_total);
Console.WriteLine("Male = " + ppm_percent + "%");
Console.WriteLine("Female = " + ppf_percent + "%");

Console.WriteLine("\nNumber of Resigned Employees = " + he_total);
Console.WriteLine("Male = " + rm_percent + "%");
Console.WriteLine("Female = " + rf_percent + "%");

Console.WriteLine("\n**End of Code**");
