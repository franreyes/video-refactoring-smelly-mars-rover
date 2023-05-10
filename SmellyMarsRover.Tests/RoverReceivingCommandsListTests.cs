using Xunit;

namespace SmellyMarsRover.Tests;

public class RoverReceivingCommandsListTests
{
    [Fact]
    public void NoCommands()
    {
        Rover rover = new Rover(0, 0, "N");

        rover.Receive("");

        Assert.Equal(new Rover(0, 0, "N"), rover);
    }

    [Fact]
    public void TwoCommands()
    {
        Rover rover = new Rover(0, 0, "N");

        rover.Receive("lf");

        Assert.Equal(new Rover(-1, 0, "W"), rover);
    }

    [Fact]
    public void ManyCommands()
    {
        Rover rover = new Rover(0, 0, "N");

        rover.Receive("ffrbbrfflff");

        Assert.Equal(new Rover(0, 0, "E"), rover);
    }
}