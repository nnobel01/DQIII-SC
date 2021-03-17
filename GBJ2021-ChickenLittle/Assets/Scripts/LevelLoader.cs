using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    private void Awake()
    {
        GetComponent<BoxCollider2D>();
    }
    public Animator transition;
    public Animator anim;
    public float transitionTime = 1f;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "endoflevel")
        {
            LoadNextLevel();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            anim.SetTrigger("Hurt");

            SceneManager.LoadScene(8);




        }
    }





    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
