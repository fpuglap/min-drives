using MinDrives;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("The example test cases are as follows:");
        PrintTestCases();

        int caseNumber = GetCaseNumberFromUser();

        AssignArrays(caseNumber, out int[] used, out int[] total);

        int result = DiskSpace.MinDrives(used, total);

        Console.WriteLine($"Minimum number of hard drives needed: {result}");
        Console.WriteLine();
        Console.Write("Press any key to close the program... ");
        Console.ReadLine();
    }

    private static void PrintTestCases()
    {
        int i = 0;

        foreach (var property in typeof(Cases).GetProperties())
        {
            var currentCase = (Case)property.GetValue(null);

            Console.WriteLine($"Case {i}:");
            Console.WriteLine($"  used[] = {{ {string.Join(", ", currentCase.Used)} }},");
            Console.WriteLine($"  total[] = {{ {string.Join(", ", currentCase.Total)} }}.");
            Console.WriteLine($"  Should return {currentCase.Result}.\n");

            i++;
        }

        Console.WriteLine();
    }

    private static int GetCaseNumberFromUser()
    {
        Console.Write("Select a test case (case zero by default): ");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int caseNumber))
        {
            return caseNumber;
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting to case zero.");
            return 0;
        }
    }

    private static void AssignArrays(int caseNumber, out int[] used, out int[] total)
    {
        switch (caseNumber)
        {
            case 0:
                used = Cases.ZeroCase.Used;
                total = Cases.ZeroCase.Total;
                break;
            case 1:
                used = Cases.FirstCase.Used;
                total = Cases.FirstCase.Total;
                break;
            case 2:
                used = Cases.SecondCase.Used;
                total = Cases.SecondCase.Total;
                break;
            case 3:
                used = Cases.ThirdCase.Used;
                total = Cases.ThirdCase.Total;
                break;
            case 4:
                used = Cases.FourthCase.Used;
                total = Cases.FourthCase.Total;
                break;
            default:
                used = Cases.ZeroCase.Used;
                total = Cases.ZeroCase.Total;
                break;
        }
    }
}
