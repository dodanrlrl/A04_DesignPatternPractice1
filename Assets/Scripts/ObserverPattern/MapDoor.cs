using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDoor : Door
{
    public override void OpenOrclose()
    {
        isClosed = !isClosed;
        this.gameObject.GetComponent<SpriteRenderer>().enabled = isClosed;
        this.gameObject.GetComponent<BoxCollider2D>().enabled = isClosed;
    }
    void Start()
    {
        isClosed = true;
    }

}
