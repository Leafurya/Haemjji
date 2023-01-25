using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalenceCamMove : MonoBehaviour
{
    private Transform trans;
    public Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        trans=gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        trans.position=new Vector3(-mainCam.transform.localPosition.x,mainCam.transform.localPosition.y,-mainCam.transform.localPosition.z);
    }
}
