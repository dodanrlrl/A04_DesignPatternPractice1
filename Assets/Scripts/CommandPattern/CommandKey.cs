using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CommandKey
{
    public GameObject player;
    public virtual void Excute(int flag) { }

}
public class CommandRight : CommandKey
{
    Vector3 prevPos;
    public CommandRight(GameObject obj)
    {
        this.player = obj;
    }
    public override void Excute(int flag)
    {
        Right(flag);
    }

    void Right(int flag)
    {
        player.transform.Translate(Vector2.right * 0.06f);
        player.transform.localScale = new Vector3(flag, 1, 1);

    }
}
public class CommandLeft : CommandKey
{
    Vector3 prevPos;
    public CommandLeft(GameObject obj)
    {
        this.player = obj;
    }
    public override void Excute(int flag)
    {
        Left(flag);
    }

    public void Left(int flag)
    {
        player.transform.Translate(Vector2.left * 0.06f);
        player.transform.localScale = new Vector3(-flag, 1, 1);
    }

}
