using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject powerupPrefab;
    public GameObject obstaclePrefab;
    public GameObject gasDoughnutPrefab;
    public GameObject oiiaCatPrefab; 
    
    public float spawnCycle = .5f;
    GameManager manager;
    float elapsedTime;

    void Start()
    {
        manager = GetComponent<GameManager>();
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > spawnCycle)
        {
            GameObject temp;

            int randomChoice = Random.Range(0, 4); 

            if (randomChoice == 0)
                temp = Instantiate(powerupPrefab) as GameObject;
            else if (randomChoice == 1)
                temp = Instantiate(obstaclePrefab) as GameObject;
            else if (randomChoice == 2)
                temp = Instantiate(gasDoughnutPrefab) as GameObject;
            else
                temp = Instantiate(oiiaCatPrefab) as GameObject; 

            Vector3 position = temp.transform.position;
            position.x = Random.Range(-3f, 3f);
            temp.transform.position = position;

            Collidable col = temp.GetComponent<Collidable>();
            if (col != null) 
            {
                col.manager = manager;
            }
            elapsedTime = 0;
        }
    }
}