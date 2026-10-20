using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using Unity.VisualScripting;

public class ChangeScene : MonoBehaviour
{
    public InputAction control;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        control.Enable();
    }

    // Update is called once per frame
    void Update()
    {
       /* Vector2 switchCamera = control.ReadValue<OnButtonClick>();
        if (switchCamera == 1)
        {
            
        }
        if (switchCamera.x == 1)
        {
            SceneManager.LoadScene("Challenge 4");
        }*/
        
    }

    public void OnButtonClick()
    {
        SceneManager.LoadScene("Prototype 4");
    }
}
