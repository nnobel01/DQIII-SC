using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escapePlan : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EscapePlan();
        }
    }

    public void EscapePlan()
    {
        SceneManager.LoadScene(0);
    }
}
