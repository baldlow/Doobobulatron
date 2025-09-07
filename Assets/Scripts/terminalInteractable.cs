using UnityEngine;

public class terminalInteractable : MonoBehaviour, IInteractable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int tasksCompleted = 0;
    public bool isActive = false;
    public string terminalId;
    public taskTwoMangager taskTwoMangager1;

    public void Interact()
    {
        // Add terminal interaction logic he
        // check if game state of puzzle one has been completed
        
        if(terminalId == "a"){
        if(tasksCompleted == 0)
        {
            Debug.Log("Terminal interacted with, tasks completed: " + tasksCompleted);
            // disapear the door to terminal one
        }else if(tasksCompleted == 1)
        {
            if (!isActive)
            {
                isActive = true;
                taskTwoMangager1.ActivateTerminalA();

            }
            Debug.Log("Terminal interacted with, tasks completed: " + tasksCompleted);
            // close door to lever room
        }else if (tasksCompleted == 2)
        {
            Debug.Log("Terminal interacted with, tasks completed: " + tasksCompleted);
            // game is done
        }

        }
        else
        {
           taskTwoMangager1.ActivateTerminalB(); 

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateTasksCompleted()
    {
        tasksCompleted++;
    }
}
