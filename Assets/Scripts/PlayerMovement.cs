using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public bool canJump;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.layer == 6 || collision.gameObject.layer == 7)

            //rb.linearVelocity = Vector3.zero;
            canJump = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == 6 || collision.gameObject.layer == 7)

            canJump = false;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
