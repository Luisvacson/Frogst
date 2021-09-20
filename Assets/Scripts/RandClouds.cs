using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandClouds : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <= 10; i++)
        {
            GameObject obj = Instantiate(prefab) as GameObject;
            obj.transform.position = new Vector3(0, 50, 0);
        }
    }

}
