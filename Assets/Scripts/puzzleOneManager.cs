using UnityEngine;

public class puzzleOneManager : MonoBehaviour
{
    public float timeLimit = 6f; // Time limit in seconds
    private float timer;
    private bool puzzleActive = false;
    public string firstLightSwitch;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzleActive)
        {
            timer -= Time.deltaTime;
            if(timer <= 0f)
            {
                Debug.Log("Time's up! Puzzle failed.");
                ResetPuzzle();
            }
        }
        
    }
    void ResetPuzzle()
    {
        puzzleActive = false;
        firstLightSwitch = null;
    }
    public void SwitchPressed(string switchId)
    {
        if(!puzzleActive)
        {
            puzzleActive = true;
            timer = timeLimit;
            firstLightSwitch = switchId;
            Debug.Log("Puzzle started! First switch: " + firstLightSwitch);
        }
        else
        {
            if (switchId != firstLightSwitch)
            {
                Debug.Log("Puzzle completed successfully!");
                ResetPuzzle();
            }
            else
            {
                Debug.Log("Same switch pressed again. Puzzle failed.");
                ResetPuzzle();
            }
        }

    }
}
