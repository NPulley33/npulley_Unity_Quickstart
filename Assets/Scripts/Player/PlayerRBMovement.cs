using UnityEngine;

/// <summary>
/// Player movement controlled by a rigidbody
/// </summary>
public class PlayerRBMovement : PlayerMovement
{
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GetComponent<CharacterController>().enabled = false; //disable the movement system we are not using
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
