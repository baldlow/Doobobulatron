using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Respawn : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 lastCheckpoint;
    public bool alive = true;
    public Animator  animator;
    void Start()
    {
        lastCheckpoint = transform.position;
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && alive)
        {
            Die();
        }
    }
    public void Die()
    {
        alive  = false;
        animator.SetTrigger("FadeToBlack");
    }
    public void GoToCheckpoint()
    {
        Debug.Log("AGHGHGHGH FUCK!");
        transform.position = lastCheckpoint;
        rb.linearVelocity = Vector3.zero;

        alive = true;
    }
}
