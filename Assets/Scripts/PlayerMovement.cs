using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    float speed = 5f;

    void Start()
    {
        Debug.Log("Hi ");
        rb.velocity = new Vector3(0f, 0f, rb.velocity.z * speed);
    }


}
