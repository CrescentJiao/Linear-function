using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopRun3 : MonoBehaviour
{
    Text distancetext;
    // Start is called before the first frame update
    void Start()
    {
        distancetext = GameObject.Find("distance").GetComponent<Text>();
    }
    private void OnTriggerEnter(Collider other)
    {
        SimpleSampleCharacterControl.h = 0;

        MyTimer3.isPause = true;
        distancetext.text = "100.00m";
        // 
    }
    private void OnTriggerExit(Collider other)
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
}
