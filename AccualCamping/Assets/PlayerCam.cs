using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform pOrientation;

    float xrot;
    float yrot;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yrot += mouseX;
        xrot -= mouseY;
        xrot = Mathf.Clamp(xrot, -90f, 90f);

        transform.rotation = Quaternion.Euler(xrot, yrot, 0);
        pOrientation.rotation = Quaternion.Euler(0, yrot, 0);
    }
}
