using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SusanPathfinder : MonoBehaviour
{
    //Variables
    public float susanSpeed = 4.5f;



    //Total target locations
    public Transform [] totalTargetLocations;

    //Location info from locationtracker script
    Transform [] locationArray;
    int spotSelected;

    // Start is called before the first frame update
    void Start()
    {
        
        transform.position = totalTargetLocations[spotSelected].transform.position;
    }

    private void FixedUpdate()
    {
        EnemyMove();
        
    }
    void EnemyMove()
    {
        transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[spotSelected].transform.position, susanSpeed * Time.fixedDeltaTime);


        if (transform.position == totalTargetLocations[spotSelected].transform.position)
        {
            spotSelected++;
        }

        if(spotSelected == totalTargetLocations.Length)
        {
            spotSelected = 0;
        }
    }

   
}
