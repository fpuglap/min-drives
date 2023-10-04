namespace MinDrives.Tests;

[TestFixture]
public class DiskSpaceTests
{
    [Test]
    public void MinDrives_ShouldReturn2()
    {
        // Arrange
        int[] used = Cases.ZeroCase.Used;
        int[] total = Cases.ZeroCase.Total;

        // Act
        int result = DiskSpace.MinDrives(used, total);

        // Assert
        Assert.That(result, Is.EqualTo(Cases.ZeroCase.Result));
    }

    [Test]
    public void MinDrives_ShouldReturn1()
    {
        // Arrange
        int[] used = Cases.FirstCase.Used;
        int[] total = Cases.FirstCase.Total;

        // Act
        int result = DiskSpace.MinDrives(used, total);

        // Assert
        Assert.That(result, Is.EqualTo(Cases.FirstCase.Result));
    }

    [Test]
    public void MinDrives_ShouldReturn5()
    {
        // Arrange
        int[] used = Cases.SecondCase.Used;
        int[] total = Cases.SecondCase.Total;

        // Act
        int result = DiskSpace.MinDrives(used, total);

        // Assert
        Assert.That(result, Is.EqualTo(Cases.SecondCase.Result));
    }

    [Test]
    public void MinDrives_ShouldReturn49()
    {
        // Arrange
        int[] used = Cases.ThirdCase.Used;
        int[] total = Cases.ThirdCase.Total;

        // Act
        int result = DiskSpace.MinDrives(used, total);

        // Assert
        Assert.That(result, Is.EqualTo(Cases.ThirdCase.Result));
    }

    [Test]
    public void MinDrives_ShouldReturn6()
    {
        // Arrange
        int[] used = Cases.FourthCase.Used;
        int[] total = Cases.FourthCase.Total;

        // Act
        int result = DiskSpace.MinDrives(used, total);

        // Assert
        Assert.That(result, Is.EqualTo(Cases.FourthCase.Result));
    }
}