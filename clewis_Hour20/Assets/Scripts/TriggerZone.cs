using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    void OnTriggerEnter(Collider other) 
    {      
        // This will destroy whatever object enters the trigger
        Destroy(other.gameObject); 
    }
}