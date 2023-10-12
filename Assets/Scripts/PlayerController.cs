using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    bool bChange;//커맨드 패턴
    CommandKey BtnA, BtnB;

    Animator animator;
    Rigidbody2D rigidbody2D;
    private int isJump = 0; 

    void Start()
    {
        bChange = false;
        ChangeKeyBtn();
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    public void ChangeKeyBtn()
    {
        if (bChange == false)
        {
            bChange = true;
            BtnA = new CommandLeft(this.gameObject);
            BtnB = new CommandRight(this.gameObject);
        }
        else
        {
            bChange = false;
            BtnA = new CommandRight(this.gameObject);
            BtnB = new CommandLeft(this.gameObject);
        }
    }


    void Update()
    {
        animator.SetBool("run", false);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            BtnB.Excute(1);
            animator.SetBool("run", true);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            BtnA.Excute(1);
            animator.SetBool("run", true);
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt) && isJump < 2)
        {
            isJump++;
            rigidbody2D.AddForce(Vector2.up * 400);
            rigidbody2D.gravityScale = 2;
            animator.SetTrigger("jump");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch(collision.gameObject.name)
        {
            case "wall":
                isJump = 0;
                break;
            case "star":
                GameObject.Destroy(collision.gameObject);
                break;
            case "poison":
                GameObject.Destroy(collision.gameObject);
                ChangeKeyBtn();
                Invoke("ChangeKeyBtn", 3f);
                break;

            case "goal1":
                GameObject.Destroy(collision.gameObject);
                Debug.Log("클리어");
                SceneManager.LoadScene("Stage2");
                break;

            case "goal2":
                GameObject.Destroy(collision.gameObject);
                Debug.Log("클리어");
                SceneManager.LoadScene("Stage3");
                break;
            case "goal3":
                GameObject.Destroy(collision.gameObject);
                Debug.Log("클리어");
                SceneManager.LoadScene("End");
                break;
            case "Bullet(Clone)":
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;
            case "fall":
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;

        }
    }
}