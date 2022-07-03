using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posecontrol : MonoBehaviour
{
    public GameObject mmdPlayerObject;
    public GameObject bust;
    public GameObject Lfoot;
    public GameObject bustsec;
    public GameObject Rsholderp;
    public GameObject Rsholder;
    public GameObject Rsholderc;
    public GameObject Rhandwrestl;
    public GameObject Relbow;
    public GameObject RlittlefingerA;
    public GameObject RlittlefingerB;
    public GameObject RringfingerA;
    public GameObject RringfingerB;
    public GameObject RmiddlefingerA;
    public GameObject RmiddlefinegrB;
    public GameObject RindexfingerA;
    public GameObject RindexfingerB;
    public GameObject RindexfingerC;
    public GameObject RthumbA;
    public GameObject Lsholderp;
    public GameObject Lsholder;
    public GameObject Lelbow;
    public GameObject LlittlefingerA;
    public GameObject LlittlefingerB;
    public GameObject LringfingerA;
    public GameObject LringfingerB;
    public GameObject LringfingerC;
    public GameObject LmiddlefingerA;
    public GameObject LmiddlefingerB;
    public GameObject LmiddlefingerC;
    public GameObject LindexfingerA;
    public GameObject LindexfingerB;
    public GameObject LindexfingerC;
    public GameObject LthumbA;
    public GameObject LthumbB;
    public GameObject LthumbC;
    public GameObject Lknee;
    public GameObject Lankle;
    public GameObject Rfoot;
    public GameObject Rknee;
    public GameObject Rankle;
    public GameObject skirtC;
    public GameObject tailA;


    // Start is called before the first frame update
    void Start()
    {
        MMD4MecanimBone bustBone = bust.GetComponent<MMD4MecanimBone>();
        Vector3 bustVec = new Vector3(70, 0, 0);
        bustBone.userEulerAngles = bustVec;

        MMD4MecanimBone LfootBone = Lfoot.GetComponent<MMD4MecanimBone>();
        Vector3 LfootVec = new Vector3(-32, -2, 5);
        LfootBone.userEulerAngles = LfootVec;
        
        MMD4MecanimBone bustsecBone = bustsec.GetComponent<MMD4MecanimBone>();
        Vector3 bustsecVec = new Vector3(-2, 0, 0);
        bustsecBone.userEulerAngles = bustsecVec;

        MMD4MecanimBone RsholderpBone = Rsholderp.GetComponent<MMD4MecanimBone>();
        Vector3 RsholderpVec = new Vector3( -77, 0, 0);
        RsholderpBone.userEulerAngles = RsholderpVec;

        MMD4MecanimBone RsholderBone = Rsholder.GetComponent<MMD4MecanimBone>();
        Vector3 RsholderVec = new Vector3( 11, -13, -49);
        RsholderBone.userEulerAngles = RsholderVec;

        MMD4MecanimBone RsholdercBone = Rsholderc.GetComponent<MMD4MecanimBone>();
        Vector3 RsholdercVec = new Vector3( 5, 0, 0);
        RsholdercBone.userEulerAngles = RsholdercVec;

        MMD4MecanimBone RhandwrestlBone = Rhandwrestl.GetComponent<MMD4MecanimBone>();
        Vector3 RhandwrestlVec = new Vector3( -27, 0, 0);
        RhandwrestlBone.userEulerAngles = RhandwrestlVec;

        MMD4MecanimBone RelbowBone = Relbow.GetComponent<MMD4MecanimBone>();
        Vector3 RelbowVec = new Vector3( 0, -24, 0);
        RelbowBone.userEulerAngles = RelbowVec;

        MMD4MecanimBone RlittlefingerABone = RlittlefingerA.GetComponent<MMD4MecanimBone>();
        Vector3 RlittlefingerAVec = new Vector3( 0, 0, -101);
        RlittlefingerABone.userEulerAngles = RlittlefingerAVec;

        MMD4MecanimBone RlittlefingerBBone = RlittlefingerB.GetComponent<MMD4MecanimBone>();
        Vector3 RlittlefingerBVec = new Vector3( 0, 0, -5);
        RlittlefingerBBone.userEulerAngles = RlittlefingerBVec;

        MMD4MecanimBone RringfingerABone = RringfingerA.GetComponent<MMD4MecanimBone>();
        Vector3 RringfingerAVec = new Vector3( 0, 0, -98);
        RringfingerABone.userEulerAngles = RringfingerAVec;

        MMD4MecanimBone RringfingerBBone = RringfingerB.GetComponent<MMD4MecanimBone>();
        Vector3 RringfingerBVec = new Vector3( 0, 0, -15);
        RringfingerBBone.userEulerAngles = RringfingerBVec;

        MMD4MecanimBone RmiddlefingerABone = RmiddlefingerA.GetComponent<MMD4MecanimBone>();
        Vector3 RmiddlefingerAVec = new Vector3( 0, 0, -71);
        RmiddlefingerABone.userEulerAngles = RmiddlefingerAVec;

        MMD4MecanimBone RmiddlefingerBBone = RmiddlefinegrB.GetComponent<MMD4MecanimBone>();
        Vector3 RmiddlefingerBVec = new Vector3( 0, 0, -58);
        RmiddlefingerBBone.userEulerAngles = RmiddlefingerBVec;

        MMD4MecanimBone RindexfingerABone = RindexfingerA.GetComponent<MMD4MecanimBone>();
        Vector3 RindexfingerAVec = new Vector3( 0, 2, -50);
        RindexfingerABone.userEulerAngles = RindexfingerAVec;

        MMD4MecanimBone RindexfingerBBone = RindexfingerB.GetComponent<MMD4MecanimBone>();
        Vector3 RindexfingerBVec = new Vector3( 0, 0, -48);
        RindexfingerBBone.userEulerAngles = RindexfingerBVec;

        MMD4MecanimBone RindexfingerCBone = RindexfingerC.GetComponent<MMD4MecanimBone>();
        Vector3 RindexfingerCVec = new Vector3( 0, 0, -66);
        RindexfingerCBone.userEulerAngles = RindexfingerCVec;

        MMD4MecanimBone RthumbABone = RthumbA.GetComponent<MMD4MecanimBone>();
        Vector3 RthumbAVec = new Vector3( 31, 11, -20);
        RthumbABone.userEulerAngles = RthumbAVec;

        MMD4MecanimBone LsholderpBone = Lsholderp.GetComponent<MMD4MecanimBone>();
        Vector3 LsholderpVec = new Vector3( -88, 0, 0);
        LsholderpBone.userEulerAngles = LsholderpVec;

        MMD4MecanimBone LsholderBone = Lsholder.GetComponent<MMD4MecanimBone>();
        Vector3 LsholderVec = new Vector3( 20, -2, 44);
        LsholderBone.userEulerAngles = LsholderVec;

        MMD4MecanimBone LelbowBone = Lelbow.GetComponent<MMD4MecanimBone>();
        Vector3 LelbowVec = new Vector3( 0, 41, -2);
        LelbowBone.userEulerAngles = LelbowVec;

        MMD4MecanimBone LlittlefingerABone = LlittlefingerA.GetComponent<MMD4MecanimBone>();
        Vector3 LlittlefingerAVec = new Vector3( 0, 0, 48);
        LlittlefingerABone.userEulerAngles = LlittlefingerAVec;

        MMD4MecanimBone LlittlefingerBBone = LlittlefingerB.GetComponent<MMD4MecanimBone>();
        Vector3 LlittlefingerBVec = new Vector3( 0, 0, 51);
        LlittlefingerBBone.userEulerAngles = LlittlefingerBVec;

        MMD4MecanimBone LringfingerABone = LringfingerA.GetComponent<MMD4MecanimBone>();
        Vector3 LringfingerAVec = new Vector3( 0, 0, 43);
        LringfingerABone.userEulerAngles = LringfingerAVec;

        MMD4MecanimBone LringfingerBBone = LringfingerB.GetComponent<MMD4MecanimBone>();
        Vector3 LringfingerBVec = new Vector3( 0, 0, 63);
        LringfingerBBone.userEulerAngles = LringfingerBVec;

        MMD4MecanimBone LringfingerCBone = LringfingerC.GetComponent<MMD4MecanimBone>();
        Vector3 LringfingerCVec = new Vector3( 0, 0, 46);
        LringfingerCBone.userEulerAngles = LringfingerCVec;

        MMD4MecanimBone LmiddlefingerABone = LmiddlefingerA.GetComponent<MMD4MecanimBone>();
        Vector3 LmiddlefingerAVec = new Vector3( 0, 0, 46);
        LmiddlefingerABone.userEulerAngles = LmiddlefingerAVec;

        MMD4MecanimBone LmiddlefingerBBone = LmiddlefingerB.GetComponent<MMD4MecanimBone>();
        Vector3 LmiddlefingerBVec = new Vector3( 0, 0, 88);
        LmiddlefingerBBone.userEulerAngles = LmiddlefingerBVec;

        MMD4MecanimBone LmiddlefingerCBone = LmiddlefingerC.GetComponent<MMD4MecanimBone>();
        Vector3 LmiddlefingerCVec = new Vector3( 0, 0, 36);
        LmiddlefingerCBone.userEulerAngles = LmiddlefingerCVec;

        MMD4MecanimBone LindexfingerABone = LindexfingerA.GetComponent<MMD4MecanimBone>();
        Vector3 LindexfingerAVec = new Vector3( 0, 0, 35);
        LindexfingerABone.userEulerAngles = LindexfingerAVec;

        MMD4MecanimBone LindexfingerBBone = LindexfingerB.GetComponent<MMD4MecanimBone>();
        Vector3 LindexfingerBVec = new Vector3( 0, 0, 75);
        LindexfingerBBone.userEulerAngles = LindexfingerBVec;

        MMD4MecanimBone LindexfingerCBone = LindexfingerC.GetComponent<MMD4MecanimBone>();
        Vector3 LindexfingerCVec = new Vector3( 0, 0, 36);
        LindexfingerCBone.userEulerAngles = LindexfingerCVec;

        MMD4MecanimBone LthumbABone = LthumbA.GetComponent<MMD4MecanimBone>();
        Vector3 LthumbAVec = new Vector3( 0, 0, 17);
        LthumbABone.userEulerAngles = LthumbAVec;

        MMD4MecanimBone LthumbBBone = LthumbB.GetComponent<MMD4MecanimBone>();
        Vector3 LthumbBVec = new Vector3( 17, -5, -10);
        LthumbBBone.userEulerAngles = LthumbBVec;

        MMD4MecanimBone LthumbCBone = LthumbC.GetComponent<MMD4MecanimBone>();
        Vector3 LthumbCVec = new Vector3( 8, -28, -18);
        LthumbCBone.userEulerAngles = LthumbCVec;

        MMD4MecanimBone LkneeBone = Lknee.GetComponent<MMD4MecanimBone>();
        Vector3 LkneeVec = new Vector3( 29, 0, 0);
        LkneeBone.userEulerAngles = LkneeVec;

        MMD4MecanimBone LankleBone = Lankle.GetComponent<MMD4MecanimBone>();
        Vector3 LankleVec = new Vector3( -13, 0, 0);
        LankleBone.userEulerAngles = LankleVec;

        MMD4MecanimBone RfootBone = Rfoot.GetComponent<MMD4MecanimBone>();
        Vector3 RfootVec = new Vector3( -32, 0, -7);
        RfootBone.userEulerAngles = RfootVec;

        MMD4MecanimBone RkneeBone = Rknee.GetComponent<MMD4MecanimBone>();
        Vector3 RkneeVec = new Vector3( 29, 0, 0);
        RkneeBone.userEulerAngles = RkneeVec;

        MMD4MecanimBone RankleBone = Rankle.GetComponent<MMD4MecanimBone>();
        Vector3 RankleVec = new Vector3( -13, 0, 0);
        RankleBone.userEulerAngles = RankleVec;

        MMD4MecanimBone skirtCBone = skirtC.GetComponent<MMD4MecanimBone>();
        Vector3 skirtCVec = new Vector3( -12, 0, 0);
        skirtCBone.userEulerAngles = skirtCVec;

        MMD4MecanimBone tailABone = tailA.GetComponent<MMD4MecanimBone>();
        Vector3 tailAVec = new Vector3( -66, -2, 0);
        tailABone.userEulerAngles = tailAVec;

       

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
