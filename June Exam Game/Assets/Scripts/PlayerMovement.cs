using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float playerSpeed = 5f;
    private Vector2 movement;

    public GameObject interactableObject;
    public GameObject interactableObject2;
    public GameObject interactableObject3;
    public GameObject Door;

    private bool iO1, iO2, iO3;

    private int indexNum;

    // Start is called before the first frame update
    void Start()
    {
        iO1 = true;
        iO2 = true;
        iO3 = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        PlayerInput();
        UnlockDoor();
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
                iO1 = false;
            }

            if (Vector2.Distance(transform.position, interactableObject2.transform.position) < 1f)
            {
                //Collect object
                
                interactableObject2.SetActive(false);
                iO2 = false;
            }

            if (Vector2.Distance(transform.position, interactableObject3.transform.position) < 1f)
            {
                //Collect object
                interactableObject3.SetActive(false);
                iO3 = false;
            }
        }
    }

    public void UnlockDoor()
    {
        if(iO1 == false && iO2 == false && iO3 == false)
        {
            //Open Door
            Destroy(Door);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Customer"))
        {
            if(iO1 == false)
            {
                interactableObject.SetActive(true);
                iO1 = true;
            }
            else if (iO2 == false)
            {
                interactableObject2.SetActive(true);
                iO2 = true;
            }
            else if (iO3 == false)
            {
                interactableObject2.SetActive(true);
                iO2 = true;
            }
            else
            {
                return;
            }
        }

        if(collision.CompareTag("WinTrig"))
        {
            SceneManager.LoadScene("End Game");
        }
    }
}
