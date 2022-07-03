using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LCD : MonoBehaviour
{


    //　タイマー表示用テキスト
    [SerializeField]
    private Text timerText;
    [SerializeField]
    private Text gearText;
    [SerializeField]
    private Text speedText;
    [SerializeField]
    private Text fastestText;

    private float speed;

    private bool isnumerator;

    public static bool lapcheck;
    private bool LCDmode;
    private string Laptimetext;

    void Start()
    {

        isnumerator = false;
        fastestText.text = "0:00.000";
        Laptimetext = "0:00.000";
        lapcheck = false;
        LCDmode = true;
        
    }

    void Update()
    {
        var enumerator = ctrl_line(fastestText,isnumerator);
        if (getsteerangle.gear == 0)
        {
            gearText.text = "N";
        }else if (getsteerangle.gear < 0)
        {
            gearText.text = "R";
        }
        else 
        {
            gearText.text = getsteerangle.gear.ToString();
        }
        speed = (float)(getsteerangle.speed * 3.6);
        speed = (int)speed;
        if (speed < 0)
        {
            speed *= -1;
        }
        speedText.text = speed.ToString();
        
        //fastestText.text = ((int)getsteerangle.rpm/1000).ToString();
        //enumerator.MoveNext();
        if(Input.GetKeyDown("joystick button 0")) {
            LCDmode = !LCDmode;
        }
        if (LCDmode)
        {
            fastestText.text = Laptimetext;
            if (!isnumerator)
            {
                if (lapcheck)
                {
                    if ((int)timectrl.laptimesec < 10)
                    {
                        fastestText.text = timectrl.laptimemin.ToString("0") + ":0" + ((float)timectrl.laptimesec).ToString("f3");
                        Laptimetext = timectrl.laptimemin.ToString("0") + ":0" + ((float)timectrl.laptimesec).ToString("f3");
                        lapcheck = false;
                        timectrl.laptimemin = 0;

                    }
                    else
                    {
                        fastestText.text = timectrl.laptimemin.ToString("0") + ":" + ((float)timectrl.laptimesec).ToString("f3");
                        Laptimetext = timectrl.laptimemin.ToString("0") + ":" + ((float)timectrl.laptimesec).ToString("f3");
                        lapcheck = false;
                        timectrl.laptimemin = 0;
                    }
                }

            }
        }
        else
        {
            fastestText.text = ((int)getsteerangle.rpm / 1000).ToString();
            if (!isnumerator)
            {
                if (lapcheck)
                {
                    if ((int)timectrl.laptimesec < 10)
                    {
                        Laptimetext = timectrl.laptimemin.ToString("0") + ":0" + ((float)timectrl.laptimesec).ToString("f3");
                        
                        lapcheck = false;
                        timectrl.laptimemin = 0;

                    }
                    else
                    {
                        Laptimetext = timectrl.laptimemin.ToString("0") + ":" + ((float)timectrl.laptimesec).ToString("f3");
                        lapcheck = false;
                        timectrl.laptimemin = 0;
                    }
                    Debug.Log(Laptimetext);
                }
            }
        }
       
        
        if (!getGaObName.isPitroad) {
            if ((int)timectrl.seconds < 10)
            {
                timerText.text = timectrl.minute.ToString("0") + ":0" + ((float)timectrl.seconds).ToString("f3");
            }
            else
            {
                timerText.text = timectrl.minute.ToString("0") + ":" + ((float)timectrl.seconds).ToString("f3");
            }
        }
        else
        {
            timerText.text = "On pitroad";
        }
        
        

        //　値が変わった時だけテキストUIを更新

    }
    public static IEnumerator ctrl_line(Text fastestText,bool isnumerator)
    {
        Debug.Log("IEnumerator");
        if (getGaObName.Obname == "ctrl_line")
        {
            isnumerator = true;
            Debug.Log("IEnumerator getGaObName.Obname == ctrl_line");
            if (timectrl.lapcount == 1)
            {
                if ((int)timectrl.laptimesec < 10)
                {
                    fastestText.text = timectrl.laptimemin.ToString("0") + ":0" + ((float)timectrl.laptimesec).ToString("f3");
                }
                else
                {
                    fastestText.text = timectrl.laptimemin.ToString("0") + ":" + ((float)timectrl.laptimesec).ToString("f3");
                }
                
            }
            else
            {
                if ((int)timectrl.laptimesec < 10)
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        fastestText.text = timectrl.laptimemin.ToString("0") + ":0" + ((float)timectrl.laptimesec).ToString("f3");
                        yield return new WaitForSeconds(1.0F);
                        if (timectrl.timedistance > 0)
                        {
                            fastestText.text = "+" + timectrl.timedistance.ToString();
                        }
                        else
                        {
                            fastestText.text = timectrl.timedistance.ToString();
                        }
                        yield return new WaitForSeconds(1.0F);
                    }
                    fastestText.text = timectrl.laptimemin.ToString("0") + ":0" + ((float)timectrl.laptimesec).ToString("f3");
                }
                else
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        fastestText.text = timectrl.laptimemin.ToString("0") + ":" + ((float)timectrl.laptimesec).ToString("f3");
                        yield return new WaitForSeconds(1.0F);
                        if (timectrl.timedistance > 0)
                        {
                            fastestText.text = "+" + timectrl.timedistance.ToString();
                        }
                        else
                        {
                            fastestText.text = timectrl.timedistance.ToString();
                        }
                        yield return new WaitForSeconds(1.0F);
                    }
                    fastestText.text = timectrl.laptimemin.ToString("0") + ":" + ((float)timectrl.laptimesec).ToString("f3");
                }
            }
            isnumerator = false;
        }
    }
}