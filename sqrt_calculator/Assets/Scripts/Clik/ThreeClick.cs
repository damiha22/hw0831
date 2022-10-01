using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeClick : MonoBehaviour
{
    GameObject gm;
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }
    public void InputThree()
    {
        gm.GetComponent<GameManager>().Input_anwer(3);
    }
}
