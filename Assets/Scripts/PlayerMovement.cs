using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRB;
    public float forwardForce;
    public float sidewaysForce;

    // Update is called once per frame
    void FixedUpdate()
    {
        playerRB.AddForce(0,0,forwardForce*Time.deltaTime);
        if(Input.GetKey("d"))
        {
            playerRB.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            playerRB.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
    }
}
