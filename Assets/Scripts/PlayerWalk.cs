using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float walkingspeed;
    
    private float xDirection;
    
    private float xVector;
    void Start()
    {
        walkingspeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * walkingspeed * Time.deltaTime;

        transform.position = transform.position + new Vector3(xVector, 0, 0);
    }
}
