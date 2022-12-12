using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeSpeed3 : MonoBehaviour
{
    public float num = 0;
    public static bool isStrat;
    public static bool istoggle2on = false;
    public static bool istoggle3on = false;
    public static int cardnum;
    public GameObject character1;
  
    public GameObject texttishi;
    public Vector3[] pos = new Vector3[3];
    public static List<int> order = new List<int>();//创建了一个空列表
    public static List<float> timeuse = new List<float>();
  
    Text velocityText;
    public static float showspeed;
    // public bool istogglemagic = false;
    // public GameObject person;
    // Use this for initialization
    void Start()
    {
        order.Clear();
        timeuse.Clear();
        
        pos[0] = new Vector3(-232f, 0.01f, -13.2f);
        pos[1] = new Vector3(-112f, 0.01f, -13.2f);
        pos[2] = new Vector3(130f, 0.01f, -13.2f);

        character1.transform.SetPositionAndRotation(pos[0], character1.transform.rotation);
        SimpleSampleCharacterControl.h = 0;
        velocityText = GameObject.Find("velocity").GetComponent<Text>();
        isStrat = false;
        Toggle toggle;
        toggle = this.GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(Speed1);

        // showspeed = Mathf.Ceil(SimpleSampleCharacterControl.m_moveSpeed / 10f )+1;

    }
    void Speed1(bool ison)
    {
        if (ison == true)
        {
            isStrat = true;
            if (this.name == "Toggle1")
            {

                cardnum = 1; 
                SimpleSampleCharacterControl.h = 1;
                order.Add(1);
                character1.transform.SetPositionAndRotation(pos[order.Count - 1], character1.transform.rotation);
                MyTimer3.isPause = false;
                timeuse.Add(MyTimer3.m_Timer);
                texttishi.SetActive(false);
               
                
                SimpleSampleCharacterControl.m_moveSpeed = num;
                //GameObject.Find("Toggle1").GetComponent<Toggle>().interactable = false;
                Togglefalse();
                showspeed = 3;
                velocityText.text = (showspeed).ToString() + "m/s";
              
            }
            else if (this.name == "Toggle2")
            {
                cardnum = 2; 
                SimpleSampleCharacterControl.h = 1;
                order.Add(2);
                character1.transform.SetPositionAndRotation(pos[order.Count - 1], character1.transform.rotation);
                MyTimer3.isPause = false;
                timeuse.Add(MyTimer3.m_Timer);
                texttishi.SetActive(false);
               
              
                SimpleSampleCharacterControl.m_moveSpeed = num;
                // GameObject.Find("Toggle2").GetComponent<Toggle>().interactable = false;
                Togglefalse();
                showspeed = 5;
                velocityText.text = (showspeed).ToString() + "m/s";
             
            }
            else if (this.name == "Toggle3")
            {
                cardnum = 3; 
                SimpleSampleCharacterControl.h = 1;
                order.Add(3);
                character1.transform.SetPositionAndRotation(pos[order.Count - 1], character1.transform.rotation);

                MyTimer3.isPause = false;
                timeuse.Add(MyTimer3.m_Timer);
                texttishi.SetActive(false);
               
                SimpleSampleCharacterControl.m_moveSpeed = num;
                //GameObject.Find("Toggle3").GetComponent<Toggle>().interactable = false;
                Togglefalse();
                showspeed = 8;
                velocityText.text = (showspeed).ToString() + "m/s";
               
            }
            else
            {
                SimpleSampleCharacterControl.m_moveSpeed = num;

            }



            //  person.GetComponent<SimpleSampleCharacterControl>.
        }
        else
        {

        }
    }
  
    void Togglefalse()
    {
        GameObject.Find("Toggle1").GetComponent<Toggle>().interactable = false;
        GameObject.Find("Toggle2").GetComponent<Toggle>().interactable = false;
        GameObject.Find("Toggle3").GetComponent<Toggle>().interactable = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
