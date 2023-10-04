namespace MinDrives;

public static class Cases
{
    public static Case ZeroCase { get; set; } = new Case
    {
        Used = new[] { 300, 525, 110 },
        Total = new[] { 350, 600, 115 },
        Result = 2
    };

    public static Case FirstCase { get; set; } = new Case
    {
        Used = new[] { 1, 200, 200, 199, 200, 200 },
        Total = new[] { 1000, 200, 200, 200, 200, 200 },
        Result = 1
    };

    public static Case SecondCase { get; set; } = new Case
    {
        Used = new[] { 750, 800, 850, 900, 950 },
        Total = new[] { 800, 850, 900, 950, 1000 },
        Result = 5
    };

    public static Case ThirdCase { get; set; } = new Case
    {
        Used = new[] { 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49 },
        Total = new[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 },
        Result = 49
    };

    public static Case FourthCase { get; set; } = new Case
    {
        Used = new[] { 331, 242, 384, 366, 428, 114, 145, 89, 381, 170, 329, 190, 482, 246, 2, 38, 220, 290, 402, 385 },
        Total = new[] { 992, 509, 997, 946, 976, 873, 771, 565, 693, 714, 755, 878, 897, 789, 969, 727, 765, 521, 961, 906 },
        Result = 6
    };
}

