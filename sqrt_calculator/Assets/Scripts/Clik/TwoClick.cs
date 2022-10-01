using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoClick : MonoBehaviour
{
    GameObject gm;
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }
    public void InputTwo()
    {
        gm.GetComponent<GameManager>().Input_anwer(2);
    }
}
