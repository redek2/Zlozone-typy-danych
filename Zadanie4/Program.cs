using System;

public enum Plec
{
    Mezczyzna,
    Kobieta
}

public struct Student
{
    public string Nazwisko;
    public int Numer_albumu;
    public float Ocena;
    public Plec Plec;

    public class Program
    {
        public static void Main(string[] args)
        {
            Student[] studenci = new Student[5];

            for (int i = 0; i < studenci.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}:");
                FillStudentInfo(ref studenci[i]);
                Console.WriteLine();
            }

            Console.WriteLine("Średnia grupy: " + srednia(studenci));
        }

        public static void FillStudentInfo(ref Student student)
        {
            Console.Write("Nazwisko: ");
            student.Nazwisko = Console.ReadLine();

            Console.Write("Numer albumu: ");
            student.Numer_albumu = int.Parse(Console.ReadLine());

            Console.Write("Ocena: ");
            float Ocena = float.Parse(Console.ReadLine());
            student.Ocena = Math.Max(2.0f, Math.Min(5.0f, Ocena));

            Console.Write("Płeć (M/K): ");
            string PlecInput = Console.ReadLine();
            student.Plec = (PlecInput.ToUpper() == "M") ? Plec.Mezczyzna : Plec.Kobieta;
        }

        public static float srednia(Student[] studenci)
        {
            float sum = 0;

            foreach (var student in studenci)
            {
                sum += student.Ocena;
            }

            return sum / studenci.Length;
        }
    }
}
