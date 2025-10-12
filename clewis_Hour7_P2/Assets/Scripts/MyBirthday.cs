using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int Month = 12;
        for (int Day = 1; Day <= 31; Day++)
        {
            if (Day == 10)
            {
                Debug.Log("It's my Birthday!");
            }
            else
            
                Debug.Log(Month + " - " + Day);
            }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
