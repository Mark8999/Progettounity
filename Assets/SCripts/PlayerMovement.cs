using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public bool grounded;
    public Rigidbody2D playerBody;
    public float jumpForce = 1;

    Vector2 movement;

    Rigidbody2D rb2d;
    Animator anim; //animation
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        //check if the collsion is happening with a game object with "ground" tag.
        if (collision.transform.CompareTag("ground"))
        {
            grounded = true;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //check if the collsion is happening with a game object with "ground" tag.
        if (collision.transform.CompareTag("ground"))
        {
            grounded = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && grounded)  //makes player jump
        {
            //player jumps
            playerBody.velocity = new Vector2(playerBody.velocity.x, jumpForce);
        }
    }
    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(movement.x * moveSpeed, rb2d.velocity.y);

        //anim.SetFloat("Speed", movement.sqrMagnitude); //Animation

        if (movement.x > 0)
            transform.localScale = new Vector2(1f, 1f);
        else if (movement.x < 0)
            transform.localScale = new Vector2(-1f, 1f);
    }
}
