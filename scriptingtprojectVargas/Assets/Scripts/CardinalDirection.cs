using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardinalDirection : MonoBehaviour
{
    enum Direction {North= 10, East, South, West};


    // Start is called before the first frame update
    void Start()
    {
        Direction myDirection;
        myDirection = Direction.North;
        myDirection = ReverseDirection(myDirection);
        Debug.Log(myDirection);
    }

    Direction ReverseDirection(Direction dir)
    {
        if (dir == Direction.North)
            dir = Direction.South;
        else if (dir == Direction.South)
            dir = Direction.North;
        else if (dir == Direction.East)
            dir = Direction.West;
        else if (dir == Direction.West)
            dir = Direction.East;

        return dir;
    }
}
