using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roulletecontroller : MonoBehaviour
{
    GameObject number;
    float rotspeed = 0f; // È¸Àü ¼Óµµ
    bool isplay = false;
    int carmovechane=0;
    // Start is called before the first frame update
    void Start()
    {
        number = GameObject.Find("number");   
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            rotspeed = 10;
            isplay = true;
        }

        rotspeed *= 0.96f;

        gameObject.transform.Rotate(0,0,rotspeed);
       
        if(rotspeed <0.1)
        {
            if(isplay==true)
            {
                if(gameObject .transform .eulerAngles.z>330 && gameObject.transform.eulerAngles .z<=30)
                {
                    number.GetComponent<Text>().text = "·ê·¿ °á°ú : 1";
                    carmovechane = 1;
                }
                else if (gameObject.transform.eulerAngles.z > 30 && gameObject.transform.eulerAngles.z <= 90)
                {
                    number.GetComponent<Text>().text = "·ê·¿ °á°ú : 2";
                    carmovechane = 2;
                }
                else if (gameObject.transform.eulerAngles.z > 90 && gameObject.transform.eulerAngles.z <= 150)
                {
                    number.GetComponent<Text>().text = "·ê·¿ °á°ú : 1";
                    carmovechane = 1;
                }
                else if (gameObject.transform.eulerAngles.z > 150 && gameObject.transform.eulerAngles.z <= 210)
                {
                    number.GetComponent<Text>().text = "·ê·¿ °á°ú : 3";
                    carmovechane = 3;
                }
                else if (gameObject.transform.eulerAngles.z > 210 && gameObject.transform.eulerAngles.z <= 270)
                {
                    number.GetComponent<Text>().text = "·ê·¿ °á°ú : 2";
                    carmovechane = 2;
                }
                else
                {
                    number.GetComponent<Text>().text = "·ê·¿ °á°ú : 4";
                    carmovechane = 4;
                }

                isplay = false;
            }
        }
        
    }
}
