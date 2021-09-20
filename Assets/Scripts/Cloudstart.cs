using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Cloudstart : MonoBehaviour
{
    private Vector3 pos;
    private int dirc;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(Random.Range(-10, 10), Random.Range(3, 4), 0);
        transform.position = pos;
        if (transform.position.x <= 5)
        {
            dirc = 1;
        }
        else if (transform.position.x > 5)
        {
            dirc = -1;
        }
        else
        {
            dirc = Random.Range(0, 1);
            if (dirc == 0)
            {
                dirc = -1;
            }
            else if (dirc == 1)
            {
                dirc = 1;
            }
            else
            {
                dirc = 0;
            }
        }
    }
    //rigidbody2d.velocity = new Vector2(dirc * 10 * Time.deltaTime, rigidbody2d.velocity.y);
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.frameCount % 10 == 0)
        {
            transform.position = new Vector3(transform.position.x + (0.1f * dirc), transform.position.y, transform.position.z);
        }
    }
    void Update()
    {
        if (transform.position.x < -10 || transform.position.x > 10)
        {
            GameObject obj = Instantiate(prefab) as GameObject;
            obj.transform.position = new Vector3(0, 8, 0);
            Destroy(gameObject);
        }
    }
}
