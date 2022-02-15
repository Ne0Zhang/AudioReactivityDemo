using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{   
    public Transform Target, Player;
    public Transform cam;
    
    private float defaultDistance = 10f;
    public float RotationSpeed = 1f;
    
    float mouseX, mouseY, fov;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate() {
        CamControl();
    }

    void CamControl() {
        mouseX += Input.GetAxis("Mouse X") *  RotationSpeed;
        mouseY += -1 * Input.GetAxis("Mouse Y") *  RotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -90, 60);

        transform.LookAt(Target);

        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Player.rotation = Quaternion.Euler(0, mouseX, 0);
    }

}
