using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject _cameraObj;
    public Transform player;
    public float mouseSensitivity = 2f;
    float cameraVerticalRotation = 0f;


    private void CameraLook()
    {
        float inputX = Input.GetAxis("Mouse X")*mouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y")*mouseSensitivity;

        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
        transform.localEulerAngles = Vector3.right * cameraVerticalRotation;

        player.Rotate(Vector3.up * inputX);
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()


    {
        Cursor.lockState = CursorLockMode.Locked; // Locks cursor to screen center
        Cursor.visible = false; // Hides the cursor
    }

    // Update is called once per frame
    void Update()
    {
        CameraLook();
    }
}
