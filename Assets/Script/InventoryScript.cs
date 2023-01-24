using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public char size;
    private int[] inven;
    // Start is called before the first frame update
    void Start()
    {
        inven=new int[size];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
