using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Transform trans;
    private Rigidbody rigi;
    public GameObject head;
    private HeadScript hs;
    // Start is called before the first frame update
    void Start()
    {
        trans=gameObject.transform;
        rigi=gameObject.GetComponent<Rigidbody>();
        hs=head.GetComponent<HeadScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotDeg=100f*Time.deltaTime;
        float speed=4f;
        Vector3 dir=trans.forward;
        if(Input.GetKey(KeyCode.A)){
            trans.Rotate(0,-rotDeg,0);
        }
        else if(Input.GetKey(KeyCode.D)){
            trans.Rotate(0,rotDeg,0);
        }
        if(hs.grip){
            speed=.25f;
        }
        else if(Input.GetKey(KeyCode.LeftShift)){
            speed=3f;
        }
        else{
            speed=2f;
        }
        if(Input.GetKey(KeyCode.W)){
            rigi.velocity=new Vector3(dir.x*speed,0,dir.z*speed);
        }
        else if(Input.GetKey(KeyCode.S)){
            rigi.velocity=new Vector3(-dir.x*speed,0,-dir.z*speed);
        }
        else{
            rigi.velocity=new Vector3(0,0,0);
        }
        trans.eulerAngles=new Vector3(0f,trans.eulerAngles.y,0f);
    }
}
