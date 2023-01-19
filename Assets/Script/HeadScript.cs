using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GripableObj{
    public Rigidbody rigi;
    public SpringJoint joint;
    public GameObject obj;
    public BoxScript bs;

    public GripableObj(GameObject obj){
        this.obj=obj;
        this.rigi=obj.GetComponent<Rigidbody>();
        this.joint=obj.GetComponent<SpringJoint>();
        this.bs=obj.GetComponent<BoxScript>();
    }
}
public class HeadScript : MonoBehaviour
{
    
    private Rigidbody rigi;
    public bool clashed,grip;
    public GripableObj gripableObj;
    private Transform trans;
    // Start is called before the first frame update
    void Start()
    {
        clashed=false;
        grip=false;
        rigi=gameObject.GetComponent<Rigidbody>();
        trans=gameObject.transform;
        gripableObj=null;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(clashed);
        if(clashed){
            if(Input.GetKey(KeyCode.Space)){
                grip=true;
                Debug.Log("gripping");//gripableObj.
                //Debug.Log(gripableObj.joint.anchor.GetType());
                
                /*gripableObj.rigi.constraints=RigidbodyConstraints.None;
                gripableObj.joint.connectedAnchor=trans.position;
                gripableObj.joint.anchor=gripableObj.bs.GetAnchorPosition(trans.position);*/
                //Debug.Log(gripableObj);
            }
            else{
                if(grip){
                    Debug.Log("gripless");
                    /*if(gripableObj!=null){
                        gripableObj.joint.connectedBody=null;
                        gripableObj=null;
                        gripableObj.rigi.constraints=RigidbodyConstraints.FreezeAll;
                    }*/
                }
            }
        }
    }
    public void OnTriggerEnter(Collider coll){
        //Debug.Log(coll.contacts[0]);
        Debug.Log("clash");
        if(coll.gameObject.tag=="moveable"){
            gripableObj=new GripableObj(coll.gameObject);
            gripableObj.joint.connectedBody=rigi;
            clashed=true;
            //clashed=true;
        }
    }
    public void OnTriggerStay(Collider coll){
        if(coll.gameObject.tag=="moveable"){
            
        }
    }
    public void OnTriggerExit(Collider coll){
        if(coll.gameObject.tag=="moveable"){
            if(!grip){
                clashed=false;
                Debug.Log("clashless");
            }
        }
    }

    //mouse의 월드좌표로 앵커위치 설정.
    /*public void OnCollisionStay(Collision coll){
        Debug.Log("stay");
        if(coll.gameObject.tag=="moveable"){
            gripableObj=coll.gameObject;
        }
    }*/
    //충돌했을때 키를 누르면 조인트를 연결하고 때면 해제한다.
    /*public void OnTriggerEnter(Collider coll){
        Debug.Log(coll.tag);
        //Debug.Log(coll.contacts);
    }
    public void OnTriggerStay(Collider coll){
        Debug.Log("stay");
        if(coll.CompareTag("moveable")){
            GameObject box=coll.gameObject;
            SpringJoint boxJoint=box.GetComponent<SpringJoint>();
            Rigidbody boxRigi=box.GetComponent<Rigidbody>();
            if(Input.GetKey(KeyCode.R)){
                //boxJoint.connectedBody=rigi;
                
            }
            else{
                //boxJoint.connectedBody=null;
            }
            //Debug.Log(boxJoint.connectedBody);
        }
        //Debug.Log(this.moveable);
    }*/
}
