using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public Respawn respawn;
    
    public void Respawn()
    {
        respawn.GoToCheckpoint();
    }
}
