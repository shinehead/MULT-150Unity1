using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " has ENTERED the " + gameObject.name);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name + " is STILL in the " + gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " has LEFT the " + gameObject.name);
    }
}
