using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{

    public Rigidbody rb;
    public MeshCollider col;

    public bool ground;
    // Start is called before the first frame update
    void GroundCollision()
    {
        ground = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(500f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-500f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 500f * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -500f * Time.deltaTime);
        }
        if (Input.GetKey("q") && ground)
        {
            rb.AddForce(0,800,0);
            ground = false;
        }
    }

}
