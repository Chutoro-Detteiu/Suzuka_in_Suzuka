using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taco : MonoBehaviour
{
    //List<int> checkrpm = new List<int>() { 8000, 8200, 8400, 8600, 8800, 9000, 9200, 9400, 9600, 9800, 10000, 10200, 10400, 10600, 10800, 11000, 11200, 11400, 11600, 11800, 12000, 12200, 12400, 12600, 12800, 13000, 13200, 13400, 13600, 13800, 14000, 14200, 14400, 14600, 14800, 15000,15200 };

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        
        //Debug.Log(getsteerangle.rpm/1000);
        for (int checkrpm = 8000,  i = 0; i <= 36; i++)
        {
            checkrpm += 189;
            //Debug.Log(checkrpm[36]);
           
            //Debug.Log(i + "at taco.cs Line25");
            //Debug.Log(checkrpm);
            if (getsteerangle.rpm / 1000 < checkrpm)
            {
                getsteerangle.LEDon[i].SetActive(false);
                getsteerangle.LEDoff[i].SetActive(true);
            }
            else if (getsteerangle.rpm/1000 >= checkrpm)
            {
                getsteerangle.LEDoff[i].SetActive(false);
                getsteerangle.LEDon[i].SetActive(true);
            }

        }
    }
}

