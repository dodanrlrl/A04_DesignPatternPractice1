using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIBtn : MonoBehaviour
{
     public void OnClickRestartBtn()
    {
        GameManager.Instance.RestartGame();
    }

    public void OnClickStopGame()
    {
        GameManager.Instance.StopGame();
    }

}
