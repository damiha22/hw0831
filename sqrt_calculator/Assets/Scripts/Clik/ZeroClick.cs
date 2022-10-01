using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroClick : MonoBehaviour
{
    GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }

    public void InputZero()
    {
        gm.GetComponent<GameManager>().Input_anwer(0);
    }
    
}
