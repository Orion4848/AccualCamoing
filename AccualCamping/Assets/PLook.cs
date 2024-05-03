using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLook : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        // Look at the player
        transform.LookAt(player.transform);

        // Lock rotation along the x and z axes
        Vector3 eulerAngles = transform.eulerAngles;
        eulerAngles.x = 0; // Lock rotation along the x axis
        eulerAngles.z = 0; // Lock rotation along the z axis
        transform.eulerAngles = eulerAngles;
    }
}
