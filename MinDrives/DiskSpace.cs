namespace MinDrives;

public static class DiskSpace
{
    public static int MinDrives(int[] used, int[] total)
    {
        // Create a list of hard drives with total capacity and used space
        List<Drive> drives = new();
        
        for (int i = 0; i < used.Length; i++)
        {
            drives.Add(new Drive(total[i], used[i]));
        }

        // Order the list of hard drives in descending order of capacity
        drives = drives.OrderByDescending(x => x.Total).ToList();

        int totalUsedSpace = used.Sum();
        int drivesNeeded = 0;
        int currentSpace = 0;

        // Iterate over the sorted hard drives
        foreach (Drive drive in drives)
        {
            drivesNeeded++;

            if ((currentSpace += drive.Total) >= totalUsedSpace)
            {
                break;
            }
        }

        return drivesNeeded;
    }
}