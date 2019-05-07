using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class completeTrigger : MonoBehaviour
{
    public GameObject lapTrigger;
    public GameObject halfTrigger;

    public GameObject minute;
    public GameObject second;
    public GameObject milli;

    public GameObject lapTimeBox;

    void OnTriggeerEnter()
    {
        if (lapTimer.second<=9) 
        {
            second.GetComponent<Text>().text = "0" + lapTimer.second + ".";
        }
        else
        {
            second.GetComponent<Text>().text = "" + lapTimer.second + ".";
        }
       
        if (lapTimer.minute <= 9)
        {
            minute.GetComponent<Text>().text = "0" + lapTimer.minute + ".";
        }
        else
        {
            minute.GetComponent<Text>().text = "" + lapTimer.minute + ".";
        }
        milli.GetComponent<Text>().text = "" + lapTimer.milli;
        lapTimer.milli = 0;
        lapTimer.second = 0;
        lapTimer.minute = 0;
        
        halfTrigger.SetActive(true);
        lapTrigger.SetActive(false);
    }

}

