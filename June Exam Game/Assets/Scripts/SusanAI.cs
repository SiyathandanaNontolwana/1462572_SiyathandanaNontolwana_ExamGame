using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SusanAI : MonoBehaviour
{

    
    //Array of locations
    public Transform[] totalTargetLocations;
    private Transform currentPosition;

    //Randomizer and number variables
    public float susanSpeed;
    private int Randomizer;
    private Transform currentPos;

    //Selected Location that will change constantly
    private Transform selectedLocation;

    // Start is called before the first frame update
    void Start()
    {
        currentPos.position = totalTargetLocations[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        LocationSelector();
    }

    private void LocationSelector()
    {
        if(totalTargetLocations[0])
        {
           Randomizer = Random.Range(0, 2);

            if(Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[1].position, susanSpeed * Time.fixedDeltaTime);
                if(Vector2.Distance(transform.position, totalTargetLocations[1].position) < 0.2f)
                {
                    LocationSelector();
                    return;
                }
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[2].position, susanSpeed * Time.fixedDeltaTime);
                if (Vector2.Distance(transform.position, totalTargetLocations[2].position) < 0.2f)
                {
                    LocationSelector();
                    return;
                }
            }
        }
        else if(totalTargetLocations[1])
        {
            Randomizer = Random.Range(0, 2);
            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[0].position, susanSpeed * Time.fixedDeltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[3].position, susanSpeed * Time.fixedDeltaTime);
            }

        }
        else if(totalTargetLocations[2])
        {
            Randomizer = Random.Range(0, 3);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[0].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[3].position, susanSpeed * Time.fixedDeltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[4].position, susanSpeed * Time.fixedDeltaTime);
            }
        }
        else if (totalTargetLocations[3])
        {
            Randomizer = Random.Range(0, 3);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[1].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[2].position, susanSpeed * Time.fixedDeltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[5].position, susanSpeed * Time.fixedDeltaTime);
            }
        }
        else if (totalTargetLocations[4])
        {
            Randomizer = Random.Range(0, 3);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[2].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[5].position, susanSpeed * Time.fixedDeltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[6].position, susanSpeed * Time.fixedDeltaTime);
            }
        }
        else if(totalTargetLocations[5])
        {
            Randomizer = Random.Range(0, 3);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[3].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[4].position, susanSpeed * Time.fixedDeltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[8].position, susanSpeed * Time.fixedDeltaTime);
            }
        }
        else if (totalTargetLocations[6])
        {
            Randomizer = Random.Range(0, 2);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[4].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[7].position, susanSpeed * Time.fixedDeltaTime);
            }
        }
        else if (totalTargetLocations[7])
        {
            Randomizer = Random.Range(0, 3);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[6].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[12].position, susanSpeed * Time.fixedDeltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[8].position, susanSpeed * Time.fixedDeltaTime);
            }
        }
        else if (totalTargetLocations[8])
        {
            Randomizer = Random.Range(0, 3);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[3].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[4].position, susanSpeed * Time.fixedDeltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[8].position, susanSpeed * Time.fixedDeltaTime);
            }
        }
        else if (totalTargetLocations[9])
        {

            Randomizer = Random.Range(0, 3);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[8].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[16].position, susanSpeed * Time.fixedDeltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[10].position, susanSpeed * Time.fixedDeltaTime);
            }
        }
        else if (totalTargetLocations[10])
        {

            Randomizer = Random.Range(0, 3);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[9].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[17].position, susanSpeed * Time.fixedDeltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[11].position, susanSpeed * Time.fixedDeltaTime);
            }
        }
        else if (totalTargetLocations[11])
        {

            Randomizer = Random.Range(0, 2);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[10].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[18].position, susanSpeed * Time.fixedDeltaTime);
            }

        }
        else if (totalTargetLocations[12])
        {

            Randomizer = Random.Range(0, 3);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[7].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[13].position, susanSpeed * Time.fixedDeltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[14].position, susanSpeed * Time.fixedDeltaTime);
            }

        }
        else if (totalTargetLocations[13])
        {

            Randomizer = Random.Range(0, 3);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[8].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[12].position, susanSpeed * Time.fixedDeltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[15].position, susanSpeed * Time.fixedDeltaTime);
            }
        }
        else if (totalTargetLocations[14])
        {

            Randomizer = Random.Range(0, 2);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[12].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[14].position, susanSpeed * Time.fixedDeltaTime);
            }

        }
        else if (totalTargetLocations[15])
        {

            Randomizer = Random.Range(0, 4);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[14].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[13].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 3)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[16].position, susanSpeed * Time.fixedDeltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[19].position, susanSpeed * Time.fixedDeltaTime);
            }
        }
        else if (totalTargetLocations[16])
        {

            Randomizer = Random.Range(0, 4);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[15].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[9].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 3)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[17].position, susanSpeed * Time.fixedDeltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[20].position, susanSpeed * Time.fixedDeltaTime);
            }
        }
        else if (totalTargetLocations[17])
        {

            Randomizer = Random.Range(0, 4);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[16].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[10].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 3)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[18].position, susanSpeed * Time.fixedDeltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[21].position, susanSpeed * Time.fixedDeltaTime);
            }
        }
        else if (totalTargetLocations[18])
        {

            Randomizer = Random.Range(0, 3);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[17].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[11].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 3)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[22].position, susanSpeed * Time.fixedDeltaTime);
            }

        }
        else if (totalTargetLocations[19])
        {

            Randomizer = Random.Range(0, 2);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[15].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[20].position, susanSpeed * Time.fixedDeltaTime);
            }

        }
        else if (totalTargetLocations[20])
        {

            Randomizer = Random.Range(0, 3);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[19].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[16].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 3)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[21].position, susanSpeed * Time.fixedDeltaTime);
            }

        }
        else if (totalTargetLocations[21])
        {

            Randomizer = Random.Range(0, 3);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[20].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[17].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 3)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[22].position, susanSpeed * Time.fixedDeltaTime);
            }

        }
        else if (totalTargetLocations[22])
        {

            Randomizer = Random.Range(0, 2);

            if (Randomizer == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[21].position, susanSpeed * Time.fixedDeltaTime);
            }
            else if (Randomizer == 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, totalTargetLocations[18].position, susanSpeed * Time.fixedDeltaTime);
            }
        }
        else
        {
            return;
        }
    }
}
