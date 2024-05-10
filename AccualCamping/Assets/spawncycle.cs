using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncycle : MonoBehaviour
{
    public fogCHange fogCHange;
    public Transform stowPos;
    Vector3 dayPos;

    // Start is called before the first frame update
    void Start()
    {
        fogCHange =  GetComponent<fogCHange>();
        dayPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (fogCHange.IsNight == false)
        {
           transform.position = dayPos;
            
        }
    }
}
