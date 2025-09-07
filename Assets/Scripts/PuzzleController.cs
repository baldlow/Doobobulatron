using UnityEngine;

public class PuzzleController : MonoBehaviour
{
    public puzzleOneManager leverPuzzle;
    public puzzleTwoManager buttonPuzzle;
    public bool allPuzzlesCompleted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!allPuzzlesCompleted)
        {
            if (leverPuzzle != null && buttonPuzzle != null)
            {
                if (leverPuzzle.puzzleCompleted && buttonPuzzle.puzzleCompleted)
                {
                    allPuzzlesCompleted = true ;
                    leverPuzzle.allowReset = false;
                    buttonPuzzle.allowReset = false;
                    activate();
                    Debug.Log("All puzzles completed! Door unlocked.");
                    // Add door unlocking logic here
                }
            }
            else {                 Debug.LogWarning("Puzzle references are not set in PuzzleController."); }
        }

    }
    void activate()
    {
        Debug.Log("Activating all puzzles complete actions.");
       leverPuzzle.allPuzzleComplete();
        buttonPuzzle.allPuzzlesComplete();
    }
}
