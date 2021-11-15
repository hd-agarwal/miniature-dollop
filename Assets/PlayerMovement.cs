using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRB;

    // Update is called once per frame
    void Update()
    {
        playerRB.AddForce(0,0,2000*Time.deltaTime);
    }
}
