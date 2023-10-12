using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class SwitchButton : MonoBehaviour

{

    public Door MapDoor;

    List<Door> doors = new List<Door>();

    public void AddDoor(Door d)

    {

        doors.Add(d);

    }

    public void RemoveDoor(Door d)

    {

        if (doors.Contains(d))

            doors.Remove(d);

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")

        {

            foreach (Door d in doors)

                d.OpenOrclose();

        }
    }

    private void Start()

    {

        AddDoor(MapDoor);

    }

}