using UnityEngine;
using System.Collections;

public class NeckController : MonoBehaviour
{
    public GameObject neckChild;
    MMD4MecanimBone neckBone;
    public GameObject faceChild;
    MMD4MecanimBone faceBone;

    Vector3 neckVec; //首の角度
    float setconstant = 0.1e3f + 90;
    private Vector3 faceVec;

    void Start()
    {
        //neckのgameObjectを取得
        //neckのBoneにアタッチされているMMD4MecanimBoneを取得
        neckBone = neckChild.GetComponent<MMD4MecanimBone>();
        faceBone = faceChild.GetComponent<MMD4MecanimBone>();
    }

    void Update()
    {
        if (neckBone != null)
        {
            //neckVec = new Vector3(0, 0, 0);


            neckVec = new Vector3(0, 0, getsteerangle.neckzangle);
            faceVec = new Vector3(0, getsteerangle.horizontal / setconstant, 0);
            //neckVec = new Vector3(0, 0, 0);
            neckBone.userEulerAngles = neckVec; //首を動かす
            faceBone.userEulerAngles = faceVec;
           // Debug.Log(getsteerangle.horizontal);
            //Debug.Log(getsteerangle.VehicleData.EngineRpm);

        }
        else
        {
            Debug.LogWarning("can't find MMD4MecanimBone(script)");
        }
    }
}