using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayManager : MonoBehaviour
{
    public GameOverScript GameOverScript;

    public GameObject ground;

    Stack<Transform> objectPool = new Stack<Transform>();

    Touch touch;

    void Awake()
    {
        GameOverScript.Setup(false);

    }

    void Start()
    {

    }

    void Update()
    {

    }



}
