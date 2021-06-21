using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SusanPathfinder : MonoBehaviour
{
    //Variables
    public float susanSpeed = 4.5f;
    public int randomLocation;

    //Total target locations
    public Transform [] totalTargetLocations;


    // Start is called before the first frame update
    void Start()
    {
        randomLocation = Random.Range(0, totalTargetLocations.Length);
    }

    // Update is called once per frame
    void Update()
    {

      
    }

    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[randomLocation].position, susanSpeed * Time.fixedDeltaTime);
    }

    private void RayLocationChecker()
    {

    }

    public void LocationStorer()
    {

    }

    private void OnDrawGizmos()
    {
        //Gizmos.color = Color.red;
        //Gizmos.DrawLine(rayCastOrigin.position, totalTargetLocations[1].position);
        //Gizmos.DrawLine(rayCastOrigin.position, totalTargetLocations[0].position);
    }
}
