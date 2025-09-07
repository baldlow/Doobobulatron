using UnityEngine;

public class gameStateManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public PuzzleController puzzleController1; // used to reference puzzle completion state
    public taskTwoMangager puzzleController2;
    public bool gameDone = false;
    public terminalInteractable terminal1; // reference to terminal to disable interaction when game is done


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameDone)
        {
            if(puzzleController1 != null)
            {
                
                if(puzzleController1.allPuzzlesCompleted)
                {
                    // then tell terminal that puzzle 1 is done
                    if(terminal1.tasksCompleted == 0)
                    {
                        terminal1.updateTasksCompleted();
                        Debug.Log("did task one");
                        //door1.SetActive(true);

                    }
                    // Add game completion logic here

                }
            }
            if(puzzleController2 != null)
            {

                if(terminal1.tasksCompleted == 1 && puzzleController2.puzzleCompleted)
                {
                    gameDone = true;
                    terminal1.updateTasksCompleted();
                    Debug.Log("Game Completed!");
                }
            }
            else { Debug.LogWarning("PuzzleController reference is not set in gameStateManager.");
            }
        }
        
    }
    public void updateTerminal1()
    {
        terminal1.updateTasksCompleted();
    }
}
