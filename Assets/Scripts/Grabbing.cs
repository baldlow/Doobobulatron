using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Grabbing : MonoBehaviour
{
    public Rigidbody playerRb;
    public GameObject cam;

    public bool canGrab = false;
    public bool canUse = false;
    public float pullForce = 2f;
    public float jumpForce = 5f;
    public float maxSpeed = 2f;
    
    public GameObject CanGrabUi;
    public GameObject CanPushUi;
    public GameObject CanUseUi;
    
    PlayerMovement playerMovement;
    public Interactor interactor;
    public GameObject interactableObjectDetected = null;

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 6 || other.gameObject.layer == 7)
        {
            canGrab = true;
        }
        if (other.gameObject.layer == 7) // true if hitting an interactable
        {
            canUse = true;
            interactableObjectDetected = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 6 || other.gameObject.layer == 7)
        {
            canGrab = false;
        }
        canUse = false;

    }

    private void Start()
    {
        playerMovement = playerRb.gameObject.GetComponent<PlayerMovement>();

    }

    private void Update()
    {
        
        CanGrabUi.SetActive(canGrab && !canUse);
        CanPushUi.SetActive(playerMovement.canJump && !canGrab && !canUse);
        CanUseUi.SetActive(canUse);
        //CanUseUi.SetActive();

        if (Input.GetMouseButton(0) && canGrab)
        {
            //Debug.Log("grabbing!");
            playerRb.AddForce(this.transform.forward * pullForce);
            playerRb.linearVelocity = Vector3.ClampMagnitude(playerRb.linearVelocity, maxSpeed);

        }
        else if(Input.GetMouseButton(0) && !canGrab && playerMovement.canJump)
        {
            playerRb.AddForce(this.transform.forward * jumpForce);
            //Debug.Log("Jumping");
            playerRb.linearVelocity = Vector3.ClampMagnitude(playerRb.linearVelocity, maxSpeed);

        }
        
    }
}
