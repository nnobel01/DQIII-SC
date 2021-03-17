using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDetect : MonoBehaviour
{
    GameObject Enemy;
    public float bounce;
    private AudioSource hit;
    void Start()
    {
        Enemy = gameObject.transform.parent.gameObject;
        hit = Enemy.GetComponent<AudioSource>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        //Launch Player
        if (collision.rigidbody)
        {
            collision.rigidbody.AddForce(Vector3.up * bounce, ForceMode2D.Impulse);
        }
        hit.Play();
        Enemy.GetComponent<Collider2D>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        Enemy.GetComponent<SpriteRenderer>().flipY = true;
        Debug.Log("Head Hit");
       Enemy.GetComponent<eT2Control>().enabled = false;
       
        
        Enemy.GetComponent<SpriteRenderer>().enabled = false;
        
        this.enabled = false;
    }
}
