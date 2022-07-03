using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VehiclePhysics;
using System;

public class getsteerangle : MonoBehaviour
{
    public static float horizontal;
    public GameObject car;
    public static VPVehicleController main;
    public static int neckzangle;
    int constant = -300;
    public static int rpm;
    public GameObject[] LEDoffselect;
    public GameObject[] LEDonselect;
    public static GameObject[] LEDoff;
    public static GameObject[] LEDon;
    public static int gear;
    public static int speed;
    public static int log;
    public static bool isreplay;
    public static int framecount;
    public static int accelconstant;

    // Start is called before the first frame update
    void Start()
    {
        main = car.gameObject.transform.GetComponent<VPVehicleController>();
        LEDoff = LEDoffselect;
        LEDon = LEDonselect;
        isreplay = false;
        framecount = 0;
        accelconstant = -10000;




    }

    // Update is called once per frame
    void Update()
    {
        if (isreplay)
        {

           // main.data.Set(Channel.Input, InputData.Throttle, replay.replayaccel[framecount]);
            //main.data.Set(Channel.Input, InputData.Brake, replay.replaybrake[framecount]);
            //main.data.Set(Channel.Input, InputData.Steer, replay.replaysteer[framecount]);
            //main.data.Set(Channel.Input, InputData.ManualGear, replay.replaygear[framecount]);
            framecount++;
        }
        else
        {
            main.data.Set(Channel.Input, InputData.Throttle, (int)(Input.GetAxis("Accel") * accelconstant));
            main.data.Set(Channel.Input, InputData.Brake, (int)(Input.GetAxis("Brake") * -10000));
            main.data.Set(Channel.Input, InputData.Steer, (int)(Input.GetAxis("Horizontal") * 10000));
            if(Input.GetButton("Ignition"))
            {
                main.data.Set(Channel.Input, InputData.Key, 1);
            }
            else
            {
                main.data.Set(Channel.Input, InputData.Key, 0);
            }
                
                
        
            if (Input.GetButton("Fire1"))
            {
                main.data.Set(Channel.Input, InputData.Clutch, 100);
            }
        }
        //main.data.Set(Channel.Input, InputData.GearShift, 0);
        gear = main.data.Get(Channel.Vehicle, VehicleData.GearboxGear);
        speed = main.data.Get(Channel.Vehicle, VehicleData.Speed)/1000;
        rpm = main.data.Get(Channel.Vehicle, VehicleData.EngineRpm);
        horizontal = main.data.Get(Channel.Vehicle, VehicleData.AidedSteer)*0.5f;
        //horizontal = main.VehicleData.AidedSteer * 0.002f;
        log = main.data.Get(Channel.Vehicle, VehicleData.EngineRpm);



        //log = main.VehicleData.EngineRpm;
        if (horizontal == 0) {
            neckzangle = 0;

        }
        else if (horizontal > 0)
        {
            if (horizontal <= 3000)
            {
                neckzangle = (int)(horizontal / constant);
            }
            else
            {
                neckzangle = -15;
            }
        }
        else
        {
            if (horizontal >= -3000)
            {
                //neckzangle = (int)(horizontal / constantminus);
                neckzangle = (int)(horizontal / constant);
            }
            else
            {
                neckzangle = 15;
            }
        }

       
    }
}
