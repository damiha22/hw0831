using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SevenClick : MonoBehaviour
{
    GameObject gm;
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }
    public void InputSeven()
    {
        gm.GetComponent<GameManager>().Input_anwer(7);
    }
}
