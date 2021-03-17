using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnima : MonoBehaviour
{
    public Animator anim;
    public bool isGrounded = false;
    public Collider2D collide;

    private void Start()
    {
        anim = GetComponent<Animator>();
        collide = GetComponent<Collider2D>();
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            isGrounded = true;
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetTrigger("Jumping");
        }
       /* else if (Input.GetKey(KeyCode.Space))
        {
            anim.SetTrigger("Punching");
        } */
        else if(Input.GetKey(KeyCode.D) || isGrounded)
        {
            anim.SetBool("isRunningRight", true);
        }
        else if(Input.GetKey(KeyCode.A) || isGrounded)
        {
            anim.SetBool("isRunningLeft", true);
        }
        else
        {
            anim.SetBool("isRunningRight", false);
            anim.SetBool("isRunningLeft", false);
        }

    }
}
