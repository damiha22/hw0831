using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiveClick : MonoBehaviour
{
    GameObject gm;
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }
    public void InputFive()
    {
        gm.GetComponent<GameManager>().Input_anwer(5);
    }
}
