using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CameraController : MonoBehaviour
{
    public float panSpeed = 20f;
    public float rotateSpeed = 20f;
    public float zoomSpeed = 20f;
    public GameObject cameraUsed;
    private Vector2 direction;
    private Vector2 rotation;
    private float zoom = 0f;
    void Awake()
    {
    }
    public void CameraMove(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
        //Debug.Log(direction);

    }
    public void Zoom(InputAction.CallbackContext context)
    {
        var x = context.ReadValue<float>();
        zoom = -x;
        Debug.Log(x);
    }
    private void Update()
    {
        Vector3 pos = cameraUsed.transform.position;
        pos.x += direction.x * panSpeed * Time.deltaTime;
        pos.y += zoom;
        //Debug.Log(zoom);
        pos.z += direction.y * panSpeed * Time.deltaTime;
        cameraUsed.transform.position = pos;



    }
}
