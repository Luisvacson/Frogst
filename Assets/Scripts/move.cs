using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float speed;
    public float jumpforce;
    public Animator anim;
    public Transform player;
    private bool isPressJumpKey;
    private float AorD;
    public float Lifes;
    private bool die;
    public Image hpb;
    public Slider hpp;
    public bool paused;

    void Start()
    {
        Lifes = 3;
        isPressJumpKey = false;
        die = false;
        transform.localScale = new Vector3(10, 10, 1);
        player.position = new Vector3(0, 4, 1);
        hpp.value = Lifes;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (die == false)
        {
            movement();
            switchanim();
        }
    }
    void Update()
    {
        if (die == false)
        {
            if (Input.GetButtonDown("Jump"))
            {
                isPressJumpKey = true;
            }
            AorD = 0;
            AorD = Input.GetAxis("Horizontal");
            deathjudge();
            end();
        }
    }
    void movement()
    {
        float facedirection = Input.GetAxisRaw("Horizontal");
        //ÒÆ¶¯
        if (AorD != 0)
        {
            rb.velocity = new Vector2(AorD * speed * Time.deltaTime, rb.velocity.y);
            anim.SetFloat("running", Mathf.Abs(AorD));
        }
        if (facedirection != 0)
        {
            transform.localScale = new Vector3(facedirection * 10, 10, 1);
        }
        //ÌøÔ¾
        if (isPressJumpKey)
        {
            if (rb.velocity.y == 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpforce * Time.deltaTime);
                anim.SetBool("jumping", true);
                isPressJumpKey = false;
            }
        }
    }
    void switchanim()
    {
        if (rb.velocity.y != 0)
        {
            anim.SetBool("airing", true);
        }
        else
        {
            anim.SetBool("airing", false);
        }
        if (anim.GetBool("jumping"))
        {
            anim.SetBool("airing", true);
        }
        if (anim.GetBool("airing"))
        {
            if (rb.velocity.y < 1)
            {
                anim.SetBool("jumping", false);
                if (rb.velocity.y == 0)
                {
                    anim.SetBool("airing", false);
                }
            }
        }
    }
    void deathjudge()
    {
        if (player.position.y < -10 && die == false)
        {
            die = true;
            player.position = new Vector3(0, 4, 1);
            Lifes--;
            hpp.value = Lifes;
            die = false;
        }
    }
    void end()
    {
        if(Lifes == 0)
        {
            SceneManager.LoadScene("start");
        }
    }
}

