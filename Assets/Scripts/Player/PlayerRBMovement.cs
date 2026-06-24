using UnityEngine;
using UnityEngine.InputSystem.XR;

/// <summary>
/// Class designed by NPulley. Player movement controlled by a rigidbody
/// </summary>
public class PlayerRBMovement : PlayerMovement
{
    Rigidbody rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Startup();

        rb = GetComponent<Rigidbody>();
        GetComponent<CharacterController>().enabled = false; //disable the movement system we are not using
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Look()
    {
        if (!canMove) return;
    }

    protected override void Move()
    {
        if (!canMove) return;
        Debug.Log("moving");
    }

    protected override void Jump()
    { 
        
    }

}
