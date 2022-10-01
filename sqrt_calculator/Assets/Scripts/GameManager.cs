using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject quest_num;
    GameObject guess1;
    GameObject guess2;
    GameObject result;

    public float answer=0f;
    bool isdecimal = false;
    int decimalcount;

    
    // Start is called before the first frame update
    void Start()
    {

        quest_num = GameObject.Find("QuestionNum");
        guess1 = GameObject.Find("Guess1");
        guess2 = GameObject.Find("Guess2");
        result = GameObject.Find("Result");

        int rand = Random.Range(1, 10);
        quest_num.GetComponent<Text>().text = rand.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Input_anwer(int num)
    {
        if(num==99)
        {
            Debug.Log(num);
            isdecimal = true;
            decimalcount = 0;
             Debug.Log(guess1.GetComponent<Text>().text);
            guess1.GetComponent<Text>().text = guess1.GetComponent<Text>().text + ".";
             Debug.Log(guess1.GetComponent<Text>().text);
        }
        else if(isdecimal==false)
        {
            answer = answer * 10 + num;

            guess1.GetComponent<Text>().text = answer.ToString();
            guess2.GetComponent<Text>().text = answer.ToString();

            float temp = answer * answer;

            result.GetComponent<Text>().text = temp.ToString();
        }
        else
        {
            decimalcount ++;
            answer = answer + num * Mathf.Pow(0.1f, decimalcount);
            guess1.GetComponent<Text>().text = answer.ToString();
            guess2.GetComponent<Text>().text = answer.ToString();

            float temp = answer * answer;

            result.GetComponent<Text>().text = temp.ToString();
        }


        // Debug.Log(guess1.GetComponent<Text>().text);
       

    }
}
