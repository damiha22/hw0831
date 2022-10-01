using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourClick : MonoBehaviour
{
    GameObject gm;
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }
    public void InputFour()
    {
        gm.GetComponent<GameManager>().Input_anwer(4);
    }
}
