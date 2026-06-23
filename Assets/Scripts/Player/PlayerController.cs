using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerMovement movement;
    UIController uiController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movement = GetComponent<PlayerMovement>();
        uiController = FindFirstObjectByType<UIController>();
    }

    public void OnMove(InputAction.CallbackContext value)
    { 
    
    }

    public void OnLook(InputAction.CallbackContext value)
    { 
    
    }

    public void OnJump(InputAction.CallbackContext value)
    { 
        
    }

    public void OnSprint(InputAction.CallbackContext value)
    { 
    
    }

    public void OnEscape(InputAction.CallbackContext value)
    {
        if (uiController != null && movement != null)
        { 
            uiController.Pause();
            movement.LockCursor(uiController.Paused);
        }
    }

}
