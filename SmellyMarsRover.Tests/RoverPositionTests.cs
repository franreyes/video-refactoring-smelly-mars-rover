using Xunit;

namespace SmellyMarsRover.Tests;

public class RoverPositionTests
{
    [Fact]
    public void FacingNorthMoveForward()
    {
        Rover rover = new Rover(0, 0, "N");

        rover.Receive("f");

        Assert.Equal(new Rover(0, 1, "N"), rover);
    }

    [Fact]
    public void FacingNorthMoveBackward()
    {
        Rover rover = new Rover(0, 0, "N");

        rover.Receive("b");

        Assert.Equal(new Rover(0, -1, "N"), rover);
    }

    [Fact]
    public void FacingSouthMoveForward()
    {
        Rover rover = new Rover(0, 0, "S");

        rover.Receive("f");

        Assert.Equal(new Rover(0, -1, "S"), rover);
    }

    [Fact]
    public void FacingSouthMoveBackward()
    {
        Rover rover = new Rover(0, 0, "S");

        rover.Receive("b");

        Assert.Equal(new Rover(0, 1, "S"), rover);
    }

    [Fact]
    public void FacingWestMoveForward()
    {
        Rover rover = new Rover(0, 0, "W");

        rover.Receive("f");

        Assert.Equal(new Rover(-1, 0, "W"), rover);
    }

    [Fact]
    public void FacingWestMoveBackward()
    {
        Rover rover = new Rover(0, 0, "W");

        rover.Receive("b");

        Assert.Equal(new Rover(1, 0, "W"), rover);
    }

    [Fact]
    public void FacingEastMoveForward()
    {
        Rover rover = new Rover(0, 0, "E");

        rover.Receive("f");

        Assert.Equal(new Rover(1, 0, "E"), rover);
    }

    [Fact]
    public void FacingEastMoveBackward()
    {
        Rover rover = new Rover(0, 0, "E");

        rover.Receive("b");

        Assert.Equal(new Rover(-1, 0, "E"), rover);
    }
}