using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Vector3 GetAnchorPosition(Vector3 anchorWorldPos){
        return gameObject.transform.InverseTransformPoint(anchorWorldPos);
    }
}
