using UnityEngine;

/// <summary>
/// Class designed by NPulley. Player movement controlled by Character Controller
/// </summary>
public class PlayerCCMovement : PlayerMovement
{
    CharacterController controller;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Startup();

        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove) { Move(); Look(); }
    }

    protected override void Look()
    {
        float mouseX = rawLookInput.x * lookSpeed * Time.deltaTime;
        float mouseY = rawLookInput.y * lookSpeed * Time.deltaTime;

        camXRotation -= mouseY;
        camXRotation = Mathf.Clamp(camXRotation, -90, 90);

        cam.transform.localRotation = Quaternion.Euler(camXRotation , 0f, 0f);
        transform.Rotate(Vector3.up, mouseX);
    }

    protected override void Move()
    {
        Vector3 move = transform.right * rawMoveInput.x + transform.forward * rawMoveInput.y;
        controller.Move(move * moveSpeed * Time.deltaTime);
    }

    protected override void Jump()
    {
        if (!controller.isGrounded) return; //disallow jumping if not on a surface


    }
}
