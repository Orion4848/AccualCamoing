using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogCHange : MonoBehaviour
{
    public GameObject object1; // Reference to the first object
    public GameObject object2; // Reference to the second object
    public bool IsNight = false; // Boolean to track trigger activation


    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider is one of the specified objects
        if (other.gameObject == object2)
        {
            // If trigger is activated, deactivate it
            if (IsNight)
            {
                IsNight = false;
                Debug.Log("Trigger Deactivated");
                fogDensity();
            }
            // If trigger is deactivated, activate it
            else
            {
                IsNight = true;
                Debug.Log("Trigger Activated");
                fogDensity();
            }
        }
    }

    void fogDensity()
    {
        if (IsNight == true)
        {
            while (RenderSettings.fogDensity <= 0.08f)
            {
                RenderSettings.fogDensity += .0001f;
            }

        }

        else
        {
            if (IsNight == false)
            {
                while (RenderSettings.fogDensity >= 0.0005f)
                {
                    RenderSettings.fogDensity -= 0.0001f;
                }
            }
        }

    }
}
