using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToS : MonoBehaviour
{
    public BoxCollider2D boxCollider2D;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            ChangeScene();
        }
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("start");
    }
    /*public void Exit()
    {
        Application.Quit();
    }*/
}
