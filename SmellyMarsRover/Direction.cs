namespace SmellyMarsRover;

internal abstract record Direction(string Value)
{
    private const string WEST = "W";
    private const string EAST = "E";
    private const string SOUTH = "S";
    private const string NORTH = "N";

    public bool IsFacingNorth()
    {
        return Value.Equals(NORTH);
    }

    public bool IsFacingSouth()
    {
        return Value.Equals(SOUTH);
    }

    public bool IsFacingWest()
    {
        return Value.Equals(WEST);
    }

    public static Direction Create(string directionEncoding)
    {
        if (directionEncoding.Equals(NORTH))
        {
            return new North();
        }

        if (directionEncoding.Equals(SOUTH))
        {
            return new South();
        }

        if (directionEncoding.Equals(WEST))
        {
            return new West();
        }
        return new East();
    }

    public abstract Direction RotateLeft();

    public Direction RotateRight()
    {
        if (IsFacingNorth())
        {
            return Create(EAST);
        }

        if (IsFacingSouth())
        {
            return Create(WEST);
        }

        if (IsFacingWest())
        {
            return Create(NORTH);
        }

        return Create(SOUTH);
    }

    private record East() : Direction(EAST)
    {
        public override Direction RotateLeft()
        {
            return Create(NORTH);
        }
    }

    private record West() : Direction(WEST)
    {
        public override Direction RotateLeft()
        {
            return Create(SOUTH);
        }
    }

    private record South() : Direction(SOUTH)
    {
        public override Direction RotateLeft()
        {
            return Create(EAST);
        }
    }

    private record North() : Direction(NORTH)
    {
        public override Direction RotateLeft()
        {
            return Create(WEST);
        }
    }
}