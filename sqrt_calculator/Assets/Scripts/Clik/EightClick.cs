using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EightClick : MonoBehaviour
{
    GameObject gm;
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }
    public void InputEight()
    {
        gm.GetComponent<GameManager>().Input_anwer(8);
    }
}
