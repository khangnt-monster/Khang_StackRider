using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float PlayerSpeed = 3;

    public Text coinsText;
    private int coins;
    private Animator anim;
    private enum State { idle, running, dancing }
    private State state = State.running;

    private Rigidbody rb;
    private Collider coll;

    Transform parentPickup;
    [SerializeField] Transform stackPos;
    [SerializeField] bool isPlaying;

    public GameOverScript gameOverScript;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        coll = GetComponent<Collider>();

        isPlaying = true;
    }

    void Update()
    {
        if (isPlaying)
            transform.Translate(Vector3.forward * PlayerSpeed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Collectable")
        {
            Destroy(other.gameObject);
            coins += 1;
            coinsText.text = coins.ToString();
        }

        if (other.tag == "Finish")
        {
            gameOverScript.Setup(true);
            isPlaying = false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ball")
        {
            Transform otherTransform = collision.transform;

            Rigidbody otherRB = otherTransform.GetComponent<Rigidbody>();

            otherRB.isKinematic = true;
            collision.collider.enabled = false;
            if (parentPickup == null)
            {
                parentPickup = otherTransform;
                parentPickup.position = stackPos.position;
                parentPickup.parent = stackPos;
            }
            else
            {
                parentPickup.position += Vector3.up * (otherTransform.localScale.y);
                otherTransform.position = stackPos.position;
                otherTransform.parent = stackPos;
            }

        }
    }

}
