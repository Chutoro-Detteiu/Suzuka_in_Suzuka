using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getGaObName : MonoBehaviour
{
    public static string Obname;
    public static bool isPitroad;
                                                                                                                                                                                                   
    // Start is called before the first frame update
    void Start()
    {
        Obname = "";
        isPitroad = true;
    }

    // Update is called once per frame
    void Update()
    { 
        //Obname = "";
    }
    void OnTriggerEnter(Collider collider)
    {
        Obname = collider.gameObject.name;
        Debug.Log(Obname);
    }
}
