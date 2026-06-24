using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Class designed by NPulley
/// </summary>
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
        if (movement != null) movement.UpdateMoveInput(value.ReadValue<Vector2>());
    }

    public void OnLook(InputAction.CallbackContext value)
    {
        if (movement != null) movement.UpdateLookInput(value.ReadValue<Vector2>());
    }

    public void OnJump(InputAction.CallbackContext value)
    { 
        
    }

    public void OnSprint(InputAction.CallbackContext value)
    { 
        Debug.Log(value.performed);
    
    }

    public void OnEscape(InputAction.CallbackContext value)
    {
        if (uiController != null && movement != null)
        { 
            uiController.Pause();
        }
    }

}
