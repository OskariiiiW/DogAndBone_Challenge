using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void LoadScene(string sceneName)
    {
        if (sceneName != null)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
        else
        {
            Debug.Log("sceneName variable missing");
        }

    }

    public void ShowSettingsMenu()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
