using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    Transform parentPickup;
    //[SerializeField] Transform stackPos;

    public Quaternion startQuaternion;
    [SerializeField] public float lerpTime = 2;

    void Start()
    {
        startQuaternion = transform.rotation;
    }
    void Update()
    {
        transform.Rotate(Vector3.right * lerpTime);
    }

    private void OnTriggerEnter(Collider other)
    {

    }
}
