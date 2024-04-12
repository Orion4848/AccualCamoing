using UnityEngine;

public class FogCycle : MonoBehaviour
{
    public Transform lightObject; // Reference to the light object
    public Transform gameObjectToMeasure; // Reference to the game object to measure

    void Update()
    {
        if (lightObject != null && gameObjectToMeasure != null)
        {
            // Calculate the direction vectors from the light to the game object
            Vector3 lightDirection = (gameObjectToMeasure.position - lightObject.position).normalized;
            Vector3 forwardDirection = lightObject.forward;

            // Calculate the angle between the two directions
            float angle = Vector3.Angle(lightDirection, forwardDirection);

            Debug.Log("Angle between light and game object: " + angle);
        }
    }
}
