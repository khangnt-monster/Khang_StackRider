using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float PlayerSpeed = 3;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * PlayerSpeed *Time.deltaTime, Space.World);
    }

}
