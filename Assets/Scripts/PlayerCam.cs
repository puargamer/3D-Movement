using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float xsens;
    public float ysens;

    public Transform forward;   //gameobject constantly looking forward

    float xRotation;
    float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * xsens;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * ysens;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -25f, 90f);
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        forward.rotation = Quaternion.Euler(0, yRotation, 0);

    }

}
