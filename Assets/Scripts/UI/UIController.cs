using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public bool Paused { get; private set; }

    [SerializeField] GameObject PauseMenu;

    [SerializeField] int MainMenuIndex;
    [SerializeField] int StartingIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        Paused = !Paused;
        if(PauseMenu != null) PauseMenu.SetActive(Paused);
        //Time.timeScale = Paused ? 0 : 1;

        //if I don't need a reference to the player in the rest of the class, invoke an event that the player will listen to
        //& the player will do this in it's own class
        //if needing a reference to the player, create a class field for the reference that gets populated on start
        PlayerMovement player = FindFirstObjectByType<PlayerMovement>();
        player.LockCursor(Paused);
        player.ToggleCanMove(!Paused);
        player.ToggleCanMove(!Paused);
    }

    public void Play()
    {
        SceneManager.LoadScene(StartingIndex);
    }

    public void ReturnToTitle()
    {
        SceneManager.LoadScene(MainMenuIndex);
    }

    public void Quit()
    { 
        Application.Quit();
    }
}
