using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float slerpSpeed = 500f;   //Speed we rotate at
    public Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        float cameraYaw = mainCamera.transform.rotation.eulerAngles.y;
        Quaternion newRot = Quaternion.Euler(0, cameraYaw, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, newRot, slerpSpeed * Time.fixedDeltaTime);
    }
}
