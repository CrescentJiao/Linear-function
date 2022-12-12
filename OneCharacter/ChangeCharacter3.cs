using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCharacter3 : MonoBehaviour
{

    public GameObject texttishi;
    Text distancetext;
    public int S;
    // Start is called before the first frame update
    void Start()
    {
        distancetext = GameObject.Find("distance").GetComponent<Text>();
    }
    private void OnTriggerEnter(Collider other)
    {
        SimpleSampleCharacterControl.h = 0;
       
        texttishi.SetActive(true);
        MyTimer3.isPause = true;
        distancetext.text = S.ToString() + ".00m";
        Toggletrue();
    }
    private void OnTriggerExit(Collider other)
    {

    }
    void Toggletrue()
    {

        for (int i = 1; i <= 3; i++)
        {
            if (!ChangeSpeed3.order.Contains(i))
            {
                GameObject.Find("Toggle" + i).GetComponent<Toggle>().interactable = true;

            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
