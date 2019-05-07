using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lapTimer : MonoBehaviour
{
    public static int minute;
    public static int second;
    public static float milli;
    public static string milliDisplay;
    public GameObject minuteBox;
    public GameObject secondBox;
    public GameObject milliBox;

    


    void Update()
    {
        milli += Time.deltaTime * 10;
        milliDisplay = milli.ToString("F0");
        milliBox.GetComponent<Text>().text = "" + milliDisplay;
        if(milli>=10)
        {
            milli = 0;
            second += 1;
        }
        if (second<=9)
        {
            secondBox.GetComponent<Text>().text = "0" + second + ".";
        }else
        {
            secondBox.GetComponent<Text>().text = "" + second + ".";
        }
        if (second >= 60)
        {
            second = 0;
            minute += 1;
        }
        if (minute <= 9)
        {
            minuteBox.GetComponent<Text>().text = "0" + minute + ".";
        }
        else
        {
            minuteBox.GetComponent<Text>().text = "" + minute + ".";
        }

    }
}
