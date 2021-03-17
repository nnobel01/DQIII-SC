using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    /* public Animator animator; */
    public AudioSource Hitaudio;
    public int health;
    int currentHealth;


    private void Start()
    {
        Hitaudio = GetComponent<AudioSource>();
    }



    public void TakeDamage(int damage)
    {
        GetComponent<Collider2D>().enabled = false;

        //Hitaudio.Play();
        Debug.Log("Killed");
        this.enabled = false;

    }

    
    

   

}
