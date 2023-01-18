using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Camera balence;
    public Camera mainCam;
    public GameObject player;
    private Transform trans;
    // Start is called before the first frame update
    void Start()
    {
        balence.enabled=true;
        trans=gameObject.transform;
    }

    // Update is called once per frames
    void Update()
    {
        float mouseX = (float)Input.GetAxis("Mouse X");
        trans.Rotate(0,mouseX,0);
    }
}
