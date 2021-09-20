using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class To1 : MonoBehaviour
{
    void Awake()
    {
        Button button = gameObject.GetComponent<Button>() as Button;
        button.onClick.AddListener(myClick);
    }
    public void myClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
    /*public void Exit()
    {
        Application.Quit();
    }*/
}