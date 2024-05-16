using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawning : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SpawnObject;
    //public GameObject SpawnPoint;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    //public float NextSpawnTime = 0;
    //public float MinSpawnTime = 0;
    //public float MaxSpawnTime = 0;

    /*void SetTimer()
    {
        this.NextSpawnTime = Random.Range(this.MinSpawnTime, this.MaxSpawnTime);
    }*/

    void Start ()
    {
        InvokeRepeating("Spawn", spawnTime, spawnDelay);
    //initialise the spawn counter at startup
        //this.SetTimer();
    }

    
    /*void Update()
    {
        this.NextSpawnTime -= Time.deltaTime;
        if(this.NextSpawnTime <= 0)
{
            Spawn();
            this.SetTimer();
        }   

    }*/
    public void Spawn()
    {
        int spawnPointX = Random.Range(-1500, 1500);
        int spawnPointY = Random.Range(10, 75);
        int spawnPointZ = Random.Range(-1500, 1500);

        Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ);

        Instantiate(SpawnObject, spawnPosition, Quaternion.identity);
    }
    


}
