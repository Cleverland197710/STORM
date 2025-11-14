using UnityEngine;
using UnityEngine.InputSystem; // <-- new namespace
using UnityEngine.SceneManagement;

public class Gothrough : MonoBehaviour
{
    private InputAction nextSceneAction;

    void Awake()
    {
        // Create an InputAction that triggers when the Space key is pressed
        nextSceneAction = new InputAction(binding: "<Keyboard>/space");
        nextSceneAction.performed += ctx => LoadNextScene();

    }

    void OnEnable()
    {
        nextSceneAction.Enable();
    }

    void OnDisable()
    {
        nextSceneAction.Disable();
    }

    private void LoadNextScene()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
