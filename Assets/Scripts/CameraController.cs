using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CameraController : MonoBehaviour
{
    public float panSpeed = 20f;
    public GameObject camera;
    private Vector2 direction;
    void Awake()
    {
    }
    // Update is called once per frame
    public void CameraMove(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
        Debug.Log(direction);

    }
    private void Update()
    {
        Vector3 pos = camera.transform.position;
        pos.x += direction.x * panSpeed * Time.deltaTime;
        pos.z += direction.y * panSpeed * Time.deltaTime;
        camera.transform.position = pos;
    }
}
