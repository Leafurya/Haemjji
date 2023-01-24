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
    public InventoryScript invns;
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
        if(Input.GetKeyDown(KeyCode.Space)&&clashed){
            grip=true;
            Vector3 tvec=trans.TransformPoint(trans.localPosition);
            gripableObj.joint.anchor=gripableObj.bs.GetAnchorPosition(tvec);
			gripableObj.joint.connectedBody=rigi;
			gripableObj.rigi.constraints=RigidbodyConstraints.None;
        }
        else if(Input.GetKeyUp(KeyCode.Space)){
            grip=false;
			gripableObj.joint.connectedBody=null;
			gripableObj.rigi.constraints=RigidbodyConstraints.FreezeAll;
        }
        if(grip){
			// Vector3 tvec=trans.TransformPoint(trans.localPosition);
            // gripableObj.joint.anchor=gripableObj.bs.GetAnchorPosition(tvec);
            //gripableObj.joint.connectedAnchor=tvec;
			//Debug.Log(tvec);
        }
        else{
        }
    }
    public void OnTriggerEnter(Collider coll){
        //Debug.Log(coll.contacts[0]);
        Debug.Log("clash");
        if(coll.gameObject.tag=="moveable"){
            
            //clashed=true;
        }
        switch(coll.gameObject.tag){
            case "moveable":
                gripableObj=new GripableObj(coll.gameObject);
                clashed=true;
                break;
            case "item":
                Debug.Log(coll.gameObject);
                invns.StoreItem(coll.gameObject);
                break;
        }
    }
    public void OnTriggerStay(Collider coll){
        if(coll.gameObject.tag=="moveable"){
            
        }
    }
    public void OnTriggerExit(Collider coll){
        if(coll.gameObject.tag=="moveable"){
            clashed=false;
        }
    }
}
