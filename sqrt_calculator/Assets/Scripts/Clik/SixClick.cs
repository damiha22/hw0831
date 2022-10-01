using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SixClick : MonoBehaviour
{
    GameObject gm;
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }
    public void InputSix()
    {
        gm.GetComponent<GameManager>().Input_anwer(6);
    }
}
