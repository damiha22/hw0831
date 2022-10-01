using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NineCkik : MonoBehaviour
{
    GameObject gm;
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }
    public void InputNine()
    {
        gm.GetComponent<GameManager>().Input_anwer(9);
    }
}
