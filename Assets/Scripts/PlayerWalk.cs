using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool overworld;
    
    // Start is called before the first frame update
    float xspeed;
    float xDirection;
    float xVector;
    float yspeed;
    float yDirection;
    float yVector;
    void Start()
    {
        xspeed = 4f;
        if (overworld)
        {
            xspeed = 3f;
            yspeed = 3f;
        }
        else
        {
            yspeed = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * xspeed * Time.deltaTime;
        
        yDirection = Input.GetAxis("Vertical");
        yVector = yDirection * yspeed * Time.deltaTime;

        transform.position = transform.position + new Vector3(xVector, yVector, 0);
    }
}
