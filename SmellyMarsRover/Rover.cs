﻿using System;
using System.Collections.Generic;

namespace SmellyMarsRover
{
    public class Rover
    {
        private const int Displacement = 1;
        private Direction _direction;
        private Coordinates _coordinates;

        public Rover(int x, int y, string direction)
        {
            _direction = DirectionMapper.Create(direction);
            SetCoordinates(x, y);
        }

        private void SetCoordinates(int x, int y)
        {
            _coordinates = new Coordinates(x, y);
        }

        public void Receive(string commandsSequence)
        {
            IList<string> commands = new List<string>();
            for (var i = 0; i < commandsSequence.Length; ++i)
            {
                var command = commandsSequence.Substring(i, 1);
                commands.Add(command);
            }

            foreach (var command in commands)
            {
                Execute(command);
            }
        }

        private void Execute(string command)
        {
            if (command.Equals("l"))
            {
                _direction = _direction.RotateLeft();
            }
            else if (command.Equals("r"))
            {
                _direction = _direction.RotateRight();
            }
            else if (command.Equals("f"))
            {
                _coordinates = _direction.Move(_coordinates, Displacement);
            }
            else
            {
                _coordinates = _direction.Move(_coordinates, -Displacement);
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Rover)obj);
        }

        protected bool Equals(Rover other)
        {
            return Equals(_direction, other._direction) && Equals(_coordinates, other._coordinates);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_direction, _coordinates);
        }

        public override string ToString()
        {
            return $"{nameof(_direction)}: {_direction}, {nameof(_coordinates)}: {_coordinates}";
        }
    }
}