using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class finishTriger : MonoBehaviour
{
    public GameObject lapTrigger;
    public GameObject halfTrigger;
    private void OnTriggerEnter()
    {
        lapTrigger.SetActive(true);
        halfTrigger.SetActive(false);
    }
}
