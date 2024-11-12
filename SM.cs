using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SM : MonoBehaviour
{

    // lists the different states 
    private enum state
    {
        idle,
        walking,
        jumping
    }

    private state currentState;
    

    
    // Start is called before the first frame update
    void Start()
    {
        // at the start of the game the state will be set to idle
        currentState = state.idle;
    }

    // Update is called once per frame and changes the sate of the actor based on the 
    void Update()
    {
        HandleState();

        if (Input.GetKeyDown(KeyCode.W))
        {
            ChangeState(state.walking);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeState(state.jumping);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            ChangeState(state.idle);
        }
    }

    // siwtches between each state and puts the change into the Debug.Log
    private void HandleState()
    {
        switch(currentState)
        {
            case state.idle:
                Debug.Log("Character is idle");
            break;

            case state.walking:
                Debug.Log("Charcter is walking");
            break;

            case state.jumping:
                Debug.Log("Charcter is jumping");
            break;
        }

    }
    // changes the state of the actor
    private void ChangeState(state newState)
    {
        currentState = newState;
        Debug.Log("Changed state to : " + currentState);
    }
    


}
