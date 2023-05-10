using Xunit;

namespace SmellyMarsRover.Tests;

public class RoverRotationTests
{
    [Fact]
    public void FacingNorthRotateLeft()
    {
        Rover rover = new Rover(0, 0, "N");

        rover.Receive("l");

        Assert.Equal(new Rover(0, 0, "W"), rover);
    }

    [Fact]
    public void FacingNorthRotateRight()
    {
        Rover rover = new Rover(0, 0, "N");

        rover.Receive("r");

        Assert.Equal(new Rover(0, 0, "E"), rover);
    }

    [Fact]
    public void FacingSouthRotateLeft()
    {
        Rover rover = new Rover(0, 0, "S");

        rover.Receive("l");

        Assert.Equal(new Rover(0, 0, "E"), rover);
    }

    [Fact]
    public void FacingSouthRotateRight()
    {
        Rover rover = new Rover(0, 0, "S");

        rover.Receive("r");

        Assert.Equal(new Rover(0, 0, "W"), rover);
    }

    [Fact]
    public void FacingWestRotateLeft()
    {
        Rover rover = new Rover(0, 0, "W");

        rover.Receive("l");

        Assert.Equal(new Rover(0, 0, "S"), rover);
    }

    [Fact]
    public void FacingWestRotateRight()
    {
        Rover rover = new Rover(0, 0, "W");

        rover.Receive("r");

        Assert.Equal(new Rover(0, 0, "N"), rover);
    }

    [Fact]
    public void FacingEastRotateLeft()
    {
        Rover rover = new Rover(0, 0, "E");

        rover.Receive("l");

        Assert.Equal(new Rover(0, 0, "N"), rover);
    }

    [Fact]
    public void FacingEastRotateRight()
    {
        Rover rover = new Rover(0, 0, "E");

        rover.Receive("r");

        Assert.Equal(new Rover(0, 0, "S"), rover);
    }
}