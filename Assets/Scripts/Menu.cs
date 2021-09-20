using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject prefab;
    public bool paused;
    // Start is called before the first frame update
    void Start()
    {
        paused = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (paused == false)
        {
            paused = Input.GetButtonDown("Cancel");
            if (paused == true)
            {
                ESC();
            }
        }
        if (Input.GetButtonDown("Cancel") && Input.GetButtonUp("Cancel") == false && paused == true)
        {
            if (Input.GetButtonUp("Cancel"))
            {
                paused = false;
            }
        }
    }
    void ESC()
    {
        GameObject obj = Instantiate(prefab) as GameObject;
        paused = true;
    }
}
