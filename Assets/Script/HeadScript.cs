using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadScript : MonoBehaviour
{
    private bool moveable=false;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKey(KeyCode.R)){
            Debug.Log(moveable);
            if(moveable){
                Debug.Log("grab");
            }
        }*/
    }
    public void OnTriggerEnter(Collider coll){
        Debug.Log(coll.tag);
    }
    public void OnTriggerStay(Collider coll){
        Debug.Log("stay");
        if(coll.CompareTag("moveable")){
            //Debug.Log("true");
            moveable=true;
            if(Input.GetKey(KeyCode.R)){
                if(moveable){
                    GameObject box=coll.gameObject;
                    Rigidbody boxRigi=box.GetComponent<Rigidbody>();
                    Debug.Log("grab");
                    //coll
                }
            }
        }
        else{
            moveable=false;
        }
        //Debug.Log(this.moveable);
    }
}
