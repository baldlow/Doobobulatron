using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool canJump;

    private void OnCollisionStay(Collision collision)
    {
        // if the player's hitbox is touching a wall or an interactable object, canJump is set to true
        if (collision.gameObject.layer == 6 || collision.gameObject.layer == 7)
        {
            canJump = true;
        }
    }

    // when the player stops touching a wall or an interactable object, canJump is set to false
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == 6 || collision.gameObject.layer == 7)
        {
            canJump = false;
        }
    }

    // when player enters the collider of a damageable object, player dies

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            Debug.Log("im dead af");
        }
    }
}
