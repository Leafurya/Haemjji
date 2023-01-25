using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateZoneScript : MonoBehaviour
{
    public GameObject partition;
    public Transform zonePerant;
    //private  trans;
    private GameObject childObj;
    // Start is called before the first frame update
    void Start()
    {
        //카메라 존의 스케일은 0.5,1,0.5
        Transform trans=gameObject.transform;
        //Debug.Log(trans.localScale);
        zonePerant.position=trans.position;
        int w=(int)trans.localScale.x;
        int h=(int)trans.localScale.z;
        float oriX=trans.position.x-(((w/2f)*10f)-5f);//(half scale * 1big cell) + 1half big cell
		float oriZ=trans.position.z-(((h/2f)*10f)-5f);
		float tOriX,tOriZ;
		int z,x;

        for(z=0,tOriZ=oriZ;z<h;z++,tOriZ+=10){
            for(x=0,tOriX=oriX;x<w;x++,tOriX+=10){
                childObj=(GameObject)Instantiate(partition);
                childObj.transform.parent=zonePerant;
                childObj.transform.position=new Vector3(tOriX,trans.position.y-1f,tOriZ);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
