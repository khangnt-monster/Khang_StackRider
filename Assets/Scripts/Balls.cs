using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balls : MonoBehaviour
{

    Transform parentPickup;
    public Text coinsText;
    private int coins;
    public GameOverScript gameOverScript;
    [SerializeField] bool isPlaying;

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
}
