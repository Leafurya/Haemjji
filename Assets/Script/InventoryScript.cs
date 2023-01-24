using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public GameObject[] inven;
    private int leri; //left:0 right:1
    // Start is called before the first frame update
    void Start()
    {
        inven=new GameObject[2];
        inven[0]=null;
        inven[1]=null;
        leri=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StoreItem(GameObject obj){
        if(inven[leri]==null){
            inven[leri++]=obj;
            obj.SetActive(false);
            leri%=2;
        }
    }
}
