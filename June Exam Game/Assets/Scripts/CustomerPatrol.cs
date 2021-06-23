using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerPatrol : MonoBehaviour
{
    public Transform[] totalLocations;
    public float customerSpeed = 3f;

    //Location info from locationtracker script
    int spotSelected;

    // Start is called before the first frame update
    void Start()
    {

        transform.position = totalLocations[spotSelected].transform.position;
    }

    private void FixedUpdate()
    {
        EnemyMove();

    }
    void EnemyMove()
    {
        transform.position = Vector2.MoveTowards(transform.position, totalLocations[spotSelected].position, customerSpeed * Time.fixedDeltaTime);

        //Rotate and face next location
        Vector3 dir = totalLocations[spotSelected].position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (Vector2.Distance(transform.position, totalLocations[spotSelected].position) < 0.1f)
        {
            if (spotSelected < totalLocations.Length - 1)
            {
                spotSelected++;
            }
            else
            {
                spotSelected = 0;
            }
        }
    }
}
