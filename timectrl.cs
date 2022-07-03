using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timectrl : MonoBehaviour
{
    
    public static int minute;
    
    public static float seconds;
    //　前のUpdateの時の秒数
    
    public static float laptime;
    public static int laptimemin;
    public static float laptimesec;
    private float fastesttime;
    public static int fastestmin;
    public static float fastestsec;
    public static float timedistance;
    public static int lapcount;
    private int lapcheck;
    public static float lastlaptime;
    // Start is called before the first frame update
    void Start()
    {
        minute = 0;
        seconds = 0f;
        fastesttime = 0f;
        laptime = 0f;
        fastestsec = 0f;
        laptimesec = 0f;
        laptimemin = 0;
        fastestmin = 0;
        lapcount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (getGaObName.Obname == "ctrl_line")
        {
            Debug.Log("timectrl Update");
            laptimesec = laptime;
            //laptimemin = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (laptimesec > 60)
                {
                    laptimemin++;
                    laptimesec -= 60;
                    lastlaptime = laptime;
                }
            }
            laptime = 0f;
            seconds = 0f;
            minute = 0;
            lapcount++;
            timedistance = laptime - fastesttime;
            LCD.lapcheck = true;
            if (timedistance < 0 || lapcount == 1)
            {
                fastesttime = laptime;
                if (fastesttime > 60)
                {
                    fastestmin++;
                    fastestsec = fastesttime - 60;
                }
            }
            getGaObName.Obname = "";

        }
        if (!getGaObName.isPitroad)
        {
            seconds += Time.deltaTime;
            laptime += Time.deltaTime;
        }
        
        if (seconds > 60)
        {
            minute++;
            seconds -= 60.0f;
            
        }
        //Debug.Log(Time.deltaTime);
       
        
        
    }
}
