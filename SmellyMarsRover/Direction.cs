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

    public abstract Direction RotateRight();

    private record East() : Direction(EAST)
    {
        public override Direction RotateLeft()
        {
            return Create(NORTH);
        }

        public override Direction RotateRight()
        {
            return Create(SOUTH);
        }
    }

    private record West() : Direction(WEST)
    {
        public override Direction RotateLeft()
        {
            return Create(SOUTH);
        }

        public override Direction RotateRight()
        {
            return Create(NORTH);
        }
    }

    private record South() : Direction(SOUTH)
    {
        public override Direction RotateLeft()
        {
            return Create(EAST);
        }

        public override Direction RotateRight()
        {
            return Create(WEST);
        }
    }

    private record North() : Direction(NORTH)
    {
        public override Direction RotateLeft()
        {
            return Create(WEST);
        }

        public override Direction RotateRight()
        {
            return Create(EAST);
        }
    }

    public Coordinates Move(Coordinates coordinates, int displacement)
    {
        if (IsFacingNorth())
        {
            return coordinates.MoveAlongYAxis(displacement);
        }

        if (IsFacingSouth())
        {
            return coordinates.MoveAlongYAxis(-displacement);
        }

        if (IsFacingWest())
        {
            return coordinates.MoveAlongXAxis(-displacement);
        }

        return coordinates.MoveAlongXAxis(displacement);
    }
}