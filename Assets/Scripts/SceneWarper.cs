using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneWarper : MonoBehaviour
{
    public string sceneToWarpTo;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            SceneManager.LoadScene(sceneToWarpTo);
        }
    }
}
