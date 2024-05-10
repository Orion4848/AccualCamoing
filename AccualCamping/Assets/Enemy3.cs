using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public Transform player; 
    public float minTeleportInterval = 2f;
    public float maxTeleportInterval = 5f; 
    public float tpDistance; 
    private float nextTeleportTime;

    private void Start()
    {
       
        nextTeleportTime = Time.time + Random.Range(minTeleportInterval, maxTeleportInterval);
    }

    private void Update()
    {
      
        if (Time.time >= nextTeleportTime)
        {
            Teleport();

            nextTeleportTime = Time.time + Random.Range(minTeleportInterval, maxTeleportInterval);
        }
    }

    private void Teleport()
    {
        
        Vector3 teleportPosition = player.position + player.forward * tpDistance;
        teleportPosition.y += 5;
        transform.position = teleportPosition;
    }
}
