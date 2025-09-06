using UnityEngine;

public class PullZone : MonoBehaviour
{
    public Transform pullTarget;   // The point players get pulled towards
    public float pullForce = 10f;  // How strong the pull is
    public bool doorOpen = false;  // Toggle this when your door opens

    void OnTriggerStay(Collider other)
    {
        // Only pull if door is open and the object has a Rigidbody
        if (doorOpen && other.attachedRigidbody != null)
        {
            Vector3 direction = (pullTarget.position - other.transform.position).normalized;
            other.attachedRigidbody.AddForce(direction * pullForce);
        }
    }
}

