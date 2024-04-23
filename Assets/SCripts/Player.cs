using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int score = 0;
    public float movementSpeed = 1;
    //force the player jumps at
    public float jumpForce = 1;

    //bool to check if player is on the ground
    public bool grounded;

    //reference to the player rigid body 2D
    public Rigidbody2D playerBody;


    // Start is called before the first frame update
    void Start()
    {
        //get reference to players Rigidbody2D component
        playerBody = GetComponent<Rigidbody2D>();
    }
    


    // Update is called once per frame
    void Update()
    {
        //Mi prendo il valore dell'input
        float xMove = Input.GetAxis("Horizontal");
        //Costruisco il vettore moviemento 
        Vector2 movementVector = new Vector2(xMove, 0).normalized;
        //Applico il movimento
        transform.Translate(movementVector * movementSpeed * Time.deltaTime);
        //check if the space key is tapped and if player is on the ground
        if (Input.GetKeyDown(KeyCode.Space) && grounded)  //makes player jump
        {
            //player jumps
            playerBody.velocity = new Vector2(playerBody.velocity.x, jumpForce);
        }
        
    }
    //Check if player is on the ground

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
    int MyFuction(int value)
    {
        //Qua dentro va il codice
        Debug.Log("Il calore è " + value);

        return value;
    }
}
