using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doors_behaviour : MonoBehaviour
{
    void OnTriggerEnter (Collision x) {
        Debug.Log(x.collider.name);
    }
}
    //public BoxCollider teleport;
    /*
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Door")  
        {
            Debug.Log("Do something here");
            Destroy(col.gameObject);  //soh um exemplo
            
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }*/

