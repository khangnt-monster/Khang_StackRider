using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public Quaternion startQuaternion;
    [SerializeField] public float lerpTime = 2;

    void Start()
    {
        startQuaternion = transform.rotation;
    }
    void Update()
    {
        transform.Rotate(Vector3.up * lerpTime);
    }
}
