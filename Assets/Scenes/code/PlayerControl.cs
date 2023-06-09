using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro 
public class PlayerControl : MonoBehaviour
{
    public float speed;
    public float upRotation;
    public float downRotation;
    CharacterController characterControl;
    public float Transform playerCam; 

    Vector3 vel;

    public float lookSensitivity;
    float xRotation = 0;
    public TMP_Text itemText;
    public string lookingAt = "nothing!";
    public bool hasKey = false;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        characterControl = GetComponent<CharacterController>();
        itemText.text = lookingAt;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * lookSensitivity, 0;);
        xRotation -= Input.GetAxis("Mouse Y") * lookSensitivity;
        xRotation = Mathf.Clamp(xRotation, -upRotation, downRotation);
        playerCam.localRotation = Quaternion.Euler(xRotation, 0, 0);

        vel.z = Input.GetAxis("Vertical") * speed;
        vel.x = Input.GetAxis("Horizontal") * speed;

        vel = transform.TransformDirectiom(vel);
        characterControl.Move(vel * Time.deltaTime); 
    
    }
}
