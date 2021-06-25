using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float playerSpeed = 5f;
    private Vector2 movement;

    public GameObject interactableObject;
    public GameObject interactableObject2;
    public GameObject interactableObject3;
    public GameObject Door;

    private int indexNum;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        PlayerInput();
    }

    private void PlayerInput()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        playerRB.MovePosition(playerRB.position + movement * playerSpeed * Time.fixedDeltaTime);
     
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(Vector2.Distance(transform.position, interactableObject.transform.position) < 1f)
            {
                //Collect object
                interactableObject.SetActive(false);
            }

            if (Vector2.Distance(transform.position, interactableObject2.transform.position) < 1f)
            {
                //Collect object
                interactableObject2.SetActive(false);
            }

            if (Vector2.Distance(transform.position, interactableObject3.transform.position) < 1f)
            {
                //Collect object
                interactableObject3.SetActive(false);
            }
        }
    }

    public void UnlockDoor()
    {
        if(interactableObject == false && interactableObject2 == false && interactableObject3 == false)
        {
            //Open Door
            Door.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Customer"))
        {
            playerSpeed = 0f;
        }
        else
        {
            playerSpeed = 5f;
        }
    }
}
