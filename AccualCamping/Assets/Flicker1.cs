using UnityEngine;

public class Flicker : MonoBehaviour
{
    public Light pointLight;
    public float intensityInitial;
    public float intensityFinal;
    public float rangeInitial;
    public float rangeFinal;

    private void Start()
    {
        pointLight = GetComponent<Light>();
    }

    private void Update()
    {
        pointLight.intensity = Random.Range(intensityInitial, intensityFinal);
        pointLight.range = Random.Range(rangeInitial, rangeFinal);
    }
}
