namespace SmellyMarsRover;

internal record Coordinates(int x, int y)
{
    public Coordinates MoveAlongYAxis(int displacement)
    {
        return new Coordinates(this.x, this.y + displacement);
    }

    public Coordinates MoveAlongXAxis(int displacement)
    {
        return new Coordinates(this.x + displacement, this.y);
    }
}