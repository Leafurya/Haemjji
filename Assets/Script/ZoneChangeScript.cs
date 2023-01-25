using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneChangeScript : MonoBehaviour
{
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider coll){
        if(coll.gameObject.tag=="zone"){
            Debug.Log("zone changed");
            cam.transform.parent=coll.gameObject.transform;
            cam.transform.localPosition=new Vector3(0,cam.transform.localPosition.y,0);
        }
    }
}
