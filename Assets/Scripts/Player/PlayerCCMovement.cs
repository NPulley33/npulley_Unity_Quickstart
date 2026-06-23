using UnityEngine;

/// <summary>
/// Player movement controlled by Character Controller
/// </summary>
public class PlayerCCMovement : PlayerMovement
{
    CharacterController controller;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
