using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public bool Paused { get; private set; }

    [SerializeField] GameObject PauseMenu;

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
        PauseMenu.SetActive(Paused);
        Time.timeScale = Paused ? 0 : 1;
    }

}
