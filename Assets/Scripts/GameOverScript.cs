using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public void Setup(bool b)
    {
        gameObject.SetActive(b);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("MyScene");
    }
}
