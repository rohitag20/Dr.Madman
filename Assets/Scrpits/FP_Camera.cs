using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FP_Camera : MonoBehaviour
{


    public Transform p1;
    public Transform r1;

    // Update is called once per frame
    void Update()
    {
        transform.position = p1.position;
        transform.rotation = r1.rotation;
    }
}
