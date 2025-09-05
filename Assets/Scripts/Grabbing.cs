using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Grabbing : MonoBehaviour
{
    public Rigidbody playerRb;
    public GameObject cam;

    public bool canGrab = false;
    public float pullForce = 2f;
    public float jumpForce = 5f;
    public float maxSpeed = 2f;
    public GameObject CanGrabUi;
    public GameObject CanPushUi;
    PlayerMovement playerMovement;

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.layer == 6)
        canGrab = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 6)

            canGrab = false;
    }

    private void Start()
    {
        playerMovement = playerRb.gameObject.GetComponent<PlayerMovement>();

    }

    private void Update()
    {
        CanGrabUi.SetActive(canGrab);
        CanPushUi.SetActive(playerMovement.canJump && !canGrab);

        if (Input.GetMouseButton(0) && canGrab)
        {
            Debug.Log("grabbing!");
            playerRb.AddForce(this.transform.forward * pullForce);
            playerRb.linearVelocity = Vector3.ClampMagnitude(playerRb.linearVelocity, maxSpeed);

        }
        else if(Input.GetMouseButton(0) && !canGrab && playerMovement.canJump)
        {
            playerRb.AddForce(this.transform.forward * jumpForce);
            Debug.Log("Jumping");
            playerRb.linearVelocity = Vector3.ClampMagnitude(playerRb.linearVelocity, maxSpeed);

        }
    }
}
