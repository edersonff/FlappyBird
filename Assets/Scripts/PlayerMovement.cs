using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform playerTransform;
    public Animator Animation;
    public float jumpForce = 200f;
    private GameControl gameControl;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
        gameControl = GameObject.Find("GameControl").GetComponent<GameControl>();
    }

    public bool isPlaying()
    {
        return GameControl.isGameOver || !GameControl.isStarted;
    }

    void Update()
    {
        if (isPlaying())
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            jump();
        }
    }

    void FixedUpdate()
    {
        if (isPlaying())
        {
            return;
        }

        playerTransform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * 5);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Floor" || other.gameObject.tag == "Objects")
        {

            gameControl.onGameOver();
            Animation.SetBool("isDead", true);
        }
    }

    public void jump()
    {
        rb.velocity = new Vector2(0, 0);
        rb.AddForce(Vector2.up * jumpForce);
    }
}
