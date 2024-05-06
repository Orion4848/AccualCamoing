using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLook : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        
        transform.LookAt(player.transform);

        Vector3 eulerAngles = transform.eulerAngles;
        eulerAngles.x = 0; 
        eulerAngles.z = 0; 
        transform.eulerAngles = eulerAngles;
    }
}
