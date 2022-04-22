using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public Transform parentPickup;
    public Transform stackPosition;

    public Quaternion startQuaternion;
    [SerializeField] public float lerpTime = 2;

    void Start()
    {
        startQuaternion = transform.rotation;
    }
    void Update()
    {
        transform.Rotate(Vector3.right   * lerpTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Transform otherTransform = other.transform;
            Rigidbody otherRb = otherTransform.GetComponent<Rigidbody>();
            otherRb.isKinematic = true;
            other.gameObject.GetComponent<SphereCollider>().isTrigger = false;

            parentPickup.position += Vector3.up * (otherTransform.localPosition.y);
            otherTransform.position = stackPosition.position;
            otherTransform.parent = parentPickup;
        }
    }
}
