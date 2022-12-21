using System;

namespace DateTimeCsharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine("\nFormatação de datas\n");

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine("\nDiferença entre datas\n");
            var d1 = new DateTime(2000, 10, 15);
            var d2 = new DateTime(2000, 10, 18);
            TimeSpan t = d2.Subtract(d1);
            Console.WriteLine(t.Days);
            /*
            DateTime x = new DateTime(2001, 8, 15, 13, 45, 58);
            DateTime y = x.Add(timeSpan);
            DateTime y = x.AddDays(double);
            DateTime y = x.AddHours(double);
            DateTime y = x.AddMilliseconds(double);
            DateTime y = x.AddMinutes(double);
            DateTime y = x.AddMonths(int);
            DateTime y = x.AddSeconds(double);
            DateTime y = x.AddTicks(long);
            DateTime y = x.AddYears(int);
            DateTime y = x.Subtract(timeSpan);
            TimeSpan t = x.Subtract(dateTime);
            */

            Console.WriteLine("\nTimeSpan\n");

            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            Console.WriteLine("\nValores em fração\n");
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            Console.WriteLine("\nOperações\n");

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

            Console.WriteLine("\nConverter para Local ou UTC\n");
            DateTime myDate = DateTime.Now;
            Console.WriteLine(myDate);

            Console.WriteLine(myDate.ToUniversalTime());
            Console.WriteLine(myDate.ToLocalTime());

            Console.WriteLine("\nCriar DateTime definindo tipo (Local ou Utc)");
            DateTime v1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime v2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            Console.WriteLine("v1 para Local " + v1.ToLocalTime());
            Console.WriteLine("v1 para UTC " + v1.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("v2 para Local " + v1.ToLocalTime());
            Console.WriteLine("v2 para UTC " + v1.ToUniversalTime());


            Console.WriteLine("\nCriar DateTimes com formato ISO (Independe de ser Local ou Utc)\n");
            DateTime b1 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine("b1 " + b1);
            Console.WriteLine("tipo b1 " + b1.Kind);
            Console.WriteLine();

            DateTime b2 = DateTime.Parse("2000-08-15T13:05:58Z");   //O formato ISO define automaticamente o Kind como Local
            Console.WriteLine("b2 " + b2);
            Console.WriteLine("tipo b2 " + b2.Kind);

            Console.WriteLine(b2.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            Console.WriteLine(b2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}