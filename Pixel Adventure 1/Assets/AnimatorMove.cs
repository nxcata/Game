using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorMove : MonoBehaviour
{
    Rigidbody2D rb2D;
    SpriteRenderer sR;
    Animator ani;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        sR = rb2D.GetComponent<SpriteRenderer>();
        ani = rb2D.GetComponent<Animator>();
    }

    void Update()
    {
        gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        rb2D.velocity = new Vector2(Input.GetAxis("Horizontal") * 1.5f, rb2D.velocity.y);
        if (Input.GetAxis("Horizontal") !=0)
        {
            ani.SetBool("run", true);
            if (Input.GetAxis("Horizontal") < 0)
            {
                sR.flipX = true;
            }else
            {
                sR.flipX = false;
            }
        }else
        {
            ani.SetBool("run", false);
        }
    }
}
