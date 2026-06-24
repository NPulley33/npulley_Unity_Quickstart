using UnityEngine;

/// <summary>
/// Class designed by NPulley
/// </summary>
public abstract class PlayerMovement : MonoBehaviour
{
    [Header("Movement Adjustments")]
    protected bool canMove;
    protected bool isSprinting;

    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float lookSpeed;
    [SerializeField] protected float jumpHeight;

    /// <summary>
    /// Modifies the delta/pointer speed/look input. Value is multiplied by look input values. 
    /// </summary>
    protected float sensitivityModifier = 1;

    protected float gravity = -9.81f;

    //movement stored values
    protected Vector2 rawMoveInput;
    protected Vector2 rawLookInput;
    protected float camXRotation;

    [Header("Componenet Pieces")]
    [SerializeField] protected Camera cam;

    /// <summary>
    /// Any operations or assignments to be done first in base classes. Should be called first in Start or Awake in base classes. 
    /// </summary>
    protected void Startup()
    {
        cam = GetComponentInChildren<Camera>();

        canMove = true;
        LockCursor(true);
    }

    /// <summary>
    /// Toggles if the cursor is locked or not based on the parameter provided. 
    /// </summary>
    /// <param name="locked"></param>
    public void LockCursor(bool locked)
    { 
        if (locked) Cursor.lockState = CursorLockMode.None;
        else Cursor.lockState = CursorLockMode.Locked;
    }

    /// <summary>
    /// Toggles if the player is able to move or not based on the parameter provided. 
    /// </summary>
    /// <param name="canMove"></param>
    public void ToggleCanMove(bool canMove) => this.canMove = canMove;

    /// <summary>
    /// Moves the player using the appropriate movement system.
    /// </summary>
    protected abstract void Move();

    /// <summary>
    /// Rotates the player & camera to look around the scene. 
    /// </summary>
    protected abstract void Look();

    protected abstract void Jump();

    /// <summary>
    /// Takes movement input from the Player Controller/new input system. 
    /// </summary>
    /// <param name="moveInput"></param>
    public void UpdateMoveInput(Vector2 moveInput) => rawMoveInput = moveInput;

    /// <summary>
    /// Takes look input from the Player Controller/new input system. 
    /// </summary>
    /// <param name="lookInput"></param>
    public void UpdateLookInput(Vector2 lookInput) => rawLookInput = lookInput;
}
