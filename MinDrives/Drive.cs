internal class Drive
{
    public int Total { get; }
    public int Used { get; }

    public Drive(int total, int used)
    {
        Total = total;
        Used = used;
    }
}