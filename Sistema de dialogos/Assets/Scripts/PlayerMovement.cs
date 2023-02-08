using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float dirX;
    public SpriteRenderer spr;
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * dirX * speed);

        if (dirX > 0)
        {
            spr.flipX = false;
        }
        if (dirX < 0)
        {
            spr.flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("Run", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("Run", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("Run", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("Run", false);
        }
    }
}
