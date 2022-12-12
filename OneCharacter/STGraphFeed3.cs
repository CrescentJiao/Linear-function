#define Graph_And_Chart_PRO
using UnityEngine;
using ChartAndGraph;

using System.Collections;
using UnityEngine.UI;


public class STGraphFeed3 : MonoBehaviour
{
    float lastTime = 0f;

    GraphChartBase graph;
    Text distancetext;
    public static float y;
    public static double yy;
    void Start()
    {
        distancetext = GameObject.Find("distance").GetComponent<Text>();
        graph = GetComponent<GraphChartBase>();
        if (graph != null)
        {
            graph.Scrollable = false;
            graph.HorizontalValueToStringMap[0.0] = "0"; // example of how to set custom axis strings
            graph.DataSource.StartBatch();
            graph.DataSource.ClearCategory("Player 1");
            //  graph.DataSource.ClearAndMakeBezierCurve("Player 2");
            graph.DataSource.AddPointToCategory2("Player 5", 0, 50);



            graph.DataSource.EndBatch();
        }
        // StartCoroutine(ClearAll());
        //InvokeRepeating("MyAddPoint", 0.01f, 0.2f);
    }
    void Update()
    {
        MyAddPoint();
    }
    void MyAddPoint()
    {

        float curTime = MyTimer3.m_Timer;
        if (lastTime + 0.01f <= curTime)
        {
            lastTime = curTime;
            int xcount=0;
            if (ChangeSpeed3.order.Count > 2) { xcount = ChangeSpeed3.order.Count; }
            else if(ChangeSpeed3.order.Count <= 2) { xcount = ChangeSpeed3.order.Count - 1; }

            if (ChangeSpeed3.cardnum == 1)
            {
                yy = 25 * (ChangeSpeed3.order.Count - 1) + ChangeSpeed3.showspeed * (MyTimer3.m_Timer - ChangeSpeed3.timeuse[ChangeSpeed3.order.Count - 1]);
                graph.DataSource.AddPointToCategory2("Player 1", MyTimer3.m_Timer, 25 * xcount + ChangeSpeed3.showspeed * (MyTimer3.m_Timer - ChangeSpeed3.timeuse[ChangeSpeed3.order.Count - 1])); // each time we call AddPointToCategory
                distancetext.text = yy.ToString("f2") + "m";
            }
            if (ChangeSpeed3.cardnum == 2)
            {
                yy = 25 * (ChangeSpeed3.order.Count - 1) + ChangeSpeed3.showspeed * (MyTimer3.m_Timer - ChangeSpeed3.timeuse[ChangeSpeed3.order.Count - 1]);
                graph.DataSource.AddPointToCategory2("Player 2", MyTimer3.m_Timer, 25 * xcount + ChangeSpeed3.showspeed * (MyTimer3.m_Timer - ChangeSpeed3.timeuse[ChangeSpeed3.order.Count - 1])); // each time we call AddPointToCategory
                distancetext.text = yy.ToString("f2") + "m";
            }
            if (ChangeSpeed3.cardnum == 3)
            {
                yy = 25 * (ChangeSpeed3.order.Count - 1) + ChangeSpeed3.showspeed * (MyTimer3.m_Timer - ChangeSpeed3.timeuse[ChangeSpeed3.order.Count - 1]);
                graph.DataSource.AddPointToCategory2("Player 3", MyTimer3.m_Timer, 25 * xcount + ChangeSpeed3.showspeed * (MyTimer3.m_Timer - ChangeSpeed3.timeuse[ChangeSpeed3.order.Count - 1])); // each time we call AddPointToCategory
                distancetext.text = yy.ToString("f2") + "m";
            }
          


        }
    }
    IEnumerator ClearAll()
    {
        yield return new WaitForSeconds(5f);
        GraphChartBase graph = GetComponent<GraphChartBase>();

        graph.DataSource.Clear();
    }
}
