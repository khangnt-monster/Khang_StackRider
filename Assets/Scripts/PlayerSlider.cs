using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSlider : MonoBehaviour
{

    public GameObject Player;

    public void Slider_Movement(float newValue)
    {
        Vector3 pos = Player.transform.position;
        pos.x = newValue;
        Player.transform.position = pos;
    }
}
