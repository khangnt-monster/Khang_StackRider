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

    private void Awake()
    {
        state = State.running;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        coll = GetComponent<Collider>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * PlayerSpeed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Collectable")
        {
            Debug.Log(" is work ");
            Destroy(collision.gameObject);
            coins += 1;
            coinsText.text = coins.ToString();
        }
    }

    private void AnimationState()
    {
    }

}
