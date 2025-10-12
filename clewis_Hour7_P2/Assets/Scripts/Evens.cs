using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int countUp = 22;
        Debug.Log(countUp);
        while (countUp <= 98)
        {
            countUp += 2;
            Debug.Log(countUp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
