using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Door : MonoBehaviour
{
    protected bool isClosed;
    public abstract void OpenOrclose();

}
