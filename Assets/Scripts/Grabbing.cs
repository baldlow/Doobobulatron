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
    public bool playerIsGrabbing = false;
    public bool playerIsClimbing = false;
    public bool wasLastActPush = false;

    
    public void OnTriggerStay(Collider other)
    {
        // if the grabbing hitbox is touching a wall or an interactable, canGrab is set to true
        if (other.gameObject.layer == 6 || other.gameObject.layer == 7)
        {
            canGrab = true;
        }
        if (other.gameObject.layer == 7) // if grab hitbox is touching an interactable, canUse is set to true.
        {
            canUse = true;
            interactableObjectDetected = other.gameObject; // interactableObjectDetected is set to the object currently being collided with
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // when the grab hitbox stops touching a wall or an interactable, canGrab is set to false
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
        playerIsGrabbing = (Input.GetMouseButton(0) && canGrab);
        playerIsClimbing = playerMovement.canJump && playerIsGrabbing;

        if (playerIsClimbing)
        {
            Debug.Log("this is climbing!");
        }

        if(playerMovement.canJump && !playerIsGrabbing)
        {
            Debug.Log("Stopped!");
            if (!wasLastActPush)
            {
                playerRb.linearVelocity = Vector3.zero;
            }
        }

        //UI logic
        CanGrabUi.SetActive(canGrab && !canUse);
        CanPushUi.SetActive(playerMovement.canJump && !canGrab && !canUse);
        CanUseUi.SetActive(canUse);


        // Hold down Left Mouse to pull yourself forward if there's something to grab
        if (playerIsGrabbing)
        {
            wasLastActPush = false;
            playerRb.AddForce(this.transform.forward * pullForce);
            playerRb.linearVelocity = Vector3.ClampMagnitude(playerRb.linearVelocity, maxSpeed);

            
        }
        // If you can't grab something and click, the playerMovement script is checked for the canJump variable being true
        // Hold down Left Mouse to jump off of a surface
        else if(Input.GetMouseButton(0) && !canGrab && playerMovement.canJump)
        {
            wasLastActPush = true;
            playerRb.AddForce(this.transform.forward * jumpForce);
            playerRb.linearVelocity = Vector3.ClampMagnitude(playerRb.linearVelocity, maxSpeed);
        }
        
    }
}
