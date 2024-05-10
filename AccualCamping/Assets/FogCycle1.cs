using UnityEngine;

public class FogCycle : MonoBehaviour
{
    public GameObject object1; // Reference to the first object
    public GameObject object2; // Reference to the second object
    public bool triggerActivated = false; // Boolean to track trigger activation

    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider is one of the specified objects
        if (other.gameObject == object2)
        {
            // If trigger is activated, deactivate it
            if (triggerActivated)
            {
                triggerActivated = false;
                Debug.Log("Trigger Deactivated");
            }
            // If trigger is deactivated, activate it
            else
            {
                triggerActivated = true;
                Debug.Log("Trigger Activated");
            }
        }
    }
}
