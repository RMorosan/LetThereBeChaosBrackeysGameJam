using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CameraController : MonoBehaviour
{
    public float panSpeed = 20f;
    public float rotateSpeed = 20f;
    public GameObject cameraUsed;
    private Vector2 direction;
    private Vector2 rotation;
    void Awake()
    {
    }
    public void CameraMove(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
        //Debug.Log(direction);

    }
    public void CameraRotate(InputAction.CallbackContext context)
    {
        rotation = context.ReadValue<Vector2>();
        //Debug.Log(rotation);
    }

    private void Update()
    {
        Vector3 pos = cameraUsed.transform.position;
        pos.x += direction.x * panSpeed * Time.deltaTime;
        pos.z += direction.y * panSpeed * Time.deltaTime;
        cameraUsed.transform.position = pos;

        var rotate = transform.rotation;
        rotate.z += rotation.x * rotateSpeed * Time.deltaTime;
        //rotate.z += rotation.y * rotateSpeed * Time.deltaTime;
        //transform.rotation = rotate;

    }
}
