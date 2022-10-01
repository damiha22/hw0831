using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotClick : MonoBehaviour
{
    GameObject gm;
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }
    public void InputDot()
    {
        gm.GetComponent<GameManager>().Input_anwer(99);
    }
}
