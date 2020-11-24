using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermouvement : MonoBehaviour
{
    // you can declare any type of variables ( it can be int-bool-float-string or a component)
    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer sp;
    private int speed = 5;
    private bool fire = false;

    private void Start()
    {
        //giving a color to a gameobject on gamestart
        /*red = new Color(255f, 0f, 0f,255f);
        sp.color = red;*/
    }

    private void OnTriggerEnter2D(Collider2D detect)
    {
        // detecting a gameobject using a collider without interacting
        if (detect.gameObject.name == "zeft (1)")
        {
            Destroy(detect.gameObject);
            Debug.Log("Detecting done:D");
        }
    }

    private void Update()
    {
        // player mouvement while holding the keys          
        if (Input.GetKey("z"))
        {
            rb.velocity = Vector2.up * speed;
            anim.SetBool("isRunning", true);
        }
        if (Input.GetKey("s"))
        {
            rb.velocity = Vector2.down * speed;
            anim.SetBool("isRunning", true);
        }
        if (Input.GetKey("d"))
        {
            rb.velocity = Vector2.right * speed;
            anim.SetBool("isRunning", true);
            sp.flipX = false;
        }
        if (Input.GetKey("q"))
        {
            rb.velocity = Vector2.left * speed;
            anim.SetBool("isRunning", true);
            sp.flipX = true;
        }
        // make the player idle while releasing keys
        if (Input.GetKeyUp("s") || Input.GetKeyUp("z") || Input.GetKeyUp("q") || Input.GetKeyUp("d")  )
        {
            rb.velocity = Vector2.zero * 0;
            anim.SetBool("isRunning", false);
        }
    }
}
