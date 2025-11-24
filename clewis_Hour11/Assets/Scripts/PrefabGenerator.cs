using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour

{
    public float spacing = 2f;

    void Start()
    { 
        int numberOfLamps = 10;
        for (int i = 0; i < numberOfLamps; i++)
        {
            Vector3 spawnPosition = new Vector3(
                transform.position.x + i * spacing,
                transform.position.y,
                transform.position.z
            );
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    } 

    public GameObject prefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}