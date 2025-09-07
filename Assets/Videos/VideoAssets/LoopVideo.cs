using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Video;
using static UnityEditor.Rendering.CameraUI;

public class LoopVideo : MonoBehaviour
{

    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<VideoPlayer>().isLooping = true;

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
