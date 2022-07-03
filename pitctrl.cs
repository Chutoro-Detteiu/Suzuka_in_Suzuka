using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VehiclePhysics;

public class pitctrl : MonoBehaviour
   
{
    [SerializeField] private bool islimitspeed;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(getGaObName.Obname == "pitenter")
        {
            getGaObName.isPitroad = true;
            Debug.Log("getGaObName.isPitroad = true;");
        }
        else if(getGaObName.Obname == "pitexit")
        {
            getGaObName.isPitroad = false;
            Debug.Log("getGaObName.isPitroad = false;");
        }
        if (getGaObName.isPitroad)
        {
            timectrl.laptime = 0f;
            timectrl.seconds = 0f;
            timectrl.minute = 0;
           

        }
       
        
        
    }
}
