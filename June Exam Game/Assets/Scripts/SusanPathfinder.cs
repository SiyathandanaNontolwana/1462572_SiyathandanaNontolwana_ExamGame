using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SusanPathfinder : MonoBehaviour
{
    //Variables
    public float susanSpeed = 4.5f;
    public Transform playerPos;
    GameManager gm;
    //Total target locations
    public Transform [] totalTargetLocations;

    //Location info from locationtracker script
    int spotSelected;

    // Start is called before the first frame update
    void Start()
    {
        gm = GetComponent<GameManager>();
        playerPos = playerPos.transform;
        transform.position = totalTargetLocations[spotSelected].transform.position;
    }

    private void FixedUpdate()
    {
        EnemyMove();
        
    }
    void EnemyMove()
    {
        transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[spotSelected].transform.position, susanSpeed * Time.fixedDeltaTime);

        //Rotate and face next location
        Vector3 dir = totalTargetLocations[spotSelected].position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (transform.position == totalTargetLocations[spotSelected].transform.position)
        {
            spotSelected++;
        }

        if(spotSelected == totalTargetLocations.Length)
        {
            spotSelected = 0;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            Debug.Log("Make noise");

            SceneManager.LoadScene("End Game");
        }

    }


}
